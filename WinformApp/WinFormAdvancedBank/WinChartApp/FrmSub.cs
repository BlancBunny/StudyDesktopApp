using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinChartApp
{
    public partial class FrmSub : Form
    {
        public FrmSub()
        {
            InitializeComponent();
        }

        private void FrmSub_Load(object sender, EventArgs e)
        {
            btnDrawSplit.Enabled = false;
            this.Text = "중간고사 성적2";

            chtScore.Titles.Add("중간고사 성적");
            chtScore.Series.Add("Series2");
            chtScore.Series["Series1"].LegendText = "수학";
            chtScore.Series["Series2"].LegendText = "영어";

            chtScore.ChartAreas.Add("ChartArea2");
            chtScore.Series["Series2"].ChartArea = "ChartArea2";

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                chtScore.Series[0].Points.Add(rand.Next(10, 100));
                chtScore.Series[1].Points.Add(rand.Next(10, 100));
            }
        }

        private void BtnDrawUnite_Click(object sender, EventArgs e)
        {
            chtScore.ChartAreas.RemoveAt(chtScore.ChartAreas.IndexOf("ChartArea2"));
            chtScore.Series["Series2"].ChartArea = "ChartArea1";

            btnDrawSplit.Enabled = true;
            btnDrawUnite.Enabled = false;
        }

        private void BtnDrawSplit_Click(object sender, EventArgs e)
        {
            chtScore.ChartAreas.Add("ChartArea2");
            chtScore.Series["Series2"].ChartArea = "ChartArea2";
            
            btnDrawSplit.Enabled = false;
            btnDrawUnite.Enabled = true;
        }
    }
}
