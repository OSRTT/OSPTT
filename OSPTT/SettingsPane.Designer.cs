
namespace OSPTT
{
    partial class SettingsPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.calibBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.boardIDBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.comparePointsLimit = new MaterialSkin.Controls.MaterialSlider();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.autoScreenshotSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.graphViewSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.axisColourSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.yAxisSlider = new MaterialSkin.Controls.MaterialSlider();
            this.materialCard10.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.calibBox);
            this.materialCard10.Controls.Add(this.boardIDBox);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(14, 498);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(924, 78);
            this.materialCard10.TabIndex = 20;
            // 
            // calibBox
            // 
            this.calibBox.AllowPromptAsInput = true;
            this.calibBox.AnimateReadOnly = false;
            this.calibBox.AsciiOnly = false;
            this.calibBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calibBox.BeepOnError = false;
            this.calibBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.calibBox.Depth = 0;
            this.calibBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.calibBox.HelperText = "Board ID";
            this.calibBox.HidePromptOnLeave = false;
            this.calibBox.HideSelection = true;
            this.calibBox.Hint = "CAL";
            this.calibBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.calibBox.LeadingIcon = null;
            this.calibBox.Location = new System.Drawing.Point(469, 13);
            this.calibBox.Mask = "000-000-000";
            this.calibBox.MaxLength = 32767;
            this.calibBox.MouseState = MaterialSkin.MouseState.OUT;
            this.calibBox.Name = "calibBox";
            this.calibBox.PasswordChar = '\0';
            this.calibBox.PrefixSuffixText = null;
            this.calibBox.PromptChar = '_';
            this.calibBox.ReadOnly = false;
            this.calibBox.RejectInputOnFirstFailure = false;
            this.calibBox.ResetOnPrompt = true;
            this.calibBox.ResetOnSpace = true;
            this.calibBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calibBox.SelectedText = "";
            this.calibBox.SelectionLength = 0;
            this.calibBox.SelectionStart = 0;
            this.calibBox.ShortcutsEnabled = true;
            this.calibBox.Size = new System.Drawing.Size(427, 48);
            this.calibBox.SkipLiterals = true;
            this.calibBox.TabIndex = 1;
            this.calibBox.TabStop = false;
            this.calibBox.Text = "   -   -";
            this.calibBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.calibBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.calibBox.TrailingIcon = null;
            this.calibBox.UseSystemPasswordChar = false;
            this.calibBox.ValidatingType = null;
            this.calibBox.TextChanged += new System.EventHandler(this.calibBox_TextChanged);
            // 
            // boardIDBox
            // 
            this.boardIDBox.AllowPromptAsInput = true;
            this.boardIDBox.AnimateReadOnly = false;
            this.boardIDBox.AsciiOnly = false;
            this.boardIDBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boardIDBox.BeepOnError = false;
            this.boardIDBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.boardIDBox.Depth = 0;
            this.boardIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boardIDBox.HelperText = "Board ID";
            this.boardIDBox.HidePromptOnLeave = false;
            this.boardIDBox.HideSelection = true;
            this.boardIDBox.Hint = "Board ID";
            this.boardIDBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.boardIDBox.LeadingIcon = null;
            this.boardIDBox.Location = new System.Drawing.Point(17, 13);
            this.boardIDBox.Mask = "OSPTT-0000";
            this.boardIDBox.MaxLength = 32767;
            this.boardIDBox.MouseState = MaterialSkin.MouseState.OUT;
            this.boardIDBox.Name = "boardIDBox";
            this.boardIDBox.PasswordChar = '\0';
            this.boardIDBox.PrefixSuffixText = null;
            this.boardIDBox.PromptChar = '_';
            this.boardIDBox.ReadOnly = false;
            this.boardIDBox.RejectInputOnFirstFailure = false;
            this.boardIDBox.ResetOnPrompt = true;
            this.boardIDBox.ResetOnSpace = true;
            this.boardIDBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boardIDBox.SelectedText = "";
            this.boardIDBox.SelectionLength = 0;
            this.boardIDBox.SelectionStart = 0;
            this.boardIDBox.ShortcutsEnabled = true;
            this.boardIDBox.Size = new System.Drawing.Size(402, 48);
            this.boardIDBox.SkipLiterals = true;
            this.boardIDBox.TabIndex = 0;
            this.boardIDBox.TabStop = false;
            this.boardIDBox.Text = "OSPTT-";
            this.boardIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boardIDBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.boardIDBox.TrailingIcon = null;
            this.boardIDBox.UseSystemPasswordChar = false;
            this.boardIDBox.ValidatingType = null;
            this.boardIDBox.TextChanged += new System.EventHandler(this.boardIDBox_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.comparePointsLimit);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 400);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(924, 78);
            this.materialCard1.TabIndex = 19;
            // 
            // comparePointsLimit
            // 
            this.comparePointsLimit.Depth = 0;
            this.comparePointsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comparePointsLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comparePointsLimit.Location = new System.Drawing.Point(23, 19);
            this.comparePointsLimit.MouseState = MaterialSkin.MouseState.HOVER;
            this.comparePointsLimit.Name = "comparePointsLimit";
            this.comparePointsLimit.RangeMax = 500;
            this.comparePointsLimit.Size = new System.Drawing.Size(874, 40);
            this.comparePointsLimit.TabIndex = 2;
            this.comparePointsLimit.Text = "Comparison Scatter Points Limit";
            this.comparePointsLimit.UseAccentColor = true;
            this.comparePointsLimit.Value = 500;
            this.comparePointsLimit.ValueMax = 500;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel1);
            this.materialCard6.Controls.Add(this.autoScreenshotSelect);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 109);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(923, 81);
            this.materialCard6.TabIndex = 18;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(18, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(237, 29);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Auto Save Screenshot";
            // 
            // autoScreenshotSelect
            // 
            this.autoScreenshotSelect.AutoResize = false;
            this.autoScreenshotSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoScreenshotSelect.Depth = 0;
            this.autoScreenshotSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.autoScreenshotSelect.DropDownHeight = 174;
            this.autoScreenshotSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoScreenshotSelect.DropDownWidth = 121;
            this.autoScreenshotSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.autoScreenshotSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.autoScreenshotSelect.FormattingEnabled = true;
            this.autoScreenshotSelect.IntegralHeight = false;
            this.autoScreenshotSelect.ItemHeight = 43;
            this.autoScreenshotSelect.Location = new System.Drawing.Point(469, 15);
            this.autoScreenshotSelect.MaxDropDownItems = 4;
            this.autoScreenshotSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.autoScreenshotSelect.Name = "autoScreenshotSelect";
            this.autoScreenshotSelect.Size = new System.Drawing.Size(427, 49);
            this.autoScreenshotSelect.StartIndex = 0;
            this.autoScreenshotSelect.TabIndex = 3;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialLabel8);
            this.materialCard7.Controls.Add(this.graphViewSelect);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 14);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(923, 81);
            this.materialCard7.TabIndex = 17;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.Location = new System.Drawing.Point(18, 26);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(205, 29);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Default Graph View";
            // 
            // graphViewSelect
            // 
            this.graphViewSelect.AutoResize = false;
            this.graphViewSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.graphViewSelect.Depth = 0;
            this.graphViewSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.graphViewSelect.DropDownHeight = 174;
            this.graphViewSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphViewSelect.DropDownWidth = 121;
            this.graphViewSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.graphViewSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.graphViewSelect.FormattingEnabled = true;
            this.graphViewSelect.IntegralHeight = false;
            this.graphViewSelect.ItemHeight = 43;
            this.graphViewSelect.Location = new System.Drawing.Point(469, 17);
            this.graphViewSelect.MaxDropDownItems = 4;
            this.graphViewSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.graphViewSelect.Name = "graphViewSelect";
            this.graphViewSelect.Size = new System.Drawing.Size(427, 49);
            this.graphViewSelect.StartIndex = 0;
            this.graphViewSelect.TabIndex = 3;
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.materialLabel10);
            this.materialCard8.Controls.Add(this.axisColourSelect);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(14, 206);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(923, 81);
            this.materialCard8.TabIndex = 16;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(18, 26);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(189, 29);
            this.materialLabel10.TabIndex = 4;
            this.materialLabel10.Text = "Chart Text Colour";
            // 
            // axisColourSelect
            // 
            this.axisColourSelect.AutoResize = false;
            this.axisColourSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.axisColourSelect.Depth = 0;
            this.axisColourSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.axisColourSelect.DropDownHeight = 174;
            this.axisColourSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axisColourSelect.DropDownWidth = 121;
            this.axisColourSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.axisColourSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.axisColourSelect.FormattingEnabled = true;
            this.axisColourSelect.IntegralHeight = false;
            this.axisColourSelect.ItemHeight = 43;
            this.axisColourSelect.Location = new System.Drawing.Point(469, 15);
            this.axisColourSelect.MaxDropDownItems = 4;
            this.axisColourSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.axisColourSelect.Name = "axisColourSelect";
            this.axisColourSelect.Size = new System.Drawing.Size(427, 49);
            this.axisColourSelect.StartIndex = 0;
            this.axisColourSelect.TabIndex = 3;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.yAxisSlider);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(13, 304);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(924, 78);
            this.materialCard9.TabIndex = 15;
            // 
            // yAxisSlider
            // 
            this.yAxisSlider.Depth = 0;
            this.yAxisSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yAxisSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yAxisSlider.Location = new System.Drawing.Point(23, 19);
            this.yAxisSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.yAxisSlider.Name = "yAxisSlider";
            this.yAxisSlider.Size = new System.Drawing.Size(874, 40);
            this.yAxisSlider.TabIndex = 2;
            this.yAxisSlider.Text = "RAW PNG Y Axis Maximum";
            this.yAxisSlider.UseAccentColor = true;
            this.yAxisSlider.Value = 30;
            this.yAxisSlider.ValueMax = 100;
            // 
            // SettingsPane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard10);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard6);
            this.Controls.Add(this.materialCard7);
            this.Controls.Add(this.materialCard8);
            this.Controls.Add(this.materialCard9);
            this.Name = "SettingsPane";
            this.Size = new System.Drawing.Size(950, 695);
            this.materialCard10.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.materialCard9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialMaskedTextBox calibBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox boardIDBox;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSlider comparePointsLimit;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox autoScreenshotSelect;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox graphViewSelect;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox axisColourSelect;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialSlider yAxisSlider;
    }
}
