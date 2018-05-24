namespace QLphongGYM.Report
{
    partial class RptThu
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
            this.viewReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpThu1 = new QLphongGYM.Report.rpThu();
            this.SuspendLayout();
            // 
            // viewReport
            // 
            this.viewReport.ActiveViewIndex = -1;
            this.viewReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewReport.Location = new System.Drawing.Point(0, 0);
            this.viewReport.Name = "viewReport";
            this.viewReport.Size = new System.Drawing.Size(898, 501);
            this.viewReport.TabIndex = 0;
            // 
            // RptThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 501);
            this.Controls.Add(this.viewReport);
            this.Name = "RptThu";
            this.Text = "RptThu";
            this.Load += new System.EventHandler(this.RptThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewReport;
        private rpThu rpThu1;
    }
}