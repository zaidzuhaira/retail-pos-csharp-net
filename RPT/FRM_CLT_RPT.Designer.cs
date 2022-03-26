namespace SaleManagementSystem.RPT
{
    partial class FRM_CLT_RPT
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
            this.clientReportViewe1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CostumerCrystalReport1 = new SaleManagementSystem.RPT.CostumerCrystalReport();
            this.SuspendLayout();
            // 
            // clientReportViewe1
            // 
            this.clientReportViewe1.ActiveViewIndex = 0;
            this.clientReportViewe1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientReportViewe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientReportViewe1.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientReportViewe1.Location = new System.Drawing.Point(0, 0);
            this.clientReportViewe1.Name = "clientReportViewe1";
            this.clientReportViewe1.ReportSource = this.CostumerCrystalReport1;
            this.clientReportViewe1.Size = new System.Drawing.Size(1370, 749);
            this.clientReportViewe1.TabIndex = 0;
            // 
            // FRM_CLT_RPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.clientReportViewe1);
            this.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CLT_RPT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "طباعة سند القبض";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer clientReportViewe1;
        private CostumerCrystalReport CostumerCrystalReport1;
    }
}