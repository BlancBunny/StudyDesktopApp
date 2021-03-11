using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.stretchToFit = true;
            button1.Location = new Point(
                ClientSize.Width - button1.Size.Width - 5,
                ClientSize.Height - button1.Size.Height - 5
                );
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 70);
            button1.Location = new Point(
                ClientSize.Width - button1.Size.Width - 5,
                ClientSize.Height - button1.Size.Height - 5
                );
        }
    }

    
}
