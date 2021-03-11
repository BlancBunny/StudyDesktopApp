
namespace AlarmClockApp
{
    partial class FrmAlarm
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
            this.components = new System.ComponentModel.Container();
            this.TabClock = new System.Windows.Forms.TabControl();
            this.TabSetAlarm = new System.Windows.Forms.TabPage();
            this.btnClearAlarm = new System.Windows.Forms.Button();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.dtpTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.TabDigitalClock = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAlarmSet = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.TabClock.SuspendLayout();
            this.TabSetAlarm.SuspendLayout();
            this.TabDigitalClock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabClock
            // 
            this.TabClock.Controls.Add(this.TabSetAlarm);
            this.TabClock.Controls.Add(this.TabDigitalClock);
            this.TabClock.Location = new System.Drawing.Point(12, 12);
            this.TabClock.Name = "TabClock";
            this.TabClock.SelectedIndex = 0;
            this.TabClock.Size = new System.Drawing.Size(439, 267);
            this.TabClock.TabIndex = 0;
            // 
            // TabSetAlarm
            // 
            this.TabSetAlarm.Controls.Add(this.btnClearAlarm);
            this.TabSetAlarm.Controls.Add(this.btnSetAlarm);
            this.TabSetAlarm.Controls.Add(this.dtpTimePicker);
            this.TabSetAlarm.Controls.Add(this.dtpDatePicker);
            this.TabSetAlarm.Controls.Add(this.lblTime2);
            this.TabSetAlarm.Controls.Add(this.lblDate2);
            this.TabSetAlarm.Location = new System.Drawing.Point(4, 22);
            this.TabSetAlarm.Name = "TabSetAlarm";
            this.TabSetAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.TabSetAlarm.Size = new System.Drawing.Size(431, 241);
            this.TabSetAlarm.TabIndex = 0;
            this.TabSetAlarm.Text = "알람설정";
            this.TabSetAlarm.UseVisualStyleBackColor = true;
            // 
            // btnClearAlarm
            // 
            this.btnClearAlarm.Location = new System.Drawing.Point(335, 203);
            this.btnClearAlarm.Name = "btnClearAlarm";
            this.btnClearAlarm.Size = new System.Drawing.Size(90, 32);
            this.btnClearAlarm.TabIndex = 5;
            this.btnClearAlarm.Text = "해제";
            this.btnClearAlarm.UseVisualStyleBackColor = true;
            this.btnClearAlarm.Click += new System.EventHandler(this.BtnClearAlarm_Click);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(238, 203);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(90, 32);
            this.btnSetAlarm.TabIndex = 4;
            this.btnSetAlarm.Text = "설정";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.BtnSetAlarm_Click);
            // 
            // dtpTimePicker
            // 
            this.dtpTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimePicker.Location = new System.Drawing.Point(22, 101);
            this.dtpTimePicker.Name = "dtpTimePicker";
            this.dtpTimePicker.ShowUpDown = true;
            this.dtpTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dtpTimePicker.TabIndex = 3;
            // 
            // dtpDatePicker
            // 
            this.dtpDatePicker.Location = new System.Drawing.Point(22, 34);
            this.dtpDatePicker.Name = "dtpDatePicker";
            this.dtpDatePicker.Size = new System.Drawing.Size(200, 21);
            this.dtpDatePicker.TabIndex = 2;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(20, 86);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(57, 12);
            this.lblTime2.TabIndex = 1;
            this.lblTime2.Text = "시간 설정";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(20, 19);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(57, 12);
            this.lblDate2.TabIndex = 0;
            this.lblDate2.Text = "날짜 설정";
            // 
            // TabDigitalClock
            // 
            this.TabDigitalClock.Controls.Add(this.groupBox1);
            this.TabDigitalClock.Controls.Add(this.lblAlarmSet);
            this.TabDigitalClock.Controls.Add(this.lblAlarm);
            this.TabDigitalClock.Location = new System.Drawing.Point(4, 22);
            this.TabDigitalClock.Name = "TabDigitalClock";
            this.TabDigitalClock.Padding = new System.Windows.Forms.Padding(3);
            this.TabDigitalClock.Size = new System.Drawing.Size(431, 241);
            this.TabDigitalClock.TabIndex = 1;
            this.TabDigitalClock.Text = "디지털시계";
            this.TabDigitalClock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(24, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 시간";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(20, 63);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 32);
            this.lblTime.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 12);
            this.lblDate.TabIndex = 2;
            // 
            // lblAlarmSet
            // 
            this.lblAlarmSet.AutoSize = true;
            this.lblAlarmSet.Location = new System.Drawing.Point(31, 55);
            this.lblAlarmSet.Name = "lblAlarmSet";
            this.lblAlarmSet.Size = new System.Drawing.Size(50, 12);
            this.lblAlarmSet.TabIndex = 1;
            this.lblAlarmSet.Text = "Alerm : ";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(31, 28);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(57, 12);
            this.lblAlarm.TabIndex = 0;
            this.lblAlarm.Text = "알람 설정";
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 291);
            this.Controls.Add(this.TabClock);
            this.Name = "FrmAlarm";
            this.Text = "알람시계";
            this.Load += new System.EventHandler(this.FrmAlarm_Load);
            this.TabClock.ResumeLayout(false);
            this.TabSetAlarm.ResumeLayout(false);
            this.TabSetAlarm.PerformLayout();
            this.TabDigitalClock.ResumeLayout(false);
            this.TabDigitalClock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabClock;
        private System.Windows.Forms.TabPage TabSetAlarm;
        private System.Windows.Forms.TabPage TabDigitalClock;
        private System.Windows.Forms.Button btnClearAlarm;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.DateTimePicker dtpTimePicker;
        private System.Windows.Forms.DateTimePicker dtpDatePicker;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAlarmSet;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Timer myTimer;
    }
}

