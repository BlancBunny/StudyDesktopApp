using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnuSelectImage_Click(object sender, EventArgs e)
        {
            dlgOpenImage.Filter = "jpg 파일(*.jpg)|*.jpg|png 파일(*.png)|*.png|모든 파일|*.*";
            dlgOpenImage.Title = "이미지 열기";
            dlgOpenImage.FileName = "";
            dlgOpenImage.ShowDialog();
            if (dlgOpenImage.FileName != "")
            {
                pictureBox1.Image = new Bitmap(dlgOpenImage.FileName);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void StretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AutosizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void CenterImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "이미지 뷰어";
            pictureBox1.BackColor = Color.White;

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
