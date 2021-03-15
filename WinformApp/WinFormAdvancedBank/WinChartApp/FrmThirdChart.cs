using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinChartApp
{
    public partial class FrmThirdChart : Form
    {
        public FrmThirdChart()
        {
            InitializeComponent();
        }

        private void FrmThirdChart_Load(object sender, EventArgs e)
        {
            this.Text = "Graph Chart";
        }

        private void FrmThirdChart_Paint(object sender, PaintEventArgs e)
        {
            chtGraph.ChartAreas[0].BackColor = Color.Black;

            // X축
            chtGraph.ChartAreas[0].AxisX.Minimum = -20;
            chtGraph.ChartAreas[0].AxisX.Maximum = 20;
            chtGraph.ChartAreas[0].AxisX.Interval = 2;
            chtGraph.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chtGraph.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            // Y축
            chtGraph.ChartAreas[0].AxisY.Minimum = -2;
            chtGraph.ChartAreas[0].AxisY.Maximum = 2;
            chtGraph.ChartAreas[0].AxisY.Interval = 0.5;
            chtGraph.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chtGraph.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            // Series
            chtGraph.Series[0].ChartType = SeriesChartType.Line;
            chtGraph.Series[0].Color = Color.LightGreen;
            chtGraph.Series[0].BorderWidth = 2;
            chtGraph.Series[0].LegendText = "sin(x)/x";

            if (chtGraph.Series.Count == 1)
            {
                chtGraph.Series.Add("Cos");
                chtGraph.Series["Cos"].ChartType = SeriesChartType.Line;
                chtGraph.Series["Cos"].Color = Color.Orange;
                chtGraph.Series["Cos"].BorderWidth = 2;
                chtGraph.Series["Cos"].LegendText = "cos(x)/x";
            }

            for (double x = -20; x < 20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chtGraph.Series[0].Points.AddXY(x, y);
                y = Math.Cos(x) / x;
                chtGraph.Series[1].Points.AddXY(x, y);
            }



        }
    }
}
