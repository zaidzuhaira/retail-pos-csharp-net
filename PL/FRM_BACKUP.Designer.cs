namespace SaleManagementSystem.PL
{
    partial class FRM_BACKUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BACKUP));
            this.txtfolderpath = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtfilepath = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnCreateBackup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFolderBrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFileBrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtfolderpath
            // 
            this.txtfolderpath.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtfolderpath.Location = new System.Drawing.Point(38, 52);
            this.txtfolderpath.Name = "txtfolderpath";
            this.txtfolderpath.ReadOnly = true;
            this.txtfolderpath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfolderpath.Size = new System.Drawing.Size(475, 42);
            this.txtfolderpath.TabIndex = 200;
            // 
            // txtfilepath
            // 
            this.txtfilepath.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtfilepath.Location = new System.Drawing.Point(38, 233);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.ReadOnly = true;
            this.txtfilepath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfilepath.Size = new System.Drawing.Size(475, 42);
            this.txtfilepath.TabIndex = 100;
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.Activecolor = System.Drawing.Color.DimGray;
            this.btnCreateBackup.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateBackup.BorderRadius = 0;
            this.btnCreateBackup.ButtonText = "أنشاء نسخة احتياطية";
            this.btnCreateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBackup.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreateBackup.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreateBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreateBackup.Iconimage = null;
            this.btnCreateBackup.Iconimage_right = null;
            this.btnCreateBackup.Iconimage_right_Selected = null;
            this.btnCreateBackup.Iconimage_Selected = null;
            this.btnCreateBackup.IconMarginLeft = 0;
            this.btnCreateBackup.IconMarginRight = 0;
            this.btnCreateBackup.IconRightVisible = true;
            this.btnCreateBackup.IconRightZoom = 0D;
            this.btnCreateBackup.IconVisible = true;
            this.btnCreateBackup.IconZoom = 90D;
            this.btnCreateBackup.IsTab = false;
            this.btnCreateBackup.Location = new System.Drawing.Point(38, 119);
            this.btnCreateBackup.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateBackup.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCreateBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreateBackup.selected = false;
            this.btnCreateBackup.Size = new System.Drawing.Size(189, 52);
            this.btnCreateBackup.TabIndex = 1;
            this.btnCreateBackup.Text = "أنشاء نسخة احتياطية";
            this.btnCreateBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateBackup.Textcolor = System.Drawing.Color.White;
            this.btnCreateBackup.TextFont = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Activecolor = System.Drawing.Color.DimGray;
            this.btnRestore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.BorderRadius = 0;
            this.btnRestore.ButtonText = "استعادة نسخة محفوظة";
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestore.Iconimage = null;
            this.btnRestore.Iconimage_right = null;
            this.btnRestore.Iconimage_right_Selected = null;
            this.btnRestore.Iconimage_Selected = null;
            this.btnRestore.IconMarginLeft = 0;
            this.btnRestore.IconMarginRight = 0;
            this.btnRestore.IconRightVisible = true;
            this.btnRestore.IconRightZoom = 0D;
            this.btnRestore.IconVisible = true;
            this.btnRestore.IconZoom = 90D;
            this.btnRestore.IsTab = false;
            this.btnRestore.Location = new System.Drawing.Point(38, 299);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(15, 21, 15, 21);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnRestore.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestore.selected = false;
            this.btnRestore.Size = new System.Drawing.Size(215, 51);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "استعادة نسخة محفوظة";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRestore.Textcolor = System.Drawing.Color.White;
            this.btnRestore.TextFont = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(242, 34);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "اختر مكان النسخ الاحتياطي";
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.ActiveBorderThickness = 1;
            this.btnFolderBrowse.ActiveCornerRadius = 20;
            this.btnFolderBrowse.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnFolderBrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnFolderBrowse.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnFolderBrowse.BackColor = System.Drawing.Color.White;
            this.btnFolderBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolderBrowse.BackgroundImage")));
            this.btnFolderBrowse.ButtonText = "...";
            this.btnFolderBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolderBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderBrowse.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFolderBrowse.IdleBorderThickness = 1;
            this.btnFolderBrowse.IdleCornerRadius = 20;
            this.btnFolderBrowse.IdleFillColor = System.Drawing.Color.White;
            this.btnFolderBrowse.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.btnFolderBrowse.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnFolderBrowse.Location = new System.Drawing.Point(525, 52);
            this.btnFolderBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(142, 42);
            this.btnFolderBrowse.TabIndex = 0;
            this.btnFolderBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.ActiveBorderThickness = 1;
            this.btnFileBrowse.ActiveCornerRadius = 20;
            this.btnFileBrowse.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnFileBrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnFileBrowse.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnFileBrowse.BackColor = System.Drawing.Color.White;
            this.btnFileBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFileBrowse.BackgroundImage")));
            this.btnFileBrowse.ButtonText = "...";
            this.btnFileBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBrowse.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFileBrowse.IdleBorderThickness = 1;
            this.btnFileBrowse.IdleCornerRadius = 20;
            this.btnFileBrowse.IdleFillColor = System.Drawing.Color.White;
            this.btnFileBrowse.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.btnFileBrowse.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnFileBrowse.Location = new System.Drawing.Point(525, 233);
            this.btnFileBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(142, 41);
            this.btnFileBrowse.TabIndex = 2;
            this.btnFileBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFileBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 196);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(251, 34);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "اختر ملف النسخة المحفوظة";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 369);
            this.Controls.Add(this.btnFileBrowse);
            this.Controls.Add(this.btnFolderBrowse);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnCreateBackup);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.txtfolderpath);
            this.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtfolderpath;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtfilepath;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreateBackup;
        private Bunifu.Framework.UI.BunifuFlatButton btnRestore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFolderBrowse;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFileBrowse;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}