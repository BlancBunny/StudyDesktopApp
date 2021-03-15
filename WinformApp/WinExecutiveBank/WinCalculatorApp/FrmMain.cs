using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculatorApp
{
    public partial class FrmMain : Form
    {
        
        private double saved; // txtResult 에 있는 값 저장
        private double Memory { get; set; } // 메모리에 저장된 값
        public bool MemFlag { get; set; }
        public bool PercentFlag { get; set; }
        public bool OpFlag { get; set; }
        private char Op { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            txtExpression.Text = txtResult.Text = "";
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains(".")) return;
            else txtResult.Text += ".";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;
            if (txtResult.Text == "0" || OpFlag == true || MemFlag == true)
            {
                txtResult.Text = s;
                OpFlag = false;
                MemFlag = false;
            }
            else txtResult.Text += s;
            
        }
        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            saved = Double.Parse(txtResult.Text);
            txtExpression.Text += $"{txtResult.Text} {btn.Text} ";
            Op = btn.Text[0]; // (+)\0
            OpFlag = true;
            PercentFlag = true; 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double value = Double.Parse(txtResult.Text);
            switch(Op)
            {
                case '+':
                    txtResult.Text = (saved + value).ToString();
                    break;
                case '-':
                    txtResult.Text = (saved - value).ToString();
                    break;
                case '×':
                    txtResult.Text = (saved * value).ToString();
                    break;
                case '÷':
                    txtResult.Text = (saved / value).ToString();
                    break;
            }
            txtResult.Text = GroupSeparator(txtResult.Text);
            txtExpression.Text = "";
        }
        private string GroupSeparator(string s)
        {
            int pos = 0;
            double v = Double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                if (pos == 1) return s; // 맨 뒤에 소수점이 있으면 그대로 리턴
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else s = string.Format("{0:N0}", v);
            return s;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtExpression.Text = "";
            saved = 0;
            Op = '\0';
            OpFlag = false;
            PercentFlag = false;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            Memory = 0;
            btnMR.Enabled = btnMC.Enabled = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtResult.Text = Memory.ToString();

        }
    }
}
