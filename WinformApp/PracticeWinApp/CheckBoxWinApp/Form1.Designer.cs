
namespace CheckBoxWinApp
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
            this.chkApple = new System.Windows.Forms.CheckBox();
            this.chkPear = new System.Windows.Forms.CheckBox();
            this.chkStrawberry = new System.Windows.Forms.CheckBox();
            this.chkBanana = new System.Windows.Forms.CheckBox();
            this.chkOrange = new System.Windows.Forms.CheckBox();
            this.chkGrape = new System.Windows.Forms.CheckBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "질문 : 좋아하는 과일을 모두 선택하세요.";
            // 
            // chkApple
            // 
            this.chkApple.AutoSize = true;
            this.chkApple.Location = new System.Drawing.Point(23, 60);
            this.chkApple.Name = "chkApple";
            this.chkApple.Size = new System.Drawing.Size(48, 16);
            this.chkApple.TabIndex = 1;
            this.chkApple.Text = "사과";
            this.chkApple.UseVisualStyleBackColor = true;
            // 
            // chkPear
            // 
            this.chkPear.AutoSize = true;
            this.chkPear.Location = new System.Drawing.Point(23, 82);
            this.chkPear.Name = "chkPear";
            this.chkPear.Size = new System.Drawing.Size(36, 16);
            this.chkPear.TabIndex = 2;
            this.chkPear.Text = "배";
            this.chkPear.UseVisualStyleBackColor = true;
            // 
            // chkStrawberry
            // 
            this.chkStrawberry.AutoSize = true;
            this.chkStrawberry.Location = new System.Drawing.Point(23, 104);
            this.chkStrawberry.Name = "chkStrawberry";
            this.chkStrawberry.Size = new System.Drawing.Size(48, 16);
            this.chkStrawberry.TabIndex = 3;
            this.chkStrawberry.Text = "딸기";
            this.chkStrawberry.UseVisualStyleBackColor = true;
            // 
            // chkBanana
            // 
            this.chkBanana.AutoSize = true;
            this.chkBanana.Location = new System.Drawing.Point(23, 126);
            this.chkBanana.Name = "chkBanana";
            this.chkBanana.Size = new System.Drawing.Size(60, 16);
            this.chkBanana.TabIndex = 4;
            this.chkBanana.Text = "바나나";
            this.chkBanana.UseVisualStyleBackColor = true;
            // 
            // chkOrange
            // 
            this.chkOrange.AutoSize = true;
            this.chkOrange.Location = new System.Drawing.Point(23, 148);
            this.chkOrange.Name = "chkOrange";
            this.chkOrange.Size = new System.Drawing.Size(60, 16);
            this.chkOrange.TabIndex = 5;
            this.chkOrange.Text = "오렌지";
            this.chkOrange.UseVisualStyleBackColor = true;
            // 
            // chkGrape
            // 
            this.chkGrape.AutoSize = true;
            this.chkGrape.Location = new System.Drawing.Point(23, 170);
            this.chkGrape.Name = "chkGrape";
            this.chkGrape.Size = new System.Drawing.Size(48, 16);
            this.chkGrape.TabIndex = 6;
            this.chkGrape.Text = "포도";
            this.chkGrape.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(243, 186);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(122, 43);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 241);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.chkGrape);
            this.Controls.Add(this.chkOrange);
            this.Controls.Add(this.chkBanana);
            this.Controls.Add(this.chkStrawberry);
            this.Controls.Add(this.chkPear);
            this.Controls.Add(this.chkApple);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkApple;
        private System.Windows.Forms.CheckBox chkPear;
        private System.Windows.Forms.CheckBox chkStrawberry;
        private System.Windows.Forms.CheckBox chkBanana;
        private System.Windows.Forms.CheckBox chkOrange;
        private System.Windows.Forms.CheckBox chkGrape;
        private System.Windows.Forms.Button btnResult;
    }
}

