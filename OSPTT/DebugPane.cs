using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSPTT
{
    public partial class DebugPane : UserControl
    {
        private Thread debugThread;
        public List<string> debugList = new List<string>();
        public DebugPane()
        {
            InitializeComponent();
            /*isolateLabel.Visible = false;
            preTestToggle.Checked = false;
            preTestToggle.Enabled = false;
            preTestToggle.Visible = false;*/
            
        }

        
        public Main mainWindow;

        private void helpBtn_Click(object sender, EventArgs e)
        {
            CFuncs.HyperlinkOut("https://OSRTT.github.io/OSPTTDocs/");
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
        private void debugBtn_Click(object sender, EventArgs e)
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
    }
}
