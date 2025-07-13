using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OSPTT.ProcessData;

namespace OSPTT
{
    public partial class ForceControl : UserControl
    {
        public string resultsFolderPath = "";
        public string RunName = "";
        public string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
        public averagedInputLag inputLagResults { get; set; }
        public List<averagedInputLag> resultsList;
        public int type = 2;
        private bool ScatterOption = false;
        public List<Color> colors = new List<Color> {
            Color.SeaGreen,
            Color.MediumPurple,
            Color.Coral,
            Color.Crimson,
            Color.Turquoise,
            Color.Gold,
            Color.Violet,
            Color.Yellow,
            Color.YellowGreen,
            Color.SkyBlue,
            Color.DeepPink,
            Color.Chartreuse,
        };
        public ForceControl()
        {
            InitializeComponent();
            
        }

        public void setupGraphs()
        {
            fillResultsTable();
            drawScatterGraph();
        }

        private void fillResultsTable()
        {
            if (resultsList.Count == 0)
            {
                throw new Exception("No data provided");
            }
            setupGridView(resultsTable);
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < 6; i++)
            {
                string[] line = new string[2];
                data.Add(line);
            }
            data[0][0] = "AVG Total";
            data[0][1] = resultsList[0].totalInputLag.AVG.ToString() + "ms";

            data[1][0] = "Min Total";
            data[1][1] = resultsList[0].totalInputLag.MIN.ToString() + "ms";

            data[2][0] = "Max Total";
            data[2][1] = resultsList[0].totalInputLag.MAX.ToString() + "ms";

            data[3][0] = "AVG On Display";
            data[3][1] = resultsList[0].onDisplayLatency.AVG.ToString() + "ms";

            data[4][0] = "Min On Display";
            data[4][1] = resultsList[0].onDisplayLatency.MIN.ToString() + "ms";

            data[5][0] = "Max On Display";
            data[5][1] = resultsList[0].onDisplayLatency.MAX.ToString() + "ms";

            foreach (var item in data)
            {
                resultsTable.Rows.Add(item);
            }

            for (int l = 0; l < resultsTable.Rows.Count; l++)
            {
                resultsTable.Rows[l].Height += 30;
            }
        }

        private void setupGridView(DataGridView dgv, bool dataType = false)
        {
            float fontSize = 16;
            int c1Width = 190;
            int c2Width = 108;
            if (dataType)
            {
                fontSize = 16;
                c1Width = 198;
                c2Width = 100;
                dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            if (dgv.Columns.Count != 0)
            {
                dgv.Columns.Clear();
            }
            if (dgv.Rows.Count != 0)
            {
                dgv.Rows.Clear();
            }
            dgv.SelectionChanged += gridView_SelectionChanged;
            dgv.ColumnCount = 2;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Outset;
            dgv.RowsDefaultCellStyle.ForeColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 50, 50, 50);
            dgv.RowsDefaultCellStyle.Font = new Font("Calibri", fontSize, FontStyle.Bold);

            //dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);

            // rtGridView.RowHeadersDefaultCellStyle.Padding = new Padding(rtGridView.RowHeadersWidth / 2 );
            for (int k = 0; k < dgv.Columns.Count; k++)
            {
                if (k == 0)
                {
                    dgv.Columns[k].Width = c1Width;
                    //dgv.Columns[k].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv.Columns[k].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                }
                else
                {
                    dgv.Columns[k].Width = c2Width;
                    dgv.Columns[k].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                dgv.Columns[k].SortMode = DataGridViewColumnSortMode.NotSortable;
                if (dataType)
                {
                    //dgv.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv.Columns[k].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
        }
        private void gridView_SelectionChanged(Object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.ClearSelection();
            dgv.CurrentRow.Selected = false;
        }

        public List<double[]> CreateGraphArrays(averagedInputLag res, int type)
        {
            List<double[]> arrays = new List<double[]>();
            int arrSize = Math.Min(res.inputLagResults.Count, Properties.Settings.Default.comparePoints);
            double[] xs = new double[arrSize];
            double[] ys = new double[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                xs[i] = res.inputLagResults[i].shotNumber;
                if (type == 0)
                {
                    ys[i] = res.inputLagResults[i].clickTimeMs;
                }
                else if (type == 1)
                {
                    ys[i] = res.inputLagResults[i].frameTimeMs;
                }
                else if (type == 2)
                {
                    ys[i] = res.inputLagResults[i].onDisplayLatency;
                }
                else if (type == 3)
                {
                    ys[i] = res.inputLagResults[i].totalInputLag;

                }
            }

            arrays.Add(xs);
            arrays.Add(ys);

            return arrays;
        }

        public void drawScatterGraph(bool acutationPoints = true)
        {
            graphedData.Plot.Clear();
            graphedData.Plot.ResetLayout();
            
            if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardForce)
            {
                this.Text = "On Display Latency" + RunName;
                type = 2;
            }
            else if (resultsList[0].inputLagResults[0].Type == resultType.MouseClick)
            {
                this.Text = "Click Latency" + RunName;
                type = 3;
                
            }
            else
            {
                this.Text = "Audio Latency" + RunName;
                type = 2;
            }
            List<double[]> plotData = CreateGraphArrays(resultsList[0], type);
            graphedData.Plot.AddScatter(plotData[0], plotData[1], null, 3, 10);
            //graphedData.Plot.Title("");
            graphedData.Plot.Legend(false);
            graphedData.Plot.Style(figureBackground: Color.Transparent, dataBackground: SystemColors.ControlDark, grid: Color.LightGray);

            graphedData.Plot.XAxis.TickLabelStyle(Properties.Settings.Default.chartTextColour, "Calibri", 20, false);
            graphedData.Plot.YAxis.TickLabelStyle(Properties.Settings.Default.chartTextColour, "Calibri", 20, false);
            //graphedData.Plot.SetAxisLimitsY(0, inputLagResults.totalInputLag.MAX + 1);

            if (acutationPoints)
            {
                //graphedData.Plot.AddMarker();
            }

            graphedData.Plot.Render();
            graphedData.Plot.RenderLegend();
            graphedData.Render();
            graphedData.Refresh();
        }
        

        

        

        private void savePNGBtn_Click(object sender, EventArgs e)
        {
            
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-SCATTER");
                Color bnColor = BackColor;
                graphedData.Plot.Style(figureBackground: Color.Transparent, dataBackground: Color.Transparent);
                graphedData.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                graphedData.Plot.Style(figureBackground: bnColor, dataBackground: SystemColors.ControlDark);
                Process.Start("explorer.exe", resultsFolderPath);
            
        }

        private void saveWhitePNGBtn_Click(object sender, EventArgs e)
        {
            
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-SCATTER");
                Color bnColor = BackColor;
                graphedData.Plot.Style(figureBackground: Color.White, dataBackground: Color.White);
                graphedData.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                graphedData.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            
        }
        public string CleanRunName(string name)
        {
            try
            {
                string n = name.Replace("-", " ");
                n = n.Replace(".csv", "");
                n = n.Replace("CLICK ", "");
                n = n.Replace("LIGHT ", "");
                n = n.Replace("AUDIO ", "");
                n = n.Replace("PROCESSED ", "");
                n = n.Replace(" OSPTT", "");
                return n;
            }
            catch
            {
                return name;
            }
        }
        
    }
}
