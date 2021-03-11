
namespace RadioWinApp
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
            this.btnResult = new System.Windows.Forms.Button();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbOthers = new System.Windows.Forms.RadioButton();
            this.rdbJapan = new System.Windows.Forms.RadioButton();
            this.rdbChina = new System.Windows.Forms.RadioButton();
            this.rdbKorea = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(316, 189);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(114, 41);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(6, 20);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(47, 16);
            this.rdbMale.TabIndex = 5;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "남성";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(71, 20);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(47, 16);
            this.rdbFemale.TabIndex = 6;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "여성";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbOthers);
            this.groupBox1.Controls.Add(this.rdbJapan);
            this.groupBox1.Controls.Add(this.rdbChina);
            this.groupBox1.Controls.Add(this.rdbKorea);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국가";
            // 
            // rdbOthers
            // 
            this.rdbOthers.AutoSize = true;
            this.rdbOthers.Location = new System.Drawing.Point(6, 161);
            this.rdbOthers.Name = "rdbOthers";
            this.rdbOthers.Size = new System.Drawing.Size(79, 16);
            this.rdbOthers.TabIndex = 8;
            this.rdbOthers.TabStop = true;
            this.rdbOthers.Text = "그 외 국가";
            this.rdbOthers.UseVisualStyleBackColor = true;
            // 
            // rdbJapan
            // 
            this.rdbJapan.AutoSize = true;
            this.rdbJapan.Location = new System.Drawing.Point(6, 114);
            this.rdbJapan.Name = "rdbJapan";
            this.rdbJapan.Size = new System.Drawing.Size(47, 16);
            this.rdbJapan.TabIndex = 7;
            this.rdbJapan.TabStop = true;
            this.rdbJapan.Text = "일본";
            this.rdbJapan.UseVisualStyleBackColor = true;
            // 
            // rdbChina
            // 
            this.rdbChina.AutoSize = true;
            this.rdbChina.Location = new System.Drawing.Point(6, 67);
            this.rdbChina.Name = "rdbChina";
            this.rdbChina.Size = new System.Drawing.Size(47, 16);
            this.rdbChina.TabIndex = 6;
            this.rdbChina.TabStop = true;
            this.rdbChina.Text = "중국";
            this.rdbChina.UseVisualStyleBackColor = true;
            // 
            // rdbKorea
            // 
            this.rdbKorea.AutoSize = true;
            this.rdbKorea.Location = new System.Drawing.Point(6, 20);
            this.rdbKorea.Name = "rdbKorea";
            this.rdbKorea.Size = new System.Drawing.Size(71, 16);
            this.rdbKorea.TabIndex = 5;
            this.rdbKorea.TabStop = true;
            this.rdbKorea.Text = "대한민국";
            this.rdbKorea.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMale);
            this.groupBox2.Controls.Add(this.rdbFemale);
            this.groupBox2.Location = new System.Drawing.Point(209, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbOthers;
        private System.Windows.Forms.RadioButton rdbJapan;
        private System.Windows.Forms.RadioButton rdbChina;
        private System.Windows.Forms.RadioButton rdbKorea;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

