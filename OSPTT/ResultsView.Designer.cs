
namespace OSPTT
{
    partial class ResultsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsView));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.importPage = new System.Windows.Forms.TabPage();
            this.importPanel = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.importBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.actuationPage = new System.Windows.Forms.TabPage();
            this.forcePage = new System.Windows.Forms.TabPage();
            this.latencyPage = new System.Windows.Forms.TabPage();
            this.latencyControl1 = new OSPTT.LatencyControl();
            this.sensorPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.compareCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.importCompareBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.importPage.SuspendLayout();
            this.importPanel.SuspendLayout();
            this.latencyPage.SuspendLayout();
            this.compareCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.importPage);
            this.materialTabControl1.Controls.Add(this.actuationPage);
            this.materialTabControl1.Controls.Add(this.forcePage);
            this.materialTabControl1.Controls.Add(this.latencyPage);
            this.materialTabControl1.Controls.Add(this.sensorPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1583, 793);
            this.materialTabControl1.TabIndex = 40;
            // 
            // importPage
            // 
            this.importPage.Controls.Add(this.compareCard);
            this.importPage.Controls.Add(this.importPanel);
            this.importPage.ImageKey = "folder-solid.png";
            this.importPage.Location = new System.Drawing.Point(4, 31);
            this.importPage.Name = "importPage";
            this.importPage.Padding = new System.Windows.Forms.Padding(3);
            this.importPage.Size = new System.Drawing.Size(1575, 758);
            this.importPage.TabIndex = 1;
            this.importPage.Text = "Import Data";
            this.importPage.UseVisualStyleBackColor = true;
            // 
            // importPanel
            // 
            this.importPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.importPanel.Controls.Add(this.materialLabel3);
            this.importPanel.Controls.Add(this.importBtn);
            this.importPanel.Controls.Add(this.materialLabel1);
            this.importPanel.Depth = 0;
            this.importPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importPanel.Location = new System.Drawing.Point(17, 29);
            this.importPanel.Margin = new System.Windows.Forms.Padding(14);
            this.importPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.importPanel.Name = "importPanel";
            this.importPanel.Padding = new System.Windows.Forms.Padding(14);
            this.importPanel.Size = new System.Drawing.Size(1488, 151);
            this.importPanel.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(18, 47);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(386, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Import raw or processed results with the button below. ";
            // 
            // importBtn
            // 
            this.importBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.importBtn.Depth = 0;
            this.importBtn.HighEmphasis = true;
            this.importBtn.Icon = null;
            this.importBtn.Location = new System.Drawing.Point(18, 84);
            this.importBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importBtn.Name = "importBtn";
            this.importBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.importBtn.Size = new System.Drawing.Size(177, 36);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import Existing File";
            this.importBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importBtn.UseAccentColor = false;
            this.importBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Import Files";
            // 
            // actuationPage
            // 
            this.actuationPage.ImageKey = "ruler-solid.png";
            this.actuationPage.Location = new System.Drawing.Point(4, 31);
            this.actuationPage.Name = "actuationPage";
            this.actuationPage.Size = new System.Drawing.Size(1575, 758);
            this.actuationPage.TabIndex = 2;
            this.actuationPage.Text = "Actuation";
            this.actuationPage.UseVisualStyleBackColor = true;
            // 
            // forcePage
            // 
            this.forcePage.ImageKey = "weight-hanging-solid.png";
            this.forcePage.Location = new System.Drawing.Point(4, 31);
            this.forcePage.Name = "forcePage";
            this.forcePage.Size = new System.Drawing.Size(1575, 758);
            this.forcePage.TabIndex = 3;
            this.forcePage.Text = "Force";
            this.forcePage.UseVisualStyleBackColor = true;
            // 
            // latencyPage
            // 
            this.latencyPage.Controls.Add(this.latencyControl1);
            this.latencyPage.ImageKey = "clock-solid.png";
            this.latencyPage.Location = new System.Drawing.Point(4, 31);
            this.latencyPage.Name = "latencyPage";
            this.latencyPage.Padding = new System.Windows.Forms.Padding(3);
            this.latencyPage.Size = new System.Drawing.Size(1575, 758);
            this.latencyPage.TabIndex = 0;
            this.latencyPage.Text = "Latency";
            this.latencyPage.UseVisualStyleBackColor = true;
            // 
            // latencyControl1
            // 
            this.latencyControl1.inputLagResults = null;
            this.latencyControl1.Location = new System.Drawing.Point(6, 6);
            this.latencyControl1.Name = "latencyControl1";
            this.latencyControl1.Size = new System.Drawing.Size(1519, 750);
            this.latencyControl1.TabIndex = 0;
            // 
            // sensorPage
            // 
            this.sensorPage.ImageKey = "arrow-pointer-solid.png";
            this.sensorPage.Location = new System.Drawing.Point(4, 31);
            this.sensorPage.Name = "sensorPage";
            this.sensorPage.Size = new System.Drawing.Size(1575, 758);
            this.sensorPage.TabIndex = 4;
            this.sensorPage.Text = "Sensor";
            this.sensorPage.UseVisualStyleBackColor = true;
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
            this.imageList1.Images.SetKeyName(18, "clock-solid.png");
            this.imageList1.Images.SetKeyName(19, "ruler-solid.png");
            this.imageList1.Images.SetKeyName(20, "weight-hanging-solid.png");
            this.imageList1.Images.SetKeyName(21, "arrow-pointer-solid.png");
            // 
            // compareCard
            // 
            this.compareCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.compareCard.Controls.Add(this.materialLabel2);
            this.compareCard.Controls.Add(this.importCompareBtn);
            this.compareCard.Controls.Add(this.materialLabel4);
            this.compareCard.Depth = 0;
            this.compareCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.compareCard.Location = new System.Drawing.Point(17, 219);
            this.compareCard.Margin = new System.Windows.Forms.Padding(14);
            this.compareCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.compareCard.Name = "compareCard";
            this.compareCard.Padding = new System.Windows.Forms.Padding(14);
            this.compareCard.Size = new System.Drawing.Size(1488, 151);
            this.compareCard.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel2.Location = new System.Drawing.Point(18, 47);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(567, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Import processed files of the same type to compare (i.e. multiple force test file" +
    "s).";
            // 
            // importCompareBtn
            // 
            this.importCompareBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importCompareBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.importCompareBtn.Depth = 0;
            this.importCompareBtn.HighEmphasis = true;
            this.importCompareBtn.Icon = null;
            this.importCompareBtn.Location = new System.Drawing.Point(18, 83);
            this.importCompareBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importCompareBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importCompareBtn.Name = "importCompareBtn";
            this.importCompareBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.importCompareBtn.Size = new System.Drawing.Size(117, 36);
            this.importCompareBtn.TabIndex = 2;
            this.importCompareBtn.Text = "Import Files";
            this.importCompareBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importCompareBtn.UseAccentColor = false;
            this.importCompareBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(17, 15);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(155, 29);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Compare Files";
            // 
            // ResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 864);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "ResultsView";
            this.Text = "Results View";
            this.materialTabControl1.ResumeLayout(false);
            this.importPage.ResumeLayout(false);
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.latencyPage.ResumeLayout(false);
            this.compareCard.ResumeLayout(false);
            this.compareCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage latencyPage;
        private System.Windows.Forms.TabPage importPage;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard importPanel;
        private MaterialSkin.Controls.MaterialButton importBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage actuationPage;
        private System.Windows.Forms.TabPage forcePage;
        private System.Windows.Forms.TabPage sensorPage;
        private LatencyControl latencyControl1;
        private MaterialSkin.Controls.MaterialCard compareCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton importCompareBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}