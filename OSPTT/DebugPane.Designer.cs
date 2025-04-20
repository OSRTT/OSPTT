
namespace OSPTT
{
    partial class DebugPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugPane));
            this.clearDebugBtn = new MaterialSkin.Controls.MaterialButton();
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.SuspendLayout();
            // 
            // clearDebugBtn
            // 
            this.clearDebugBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearDebugBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearDebugBtn.Depth = 0;
            this.clearDebugBtn.HighEmphasis = true;
            this.clearDebugBtn.Icon = global::OSPTT.Properties.Resources.arrow_rotate_right;
            this.clearDebugBtn.Location = new System.Drawing.Point(770, 115);
            this.clearDebugBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearDebugBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearDebugBtn.Name = "clearDebugBtn";
            this.clearDebugBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearDebugBtn.Size = new System.Drawing.Size(126, 36);
            this.clearDebugBtn.TabIndex = 68;
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
            this.helpBtn.Location = new System.Drawing.Point(810, 19);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.helpBtn.Size = new System.Drawing.Size(86, 36);
            this.helpBtn.TabIndex = 65;
            this.helpBtn.Text = "Help";
            this.helpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpBtn.UseAccentColor = false;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // debugBtn
            // 
            this.debugBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debugBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.debugBtn.Depth = 0;
            this.debugBtn.HighEmphasis = true;
            this.debugBtn.Icon = ((System.Drawing.Image)(resources.GetObject("debugBtn.Icon")));
            this.debugBtn.Location = new System.Drawing.Point(706, 67);
            this.debugBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.debugBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.debugBtn.Size = new System.Drawing.Size(190, 36);
            this.debugBtn.TabIndex = 66;
            this.debugBtn.Text = "Enable Debugging";
            this.debugBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.debugBtn.UseAccentColor = false;
            this.debugBtn.UseVisualStyleBackColor = true;
            this.debugBtn.Click += new System.EventHandler(this.debugBtn_Click);
            // 
            // debugBox
            // 
            this.debugBox.AnimateReadOnly = true;
            this.debugBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debugBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.debugBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.debugBox.Depth = 0;
            this.debugBox.HideSelection = true;
            this.debugBox.Location = new System.Drawing.Point(3, 3);
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
            this.debugBox.Size = new System.Drawing.Size(937, 721);
            this.debugBox.TabIndex = 67;
            this.debugBox.TabStop = false;
            this.debugBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.debugBox.UseSystemPasswordChar = false;
            // 
            // DebugPane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.clearDebugBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.debugBtn);
            this.Controls.Add(this.debugBox);
            this.Name = "DebugPane";
            this.Size = new System.Drawing.Size(954, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton clearDebugBtn;
        private MaterialSkin.Controls.MaterialButton helpBtn;
        private MaterialSkin.Controls.MaterialButton debugBtn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 debugBox;
    }
}
