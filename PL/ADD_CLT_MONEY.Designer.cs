namespace SaleManagementSystem.PL
{
    partial class ADD_CLT_MONEY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_CLT_MONEY));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CBClientName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtRecievedAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtNotes = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 68);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 34);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "اسم الزبون";
            // 
            // CBClientName
            // 
            this.CBClientName.FormattingEnabled = true;
            this.CBClientName.Location = new System.Drawing.Point(160, 65);
            this.CBClientName.Name = "CBClientName";
            this.CBClientName.Size = new System.Drawing.Size(218, 42);
            this.CBClientName.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 145);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(145, 34);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "المبلغ المستلم";
            // 
            // TxtRecievedAmount
            // 
            this.TxtRecievedAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtRecievedAmount.Location = new System.Drawing.Point(191, 143);
            this.TxtRecievedAmount.Name = "TxtRecievedAmount";
            this.TxtRecievedAmount.Size = new System.Drawing.Size(187, 42);
            this.TxtRecievedAmount.TabIndex = 2;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 199);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 34);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "ملاحظة";
            // 
            // TxtNotes
            // 
            this.TxtNotes.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtNotes.Location = new System.Drawing.Point(42, 243);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(338, 85);
            this.TxtNotes.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.Pink;
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancel.BorderRadius = 0;
            this.BtnCancel.ButtonText = "الغاء";
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCancel.Iconimage = global::SaleManagementSystem.Properties.Resources.delete_sign_64px;
            this.BtnCancel.Iconimage_right = null;
            this.BtnCancel.Iconimage_right_Selected = null;
            this.BtnCancel.Iconimage_Selected = null;
            this.BtnCancel.IconMarginLeft = 0;
            this.BtnCancel.IconMarginRight = 0;
            this.BtnCancel.IconRightVisible = true;
            this.BtnCancel.IconRightZoom = 0D;
            this.BtnCancel.IconVisible = true;
            this.BtnCancel.IconZoom = 65D;
            this.BtnCancel.IsTab = false;
            this.BtnCancel.Location = new System.Drawing.Point(221, 352);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Normalcolor = System.Drawing.Color.Pink;
            this.BtnCancel.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancel.selected = false;
            this.BtnCancel.Size = new System.Drawing.Size(169, 56);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "الغاء";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.Textcolor = System.Drawing.Color.Black;
            this.BtnCancel.TextFont = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.Transparent;
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "موافق";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOk.Iconimage")));
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 140D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(33, 352);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnOk.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(169, 56);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "موافق";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Textcolor = System.Drawing.Color.White;
            this.btnOk.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("PNU Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(125, 9);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(161, 38);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "ادخال سند قبض";
            // 
            // ADD_CLT_MONEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 433);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.TxtRecievedAmount);
            this.Controls.Add(this.CBClientName);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADD_CLT_MONEY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ADD_CLT_MONEY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtRecievedAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtNotes;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCancel;
        public Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public System.Windows.Forms.ComboBox CBClientName;
    }
}