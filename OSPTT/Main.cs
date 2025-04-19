using AutoUpdaterDotNET;
using GlobalHotKey;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static OSPTT.ProcessData;

namespace OSPTT
{
    public partial class Main : MaterialForm
    {
        private string softwareVersion = "1.0";
        private static double boardFirmware = 0;
        private static double downloadedFirmwareVersion = -1;
        public static int boardType = Properties.Settings.Default.LastBoardType;

        public static System.IO.Ports.SerialPort port;
        public static bool portConnected = false;
        public static bool fwUpdateRunning = false;
        public static bool boardUpdate = false;

        private ResourceManager rm = OSPTT.Properties.Resources.ResourceManager;

        public TestSettings testSettings = new TestSettings();

        private Thread readThread = null;
        private Thread connectThread = null;
        private BackgroundWorker bgWorker = new BackgroundWorker();

        string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
        string resultsPath = "";
        string resultsFolderPath = "";
        string rawFileName = "";
        string processedFileName = "";

        private List<float> inputLagEvents = new List<float>();
        private List<rawInputLagResult> inputLagRawData = new List<rawInputLagResult>();
        private List<inputLagResult> inputLagProcessed = new List<inputLagResult>();
        private List<rawInputLagResult> rawSystemLagData = new List<rawInputLagResult>();
        public averagedInputLag systemLagData = new averagedInputLag();

        public SettingsClasses.RunSettings RunSettings;
        private bool processingFailed = false;
        public bool settingsSynced = false;
        private Thread debugThread;
        public List<string> debugList = new List<string>();

        HotKeyManager hotKeys = new HotKeyManager();
        List<HotKey> hotKeyList = new List<HotKey>();
        MouseHook mouseHook = new MouseHook();
        KeyboardHook keyboardHook = new KeyboardHook();

        private readonly string fqbn = "adafruit:samd:adafruit_feather_m0";

        public bool MouseMoveTest = false;

        Stopwatch sw = new Stopwatch();
        List<List<long>> testList = new List<List<long>>();
        int testLoopCounter = 0;
        public Main()
        {
            this.Icon = (Icon)rm.GetObject("icon");
            InitializeComponent();
            settingsPane1.mainWindow = this;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            appRunning();

            //982, 588
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.Resize += Form1_Resize;

            path = new Uri(System.IO.Path.GetDirectoryName(path)).LocalPath;
            resultsPath = path + @"\Results";
            if (!Directory.Exists(resultsPath)) { Directory.CreateDirectory(resultsPath); }

            

            UpdateHandler.UpdateMe(softwareVersion);

            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(CFuncs.IFailedYou);
            CFuncs.checkFolderPermissions(path);

            UserSettings.readAndSaveUserSettings(false);

            //settingsPane1.mainWindow = this;
            SetDeviceStatus(0);
            toggleMouseKeyboardBoxes(false);
            fillHotkeyList();
            UpdateFirmware.initialSetup();
            downloadedFirmwareVersion = UpdateFirmware.getNewFirmwareFile(path);

            connectThread = new Thread(new ThreadStart(this.findAndConnectToBoard));
            connectThread.Start();

            CleanupDevTools();

            UpdateHandler.AnnouncementText announcementText = UpdateHandler.GetAnnouncements(path);
            if (announcementText != null)
            {
                Announcements announcements = new Announcements();
                announcements.SetAnnouncement(announcementText);
                announcements.Show();
                announcements.Activate();
                //ActiveControl = announcements;
            }
            this.Text += softwareVersion;
            sw.Start();
            UpdateHandler.UpdateMe(softwareVersion);
        }

        /// <summary>
        /// Hide dev test button if debugger is attached
        /// </summary>
        private void CleanupDevTools()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                materialButton1.Visible = true;
                
                materialButton2.Visible = true;
                
            }
            else
            {
                materialButton1.Visible = false;
                
                materialButton2.Visible = false;
                
            }
        }

        /// <summary>
        /// Checks if there's another instance of the program running
        /// </summary>
        private void appRunning()
        {
            Process[] p = Process.GetProcessesByName("OSPTT");
            if (p.Length > 1)
            {
                MessageBox.Show("ERROR: Program already open! Please close it before running again, or check the task bar and system tray for the running app.", "Program Open Already", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(p.Length);
                //this.Close();
            }
        }

        /// <summary>
        /// Init hotkeys - specifically F10 for now.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            hotKeys.KeyPressed += HotKeyPressed;
            try
            {
                var k = hotKeys.Register(hotkeysDict[Properties.Settings.Default.hotkey], System.Windows.Input.ModifierKeys.None);
                hotKeyList.Add(k);
            }
            catch (Exception ex)
            {
                CFuncs.showMessageBox("Error Registering Hotkey",
                    "Error: Unable to register hotkey. Please pick a different key not already in use.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }

            mouseHook.LeftButtonDown += MouseHook_LeftButtonDown;
            mouseHook.MouseMove += MouseHook_Move;
            keyboardHook.KeyDown += KeyboardHook_KeyDown;
        }

        private void KeyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            if (!MouseMoveTest)
            {
                portWrite("H");
                Console.WriteLine(key.ToString());
            }
            else if (!MouseMoveReady)
            {
                portWrite("R");
                MouseMoveReady = true;
            }
        }

        /// <summary>
        /// MouseHook left click event handler - used for click/keypress test
        /// </summary>
        /// <param name="mouseStruct"></param>
        private void MouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (testSettings.TestSource == 2)
            {
                portWrite("H");
                Console.WriteLine("Triggered");
            }
            else
            {
                MouseMoveReady = true;
            }
        }

        private bool MouseMoveReady = true;
        /// <summary>
        /// MouseHook move event handler - used for click/keypress test
        /// </summary>
        /// <param name="mouseStruct"></param>
        private void MouseHook_Move(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (MouseMoveReady)
            {
                portWrite("H");
                Console.WriteLine("Triggered");
                MouseMoveReady = false;
            }
        }

        private bool ControllerKill = false;
        private GamepadButtonFlags lastButton;
        /// <summary>
        /// Controller handler
        /// </summary>
        private void ControllerEventHandler()
        {
            Console.WriteLine("Controller starting");
            Controller c = new Controller(UserIndex.One);
            if (c.IsConnected == false)
            {
                Console.WriteLine("Controller not found");
                CFuncs.showMessageBox("Controller Not Found", "Unable to connect to controller, please connect one and start the test again.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var previousState = c.GetState();
                while (c.IsConnected)
                {
                    if (ControllerKill == true)
                    {
                        break;
                    }
                    var state = c.GetState();
                    if (previousState.PacketNumber != state.PacketNumber)
                    {
                        if (state.Gamepad.Buttons != GamepadButtonFlags.None && state.Gamepad.Buttons != lastButton)
                        {
                            lastButton = state.Gamepad.Buttons;
                            portWrite("H");
                            Console.WriteLine(state.Gamepad);
                            Thread.Sleep(100);
                        }
                    }
                    Thread.Sleep(1);
                    previousState = state;
                }
            }
            Console.WriteLine("Exiting controller handler");
        }

        

        /// <summary>
        /// Handle when the form closes to cancel any running tests and save settings to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When form is closed halt read thread & close Serial Port
            ControllerKill = true;
            if (port != null)
            {
                try
                {
                    port.Write("X");
                }
                catch { Console.WriteLine("Port not open"); }
            }
            if (connectThread != null)
            {
                connectThread.Abort();
            }
            if (readThread != null)
            {
                readThread.Abort();
            }
            if (port != null)
            {
                port.Close();
            }
            UserSettings.readAndSaveUserSettings(true);
            Environment.Exit(Environment.ExitCode);
        }

        #region Serial Connection
        /// <summary>
        /// Function to use the arduino cli to find the board and initiate connect over serial. Also handles the update connection.
        /// </summary>
        private void findAndConnectToBoard()
        {
            Thread.Sleep(1000);
            bool checkedRunning = false;
            while (true)
            {
                if (!portConnected)
                {
                    SetDeviceStatus(0);
                    portConnected = false;
                    try
                    {
                        //testThread.Abort();
                    }
                    catch { }

                    if (!Properties.Settings.Default.updateInProgress)
                    {
                        if (!checkedRunning)
                        {
                            CFuncs.appRunning();
                            checkedRunning = true;
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.updateInProgress = false;
                        Properties.Settings.Default.Save();
                    }
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe board list";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    // if mdns discovery is blocked, the Arduino CLI will fail to search for boards. This is a backup way to connect to the board.
                    if (output.Contains("mdns-discovery")) 
                    {
                        Properties.Settings.Default.useArduinoCLI = false;
                        Properties.Settings.Default.Save();
                        var ports = SerialPort.GetPortNames();
                        bool correctPort = false;
                        foreach (var p in ports)
                        {
                            System.ComponentModel.IContainer components =
                                new System.ComponentModel.Container();
                            port = new System.IO.Ports.SerialPort(components);
                            port.PortName = p;
                            port.BaudRate = 115200;
                            port.DtrEnable = true;
                            port.ReadTimeout = 5000;
                            port.WriteTimeout = 5000;
                            port.ReadBufferSize = 2097152;
                            Console.WriteLine("Port details set");
                            try
                            { port.Open(); }
                            catch (Exception ex)
                            { Console.WriteLine(ex); }

                            if (port.IsOpen)
                            {
                                portWrite("I");
                                Stopwatch sw2 = new Stopwatch();
                                sw2.Start();
                                while (sw2.ElapsedMilliseconds < 5000)
                                {
                                    string message = port.ReadLine();
                                    if (message.Contains("FW:"))
                                    {
                                        correctPort = true;
                                        break;
                                    }
                                }
                            }
                            if (correctPort)
                            {
                                break;
                            }
                            else
                            {
                                port.Close();
                                port.Dispose();
                            }
                        }
                    }
                    else
                    {
                        string[] lines = output.Split(
                            new[] { "\r\n", "\r", "\n" },
                            StringSplitOptions.None
                        );
                        string p = "";
                        string board = "";
                        foreach (var s in lines)
                        {
                            if (s.Contains(fqbn) )
                            {
                                char[] whitespace = new char[] { ' ', '\t' };
                                string[] split = s.Split(whitespace);
                                p = split[0];
                                board = s;
                            }
                        }
                        if (p != "")
                        {
                            try
                            {
                                connectToBoard(p);
                                Thread.Sleep(1000);
                                SetDeviceStatus(1);
                                if (board.Contains("feather")) { 
                                    
                                    boardType = 1;
                                    Properties.Settings.Default.LastBoardType = 1;
                                }
                                else { 
                                    
                                    boardType = 0;
                                    Properties.Settings.Default.LastBoardType = 0;
                                }
                                Thread syncThread = new Thread(new ThreadStart(SyncSettingsThreadFunc));
                                syncThread.Start();
                                Properties.Settings.Default.Save();
                                //setBoardSerial();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                debugList.Add(e.Message + e.StackTrace);
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
                else if (fwUpdateRunning) // probably don't need this anymore
                {
                    Thread.Sleep(100);
                }
                else if (boardUpdate)
                {
                    fwUpdateRunning = true;
                    SetDeviceStatus(2);
                    string p = "";
                    p = port.PortName;
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
                    if (p == "")
                    {
                        MessageBox.Show("Please connect to the device first!", "Update Device", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UpdateFirmware.FirmwareReport fw = UpdateFirmware.UpdateDeviceFirmware(path, p, boardType);
                        SetDeviceStatus(fw.State);
                        debugList.Add(fw.ErrorMessage);
                        if (fw.State == 4)
                        {
                            CFuncs.showMessageBox("Firmware update failed", fw.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (fw.State == 3)
                        {
                            if (port.IsOpen)
                            {
                                port.Close();
                            }
                        }
                    }
                    fwUpdateRunning = false;
                    boardUpdate = false;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Takes in the COM port name from findAndConnectToBoard and initiates the serial connection
        /// </summary>
        /// <param name="comPort"></param>
        private void connectToBoard(string comPort)
        {
            System.ComponentModel.IContainer components =
                new System.ComponentModel.Container();
            port = new System.IO.Ports.SerialPort(components);
            port.PortName = comPort;
            port.BaudRate = 115200;
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 5000;
            port.ReadBufferSize = 2097152;
            Console.WriteLine("Port details set");
            try
            { port.Open(); }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            if (port.IsOpen)
            {
                portConnected = true;
                Thread.Sleep(100);
                port.Write("I");
                readThread = new Thread(new ThreadStart(this.Read));
                readThread.Start();
                bgWorker.RunWorkerAsync();
                //port.Write("X");
                //Thread.Sleep(250);

            }
            else
            {
                SetDeviceStatus(0);
            }
        }
        #endregion

        #region Serial Read
        /// <summary>
        /// This function endlessly reads the serial bus waiting for output from the device.
        /// </summary>
        public void Read()
        {
            while (port.IsOpen)
            {
                try
                {
                    string message = port.ReadLine();
                    Console.WriteLine(message);
                    
                    if (message.Contains("RESULT:"))
                    {
                        // on-device processed result. not that accurate.
                    }
                    else if (message.Contains("Settings Synced"))
                    {
                        settingsSynced = true;
                    }
                    else if (message.Contains("FW:"))
                    {
                        string[] sp = message.Split(':');
                        boardFirmware = double.Parse(sp[1]);
                        compareFirmware();
                        this.devStat.Invoke((MethodInvoker)(() => this.devStat.Text += " V" + boardFirmware));
                    }
                    else if (message.Contains("CALIB"))
                    {
                        if (message.Contains("Missing") && Properties.Settings.Default.BoardId == null)
                        {
                            CFuncs.showMessageBox(
                                "Please enter the board ID and CAL data from the card included with your unit on the settings page.",
                                "Calibration Data Missing",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                        }
                        else
                        {
                            // Save calibration data to settings and settingsPane boxes
                            settingsPane1.setBoardInfo(0000, 000000000); // TODO
                        }
                    }
                    else if (message.Contains("CLICK:"))
                    {
                        // click result
                        string[] splitMessage = message.Split(':');
                        double result = double.Parse(splitMessage[1]);
                        inputLagProcessed.Add(new inputLagResult { Type = resultType.Click, shotNumber = inputLagProcessed.Count + 1, totalInputLag = result / 1000 });
                        lastButton = GamepadButtonFlags.None;
                    }
                    else if (message.Contains("AUTO FINISHED")) // auto click test complete, write to folder & process
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    else if (message.Contains("Clicks Finished")) // click test finished, end test (user cancelled test)
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    
                    
                    else if (message.Contains("FINISHED"))
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    
                    else if (message.Contains("CLICKTEST"))
                    {
                        clickTestBox_Click(null, null);
                    }
                    else
                    {
                        debugList.Add(message);
                    }
                }
                catch (TimeoutException ex) // purposefully catch and ignore serial timeouts
                {
                    //Console.WriteLine(ex);
                    //debugList.Add(ex.Message + ex.StackTrace);
                }
                catch (ArgumentOutOfRangeException aex)
                {
                    Console.WriteLine(aex);
                    debugList.Add(aex.Message + aex.StackTrace);
                }
                catch (Exception e)
                {
                    try
                    {
                        port.Write("X");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                        debugList.Add(exc.Message + exc.StackTrace);
                    }
                    Console.WriteLine(e);
                    debugList.Add(e.Message + e.StackTrace);
                    port.Close();
                    portConnected = false;
                    //testRunning = false;
                    //testMode = false;
                    //testStarted = false;

                    //if (runTestThread != null)
                    //{ runTestThread.Abort(); }
                    //readThread.Abort();
                }
            }
        }
        #endregion

        /// <summary>
        /// Safely write to the serial port
        /// </summary>
        /// <param name="input"></param>
        public void portWrite(string input)
        {
            if (port != null)
            {
                if (port.IsOpen)
                {
                    try
                    {
                        port.Write(input);
                    }
                    catch (Exception ex)
                    {
                        debugList.Add(ex.Message + ex.StackTrace);
                        Console.WriteLine(ex.Message + ex.StackTrace);
                    }
                }
            }
        }

        private void compareFirmware()
        {
            // run function to fetch latest version, returns new version number
            // if (boardFirmware < newFirmware)
            // fwUpdateRunning = true;
            // port.Close();
            // run function to update firmware, returns bool. 
            if (downloadedFirmwareVersion > boardFirmware)
            {
                DialogResult d = CFuncs.showMessageBox("Current version: " + boardFirmware.ToString() + "\n New version: " + downloadedFirmwareVersion.ToString() + "\n Update now?", "Firmware Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    boardUpdate = true;
                    port.Close();
                }
            }

        }



        private void SetDeviceStatus(int state)
        {
            string text = " Device Not Connected";
            string testBtnText = "Start";
            Color bg = Color.FromArgb(255, 255, 131, 21);
            Color btnBg = Color.Gray;
            bool active = false;
            bool check = false;
            if (state == 1)
            {
                text = "Device Connected";
                check = true;
                active = true;
                bg = Color.FromArgb(255, 38, 50, 56);
            }
            else if (state == 2)
            {
                text = "Updating Firmware";
                bg = Color.Violet;
            }
            else if (state == 3)
            {
                text = "Update Successful";
                bg = Color.FromArgb(255, 105, 180, 76);
                check = true;
            }
            else if (state == 4)
            {
                text = "Firmware Update Failed";
                bg = Color.FromArgb(255, 255, 80, 80);
            }
            else if (state == 5)
            {
                text = "Test Running";
                active = false;
                bg = Color.FromArgb(255, 38, 50, 56);
                testBtnText = "End Test";
                check = true;
            }
            if (systemLagData.inputLagResults != null)
            {
                text += " - Pretest Data Saved";
            }
            if (this.devStat.InvokeRequired)
            {
                this.devStat.Invoke((MethodInvoker)(() => this.devStat.Text = text));
                
                this.deviceStatusPanel.Invoke((MethodInvoker)(() => this.deviceStatusPanel.BackColor = bg));
                
                this.Invoke((MethodInvoker)(() => this.Invalidate()));
            }
            else
            {
                this.devStat.Text = text;
                this.deviceStatusPanel.BackColor = bg;
                
                
                this.Invalidate();
            }
        }

        private void toggleMouseKeyboardBoxes(bool state)
        {
            if (this.clickTestBox.InvokeRequired)
            {
                this.clickTestBox.Invoke((MethodInvoker)(() => this.clickTestBox.Visible = state));
                

                if (state)
                {
                    this.clickTestBox.Invoke((MethodInvoker)(() => this.clickTestBox.BringToFront()));
                    this.Invoke((MethodInvoker)(() => this.mouseMoveLabel.Visible = false));
                    if (testSettings.TestSource == 2)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Install()));
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Install()));
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        Thread t = new Thread(new ThreadStart(ControllerEventHandler));
                        t.Start();
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Install()));
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Install()));
                        this.Invoke((MethodInvoker)(() => this.mouseMoveLabel.Visible = true));
                    }
                }
                else
                {
                    if (testSettings.TestSource == 2)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Uninstall()));
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Uninstall()));
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        ControllerKill = true;
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Uninstall()));
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Uninstall()));
                        this.Invoke((MethodInvoker)(() => this.mouseMoveLabel.Visible = false));
                    }
                }
            }
            else
            {
                this.clickTestBox.Visible = state;
                
                if (state)
                {
                    this.clickTestBox.BringToFront();
                    mouseMoveLabel.Visible = false;
                    if (testSettings.TestSource == 2)
                    {
                        mouseHook.Install();
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        keyboardHook.Install();
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        Thread t = new Thread(new ThreadStart(ControllerEventHandler));
                        t.Start();
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        mouseHook.Install();
                        keyboardHook.Install();
                        mouseMoveLabel.Visible = true;
                    }

                }
                else
                {
                    if (testSettings.TestSource == 2)
                    {
                        mouseHook.Uninstall();
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        keyboardHook.Uninstall();
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        ControllerKill = true;
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        mouseHook.Uninstall();
                        keyboardHook.Uninstall();
                        mouseMoveLabel.Visible = false;
                    }
                }
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }



        public void getInputLagEvents(List<float> fpsList)
        {
            inputLagEvents = fpsList;
            //Console.WriteLine(fpsList.Average().ToString());
        }

        private DialogResult DialogBox(string message, string title, string okButton, bool showCancel, string cancelText = "Cancel")
        {
            try
            {
                MaterialDialog materialDialog = new MaterialDialog(this, title, message, okButton, showCancel, cancelText, true);
                DialogResult result = materialDialog.ShowDialog(this);
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(result.ToString(), 750);

                SnackBarMessage.Show(this);
                return result;
            }
            catch (InvalidOperationException ex)
            {
                DialogResult d = MessageBox.Show(message, title, MessageBoxButtons.OKCancel);
                return d;
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            CFuncs.HyperlinkOut("https://OSRTT.github.io/OSPTTDocs/");
        }

        private void HotKeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.HotKey.Key == hotKeyList[0].Key)
            {
                /*if (startTestBtn.Enabled)
                {
                    startTestBtn_Click(null, null);
                }
                else
                {
                    // message box to say can't start test? undecided.
                    Console.WriteLine("Didn't start test");
                }*/
            }
        }

        public void pretestButtonState()
        {
            if (systemLagData.inputLagResults != null)
            {
                SetDeviceStatus(1);
            }
            else
            {
                SetDeviceStatus(1);
            }
        }

        private Thread testThread;
        public bool stopTest = false;

        private void startTestBtn_Click(object sender, EventArgs e)
        {
            if ("Start" == "Start")
            {
                bool skipTest = false; // can't think of a better way to do this atm..
                if (testSettings.PreTest && systemLagData.inputLagResults == null)
                {
                    DialogResult d = DialogBox("WARNING: No pretest data found. Please run the pretest before testing or disable the pretest option. Continuing will disable the option.",
                    "PRETEST Data Not Found", "Continue Anyway", true, "Cancel Test");
                    if (d == DialogResult.Cancel)
                    {
                        skipTest = true;
                    }
                }
                if (!skipTest)
                {
                    settingsSynced = false;
                    stopTest = false;
                    /*if (settingsPane1.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            settingsPane1.SaveSettings();
                        });
                    }
                    else
                    {
                        settingsPane1.SaveSettings();
                    }*/
                    inputLagRawData.Clear();
                    inputLagProcessed.Clear();
                    resultsFolderPath = CFuncs.makeResultsFolder(resultsPath, testSettings.GetResultType(testSettings.SensorType), testName2.Text);
                    // create raw and processed files? or just let the files do that?
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 6)
                    {
                        rawFileName = CFuncs.makeResultsFile(resultsFolderPath, "RAW");
                    }
                    processedFileName = CFuncs.makeResultsFile(resultsFolderPath, "PROCESSED");
                    SetDeviceStatus(5);
                    
                        testThread = new Thread(new ThreadStart(runTest));
                        testThread.Start();
                    
                }
            }
            else
            {
                //Console.WriteLine("Test thread alive: " +testThread.IsAlive);
                // End test
                portWrite("X");
                stopTest = true;
                MouseMoveTest = false;
                toggleMouseKeyboardBoxes(false);
                SetDeviceStatus(1);

                SaveResultsToFile();
                CFuncs.removeResultsFolder(resultsFolderPath); // if test failed to produce data, remove folder
                if (inputLagProcessed.Count != 0 || inputLagRawData.Count != 0)
                {
                    //Thread inputLagThread = new Thread(new ThreadStart(processInputLagData));
                    //inputLagThread.Start();
                }
                try { testThread.Abort(); } catch { } // added this as a catch incase the thread is still hanging around

            }
        }

        private void SaveResultsToFile()
        {
            string[] folders = resultsFolderPath.Split('\\');
            string monitorInfo = folders.Last();
            if (inputLagRawData.Count != 0)
            {
                string filePath = resultsFolderPath + "\\" + monitorInfo + "-RAW-OSPTT.csv";
                string strSeparator = ",";
                StringBuilder csvString = new StringBuilder();
                foreach (var res in inputLagRawData)
                {
                    csvString.AppendLine(res.ClickTime.ToString() + "," + res.FrameTime.ToString() + "," + res.TimeTaken.ToString() + "," + res.SampleCount.ToString() + "," + string.Join(strSeparator, res.Samples));
                }
                File.WriteAllText(filePath, csvString.ToString());
            }
            else if (inputLagProcessed.Count != 0)
            {
                //inputLagProcessed
                string filePath = resultsFolderPath + "\\" + monitorInfo + "-RAWRESULTS-OSPTT.csv";
                StringBuilder csvString = new StringBuilder();
                csvString.AppendLine("Result Type,Shot Number,Click Time (ms),Frame Time (ms),On Display Latency (ms),Total Input Latency (ms)");
                foreach (var res in inputLagProcessed)
                {
                    csvString.AppendLine(res.Type.ToString() + "," + res.shotNumber.ToString() + "," + res.frameTimeMs.ToString() + "," + res.clickTimeMs.ToString() + "," + res.onDisplayLatency.ToString() + "," + res.totalInputLag.ToString());
                }
                File.WriteAllText(filePath, csvString.ToString());
            }
        }

        private void SyncSettingsThreadFunc()
        {
            Thread.Sleep(1000);
            if (port != null)
            {
                if (!settingsSynced)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        //settingsPane1.SaveSettings();
                    });
                }
            }
        }

        private void runTest()
        {
            try
            {
                while (!settingsSynced) { Thread.Sleep(100); } // can use this because this function is threaded
                portWrite("T");
                RunSettings = SettingsClasses.initRunSettings();
                inputLagEvents.Clear();
                inputLagProcessed.Clear();
                inputLagRawData.Clear();
                ControllerKill = false;
                if (testSettings.TestSource == 2 || testSettings.TestSource == 6 || testSettings.TestSource == 7 || testSettings.TestSource == 8) // mouse/keyboard mode
                {
                    // switch modes then wait for test end
                    toggleMouseKeyboardBoxes(true);
                    if (testSettings.TestSource == 8)
                    {
                        MouseMoveTest = true;
                    }
                }
                else if (testSettings.TestSource == 4) // audio clip
                {
                    // wait for device trigger still right?
                }
                else
                {
                    // erm idk? wait? External/game mode
                }
                while (!stopTest)
                {
                    Thread.Sleep(100);
                }
                SetDeviceStatus(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                debugList.Add(ex.Message + ex.StackTrace);
            }
        }

        

        

        private void clickTestBox_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // click handlers added 87us
            // 1.1ms avg added waiting for click handler (triggered with mouse clicks)
            portWrite("H");
            Console.WriteLine("H sent");
        }
        bool testbool = false;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void resultsViewBtn_Click(object sender, EventArgs e)
        {
            ResultsView res = new ResultsView();
            res.importMode();
            res.Show();
        }
        private void resultsFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start(resultsPath);
        }
        private void viewerBtn2_Click(object sender, EventArgs e)
        {
            ResultsView res = new ResultsView();
            res.importMode();
            res.Show();
        }
        private void resFolderBtn2_Click(object sender, EventArgs e)
        {
            Process.Start(resultsPath);
        }

        private void hotkeySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                try
                {
                    string selected = s.Items[s.SelectedIndex].ToString();
                    Key newKey = hotkeysDict[selected];
                    if (hotKeyList.Count > 0)
                    {
                        hotKeys.Unregister(hotKeyList[0].Key, System.Windows.Input.ModifierKeys.None);
                        hotKeyList.Clear();
                    }
                    var k = hotKeys.Register(newKey, System.Windows.Input.ModifierKeys.None);
                    hotKeyList.Add(k);
                    Properties.Settings.Default.hotkey = selected;
                    Properties.Settings.Default.Save();
                }
                catch { }
            }   
        }
        public Dictionary<string, Key> hotkeysDict = new Dictionary<string, Key> {
                { "F1", Key.F1 },
                { "F2", Key.F2 },
                { "F3", Key.F3 },
                { "F4", Key.F4 },
                { "F5", Key.F5 },
                { "F6", Key.F6 },
                { "F7", Key.F7 },
                { "F8", Key.F8 },
                { "F9", Key.F9 },
                { "F10", Key.F10 },
                { "F11", Key.F11 },
                { "F12", Key.F12 },
            };
        private void fillHotkeyList()
        {
            var preset = Properties.Settings.Default.hotkey;
            int count = 0; // I know I could do this with a for loop but it's midnight I cba
            int sel = 0;
            foreach (var i in hotkeysDict)
            {
                //hotkeySelect.Items.Add(i.Key);
                if (i.Key != preset) { count++; }
                else { sel = count; }
            }
            //hotkeySelect.SelectedIndex = sel;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            portWrite("Z1");
        }

        private void clearDebugBtn_Click(object sender, EventArgs e)
        {
            debugList.Clear();
            debugBox.Clear();
        }
        private void UpdateDebugLog()
        {
            int listSize = 0;
            while (true)
            {
                while (this.IsHandleCreated)
                {
                    if (listSize != debugList.Count)
                    {
                        for (int i = listSize; i < debugList.Count; i++)
                        {
                            this.debugBox.Invoke((MethodInvoker)(() => this.debugBox.Text = debugList[i] + Environment.NewLine + this.debugBox.Text));
                        }
                        listSize = debugList.Count();
                    }
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
            }
        }
        private void debugBtn_Click_1(object sender, EventArgs e)
        {
            // enable debugging?
            if (debugThread.IsAlive)
            {
                debugThread = new Thread(new ThreadStart(UpdateDebugLog));
                debugBtn.Text = "Disable Debugging";
            }
            else
            {
                debugThread.Abort();
                debugBtn.Text = "Enable Debugging";
            }
        }

        void EnableDisableActions(int activeTest)
        {
            testName1.Enabled = false;
            testName2.Enabled = false;
            actNextBtn.Enabled = false;
            actuationPointBox.Enabled = false;
            if (activeTest == 0) // Actuation Point
            {
                actuationPointCard.Enabled = true;
                forceCard.Enabled = false;
                latencyCard.Enabled = false;
                mouseSwitchCard.Enabled = false;
                sensorCard.Enabled = false;
            }
            else if (activeTest == 1) // Force
            {
                actuationPointCard.Enabled = false;
                forceCard.Enabled = true;
                latencyCard.Enabled = false;
                mouseSwitchCard.Enabled = false;
                sensorCard.Enabled = false;
            }
            else if (activeTest == 2) // Switch Latency
            {
                actuationPointCard.Enabled = false;
                forceCard.Enabled = false;
                latencyCard.Enabled = true;
                mouseSwitchCard.Enabled = false;
                sensorCard.Enabled = false;
            }
            else if (activeTest == 3) // Mouse Latency
            {
                actuationPointCard.Enabled = false;
                forceCard.Enabled = false;
                latencyCard.Enabled = false;
                mouseSwitchCard.Enabled = true;
                sensorCard.Enabled = false;
            }
            else if (activeTest == 4) // Mouse Sensor
            {
                actuationPointCard.Enabled = false;
                forceCard.Enabled = false;
                latencyCard.Enabled = false;
                mouseSwitchCard.Enabled = false;
                sensorCard.Enabled = true;
            }
            else // all active
            {
                testName1.Enabled = true;
                testName2.Enabled = true;
                actuationPointCard.Enabled = true;
                forceCard.Enabled = true;
                latencyCard.Enabled = true;
                mouseSwitchCard.Enabled = true;
                sensorCard.Enabled = true;
            }
        }

        private void actuationTestBtn_Click(object sender, EventArgs e)
        {
            EnableDisableActions(0);
            actNextBtn.Enabled = true;
            actuationPointBox.Enabled = true;
            portWrite("T1");
            CFuncs.SetLabel(actInstLabel, "Setting Up Tool...");
            // run test
        }

        private void actNextBtn_Click(object sender, EventArgs e)
        {
            EnableDisableActions(1);
            portWrite("N");
            CFuncs.SetLabel(actInstLabel, "Setting Up Tool...");


        }

        private void forceTestBtn_Click(object sender, EventArgs e)
        {
            EnableDisableActions(2);
            if (initialForceBox.Text == "  gf" && opForceBox.Text == "  gf" && endForceBox.Text == "  gf")
            {
                CFuncs.showMessageBox("Please enter at least one force value. Test cancelled.", "Error - Can't Run Test", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int initial = int.Parse(initialForceBox.Text.Substring(0, 2));
                int operating = int.Parse(opForceBox.Text.Substring(0, 2));
                int end = int.Parse(endForceBox.Text.Substring(0, 2));
                if (initial <= 10 || operating <= 10)
                {
                    CFuncs.showMessageBox( "The tool needs at least 10 gram-force of initial pressure to work. Test cancelled.", "Error - Can't Run Test", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    portWrite("T2");
                    CFuncs.SetLabel(actInstLabel, "Setting Up Tool...");

                }
            }
        }

        private void latencyBtn_Click(object sender, EventArgs e)
        {
            EnableDisableActions(3);
            portWrite("T3");
            CFuncs.SetLabel(actInstLabel, "Setting Up Tool...");

        }

        private void mouseSwitchBtn_Click(object sender, EventArgs e)
        {
            EnableDisableActions(4);
            portWrite("T4");
            CFuncs.SetLabel(actInstLabel, "Setting Up Tool...");

        }

        private void mouseSensorBtn_Click(object sender, EventArgs e)
        {
            EnableDisableActions(5);
            if (sensorDPIBox.Text == "       dpi")
            {
                CFuncs.showMessageBox("Please enter the current mouse DPI to run this test before starting. Test cancelled.", "Error - Can't Run Test", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                portWrite("T5");
                CFuncs.SetLabel(actInstLabel, "Setting Up Tool...");

            }

        }

        
    }

}
