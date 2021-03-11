
namespace ColorChangeApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrRed = new System.Windows.Forms.HScrollBar();
            this.scrGreen = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.scrBlue = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.MaskedTextBox();
            this.txtGreen = new System.Windows.Forms.MaskedTextBox();
            this.txtBlue = new System.Windows.Forms.MaskedTextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Location = new System.Drawing.Point(40, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 160);
            this.panel1.TabIndex = 3;
            // 
            // scrRed
            // 
            this.scrRed.Location = new System.Drawing.Point(65, 219);
            this.scrRed.Name = "scrRed";
            this.scrRed.Size = new System.Drawing.Size(246, 21);
            this.scrRed.TabIndex = 4;
            this.scrRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrScroll);
            // 
            // scrGreen
            // 
            this.scrGreen.Location = new System.Drawing.Point(65, 253);
            this.scrGreen.Name = "scrGreen";
            this.scrGreen.Size = new System.Drawing.Size(246, 21);
            this.scrGreen.TabIndex = 7;
            this.scrGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrScroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // scrBlue
            // 
            this.scrBlue.Location = new System.Drawing.Point(65, 286);
            this.scrBlue.Name = "scrBlue";
            this.scrBlue.Size = new System.Drawing.Size(246, 21);
            this.scrBlue.TabIndex = 10;
            this.scrBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrScroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(336, 219);
            this.txtRed.Mask = "000";
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(41, 21);
            this.txtRed.TabIndex = 12;
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRed.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(336, 253);
            this.txtGreen.Mask = "000";
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(41, 21);
            this.txtGreen.TabIndex = 13;
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGreen.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(336, 286);
            this.txtBlue.Mask = "000";
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(41, 21);
            this.txtBlue.TabIndex = 14;
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBlue.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(361, 22);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 15;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(361, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(448, 356);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.scrBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scrGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scrRed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar scrRed;
        private System.Windows.Forms.HScrollBar scrGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scrBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRed;
        private System.Windows.Forms.MaskedTextBox txtGreen;
        private System.Windows.Forms.MaskedTextBox txtBlue;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

