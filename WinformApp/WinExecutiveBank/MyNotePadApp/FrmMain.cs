using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyNotePadApp
{
    public partial class Form1 : Form
    {
        private bool IsModify { get; set; }
        private string fileName = "noname.txt";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dlgSaveFile.Filter = dlgOpenFile.Filter = "Text file(*.txt)|*.txt|Log file(*.log)|*.log";
            this.Text = $"{fileName} - 내 메모장";
            IsModify = false;
        }
        private void txtMain_TextChanged(object sender, EventArgs e) 
        {
            IsModify = true;
        }

        private void MnuNewFile_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();

            txtMain.Text = "";
            IsModify = false;
            fileName = "noname.txt";
        }
        private void MnuOpenFile_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();
            dlgOpenFile.ShowDialog();
            fileName = dlgOpenFile.FileName;
            this.Text = $"{fileName} - 내 메모장";
            try
            {
                StreamReader sr = File.OpenText(fileName);
                txtMain.Text = sr.ReadToEnd();

                IsModify = false;
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MnuSaveFile_Click(object sender, EventArgs e)
        {
            if (fileName == "noname.txt")
            {
                dlgSaveFile.ShowDialog();
                fileName = dlgSaveFile.FileName;
            }

            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(txtMain.Text);

            IsModify = false;
            sw.Close();
        }

        private void MnuSaveAs_Click(object sender, EventArgs e)
        {
            dlgSaveFile.ShowDialog();
            fileName = dlgSaveFile.FileName;
           
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(txtMain.Text);

            IsModify = false;
            sw.Close();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();
            Close();
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
            }
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                IsModify = true;
            }
        }
        private void FileProcessBeforeClose()
        {
            if (IsModify == true)
            {
                DialogResult ans = MessageBox.Show("변경된 내용을 저장하겠습니까?",
                    "저장", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    if (fileName == "noname.txt") 
                    {
                        if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(dlgSaveFile.FileName);
                            sw.WriteLine(txtMain.Text);
                            sw.Close();
                        }
                    }
                
                
                    else // 파일 이름이 지정되어 있다면
                    {
                        StreamWriter sw = File.CreateText(fileName);
                        sw.WriteLine(txtMain.Text);
                        sw.Close();
                    }
                }
            }
        }

       
    }
}
