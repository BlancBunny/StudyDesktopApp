
namespace SimpleGraphicEditor
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
            this.tlbMain = new System.Windows.Forms.ToolStrip();
            this.tlmLine = new System.Windows.Forms.ToolStripLabel();
            this.tlmRectangle = new System.Windows.Forms.ToolStripLabel();
            this.tlmCircle = new System.Windows.Forms.ToolStripLabel();
            this.tlmCurvedLine = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlmColor = new System.Windows.Forms.ToolStripLabel();
            this.susMain = new System.Windows.Forms.StatusStrip();
            this.tslLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlbMain.SuspendLayout();
            this.susMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbMain
            // 
            this.tlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmLine,
            this.tlmRectangle,
            this.tlmCircle,
            this.tlmCurvedLine,
            this.toolStripSeparator1,
            this.tlmColor});
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.Size = new System.Drawing.Size(624, 25);
            this.tlbMain.TabIndex = 0;
            this.tlbMain.Text = "toolStrip1";
            // 
            // tlmLine
            // 
            this.tlmLine.Name = "tlmLine";
            this.tlmLine.Size = new System.Drawing.Size(19, 22);
            this.tlmLine.Text = "선";
            this.tlmLine.Click += new System.EventHandler(this.TlmLine_Click);
            // 
            // tlmRectangle
            // 
            this.tlmRectangle.Name = "tlmRectangle";
            this.tlmRectangle.Size = new System.Drawing.Size(43, 22);
            this.tlmRectangle.Text = "사각형";
            this.tlmRectangle.Click += new System.EventHandler(this.TlmRectangle_Click);
            // 
            // tlmCircle
            // 
            this.tlmCircle.Name = "tlmCircle";
            this.tlmCircle.Size = new System.Drawing.Size(19, 22);
            this.tlmCircle.Text = "원";
            this.tlmCircle.Click += new System.EventHandler(this.TlmCircle_Click);
            // 
            // tlmCurvedLine
            // 
            this.tlmCurvedLine.Name = "tlmCurvedLine";
            this.tlmCurvedLine.Size = new System.Drawing.Size(31, 22);
            this.tlmCurvedLine.Text = "곡선";
            this.tlmCurvedLine.Click += new System.EventHandler(this.TlmCurvedLine_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlmColor
            // 
            this.tlmColor.Name = "tlmColor";
            this.tlmColor.Size = new System.Drawing.Size(31, 22);
            this.tlmColor.Text = "색깔";
            this.tlmColor.Click += new System.EventHandler(this.TlmColor_Click);
            // 
            // susMain
            // 
            this.susMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLabel});
            this.susMain.Location = new System.Drawing.Point(0, 374);
            this.susMain.Name = "susMain";
            this.susMain.Size = new System.Drawing.Size(624, 22);
            this.susMain.TabIndex = 1;
            this.susMain.Text = "statusStrip1";
            // 
            // tslLabel
            // 
            this.tslLabel.Name = "tslLabel";
            this.tslLabel.Size = new System.Drawing.Size(121, 17);
            this.tslLabel.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.susMain);
            this.Controls.Add(this.tlbMain);
            this.Name = "Form1";
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.susMain.ResumeLayout(false);
            this.susMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlbMain;
        private System.Windows.Forms.ToolStripLabel tlmLine;
        private System.Windows.Forms.ToolStripLabel tlmRectangle;
        private System.Windows.Forms.ToolStripLabel tlmCircle;
        private System.Windows.Forms.ToolStripLabel tlmCurvedLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlmColor;
        private System.Windows.Forms.StatusStrip susMain;
        private System.Windows.Forms.ToolStripStatusLabel tslLabel;
    }
}

