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
    public partial class LatencyControl : UserControl
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
        public LatencyControl()
        {
            InitializeComponent();
            
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
        public void drawCompareScatter()
        {
            if (resultsList.Count > 1 && resultsList.Count <= colors.Count)
            {
                setupGridView(resultsTable, true);
                resultType t = resultsList[0].inputLagResults[0].Type;
                graphedData.Plot.Clear();
                graphedData.Plot.Legend(true);
                for (int i = 0; i < resultsList.Count; i++)
                {
                    // Check results type match, ie light to light, clicks to clicks
                    if (t == resultsList[i].inputLagResults[0].Type)
                    {
                        // add to scatter
                        List<double[]> plotData = CreateGraphArrays(resultsList[i], type);
                        var plt = graphedData.Plot.AddScatter(plotData[0], plotData[1], null, 3, 10);
                        var plottables = graphedData.Plot.GetPlottables();
                        //graphedData.Plot.Remove(plottables[1]);
                        // add legend
                        plt.Label = CleanRunName(resultsList[i].RunName);
                    }
                    string[] row = new string[] {
                        CleanRunName(resultsList[i].RunName),
                        Math.Round(resultsList[i].totalInputLag.AVG, 2).ToString() + "ms"
                    };
                    resultsTable.Rows.Add(row);
                }
                graphedData.Refresh();
            }
            else
            {
                if (resultsList[0].inputLagResults.Count == 0)
                {
                    CFuncs.showMessageBox("Error", "Unable to compare, please import a file first.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (resultsList.Count > colors.Count)
                {
                    CFuncs.showMessageBox("Error", "Unable to compare that many files. Please import fewer files. Existing imports have been cleared.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultsList.Clear();
                }
            }
        }
        public void drawScatterGraph(bool avgLine = true)
        {
            graphedData.Plot.Clear();
            graphedData.Plot.ResetLayout();
            double averageLine = resultsList[0].onDisplayLatency.AVG;
            if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardForce)
            {
                this.Text = "On Display Latency" + RunName;
                type = 2;
            }
            else if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardForce)
            {
                this.Text = "Click Latency" + RunName;
                type = 3;
                averageLine = Math.Round(resultsList[0].totalInputLag.AVG, 2);
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

            if (avgLine)
            {
                graphedData.Plot.AddHorizontalLine(averageLine, Color.DarkGreen, 5);


            }
            else
            {
                graphedData.Plot.Frameless();
                graphedData.Plot.SetAxisLimitsY(0, (double)Properties.Settings.Default.yMax);
            }

            graphedData.Plot.Render();
            graphedData.Plot.RenderLegend();
            graphedData.Render();
            graphedData.Refresh();
        }
        public void drawBarGraph()
        {
            this.Text = "Latency Results" + RunName;
            barPlot.Plot.Clear();
            double[][] values = new double[3][];
            string[] titles = { "USB Polling Delay", "Render Time", "On Display Lag", "Total Input Lag" };
            string[] labels = { "AVG", "MIN", "MAX" };
            if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardActuation)
            {
                values[0] = new double[4];
                values[1] = new double[4];
                values[2] = new double[4];
                values[0][0] = Math.Round(resultsList[0].ClickTime.AVG, 2);
                values[1][0] = Math.Round(resultsList[0].ClickTime.MIN, 2);
                values[2][0] = Math.Round(resultsList[0].ClickTime.MAX, 2);
                values[0][1] = Math.Round(resultsList[0].FrameTime.AVG, 2);
                values[1][1] = Math.Round(resultsList[0].FrameTime.MIN, 2);
                values[2][1] = Math.Round(resultsList[0].FrameTime.MAX, 2);
                values[0][2] = Math.Round(resultsList[0].onDisplayLatency.AVG, 2);
                values[1][2] = Math.Round(resultsList[0].onDisplayLatency.MIN, 2);
                values[2][2] = Math.Round(resultsList[0].onDisplayLatency.MAX, 2);
                values[0][3] = Math.Round(resultsList[0].totalInputLag.AVG, 2);
                values[1][3] = Math.Round(resultsList[0].totalInputLag.MIN, 2);
                values[2][3] = Math.Round(resultsList[0].totalInputLag.MAX, 2);
            }
            else if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardForce)
            {
                titles = new[] { "USB Polling Delay", "Audio Latency", "Total Latency" };
                values[0] = new double[3];
                values[1] = new double[3];
                values[2] = new double[3];
                values[0][0] = Math.Round(resultsList[0].ClickTime.AVG, 2);
                values[1][0] = Math.Round(resultsList[0].ClickTime.MIN, 2);
                values[2][0] = Math.Round(resultsList[0].ClickTime.MAX, 2);
                values[0][1] = Math.Round(resultsList[0].onDisplayLatency.AVG, 2);
                values[1][1] = Math.Round(resultsList[0].onDisplayLatency.MIN, 2);
                values[2][1] = Math.Round(resultsList[0].onDisplayLatency.MAX, 2);
                values[0][2] = Math.Round(resultsList[0].totalInputLag.AVG, 2);
                values[1][2] = Math.Round(resultsList[0].totalInputLag.MIN, 2);
                values[2][2] = Math.Round(resultsList[0].totalInputLag.MAX, 2);
            }
            else
            {
                titles = new[] { "Total Latency" };
                values[0] = new double[1];
                values[1] = new double[1];
                values[2] = new double[1];
                values[0][0] = Math.Round(resultsList[0].totalInputLag.AVG, 2);
                values[1][0] = Math.Round(resultsList[0].totalInputLag.MIN, 2);
                values[2][0] = Math.Round(resultsList[0].totalInputLag.MAX, 2);
            }
            Console.WriteLine(Properties.Settings.Default.chartTextColour);
            barPlot.Plot.Style(figureBackground: Color.Transparent, dataBackground: SystemColors.ControlDark);

            barPlot.Plot.AddBarGroups(titles, labels, values, null);
            barPlot.Plot.Legend(location: ScottPlot.Alignment.UpperLeft);
            barPlot.Plot.XAxis.Grid(false);
            barPlot.Plot.XAxis.TickLabelStyle(Properties.Settings.Default.chartTextColour, "Calibri", 24, true);
            barPlot.Plot.YAxis.TickLabelStyle(Properties.Settings.Default.chartTextColour, "Calibri", 20, false);
            barPlot.Plot.SetAxisLimitsY(0, resultsList[0].totalInputLag.MAX * 1.1);

            //barPlot.Plot.XAxis.Color(Color.White);
            //barPlot.Plot.YAxis.Color(Color.White);

            var bar = barPlot.Plot.GetPlottables();
            foreach (ScottPlot.Plottable.BarPlot b in bar)
            {
                b.ShowValuesAboveBars = true;
                b.Font.Bold = true;
                b.Font.Size = 22;
                b.Font.Color = Properties.Settings.Default.chartTextColour;
            }

            barPlot.Plot.Render();
            barPlot.Refresh();
            //string[] existingFiles = Directory.GetFiles(resultsFolderPath, "*.png");
            /*if (existingFiles.Length == 0 && Properties.Settings.Default.autoSavePNG != 0)
            {
                if (Properties.Settings.Default.autoSavePNG == 1)
                {
                    savePNGBtn_Click(null, null);
                }
                else
                {
                    saveWhitePNGBtn_Click(null, null);
                }
            }*/
            barPlot.Refresh();
        }

        public void DrawCompareBarChart()
        {
            if (resultsList.Count > 1 && resultsList[0].inputLagResults != null)
            {
                barPlot.Plot.Clear();
                double[][] values = new double[3][];
                string[] titles = new string[resultsList.Count];
                string[] labels = { "AVG", "MIN", "MAX" };
                values[0] = new double[resultsList.Count];
                values[1] = new double[resultsList.Count];
                values[2] = new double[resultsList.Count];
                for (int i = 0; i < resultsList.Count; i++)
                {
                    titles[i] = CleanRunName(resultsList[i].RunName);
                    if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardForce)
                    {
                        values[0][i] = Math.Round(resultsList[0].onDisplayLatency.AVG, 2);
                        values[1][i] = Math.Round(resultsList[0].onDisplayLatency.MIN, 2);
                        values[1][i] = Math.Round(resultsList[0].onDisplayLatency.MAX, 2);

                    }
                    else if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardLatency)
                    {
                        values[0][i] = Math.Round(resultsList[0].totalInputLag.AVG, 2);
                        values[1][i] = Math.Round(resultsList[0].totalInputLag.MIN, 2);
                        values[2][i] = Math.Round(resultsList[0].totalInputLag.MAX, 2);
                    }
                    else if (resultsList[0].inputLagResults[0].Type == resultType.KeyboardLatency)
                    {
                        values[0][i] = Math.Round(resultsList[0].onDisplayLatency.AVG, 2);
                        values[1][i] = Math.Round(resultsList[0].onDisplayLatency.MIN, 2);
                        values[2][i] = Math.Round(resultsList[0].onDisplayLatency.MAX, 2);
                    }

                }

                barPlot.Plot.Style(figureBackground: Color.Transparent, dataBackground: SystemColors.ControlDark);

                barPlot.Plot.AddBarGroups(titles, labels, values, null);
                barPlot.Plot.Legend(location: ScottPlot.Alignment.UpperLeft);
                barPlot.Plot.XAxis.Grid(false);
                barPlot.Plot.XAxis.TickLabelStyle(Properties.Settings.Default.chartTextColour, "Calibri", 24, true);
                barPlot.Plot.YAxis.TickLabelStyle(Properties.Settings.Default.chartTextColour, "Calibri", 20, false);
                barPlot.Plot.SetAxisLimitsY(0, resultsList[0].totalInputLag.MAX * 1.1);

                //barPlot.Plot.XAxis.Color(Color.White);
                //barPlot.Plot.YAxis.Color(Color.White);

                var bar = barPlot.Plot.GetPlottables();
                foreach (ScottPlot.Plottable.BarPlot b in bar)
                {
                    b.ShowValuesAboveBars = true;
                    b.Font.Bold = true;
                    b.Font.Size = 22;
                    b.Font.Color = Properties.Settings.Default.chartTextColour;
                }

                barPlot.Plot.Render();
                barPlot.Refresh();
            }
            else // Can't compare with a single result
            {

            }
        }

        private void switchGraphTypeBtn_Click(object sender, EventArgs e)
        {
            ScatterOption = !ScatterOption;

            if (ScatterOption)
            {
                switchGraphTypeBtn.Text = "Switch to Averaged Results";
                barPlot.Visible = false;
                barPlot.Enabled = false;
                barPlot.SendToBack();
                graphedData.Visible = true;
                graphedData.Enabled = true;
                graphedData.BringToFront();
                //compareBtn.Visible = true;
                if (resultsList.Count > 1)
                {
                    drawCompareScatter();
                }
                else
                {
                    drawScatterGraph();
                }
            }
            else
            {
                switchGraphTypeBtn.Text = "Switch to Individual Results";
                graphedData.Visible = false;
                graphedData.Enabled = false;
                graphedData.SendToBack();
                barPlot.Visible = true;
                barPlot.Enabled = true;
                barPlot.BringToFront();
                //compareBtn.Visible = true;
                if (resultsList.Count > 1)
                {
                    DrawCompareBarChart();
                }
                else
                {
                    drawBarGraph();
                }
            }
        }

        private void savePNGBtn_Click(object sender, EventArgs e)
        {
            if (ScatterOption)
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-SCATTER");
                Color bnColor = BackColor;
                graphedData.Plot.Style(figureBackground: Color.Transparent, dataBackground: Color.Transparent);
                graphedData.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                graphedData.Plot.Style(figureBackground: bnColor, dataBackground: SystemColors.ControlDark);
                Process.Start("explorer.exe", resultsFolderPath);
            }
            else
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-CHART");
                Color bnColor = BackColor;
                barPlot.Plot.Style(figureBackground: Color.Transparent, dataBackground: Color.Transparent);
                barPlot.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                barPlot.Plot.Style(figureBackground: bnColor, dataBackground: SystemColors.ControlDark);
                Process.Start("explorer.exe", resultsFolderPath);
            }
        }

        private void saveWhitePNGBtn_Click(object sender, EventArgs e)
        {
            if (ScatterOption)
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-SCATTER");
                Color bnColor = BackColor;
                graphedData.Plot.Style(figureBackground: Color.White, dataBackground: Color.White);
                graphedData.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                graphedData.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            }
            else
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-CHART");
                Color bnColor = BackColor;
                barPlot.Plot.Style(figureBackground: Color.White, dataBackground: Color.White);
                barPlot.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                barPlot.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            }
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
