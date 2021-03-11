using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            
            scrRed.Maximum = 255 + 9;
            scrGreen.Maximum = 255 + 9;
            scrBlue.Maximum = 255 + 9;
        }

        private void ScrScroll(object sender, EventArgs e)
        {
            txtRed.Text = scrRed.Value.ToString();
            txtGreen.Text = scrGreen.Value.ToString();
            txtBlue.Text = scrBlue.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
        }
        
        private new void TextChanged(object sender, EventArgs e)
        {
            if(txtRed.Text != "" && txtGreen.Text != "" && txtBlue.Text != "")
            {
                scrRed.Value = int.Parse(txtRed.Text);
                scrGreen.Value = int.Parse(txtGreen.Text);
                scrBlue.Value = int.Parse(txtBlue.Text);
                panel1.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            scrRed.Value = colorDialog1.Color.R;
            scrGreen.Value = colorDialog1.Color.G;
            scrBlue.Value = colorDialog1.Color.B;
            txtRed.Text = scrRed.Value.ToString();
            txtGreen.Text = scrGreen.Value.ToString();
            txtBlue.Text = scrBlue.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
