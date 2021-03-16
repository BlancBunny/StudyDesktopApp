
namespace BookRentalShopApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구분코드CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.대여RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리MToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리MToolStripMenuItem
            // 
            this.관리MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구분코드CToolStripMenuItem,
            this.회원관리MToolStripMenuItem,
            this.도서BToolStripMenuItem,
            this.toolStripMenuItem1,
            this.대여RToolStripMenuItem});
            this.관리MToolStripMenuItem.Name = "관리MToolStripMenuItem";
            this.관리MToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.관리MToolStripMenuItem.Text = "관리(&M)";
            // 
            // 구분코드CToolStripMenuItem
            // 
            this.구분코드CToolStripMenuItem.Name = "구분코드CToolStripMenuItem";
            this.구분코드CToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.구분코드CToolStripMenuItem.Text = "구분 코드(&C)";
            // 
            // 회원관리MToolStripMenuItem
            // 
            this.회원관리MToolStripMenuItem.Name = "회원관리MToolStripMenuItem";
            this.회원관리MToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.회원관리MToolStripMenuItem.Text = "회원(&M)";
            // 
            // 도서BToolStripMenuItem
            // 
            this.도서BToolStripMenuItem.Name = "도서BToolStripMenuItem";
            this.도서BToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.도서BToolStripMenuItem.Text = "도서(&B)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // 대여RToolStripMenuItem
            // 
            this.대여RToolStripMenuItem.Name = "대여RToolStripMenuItem";
            this.대여RToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.대여RToolStripMenuItem.Text = "대여(&R) ";
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(553, 34);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 375);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Book Rental Shop v0.5";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구분코드CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서BToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 대여RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}

