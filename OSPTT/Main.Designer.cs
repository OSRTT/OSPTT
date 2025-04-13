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
            this.clickTestBox = new MaterialSkin.Controls.MaterialCard();
            this.mouseMoveLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.resultsFolderBtn = new MaterialSkin.Controls.MaterialButton();
            this.resultsViewBtn = new MaterialSkin.Controls.MaterialButton();
            this.actuationPointCard = new MaterialSkin.Controls.MaterialCard();
            this.actuationTestBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.KeyboardPage = new System.Windows.Forms.TabPage();
            this.actuationPointBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.actNextBtn = new MaterialSkin.Controls.MaterialButton();
            this.actInstLabel = new MaterialSkin.Controls.MaterialLabel();
            this.forceCard = new MaterialSkin.Controls.MaterialCard();
            this.forceInstLabel = new MaterialSkin.Controls.MaterialLabel();
            this.initialForceBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.forceTestBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.endForceBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.latencyCard = new MaterialSkin.Controls.MaterialCard();
            this.latencyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.latencyBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.textName1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.testName2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.mouseSwitchCard = new MaterialSkin.Controls.MaterialCard();
            this.mouseSwitchLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.sensorCard = new MaterialSkin.Controls.MaterialCard();
            this.sensorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.sensorDPIBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.deviceStatusPanel.SuspendLayout();
            this.clickTestBox.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.actuationPointCard.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.KeyboardPage.SuspendLayout();
            this.MousePage.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.HelpPage.SuspendLayout();
            this.forceCard.SuspendLayout();
            this.latencyCard.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.mouseSwitchCard.SuspendLayout();
            this.sensorCard.SuspendLayout();
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
            // clickTestBox
            // 
            this.clickTestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clickTestBox.Controls.Add(this.mouseMoveLabel);
            this.clickTestBox.Controls.Add(this.materialLabel11);
            this.clickTestBox.Depth = 0;
            this.clickTestBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickTestBox.Location = new System.Drawing.Point(978, 28);
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
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.resultsFolderBtn);
            this.materialCard3.Controls.Add(this.resultsViewBtn);
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
            // actuationPointCard
            // 
            this.actuationPointCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.actuationPointCard.Controls.Add(this.actInstLabel);
            this.actuationPointCard.Controls.Add(this.actNextBtn);
            this.actuationPointCard.Controls.Add(this.actuationPointBox);
            this.actuationPointCard.Controls.Add(this.actuationTestBtn);
            this.actuationPointCard.Controls.Add(this.materialLabel4);
            this.actuationPointCard.Depth = 0;
            this.actuationPointCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.actuationPointCard.Location = new System.Drawing.Point(17, 209);
            this.actuationPointCard.Margin = new System.Windows.Forms.Padding(14);
            this.actuationPointCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.actuationPointCard.Name = "actuationPointCard";
            this.actuationPointCard.Padding = new System.Windows.Forms.Padding(14);
            this.actuationPointCard.Size = new System.Drawing.Size(933, 137);
            this.actuationPointCard.TabIndex = 77;
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
            this.actuationTestBtn.Location = new System.Drawing.Point(737, 62);
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(695, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(220, 29);
            this.materialLabel4.TabIndex = 68;
            this.materialLabel4.Text = "Actuation Point Test";
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
            this.KeyboardPage.Controls.Add(this.materialCard5);
            this.KeyboardPage.Controls.Add(this.latencyCard);
            this.KeyboardPage.Controls.Add(this.forceCard);
            this.KeyboardPage.Controls.Add(this.materialCard3);
            this.KeyboardPage.Controls.Add(this.actuationPointCard);
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
            // actuationPointBox
            // 
            this.actuationPointBox.AllowPromptAsInput = true;
            this.actuationPointBox.AnimateReadOnly = false;
            this.actuationPointBox.AsciiOnly = false;
            this.actuationPointBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.actuationPointBox.BeepOnError = false;
            this.actuationPointBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.actuationPointBox.Depth = 0;
            this.actuationPointBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actuationPointBox.HidePromptOnLeave = false;
            this.actuationPointBox.HideSelection = true;
            this.actuationPointBox.Hint = "Current Actuation Point";
            this.actuationPointBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.actuationPointBox.LeadingIcon = null;
            this.actuationPointBox.Location = new System.Drawing.Point(33, 68);
            this.actuationPointBox.Mask = "00.00";
            this.actuationPointBox.MaxLength = 32767;
            this.actuationPointBox.MouseState = MaterialSkin.MouseState.OUT;
            this.actuationPointBox.Name = "actuationPointBox";
            this.actuationPointBox.PasswordChar = '\0';
            this.actuationPointBox.PrefixSuffixText = null;
            this.actuationPointBox.PromptChar = '_';
            this.actuationPointBox.ReadOnly = false;
            this.actuationPointBox.RejectInputOnFirstFailure = false;
            this.actuationPointBox.ResetOnPrompt = true;
            this.actuationPointBox.ResetOnSpace = true;
            this.actuationPointBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.actuationPointBox.SelectedText = "";
            this.actuationPointBox.SelectionLength = 0;
            this.actuationPointBox.SelectionStart = 0;
            this.actuationPointBox.ShortcutsEnabled = true;
            this.actuationPointBox.Size = new System.Drawing.Size(170, 48);
            this.actuationPointBox.SkipLiterals = true;
            this.actuationPointBox.TabIndex = 71;
            this.actuationPointBox.TabStop = false;
            this.actuationPointBox.Text = "  .";
            this.actuationPointBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.actuationPointBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.actuationPointBox.TrailingIcon = null;
            this.actuationPointBox.UseSystemPasswordChar = false;
            this.actuationPointBox.ValidatingType = null;
            // 
            // MousePage
            // 
            this.MousePage.Controls.Add(this.sensorCard);
            this.MousePage.Controls.Add(this.mouseSwitchCard);
            this.MousePage.Controls.Add(this.materialCard2);
            this.MousePage.Controls.Add(this.materialCard4);
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
            this.materialCard4.Location = new System.Drawing.Point(39, 19);
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
            // actNextBtn
            // 
            this.actNextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actNextBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.actNextBtn.Depth = 0;
            this.actNextBtn.HighEmphasis = true;
            this.actNextBtn.Icon = null;
            this.actNextBtn.Location = new System.Drawing.Point(231, 74);
            this.actNextBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.actNextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.actNextBtn.Name = "actNextBtn";
            this.actNextBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.actNextBtn.Size = new System.Drawing.Size(64, 36);
            this.actNextBtn.TabIndex = 72;
            this.actNextBtn.Text = "Next";
            this.actNextBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.actNextBtn.UseAccentColor = false;
            this.actNextBtn.UseVisualStyleBackColor = true;
            // 
            // actInstLabel
            // 
            this.actInstLabel.AutoSize = true;
            this.actInstLabel.Depth = 0;
            this.actInstLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.actInstLabel.Location = new System.Drawing.Point(36, 36);
            this.actInstLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.actInstLabel.Name = "actInstLabel";
            this.actInstLabel.Size = new System.Drawing.Size(461, 19);
            this.actInstLabel.TabIndex = 73;
            this.actInstLabel.Text = "Position Tool Above Switch (not space or escape) Before Starting";
            // 
            // forceCard
            // 
            this.forceCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.forceCard.Controls.Add(this.endForceBox);
            this.forceCard.Controls.Add(this.forceInstLabel);
            this.forceCard.Controls.Add(this.initialForceBox);
            this.forceCard.Controls.Add(this.forceTestBtn);
            this.forceCard.Controls.Add(this.materialLabel6);
            this.forceCard.Depth = 0;
            this.forceCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.forceCard.Location = new System.Drawing.Point(17, 374);
            this.forceCard.Margin = new System.Windows.Forms.Padding(14);
            this.forceCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.forceCard.Name = "forceCard";
            this.forceCard.Padding = new System.Windows.Forms.Padding(14);
            this.forceCard.Size = new System.Drawing.Size(933, 137);
            this.forceCard.TabIndex = 78;
            // 
            // forceInstLabel
            // 
            this.forceInstLabel.AutoSize = true;
            this.forceInstLabel.Depth = 0;
            this.forceInstLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forceInstLabel.Location = new System.Drawing.Point(36, 36);
            this.forceInstLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.forceInstLabel.Name = "forceInstLabel";
            this.forceInstLabel.Size = new System.Drawing.Size(461, 19);
            this.forceInstLabel.TabIndex = 73;
            this.forceInstLabel.Text = "Position Tool Above Switch (not space or escape) Before Starting";
            // 
            // initialForceBox
            // 
            this.initialForceBox.AllowPromptAsInput = true;
            this.initialForceBox.AnimateReadOnly = false;
            this.initialForceBox.AsciiOnly = false;
            this.initialForceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.initialForceBox.BeepOnError = false;
            this.initialForceBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.initialForceBox.Depth = 0;
            this.initialForceBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialForceBox.HidePromptOnLeave = false;
            this.initialForceBox.HideSelection = true;
            this.initialForceBox.Hint = "Initial Force Spec";
            this.initialForceBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.initialForceBox.LeadingIcon = null;
            this.initialForceBox.Location = new System.Drawing.Point(33, 68);
            this.initialForceBox.Mask = "00gf";
            this.initialForceBox.MaxLength = 32767;
            this.initialForceBox.MouseState = MaterialSkin.MouseState.OUT;
            this.initialForceBox.Name = "initialForceBox";
            this.initialForceBox.PasswordChar = '\0';
            this.initialForceBox.PrefixSuffixText = null;
            this.initialForceBox.PromptChar = '_';
            this.initialForceBox.ReadOnly = false;
            this.initialForceBox.RejectInputOnFirstFailure = false;
            this.initialForceBox.ResetOnPrompt = true;
            this.initialForceBox.ResetOnSpace = true;
            this.initialForceBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.initialForceBox.SelectedText = "";
            this.initialForceBox.SelectionLength = 0;
            this.initialForceBox.SelectionStart = 0;
            this.initialForceBox.ShortcutsEnabled = true;
            this.initialForceBox.Size = new System.Drawing.Size(170, 48);
            this.initialForceBox.SkipLiterals = true;
            this.initialForceBox.TabIndex = 71;
            this.initialForceBox.TabStop = false;
            this.initialForceBox.Text = "  gf";
            this.initialForceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.initialForceBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.initialForceBox.TrailingIcon = null;
            this.initialForceBox.UseSystemPasswordChar = false;
            this.initialForceBox.ValidatingType = null;
            // 
            // forceTestBtn
            // 
            this.forceTestBtn.AutoSize = false;
            this.forceTestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forceTestBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.forceTestBtn.Depth = 0;
            this.forceTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forceTestBtn.HighEmphasis = true;
            this.forceTestBtn.Icon = ((System.Drawing.Image)(resources.GetObject("forceTestBtn.Icon")));
            this.forceTestBtn.Location = new System.Drawing.Point(737, 62);
            this.forceTestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.forceTestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.forceTestBtn.Name = "forceTestBtn";
            this.forceTestBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.forceTestBtn.Size = new System.Drawing.Size(178, 54);
            this.forceTestBtn.TabIndex = 69;
            this.forceTestBtn.Text = "Start Testing";
            this.forceTestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.forceTestBtn.UseAccentColor = true;
            this.forceTestBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(720, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(193, 29);
            this.materialLabel6.TabIndex = 68;
            this.materialLabel6.Text = "Switch Force Test";
            // 
            // endForceBox
            // 
            this.endForceBox.AllowPromptAsInput = true;
            this.endForceBox.AnimateReadOnly = false;
            this.endForceBox.AsciiOnly = false;
            this.endForceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.endForceBox.BeepOnError = false;
            this.endForceBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.endForceBox.Depth = 0;
            this.endForceBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endForceBox.HidePromptOnLeave = false;
            this.endForceBox.HideSelection = true;
            this.endForceBox.Hint = "End Force Spec";
            this.endForceBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.endForceBox.LeadingIcon = null;
            this.endForceBox.Location = new System.Drawing.Point(231, 68);
            this.endForceBox.Mask = "00gf";
            this.endForceBox.MaxLength = 32767;
            this.endForceBox.MouseState = MaterialSkin.MouseState.OUT;
            this.endForceBox.Name = "endForceBox";
            this.endForceBox.PasswordChar = '\0';
            this.endForceBox.PrefixSuffixText = null;
            this.endForceBox.PromptChar = '_';
            this.endForceBox.ReadOnly = false;
            this.endForceBox.RejectInputOnFirstFailure = false;
            this.endForceBox.ResetOnPrompt = true;
            this.endForceBox.ResetOnSpace = true;
            this.endForceBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endForceBox.SelectedText = "";
            this.endForceBox.SelectionLength = 0;
            this.endForceBox.SelectionStart = 0;
            this.endForceBox.ShortcutsEnabled = true;
            this.endForceBox.Size = new System.Drawing.Size(170, 48);
            this.endForceBox.SkipLiterals = true;
            this.endForceBox.TabIndex = 74;
            this.endForceBox.TabStop = false;
            this.endForceBox.Text = "  gf";
            this.endForceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.endForceBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.endForceBox.TrailingIcon = null;
            this.endForceBox.UseSystemPasswordChar = false;
            this.endForceBox.ValidatingType = null;
            // 
            // latencyCard
            // 
            this.latencyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.latencyCard.Controls.Add(this.latencyLabel);
            this.latencyCard.Controls.Add(this.latencyBtn);
            this.latencyCard.Controls.Add(this.materialLabel7);
            this.latencyCard.Depth = 0;
            this.latencyCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.latencyCard.Location = new System.Drawing.Point(17, 539);
            this.latencyCard.Margin = new System.Windows.Forms.Padding(14);
            this.latencyCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.latencyCard.Name = "latencyCard";
            this.latencyCard.Padding = new System.Windows.Forms.Padding(14);
            this.latencyCard.Size = new System.Drawing.Size(933, 137);
            this.latencyCard.TabIndex = 79;
            // 
            // latencyLabel
            // 
            this.latencyLabel.AutoSize = true;
            this.latencyLabel.Depth = 0;
            this.latencyLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.latencyLabel.Location = new System.Drawing.Point(36, 58);
            this.latencyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.latencyLabel.Name = "latencyLabel";
            this.latencyLabel.Size = new System.Drawing.Size(461, 19);
            this.latencyLabel.TabIndex = 73;
            this.latencyLabel.Text = "Position Tool Above Switch (not space or escape) Before Starting";
            // 
            // latencyBtn
            // 
            this.latencyBtn.AutoSize = false;
            this.latencyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.latencyBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.latencyBtn.Depth = 0;
            this.latencyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latencyBtn.HighEmphasis = true;
            this.latencyBtn.Icon = ((System.Drawing.Image)(resources.GetObject("latencyBtn.Icon")));
            this.latencyBtn.Location = new System.Drawing.Point(737, 62);
            this.latencyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.latencyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.latencyBtn.Name = "latencyBtn";
            this.latencyBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.latencyBtn.Size = new System.Drawing.Size(178, 54);
            this.latencyBtn.TabIndex = 69;
            this.latencyBtn.Text = "Start Testing";
            this.latencyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.latencyBtn.UseAccentColor = true;
            this.latencyBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(697, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(216, 29);
            this.materialLabel7.TabIndex = 68;
            this.materialLabel7.Text = "Switch Latency Test";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.textName1);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(17, 104);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(933, 77);
            this.materialCard5.TabIndex = 80;
            // 
            // textName1
            // 
            this.textName1.AnimateReadOnly = false;
            this.textName1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textName1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textName1.Depth = 0;
            this.textName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textName1.HideSelection = true;
            this.textName1.Hint = "Test Name - Switch, Device, etc";
            this.textName1.LeadingIcon = null;
            this.textName1.Location = new System.Drawing.Point(22, 13);
            this.textName1.MaxLength = 32767;
            this.textName1.MouseState = MaterialSkin.MouseState.OUT;
            this.textName1.Name = "textName1";
            this.textName1.PasswordChar = '\0';
            this.textName1.PrefixSuffixText = null;
            this.textName1.ReadOnly = false;
            this.textName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textName1.SelectedText = "";
            this.textName1.SelectionLength = 0;
            this.textName1.SelectionStart = 0;
            this.textName1.ShortcutsEnabled = true;
            this.textName1.Size = new System.Drawing.Size(891, 48);
            this.textName1.TabIndex = 3;
            this.textName1.TabStop = false;
            this.textName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textName1.TrailingIcon = null;
            this.textName1.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.testName2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 123);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(933, 77);
            this.materialCard2.TabIndex = 81;
            // 
            // testName2
            // 
            this.testName2.AnimateReadOnly = false;
            this.testName2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testName2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.testName2.Depth = 0;
            this.testName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.testName2.HideSelection = true;
            this.testName2.Hint = "Test Name - Device, Settings, etc";
            this.testName2.LeadingIcon = null;
            this.testName2.Location = new System.Drawing.Point(22, 13);
            this.testName2.MaxLength = 32767;
            this.testName2.MouseState = MaterialSkin.MouseState.OUT;
            this.testName2.Name = "testName2";
            this.testName2.PasswordChar = '\0';
            this.testName2.PrefixSuffixText = null;
            this.testName2.ReadOnly = false;
            this.testName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.testName2.SelectedText = "";
            this.testName2.SelectionLength = 0;
            this.testName2.SelectionStart = 0;
            this.testName2.ShortcutsEnabled = true;
            this.testName2.Size = new System.Drawing.Size(891, 48);
            this.testName2.TabIndex = 3;
            this.testName2.TabStop = false;
            this.testName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.testName2.TrailingIcon = null;
            this.testName2.UseSystemPasswordChar = false;
            // 
            // mouseSwitchCard
            // 
            this.mouseSwitchCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mouseSwitchCard.Controls.Add(this.mouseSwitchLabel);
            this.mouseSwitchCard.Controls.Add(this.materialButton4);
            this.mouseSwitchCard.Controls.Add(this.materialLabel5);
            this.mouseSwitchCard.Depth = 0;
            this.mouseSwitchCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mouseSwitchCard.Location = new System.Drawing.Point(17, 279);
            this.mouseSwitchCard.Margin = new System.Windows.Forms.Padding(14);
            this.mouseSwitchCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.mouseSwitchCard.Name = "mouseSwitchCard";
            this.mouseSwitchCard.Padding = new System.Windows.Forms.Padding(14);
            this.mouseSwitchCard.Size = new System.Drawing.Size(933, 137);
            this.mouseSwitchCard.TabIndex = 82;
            // 
            // mouseSwitchLabel
            // 
            this.mouseSwitchLabel.AutoSize = true;
            this.mouseSwitchLabel.Depth = 0;
            this.mouseSwitchLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mouseSwitchLabel.Location = new System.Drawing.Point(36, 62);
            this.mouseSwitchLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mouseSwitchLabel.Name = "mouseSwitchLabel";
            this.mouseSwitchLabel.Size = new System.Drawing.Size(323, 19);
            this.mouseSwitchLabel.TabIndex = 73;
            this.mouseSwitchLabel.Text = "Position Tool Above Left Click Before Starting";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton4.Icon")));
            this.materialButton4.Location = new System.Drawing.Point(737, 62);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(178, 54);
            this.materialButton4.TabIndex = 69;
            this.materialButton4.Text = "Start Testing";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = true;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.Location = new System.Drawing.Point(538, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(375, 29);
            this.materialLabel5.TabIndex = 68;
            this.materialLabel5.Text = "Switch Testing - Latency, Pre-travel";
            // 
            // sensorCard
            // 
            this.sensorCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sensorCard.Controls.Add(this.sensorLabel);
            this.sensorCard.Controls.Add(this.sensorDPIBox);
            this.sensorCard.Controls.Add(this.materialButton6);
            this.sensorCard.Controls.Add(this.materialLabel9);
            this.sensorCard.Depth = 0;
            this.sensorCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sensorCard.Location = new System.Drawing.Point(17, 483);
            this.sensorCard.Margin = new System.Windows.Forms.Padding(14);
            this.sensorCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.sensorCard.Name = "sensorCard";
            this.sensorCard.Padding = new System.Windows.Forms.Padding(14);
            this.sensorCard.Size = new System.Drawing.Size(933, 137);
            this.sensorCard.TabIndex = 83;
            // 
            // sensorLabel
            // 
            this.sensorLabel.AutoSize = true;
            this.sensorLabel.Depth = 0;
            this.sensorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sensorLabel.Location = new System.Drawing.Point(36, 36);
            this.sensorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sensorLabel.Name = "sensorLabel";
            this.sensorLabel.Size = new System.Drawing.Size(382, 19);
            this.sensorLabel.TabIndex = 73;
            this.sensorLabel.Text = "Position Tool At the Side of the Mouse Before Starting";
            // 
            // sensorDPIBox
            // 
            this.sensorDPIBox.AllowPromptAsInput = true;
            this.sensorDPIBox.AnimateReadOnly = false;
            this.sensorDPIBox.AsciiOnly = false;
            this.sensorDPIBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sensorDPIBox.BeepOnError = false;
            this.sensorDPIBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.sensorDPIBox.Depth = 0;
            this.sensorDPIBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorDPIBox.HidePromptOnLeave = false;
            this.sensorDPIBox.HideSelection = true;
            this.sensorDPIBox.Hint = "Current DPI";
            this.sensorDPIBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.sensorDPIBox.LeadingIcon = null;
            this.sensorDPIBox.Location = new System.Drawing.Point(33, 68);
            this.sensorDPIBox.Mask = "000000 dpi";
            this.sensorDPIBox.MaxLength = 32767;
            this.sensorDPIBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sensorDPIBox.Name = "sensorDPIBox";
            this.sensorDPIBox.PasswordChar = '\0';
            this.sensorDPIBox.PrefixSuffixText = null;
            this.sensorDPIBox.PromptChar = '_';
            this.sensorDPIBox.ReadOnly = false;
            this.sensorDPIBox.RejectInputOnFirstFailure = false;
            this.sensorDPIBox.ResetOnPrompt = true;
            this.sensorDPIBox.ResetOnSpace = true;
            this.sensorDPIBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sensorDPIBox.SelectedText = "";
            this.sensorDPIBox.SelectionLength = 0;
            this.sensorDPIBox.SelectionStart = 0;
            this.sensorDPIBox.ShortcutsEnabled = true;
            this.sensorDPIBox.Size = new System.Drawing.Size(170, 48);
            this.sensorDPIBox.SkipLiterals = true;
            this.sensorDPIBox.TabIndex = 71;
            this.sensorDPIBox.TabStop = false;
            this.sensorDPIBox.Text = "       dpi";
            this.sensorDPIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sensorDPIBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.sensorDPIBox.TrailingIcon = null;
            this.sensorDPIBox.UseSystemPasswordChar = false;
            this.sensorDPIBox.ValidatingType = null;
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSize = false;
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton6.Icon")));
            this.materialButton6.Location = new System.Drawing.Point(737, 62);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(178, 54);
            this.materialButton6.TabIndex = 69;
            this.materialButton6.Text = "Start Testing";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = true;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(539, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(374, 29);
            this.materialLabel9.TabIndex = 68;
            this.materialLabel9.Text = "Sensor Testing - Latency, Accuracy";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 819);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.deviceStatusPanel);
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
            this.clickTestBox.ResumeLayout(false);
            this.clickTestBox.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.actuationPointCard.ResumeLayout(false);
            this.actuationPointCard.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.KeyboardPage.ResumeLayout(false);
            this.MousePage.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.HelpPage.ResumeLayout(false);
            this.HelpPage.PerformLayout();
            this.forceCard.ResumeLayout(false);
            this.forceCard.PerformLayout();
            this.latencyCard.ResumeLayout(false);
            this.latencyCard.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.mouseSwitchCard.ResumeLayout(false);
            this.mouseSwitchCard.PerformLayout();
            this.sensorCard.ResumeLayout(false);
            this.sensorCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel deviceStatusPanel;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialLabel devStat;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard clickTestBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialButton resultsViewBtn;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard actuationPointCard;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton resultsFolderBtn;
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
        private MaterialMaskedTextBox actuationPointBox;
        private MaterialLabel actInstLabel;
        private MaterialButton actNextBtn;
        private MaterialCard forceCard;
        private MaterialMaskedTextBox endForceBox;
        private MaterialLabel forceInstLabel;
        private MaterialMaskedTextBox initialForceBox;
        private MaterialButton forceTestBtn;
        private MaterialLabel materialLabel6;
        private MaterialCard materialCard5;
        private MaterialTextBox2 textName1;
        private MaterialCard latencyCard;
        private MaterialLabel latencyLabel;
        private MaterialButton latencyBtn;
        private MaterialLabel materialLabel7;
        private MaterialCard mouseSwitchCard;
        private MaterialLabel mouseSwitchLabel;
        private MaterialButton materialButton4;
        private MaterialLabel materialLabel5;
        private MaterialCard materialCard2;
        private MaterialTextBox2 testName2;
        private MaterialCard sensorCard;
        private MaterialLabel sensorLabel;
        private MaterialMaskedTextBox sensorDPIBox;
        private MaterialButton materialButton6;
        private MaterialLabel materialLabel9;
    }
}

