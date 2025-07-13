
namespace OSPTT
{
    partial class ForceControl
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
            this.graphedData = new ScottPlot.FormsPlot();
            this.controlsPanel = new MaterialSkin.Controls.MaterialCard();
            this.savePNGNoLineBtn = new MaterialSkin.Controls.MaterialButton();
            this.saveWhitePNGBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.savePNGBtn = new MaterialSkin.Controls.MaterialButton();
            this.resultsTable = new System.Windows.Forms.DataGridView();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // graphedData
            // 
            this.graphedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphedData.Location = new System.Drawing.Point(14, 73);
            this.graphedData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphedData.Name = "graphedData";
            this.graphedData.Size = new System.Drawing.Size(1184, 666);
            this.graphedData.TabIndex = 40;
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.controlsPanel.Controls.Add(this.savePNGNoLineBtn);
            this.controlsPanel.Controls.Add(this.saveWhitePNGBtn);
            this.controlsPanel.Controls.Add(this.materialLabel2);
            this.controlsPanel.Controls.Add(this.savePNGBtn);
            this.controlsPanel.Depth = 0;
            this.controlsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.controlsPanel.Location = new System.Drawing.Point(14, 14);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(14);
            this.controlsPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(14);
            this.controlsPanel.Size = new System.Drawing.Size(1184, 60);
            this.controlsPanel.TabIndex = 39;
            // 
            // savePNGNoLineBtn
            // 
            this.savePNGNoLineBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePNGNoLineBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.savePNGNoLineBtn.Depth = 0;
            this.savePNGNoLineBtn.HighEmphasis = true;
            this.savePNGNoLineBtn.Icon = null;
            this.savePNGNoLineBtn.Location = new System.Drawing.Point(782, 12);
            this.savePNGNoLineBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savePNGNoLineBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePNGNoLineBtn.Name = "savePNGNoLineBtn";
            this.savePNGNoLineBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.savePNGNoLineBtn.Size = new System.Drawing.Size(137, 36);
            this.savePNGNoLineBtn.TabIndex = 4;
            this.savePNGNoLineBtn.Text = "Save PNG (Raw)";
            this.savePNGNoLineBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.savePNGNoLineBtn.UseAccentColor = false;
            this.savePNGNoLineBtn.UseVisualStyleBackColor = true;
            // 
            // saveWhitePNGBtn
            // 
            this.saveWhitePNGBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveWhitePNGBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveWhitePNGBtn.Depth = 0;
            this.saveWhitePNGBtn.HighEmphasis = true;
            this.saveWhitePNGBtn.Icon = null;
            this.saveWhitePNGBtn.Location = new System.Drawing.Point(1026, 12);
            this.saveWhitePNGBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveWhitePNGBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveWhitePNGBtn.Name = "saveWhitePNGBtn";
            this.saveWhitePNGBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveWhitePNGBtn.Size = new System.Drawing.Size(140, 36);
            this.saveWhitePNGBtn.TabIndex = 2;
            this.saveWhitePNGBtn.Text = "Save White PNG";
            this.saveWhitePNGBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveWhitePNGBtn.UseAccentColor = false;
            this.saveWhitePNGBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(17, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 29);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Controls";
            // 
            // savePNGBtn
            // 
            this.savePNGBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePNGBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.savePNGBtn.Depth = 0;
            this.savePNGBtn.HighEmphasis = true;
            this.savePNGBtn.Icon = null;
            this.savePNGBtn.Location = new System.Drawing.Point(927, 12);
            this.savePNGBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savePNGBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePNGBtn.Name = "savePNGBtn";
            this.savePNGBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.savePNGBtn.Size = new System.Drawing.Size(91, 36);
            this.savePNGBtn.TabIndex = 0;
            this.savePNGBtn.Text = "Save PNG";
            this.savePNGBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.savePNGBtn.UseAccentColor = false;
            this.savePNGBtn.UseVisualStyleBackColor = true;
            // 
            // resultsTable
            // 
            this.resultsTable.AllowUserToAddRows = false;
            this.resultsTable.AllowUserToDeleteRows = false;
            this.resultsTable.AllowUserToResizeColumns = false;
            this.resultsTable.AllowUserToResizeRows = false;
            this.resultsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resultsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.resultsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTable.ColumnHeadersVisible = false;
            this.resultsTable.Location = new System.Drawing.Point(1205, 106);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowHeadersVisible = false;
            this.resultsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultsTable.Size = new System.Drawing.Size(299, 549);
            this.resultsTable.TabIndex = 41;
            // 
            // ForceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphedData);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.resultsTable);
            this.Name = "ForceControl";
            this.Size = new System.Drawing.Size(1519, 750);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot graphedData;
        private MaterialSkin.Controls.MaterialCard controlsPanel;
        private MaterialSkin.Controls.MaterialButton savePNGNoLineBtn;
        private MaterialSkin.Controls.MaterialButton saveWhitePNGBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton savePNGBtn;
        private System.Windows.Forms.DataGridView resultsTable;
    }
}
