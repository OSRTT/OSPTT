using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls; 

namespace OSPTT
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.deviceStatusPanel = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.devStat = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.deviceNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.clickTestBox = new MaterialSkin.Controls.MaterialCard();
            this.mouseMoveLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.consolesPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.gamepadPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.keyboardPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.customPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.headsetPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.gamePresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.mouseClickPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.monitorPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.resultsFolderBtn = new MaterialSkin.Controls.MaterialButton();
            this.resultsViewBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.startTestBtn = new MaterialSkin.Controls.MaterialButton();
            this.hotkeySelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.KeyboardPage = new System.Windows.Forms.TabPage();
            this.MousePage = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.resFolderBtn2 = new MaterialSkin.Controls.MaterialButton();
            this.viewerBtn2 = new MaterialSkin.Controls.MaterialButton();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.HelpPage = new System.Windows.Forms.TabPage();
            this.clearDebugBtn = new MaterialSkin.Controls.MaterialButton();
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.actuationTestBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.deviceStatusPanel.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.clickTestBox.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.KeyboardPage.SuspendLayout();
            this.MousePage.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.HelpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceStatusPanel
            // 
            this.deviceStatusPanel.BackColor = System.Drawing.Color.White;
            this.deviceStatusPanel.Controls.Add(this.materialButton2);
            this.deviceStatusPanel.Controls.Add(this.devStat);
            this.deviceStatusPanel.Controls.Add(this.materialButton1);
            this.deviceStatusPanel.Location = new System.Drawing.Point(278, 24);
            this.deviceStatusPanel.Name = "deviceStatusPanel";
            this.deviceStatusPanel.Size = new System.Drawing.Size(753, 40);
            this.deviceStatusPanel.TabIndex = 31;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(572, 2);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(150, 36);
            this.materialButton2.TabIndex = 59;
            this.materialButton2.Text = "(Dev) Test Board";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // devStat
            // 
            this.devStat.AutoSize = true;
            this.devStat.BackColor = System.Drawing.Color.Transparent;
            this.devStat.Depth = 0;
            this.devStat.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.devStat.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.devStat.Location = new System.Drawing.Point(13, 8);
            this.devStat.MouseState = MaterialSkin.MouseState.HOVER;
            this.devStat.Name = "devStat";
            this.devStat.Size = new System.Drawing.Size(162, 24);
            this.devStat.TabIndex = 10;
            this.devStat.Text = "Device Connected";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(466, 2);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(98, 36);
            this.materialButton1.TabIndex = 58;
            this.materialButton1.Text = "(Dev) Test";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 273);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 42;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.deviceNameBox);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(109, 183);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(903, 77);
            this.materialCard2.TabIndex = 45;
            // 
            // deviceNameBox
            // 
            this.deviceNameBox.AnimateReadOnly = false;
            this.deviceNameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deviceNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.deviceNameBox.Depth = 0;
            this.deviceNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deviceNameBox.HideSelection = true;
            this.deviceNameBox.Hint = "Test Name - Device, Settings, etc";
            this.deviceNameBox.LeadingIcon = null;
            this.deviceNameBox.Location = new System.Drawing.Point(14, 13);
            this.deviceNameBox.MaxLength = 32767;
            this.deviceNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.deviceNameBox.Name = "deviceNameBox";
            this.deviceNameBox.PasswordChar = '\0';
            this.deviceNameBox.PrefixSuffixText = null;
            this.deviceNameBox.ReadOnly = false;
            this.deviceNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deviceNameBox.SelectedText = "";
            this.deviceNameBox.SelectionLength = 0;
            this.deviceNameBox.SelectionStart = 0;
            this.deviceNameBox.ShortcutsEnabled = true;
            this.deviceNameBox.Size = new System.Drawing.Size(874, 48);
            this.deviceNameBox.TabIndex = 3;
            this.deviceNameBox.TabStop = false;
            this.deviceNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deviceNameBox.TrailingIcon = null;
            this.deviceNameBox.UseSystemPasswordChar = false;
            // 
            // clickTestBox
            // 
            this.clickTestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clickTestBox.Controls.Add(this.mouseMoveLabel);
            this.clickTestBox.Controls.Add(this.materialLabel11);
            this.clickTestBox.Depth = 0;
            this.clickTestBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickTestBox.Location = new System.Drawing.Point(941, 31);
            this.clickTestBox.Margin = new System.Windows.Forms.Padding(14);
            this.clickTestBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickTestBox.Name = "clickTestBox";
            this.clickTestBox.Padding = new System.Windows.Forms.Padding(14);
            this.clickTestBox.Size = new System.Drawing.Size(903, 661);
            this.clickTestBox.TabIndex = 48;
            // 
            // mouseMoveLabel
            // 
            this.mouseMoveLabel.AutoSize = true;
            this.mouseMoveLabel.Depth = 0;
            this.mouseMoveLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mouseMoveLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.mouseMoveLabel.Location = new System.Drawing.Point(245, 603);
            this.mouseMoveLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mouseMoveLabel.Name = "mouseMoveLabel";
            this.mouseMoveLabel.Size = new System.Drawing.Size(411, 29);
            this.mouseMoveLabel.TabIndex = 2;
            this.mouseMoveLabel.Text = "Press a key to reset after mouse move";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(324, 14);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(248, 29);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "Click or type in this box";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow-rotate-right.png");
            this.imageList1.Images.SetKeyName(1, "bug-solid.png");
            this.imageList1.Images.SetKeyName(2, "chart-bar-solid.png");
            this.imageList1.Images.SetKeyName(3, "check.png");
            this.imageList1.Images.SetKeyName(4, "circle-question-solid.png");
            this.imageList1.Images.SetKeyName(5, "computer-mouse-solid.png");
            this.imageList1.Images.SetKeyName(6, "desktop-solid.png");
            this.imageList1.Images.SetKeyName(7, "folder-solid.png");
            this.imageList1.Images.SetKeyName(8, "gamepad-solid.png");
            this.imageList1.Images.SetKeyName(9, "gear-solid.png");
            this.imageList1.Images.SetKeyName(10, "headset-solid.png");
            this.imageList1.Images.SetKeyName(11, "keyboard-solid.png");
            this.imageList1.Images.SetKeyName(12, "play-solid.png");
            this.imageList1.Images.SetKeyName(13, "wrench-solid.png");
            this.imageList1.Images.SetKeyName(14, "mouse-24.png");
            this.imageList1.Images.SetKeyName(15, "gear-24.png");
            this.imageList1.Images.SetKeyName(16, "keyboard-24.png");
            this.imageList1.Images.SetKeyName(17, "question-24.png");
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.consolesPresetBtn);
            this.materialCard1.Controls.Add(this.gamepadPresetBtn);
            this.materialCard1.Controls.Add(this.keyboardPresetBtn);
            this.materialCard1.Controls.Add(this.customPresetBtn);
            this.materialCard1.Controls.Add(this.headsetPresetBtn);
            this.materialCard1.Controls.Add(this.gamePresetBtn);
            this.materialCard1.Controls.Add(this.mouseClickPresetBtn);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.monitorPresetBtn);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 307);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(889, 141);
            this.materialCard1.TabIndex = 58;
            // 
            // consolesPresetBtn
            // 
            this.consolesPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consolesPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consolesPresetBtn.Depth = 0;
            this.consolesPresetBtn.HighEmphasis = true;
            this.consolesPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("consolesPresetBtn.Icon")));
            this.consolesPresetBtn.Location = new System.Drawing.Point(14, 93);
            this.consolesPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consolesPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consolesPresetBtn.Name = "consolesPresetBtn";
            this.consolesPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consolesPresetBtn.Size = new System.Drawing.Size(124, 36);
            this.consolesPresetBtn.TabIndex = 65;
            this.consolesPresetBtn.Text = "Consoles";
            this.consolesPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consolesPresetBtn.UseAccentColor = false;
            this.consolesPresetBtn.UseVisualStyleBackColor = true;
            this.consolesPresetBtn.Click += new System.EventHandler(this.consolesPresetBtn_Click);
            // 
            // gamepadPresetBtn
            // 
            this.gamepadPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamepadPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gamepadPresetBtn.Depth = 0;
            this.gamepadPresetBtn.HighEmphasis = true;
            this.gamepadPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("gamepadPresetBtn.Icon")));
            this.gamepadPresetBtn.Location = new System.Drawing.Point(479, 47);
            this.gamepadPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gamepadPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.gamepadPresetBtn.Name = "gamepadPresetBtn";
            this.gamepadPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gamepadPresetBtn.Size = new System.Drawing.Size(119, 36);
            this.gamepadPresetBtn.TabIndex = 64;
            this.gamepadPresetBtn.Text = "Gamepad";
            this.gamepadPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gamepadPresetBtn.UseAccentColor = false;
            this.gamepadPresetBtn.UseVisualStyleBackColor = true;
            this.gamepadPresetBtn.Click += new System.EventHandler(this.gamepadPresetBtn_Click);
            // 
            // keyboardPresetBtn
            // 
            this.keyboardPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.keyboardPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.keyboardPresetBtn.Depth = 0;
            this.keyboardPresetBtn.HighEmphasis = true;
            this.keyboardPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("keyboardPresetBtn.Icon")));
            this.keyboardPresetBtn.Location = new System.Drawing.Point(331, 47);
            this.keyboardPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.keyboardPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyboardPresetBtn.Name = "keyboardPresetBtn";
            this.keyboardPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.keyboardPresetBtn.Size = new System.Drawing.Size(124, 36);
            this.keyboardPresetBtn.TabIndex = 63;
            this.keyboardPresetBtn.Text = "Keyboard";
            this.keyboardPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.keyboardPresetBtn.UseAccentColor = false;
            this.keyboardPresetBtn.UseVisualStyleBackColor = true;
            this.keyboardPresetBtn.Click += new System.EventHandler(this.keyboardPresetBtn_Click);
            // 
            // customPresetBtn
            // 
            this.customPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.customPresetBtn.Depth = 0;
            this.customPresetBtn.HighEmphasis = true;
            this.customPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("customPresetBtn.Icon")));
            this.customPresetBtn.Location = new System.Drawing.Point(165, 93);
            this.customPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.customPresetBtn.Name = "customPresetBtn";
            this.customPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.customPresetBtn.Size = new System.Drawing.Size(109, 36);
            this.customPresetBtn.TabIndex = 62;
            this.customPresetBtn.Text = "Custom";
            this.customPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.customPresetBtn.UseAccentColor = false;
            this.customPresetBtn.UseVisualStyleBackColor = true;
            this.customPresetBtn.Click += new System.EventHandler(this.customPresetBtn_Click);
            // 
            // headsetPresetBtn
            // 
            this.headsetPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headsetPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.headsetPresetBtn.Depth = 0;
            this.headsetPresetBtn.HighEmphasis = true;
            this.headsetPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("headsetPresetBtn.Icon")));
            this.headsetPresetBtn.Location = new System.Drawing.Point(751, 47);
            this.headsetPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.headsetPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.headsetPresetBtn.Name = "headsetPresetBtn";
            this.headsetPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.headsetPresetBtn.Size = new System.Drawing.Size(123, 36);
            this.headsetPresetBtn.TabIndex = 61;
            this.headsetPresetBtn.Text = "Headsets";
            this.headsetPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.headsetPresetBtn.UseAccentColor = false;
            this.headsetPresetBtn.UseVisualStyleBackColor = true;
            this.headsetPresetBtn.Click += new System.EventHandler(this.headsetPresetBtn_Click);
            // 
            // gamePresetBtn
            // 
            this.gamePresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamePresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gamePresetBtn.Depth = 0;
            this.gamePresetBtn.HighEmphasis = true;
            this.gamePresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("gamePresetBtn.Icon")));
            this.gamePresetBtn.Location = new System.Drawing.Point(626, 47);
            this.gamePresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gamePresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.gamePresetBtn.Name = "gamePresetBtn";
            this.gamePresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gamePresetBtn.Size = new System.Drawing.Size(99, 36);
            this.gamePresetBtn.TabIndex = 60;
            this.gamePresetBtn.Text = "Games";
            this.gamePresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gamePresetBtn.UseAccentColor = false;
            this.gamePresetBtn.UseVisualStyleBackColor = true;
            this.gamePresetBtn.Click += new System.EventHandler(this.gamePresetBtn_Click);
            // 
            // mouseClickPresetBtn
            // 
            this.mouseClickPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mouseClickPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mouseClickPresetBtn.Depth = 0;
            this.mouseClickPresetBtn.HighEmphasis = true;
            this.mouseClickPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("mouseClickPresetBtn.Icon")));
            this.mouseClickPresetBtn.Location = new System.Drawing.Point(165, 47);
            this.mouseClickPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mouseClickPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mouseClickPresetBtn.Name = "mouseClickPresetBtn";
            this.mouseClickPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mouseClickPresetBtn.Size = new System.Drawing.Size(144, 36);
            this.mouseClickPresetBtn.TabIndex = 59;
            this.mouseClickPresetBtn.Text = "Mouse Click";
            this.mouseClickPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mouseClickPresetBtn.UseAccentColor = false;
            this.mouseClickPresetBtn.UseVisualStyleBackColor = true;
            this.mouseClickPresetBtn.Click += new System.EventHandler(this.miceKeyboardPresetBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 29);
            this.materialLabel1.TabIndex = 58;
            this.materialLabel1.Text = "Preset Modes";
            // 
            // monitorPresetBtn
            // 
            this.monitorPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monitorPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.monitorPresetBtn.Depth = 0;
            this.monitorPresetBtn.HighEmphasis = true;
            this.monitorPresetBtn.Icon = ((System.Drawing.Image)(resources.GetObject("monitorPresetBtn.Icon")));
            this.monitorPresetBtn.Location = new System.Drawing.Point(14, 47);
            this.monitorPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monitorPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.monitorPresetBtn.Name = "monitorPresetBtn";
            this.monitorPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.monitorPresetBtn.Size = new System.Drawing.Size(124, 36);
            this.monitorPresetBtn.TabIndex = 57;
            this.monitorPresetBtn.Text = "Monitors";
            this.monitorPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.monitorPresetBtn.UseAccentColor = false;
            this.monitorPresetBtn.UseVisualStyleBackColor = true;
            this.monitorPresetBtn.Click += new System.EventHandler(this.monitorPresetBtn_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.resultsFolderBtn);
            this.materialCard3.Controls.Add(this.resultsViewBtn);
            this.materialCard3.Controls.Add(this.hotkeySelect);
            this.materialCard3.Controls.Add(this.materialLabel9);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(39, 19);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(891, 57);
            this.materialCard3.TabIndex = 60;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 29);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = "Results Tools";
            // 
            // resultsFolderBtn
            // 
            this.resultsFolderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsFolderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultsFolderBtn.Depth = 0;
            this.resultsFolderBtn.HighEmphasis = true;
            this.resultsFolderBtn.Icon = ((System.Drawing.Image)(resources.GetObject("resultsFolderBtn.Icon")));
            this.resultsFolderBtn.Location = new System.Drawing.Point(326, 9);
            this.resultsFolderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resultsFolderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsFolderBtn.Name = "resultsFolderBtn";
            this.resultsFolderBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resultsFolderBtn.Size = new System.Drawing.Size(103, 36);
            this.resultsFolderBtn.TabIndex = 58;
            this.resultsFolderBtn.Text = "Folder";
            this.resultsFolderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resultsFolderBtn.UseAccentColor = false;
            this.resultsFolderBtn.UseVisualStyleBackColor = true;
            this.resultsFolderBtn.Click += new System.EventHandler(this.resultsFolderBtn_Click);
            // 
            // resultsViewBtn
            // 
            this.resultsViewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsViewBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultsViewBtn.Depth = 0;
            this.resultsViewBtn.HighEmphasis = true;
            this.resultsViewBtn.Icon = ((System.Drawing.Image)(resources.GetObject("resultsViewBtn.Icon")));
            this.resultsViewBtn.Location = new System.Drawing.Point(194, 9);
            this.resultsViewBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resultsViewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsViewBtn.Name = "resultsViewBtn";
            this.resultsViewBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resultsViewBtn.Size = new System.Drawing.Size(102, 36);
            this.resultsViewBtn.TabIndex = 57;
            this.resultsViewBtn.Text = "Viewer";
            this.resultsViewBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resultsViewBtn.UseAccentColor = false;
            this.resultsViewBtn.UseVisualStyleBackColor = true;
            this.resultsViewBtn.Click += new System.EventHandler(this.resultsViewBtn_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialMaskedTextBox1);
            this.materialCard5.Controls.Add(this.actuationTestBtn);
            this.materialCard5.Controls.Add(this.materialLabel4);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(17, 104);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(933, 276);
            this.materialCard5.TabIndex = 77;
            // 
            // startTestBtn
            // 
            this.startTestBtn.AutoSize = false;
            this.startTestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startTestBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startTestBtn.Depth = 0;
            this.startTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTestBtn.HighEmphasis = true;
            this.startTestBtn.Icon = ((System.Drawing.Image)(resources.GetObject("startTestBtn.Icon")));
            this.startTestBtn.Location = new System.Drawing.Point(737, 463);
            this.startTestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startTestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startTestBtn.Name = "startTestBtn";
            this.startTestBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startTestBtn.Size = new System.Drawing.Size(178, 54);
            this.startTestBtn.TabIndex = 56;
            this.startTestBtn.Text = "Start Testing";
            this.startTestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startTestBtn.UseAccentColor = true;
            this.startTestBtn.UseVisualStyleBackColor = true;
            this.startTestBtn.Click += new System.EventHandler(this.startTestBtn_Click);
            // 
            // hotkeySelect
            // 
            this.hotkeySelect.AutoResize = false;
            this.hotkeySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hotkeySelect.Depth = 0;
            this.hotkeySelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.hotkeySelect.DropDownHeight = 174;
            this.hotkeySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotkeySelect.DropDownWidth = 121;
            this.hotkeySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hotkeySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotkeySelect.FormattingEnabled = true;
            this.hotkeySelect.IntegralHeight = false;
            this.hotkeySelect.ItemHeight = 43;
            this.hotkeySelect.Location = new System.Drawing.Point(598, 6);
            this.hotkeySelect.MaxDropDownItems = 4;
            this.hotkeySelect.MouseState = MaterialSkin.MouseState.OUT;
            this.hotkeySelect.Name = "hotkeySelect";
            this.hotkeySelect.Size = new System.Drawing.Size(134, 49);
            this.hotkeySelect.StartIndex = 0;
            this.hotkeySelect.TabIndex = 67;
            this.hotkeySelect.SelectedIndexChanged += new System.EventHandler(this.hotkeySelect_SelectedIndexChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(507, 15);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(76, 29);
            this.materialLabel9.TabIndex = 66;
            this.materialLabel9.Text = "Hotkey";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.KeyboardPage);
            this.materialTabControl1.Controls.Add(this.MousePage);
            this.materialTabControl1.Controls.Add(this.SettingsPage);
            this.materialTabControl1.Controls.Add(this.HelpPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1020, 752);
            this.materialTabControl1.TabIndex = 78;
            // 
            // KeyboardPage
            // 
            this.KeyboardPage.Controls.Add(this.materialCard3);
            this.KeyboardPage.Controls.Add(this.materialCard5);
            this.KeyboardPage.Controls.Add(this.startTestBtn);
            this.KeyboardPage.Controls.Add(this.clickTestBox);
            this.KeyboardPage.ImageKey = "keyboard-24.png";
            this.KeyboardPage.Location = new System.Drawing.Point(4, 31);
            this.KeyboardPage.Name = "KeyboardPage";
            this.KeyboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.KeyboardPage.Size = new System.Drawing.Size(1012, 717);
            this.KeyboardPage.TabIndex = 0;
            this.KeyboardPage.Text = "Keyboard";
            this.KeyboardPage.UseVisualStyleBackColor = true;
            // 
            // MousePage
            // 
            this.MousePage.Controls.Add(this.materialCard4);
            this.MousePage.Controls.Add(this.materialCard1);
            this.MousePage.Controls.Add(this.materialCard2);
            this.MousePage.ImageKey = "mouse-24.png";
            this.MousePage.Location = new System.Drawing.Point(4, 31);
            this.MousePage.Name = "MousePage";
            this.MousePage.Padding = new System.Windows.Forms.Padding(3);
            this.MousePage.Size = new System.Drawing.Size(1012, 717);
            this.MousePage.TabIndex = 1;
            this.MousePage.Text = "Mouse";
            this.MousePage.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel3);
            this.materialCard4.Controls.Add(this.resFolderBtn2);
            this.materialCard4.Controls.Add(this.viewerBtn2);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(40, 19);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(891, 57);
            this.materialCard4.TabIndex = 61;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(17, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 29);
            this.materialLabel3.TabIndex = 67;
            this.materialLabel3.Text = "Results Tools";
            // 
            // resFolderBtn2
            // 
            this.resFolderBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resFolderBtn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resFolderBtn2.Depth = 0;
            this.resFolderBtn2.HighEmphasis = true;
            this.resFolderBtn2.Icon = ((System.Drawing.Image)(resources.GetObject("resFolderBtn2.Icon")));
            this.resFolderBtn2.Location = new System.Drawing.Point(326, 9);
            this.resFolderBtn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resFolderBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.resFolderBtn2.Name = "resFolderBtn2";
            this.resFolderBtn2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resFolderBtn2.Size = new System.Drawing.Size(103, 36);
            this.resFolderBtn2.TabIndex = 58;
            this.resFolderBtn2.Text = "Folder";
            this.resFolderBtn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resFolderBtn2.UseAccentColor = false;
            this.resFolderBtn2.UseVisualStyleBackColor = true;
            this.resFolderBtn2.Click += new System.EventHandler(this.resFolderBtn2_Click);
            // 
            // viewerBtn2
            // 
            this.viewerBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewerBtn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.viewerBtn2.Depth = 0;
            this.viewerBtn2.HighEmphasis = true;
            this.viewerBtn2.Icon = ((System.Drawing.Image)(resources.GetObject("viewerBtn2.Icon")));
            this.viewerBtn2.Location = new System.Drawing.Point(194, 9);
            this.viewerBtn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewerBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.viewerBtn2.Name = "viewerBtn2";
            this.viewerBtn2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.viewerBtn2.Size = new System.Drawing.Size(102, 36);
            this.viewerBtn2.TabIndex = 57;
            this.viewerBtn2.Text = "Viewer";
            this.viewerBtn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.viewerBtn2.UseAccentColor = false;
            this.viewerBtn2.UseVisualStyleBackColor = true;
            this.viewerBtn2.Click += new System.EventHandler(this.viewerBtn2_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.ImageKey = "gear-24.png";
            this.SettingsPage.Location = new System.Drawing.Point(4, 31);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(1012, 717);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // HelpPage
            // 
            this.HelpPage.Controls.Add(this.clearDebugBtn);
            this.HelpPage.Controls.Add(this.helpBtn);
            this.HelpPage.Controls.Add(this.debugBtn);
            this.HelpPage.Controls.Add(this.debugBox);
            this.HelpPage.ImageKey = "question-24.png";
            this.HelpPage.Location = new System.Drawing.Point(4, 31);
            this.HelpPage.Name = "HelpPage";
            this.HelpPage.Size = new System.Drawing.Size(1012, 717);
            this.HelpPage.TabIndex = 2;
            this.HelpPage.Text = "Help";
            this.HelpPage.UseVisualStyleBackColor = true;
            // 
            // clearDebugBtn
            // 
            this.clearDebugBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearDebugBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearDebugBtn.Depth = 0;
            this.clearDebugBtn.HighEmphasis = true;
            this.clearDebugBtn.Icon = global::OSPTT.Properties.Resources.arrow_rotate_right;
            this.clearDebugBtn.Location = new System.Drawing.Point(779, 124);
            this.clearDebugBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearDebugBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearDebugBtn.Name = "clearDebugBtn";
            this.clearDebugBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearDebugBtn.Size = new System.Drawing.Size(126, 36);
            this.clearDebugBtn.TabIndex = 64;
            this.clearDebugBtn.Text = "Clear Log";
            this.clearDebugBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearDebugBtn.UseAccentColor = false;
            this.clearDebugBtn.UseVisualStyleBackColor = true;
            this.clearDebugBtn.Click += new System.EventHandler(this.clearDebugBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpBtn.Depth = 0;
            this.helpBtn.HighEmphasis = true;
            this.helpBtn.Icon = ((System.Drawing.Image)(resources.GetObject("helpBtn.Icon")));
            this.helpBtn.Location = new System.Drawing.Point(819, 28);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.helpBtn.Size = new System.Drawing.Size(86, 36);
            this.helpBtn.TabIndex = 54;
            this.helpBtn.Text = "Help";
            this.helpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpBtn.UseAccentColor = false;
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // debugBtn
            // 
            this.debugBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debugBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.debugBtn.Depth = 0;
            this.debugBtn.HighEmphasis = true;
            this.debugBtn.Icon = ((System.Drawing.Image)(resources.GetObject("debugBtn.Icon")));
            this.debugBtn.Location = new System.Drawing.Point(715, 76);
            this.debugBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.debugBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.debugBtn.Size = new System.Drawing.Size(190, 36);
            this.debugBtn.TabIndex = 57;
            this.debugBtn.Text = "Enable Debugging";
            this.debugBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.debugBtn.UseAccentColor = false;
            this.debugBtn.UseVisualStyleBackColor = true;
            this.debugBtn.Click += new System.EventHandler(this.debugBtn_Click_1);
            // 
            // debugBox
            // 
            this.debugBox.AnimateReadOnly = true;
            this.debugBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debugBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.debugBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.debugBox.Depth = 0;
            this.debugBox.HideSelection = true;
            this.debugBox.Location = new System.Drawing.Point(12, 12);
            this.debugBox.MaxLength = 32767;
            this.debugBox.MouseState = MaterialSkin.MouseState.OUT;
            this.debugBox.Name = "debugBox";
            this.debugBox.PasswordChar = '\0';
            this.debugBox.ReadOnly = true;
            this.debugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugBox.SelectedText = "";
            this.debugBox.SelectionLength = 0;
            this.debugBox.SelectionStart = 0;
            this.debugBox.ShortcutsEnabled = true;
            this.debugBox.Size = new System.Drawing.Size(937, 702);
            this.debugBox.TabIndex = 63;
            this.debugBox.TabStop = false;
            this.debugBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.debugBox.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(17, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(220, 29);
            this.materialLabel4.TabIndex = 68;
            this.materialLabel4.Text = "Actuation Point Test";
            // 
            // actuationTestBtn
            // 
            this.actuationTestBtn.AutoSize = false;
            this.actuationTestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actuationTestBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.actuationTestBtn.Depth = 0;
            this.actuationTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actuationTestBtn.HighEmphasis = true;
            this.actuationTestBtn.Icon = ((System.Drawing.Image)(resources.GetObject("actuationTestBtn.Icon")));
            this.actuationTestBtn.Location = new System.Drawing.Point(737, 202);
            this.actuationTestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.actuationTestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.actuationTestBtn.Name = "actuationTestBtn";
            this.actuationTestBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.actuationTestBtn.Size = new System.Drawing.Size(178, 54);
            this.actuationTestBtn.TabIndex = 69;
            this.actuationTestBtn.Text = "Start Testing";
            this.actuationTestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.actuationTestBtn.UseAccentColor = true;
            this.actuationTestBtn.UseVisualStyleBackColor = true;
            this.actuationTestBtn.Click += new System.EventHandler(this.actuationTestBtn_Click);
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.Hint = "Current Actuation Point";
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(22, 63);
            this.materialMaskedTextBox1.Mask = "00.00";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(170, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 71;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.Text = "  .";
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 819);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.deviceStatusPanel);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "OSPTT V";
            this.Load += new System.EventHandler(this.Main_Load);
            this.deviceStatusPanel.ResumeLayout(false);
            this.deviceStatusPanel.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.clickTestBox.ResumeLayout(false);
            this.clickTestBox.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.KeyboardPage.ResumeLayout(false);
            this.MousePage.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.HelpPage.ResumeLayout(false);
            this.HelpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel deviceStatusPanel;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialLabel devStat;
        private MaterialSkin.Controls.MaterialButton startTestBtn;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 deviceNameBox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard clickTestBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialButton resultsViewBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton monitorPresetBtn;
        private MaterialSkin.Controls.MaterialButton headsetPresetBtn;
        private MaterialSkin.Controls.MaterialButton gamePresetBtn;
        private MaterialSkin.Controls.MaterialButton mouseClickPresetBtn;
        private MaterialSkin.Controls.MaterialButton customPresetBtn;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialComboBox hotkeySelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton resultsFolderBtn;
        private MaterialSkin.Controls.MaterialButton gamepadPresetBtn;
        private MaterialSkin.Controls.MaterialButton keyboardPresetBtn;
        private MaterialSkin.Controls.MaterialButton consolesPresetBtn;
        private MaterialSkin.Controls.MaterialLabel mouseMoveLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage KeyboardPage;
        private System.Windows.Forms.TabPage MousePage;
        private System.Windows.Forms.TabPage HelpPage;
        private TabPage SettingsPage;
        private MaterialButton helpBtn;
        private MaterialButton debugBtn;
        private MaterialButton clearDebugBtn;
        private MaterialMultiLineTextBox2 debugBox;
        private MaterialCard materialCard4;
        private MaterialLabel materialLabel3;
        private MaterialButton resFolderBtn2;
        private MaterialButton viewerBtn2;
        private MaterialButton actuationTestBtn;
        private MaterialLabel materialLabel4;
        private MaterialMaskedTextBox materialMaskedTextBox1;
    }
}

