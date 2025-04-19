using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSPTT
{
    // TODO  - write functions to fill the selects!!!!
    public partial class SettingsPane : UserControl
    {
        public SettingsPane()
        {
            InitializeComponent();
            
        }

        
        public Main mainWindow;

        public void setBoardInfo(int boardId, int cal)
        {
            boardIDBox.Invoke((MethodInvoker)(() => boardIDBox.Text = "OSPTT-" + boardId.ToString()));
            string calData = cal + "-" + cal + "-" + cal;
            calibBox.Invoke((MethodInvoker)(() => calibBox.Text = calData)); ;
        }

        private void boardIDBox_TextChanged(object sender, EventArgs e)
        {
            var ctrl = sender as BaseMaskedTextBox;
            if (ctrl.Focused)
            {
                if (!ctrl.Text.Any(Char.IsWhiteSpace) && ctrl.Text.Length == 10)
                {
                    if (!calibBox.Text.Any(Char.IsWhiteSpace) && calibBox.Text.Length == 11)
                    {
                        // save calib data 
                        // TODO
                    }
                    // Save board ID
                    if (Properties.Settings.Default.BoardId == null)
                    {
                        Properties.Settings.Default.BoardId = new BoardId { Id = int.Parse(ctrl.Text.Substring(6)) };
                    }
                    else
                    {
                        Properties.Settings.Default.BoardId.Id = int.Parse(ctrl.Text.Substring(6));
                    }
                }
            }
        }

        private void calibBox_TextChanged(object sender, EventArgs e)
        {
            var ctrl = sender as BaseMaskedTextBox;
            if (ctrl.Focused)
            {
                if (!ctrl.Text.Any(Char.IsWhiteSpace) && ctrl.Text.Length == 11)
                {
                    // Save calibration data for this board
                    if (Properties.Settings.Default.BoardId == null)
                    {
                        CFuncs.showMessageBox("Please enter the board ID to save the calibration data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        // process the 2/3 parts into a single number?
                        // TODO 
                        Properties.Settings.Default.BoardId.Calibration = 0;
                    }
                }
            }
        }
    }
}
