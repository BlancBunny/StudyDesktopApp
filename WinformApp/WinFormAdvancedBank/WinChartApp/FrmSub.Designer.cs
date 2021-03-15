
namespace WinChartApp
{
    partial class FrmSub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDrawUnite = new System.Windows.Forms.Button();
            this.btnDrawSplit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtScore)).BeginInit();
            this.SuspendLayout();
            // 
            // chtScore
            // 
            chartArea1.Name = "ChartArea1";
            this.chtScore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtScore.Legends.Add(legend1);
            this.chtScore.Location = new System.Drawing.Point(12, 27);
            this.chtScore.Name = "chtScore";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtScore.Series.Add(series1);
            this.chtScore.Size = new System.Drawing.Size(579, 313);
            this.chtScore.TabIndex = 0;
            this.chtScore.Text = "chart1";
            // 
            // btnDrawUnite
            // 
            this.btnDrawUnite.Location = new System.Drawing.Point(162, 346);
            this.btnDrawUnite.Name = "btnDrawUnite";
            this.btnDrawUnite.Size = new System.Drawing.Size(114, 42);
            this.btnDrawUnite.TabIndex = 1;
            this.btnDrawUnite.Text = "합쳐서 그리기";
            this.btnDrawUnite.UseVisualStyleBackColor = true;
            this.btnDrawUnite.Click += new System.EventHandler(this.BtnDrawUnite_Click);
            // 
            // btnDrawSplit
            // 
            this.btnDrawSplit.Location = new System.Drawing.Point(312, 346);
            this.btnDrawSplit.Name = "btnDrawSplit";
            this.btnDrawSplit.Size = new System.Drawing.Size(114, 42);
            this.btnDrawSplit.TabIndex = 1;
            this.btnDrawSplit.Text = "나눠서 그리기";
            this.btnDrawSplit.UseVisualStyleBackColor = true;
            this.btnDrawSplit.Click += new System.EventHandler(this.BtnDrawSplit_Click);
            // 
            // FrmSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 400);
            this.Controls.Add(this.btnDrawSplit);
            this.Controls.Add(this.btnDrawUnite);
            this.Controls.Add(this.chtScore);
            this.Name = "FrmSub";
            this.Text = "FrmSub";
            this.Load += new System.EventHandler(this.FrmSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtScore;
        private System.Windows.Forms.Button btnDrawUnite;
        private System.Windows.Forms.Button btnDrawSplit;
    }
}