namespace SaleManagementSystem.PL
{
    partial class FRM_COSTUMER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ClientDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NewClientBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EditClientBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DelClinetBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DetlClientBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCltReport = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox1.AutoSize = true;
            this.bunifuMaterialTextbox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintText = "ابحث هنا";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuMaterialTextbox1.LineThickness = 6;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(12, 2);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(375, 52);
            this.bunifuMaterialTextbox1.TabIndex = 1;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // ClientDataGrid
            // 
            this.ClientDataGrid.AllowDrop = true;
            this.ClientDataGrid.AllowUserToAddRows = false;
            this.ClientDataGrid.AllowUserToDeleteRows = false;
            this.ClientDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ClientDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ClientDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientDataGrid.DoubleBuffered = true;
            this.ClientDataGrid.EnableHeadersVisualStyles = false;
            this.ClientDataGrid.GridColor = System.Drawing.Color.White;
            this.ClientDataGrid.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.ClientDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ClientDataGrid.Location = new System.Drawing.Point(12, 63);
            this.ClientDataGrid.MultiSelect = false;
            this.ClientDataGrid.Name = "ClientDataGrid";
            this.ClientDataGrid.ReadOnly = true;
            this.ClientDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClientDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ClientDataGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.ClientDataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.ClientDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.ClientDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGrid.RowTemplate.ReadOnly = true;
            this.ClientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGrid.ShowEditingIcon = false;
            this.ClientDataGrid.Size = new System.Drawing.Size(1192, 575);
            this.ClientDataGrid.TabIndex = 2;
            // 
            // NewClientBtn
            // 
            this.NewClientBtn.Activecolor = System.Drawing.Color.DimGray;
            this.NewClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewClientBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NewClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewClientBtn.BorderRadius = 0;
            this.NewClientBtn.ButtonText = "اضافة زبون جديد";
            this.NewClientBtn.CausesValidation = false;
            this.NewClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewClientBtn.DisabledColor = System.Drawing.Color.Transparent;
            this.NewClientBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewClientBtn.ForeColor = System.Drawing.Color.Black;
            this.NewClientBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.NewClientBtn.Iconimage = null;
            this.NewClientBtn.Iconimage_right = null;
            this.NewClientBtn.Iconimage_right_Selected = null;
            this.NewClientBtn.Iconimage_Selected = null;
            this.NewClientBtn.IconMarginLeft = 0;
            this.NewClientBtn.IconMarginRight = 0;
            this.NewClientBtn.IconRightVisible = true;
            this.NewClientBtn.IconRightZoom = 0D;
            this.NewClientBtn.IconVisible = true;
            this.NewClientBtn.IconZoom = 90D;
            this.NewClientBtn.IsTab = false;
            this.NewClientBtn.Location = new System.Drawing.Point(31, 649);
            this.NewClientBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NewClientBtn.Name = "NewClientBtn";
            this.NewClientBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.NewClientBtn.OnHovercolor = System.Drawing.Color.DimGray;
            this.NewClientBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NewClientBtn.selected = false;
            this.NewClientBtn.Size = new System.Drawing.Size(166, 47);
            this.NewClientBtn.TabIndex = 3;
            this.NewClientBtn.Text = "اضافة زبون جديد";
            this.NewClientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewClientBtn.Textcolor = System.Drawing.Color.White;
            this.NewClientBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewClientBtn.Click += new System.EventHandler(this.NewClientBtn_Click);
            // 
            // EditClientBtn
            // 
            this.EditClientBtn.Activecolor = System.Drawing.Color.DimGray;
            this.EditClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditClientBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EditClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditClientBtn.BorderRadius = 0;
            this.EditClientBtn.ButtonText = "تعديل الزبون المحدد";
            this.EditClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditClientBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EditClientBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditClientBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EditClientBtn.Iconimage = null;
            this.EditClientBtn.Iconimage_right = null;
            this.EditClientBtn.Iconimage_right_Selected = null;
            this.EditClientBtn.Iconimage_Selected = null;
            this.EditClientBtn.IconMarginLeft = 0;
            this.EditClientBtn.IconMarginRight = 0;
            this.EditClientBtn.IconRightVisible = true;
            this.EditClientBtn.IconRightZoom = 0D;
            this.EditClientBtn.IconVisible = true;
            this.EditClientBtn.IconZoom = 90D;
            this.EditClientBtn.IsTab = false;
            this.EditClientBtn.Location = new System.Drawing.Point(245, 649);
            this.EditClientBtn.Margin = new System.Windows.Forms.Padding(15, 21, 15, 21);
            this.EditClientBtn.Name = "EditClientBtn";
            this.EditClientBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.EditClientBtn.OnHovercolor = System.Drawing.Color.DimGray;
            this.EditClientBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.EditClientBtn.selected = false;
            this.EditClientBtn.Size = new System.Drawing.Size(166, 47);
            this.EditClientBtn.TabIndex = 3;
            this.EditClientBtn.Text = "تعديل الزبون المحدد";
            this.EditClientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditClientBtn.Textcolor = System.Drawing.Color.White;
            this.EditClientBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditClientBtn.Click += new System.EventHandler(this.EditClientBtn_Click);
            // 
            // DelClinetBtn
            // 
            this.DelClinetBtn.Activecolor = System.Drawing.Color.DimGray;
            this.DelClinetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DelClinetBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DelClinetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DelClinetBtn.BorderRadius = 0;
            this.DelClinetBtn.ButtonText = "حذف الزبون المحدد";
            this.DelClinetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelClinetBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DelClinetBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelClinetBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DelClinetBtn.Iconimage = null;
            this.DelClinetBtn.Iconimage_right = null;
            this.DelClinetBtn.Iconimage_right_Selected = null;
            this.DelClinetBtn.Iconimage_Selected = null;
            this.DelClinetBtn.IconMarginLeft = 0;
            this.DelClinetBtn.IconMarginRight = 0;
            this.DelClinetBtn.IconRightVisible = true;
            this.DelClinetBtn.IconRightZoom = 0D;
            this.DelClinetBtn.IconVisible = true;
            this.DelClinetBtn.IconZoom = 90D;
            this.DelClinetBtn.IsTab = false;
            this.DelClinetBtn.Location = new System.Drawing.Point(459, 649);
            this.DelClinetBtn.Margin = new System.Windows.Forms.Padding(33, 55, 33, 55);
            this.DelClinetBtn.Name = "DelClinetBtn";
            this.DelClinetBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.DelClinetBtn.OnHovercolor = System.Drawing.Color.DimGray;
            this.DelClinetBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DelClinetBtn.selected = false;
            this.DelClinetBtn.Size = new System.Drawing.Size(166, 47);
            this.DelClinetBtn.TabIndex = 3;
            this.DelClinetBtn.Text = "حذف الزبون المحدد";
            this.DelClinetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelClinetBtn.Textcolor = System.Drawing.Color.White;
            this.DelClinetBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelClinetBtn.Click += new System.EventHandler(this.DelClinetBtn_Click);
            // 
            // DetlClientBtn
            // 
            this.DetlClientBtn.Activecolor = System.Drawing.Color.DimGray;
            this.DetlClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DetlClientBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DetlClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DetlClientBtn.BorderRadius = 0;
            this.DetlClientBtn.ButtonText = "اسعار الزبون المحدد";
            this.DetlClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetlClientBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DetlClientBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DetlClientBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DetlClientBtn.Iconimage = null;
            this.DetlClientBtn.Iconimage_right = null;
            this.DetlClientBtn.Iconimage_right_Selected = null;
            this.DetlClientBtn.Iconimage_Selected = null;
            this.DetlClientBtn.IconMarginLeft = 0;
            this.DetlClientBtn.IconMarginRight = 0;
            this.DetlClientBtn.IconRightVisible = true;
            this.DetlClientBtn.IconRightZoom = 0D;
            this.DetlClientBtn.IconVisible = true;
            this.DetlClientBtn.IconZoom = 90D;
            this.DetlClientBtn.IsTab = false;
            this.DetlClientBtn.Location = new System.Drawing.Point(675, 649);
            this.DetlClientBtn.Margin = new System.Windows.Forms.Padding(33, 55, 33, 55);
            this.DetlClientBtn.Name = "DetlClientBtn";
            this.DetlClientBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.DetlClientBtn.OnHovercolor = System.Drawing.Color.DimGray;
            this.DetlClientBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DetlClientBtn.selected = false;
            this.DetlClientBtn.Size = new System.Drawing.Size(166, 47);
            this.DetlClientBtn.TabIndex = 3;
            this.DetlClientBtn.Text = "اسعار الزبون المحدد";
            this.DetlClientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DetlClientBtn.Textcolor = System.Drawing.Color.White;
            this.DetlClientBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DetlClientBtn.Click += new System.EventHandler(this.DetlClientBtn_Click);
            // 
            // btnCltReport
            // 
            this.btnCltReport.Activecolor = System.Drawing.Color.DimGray;
            this.btnCltReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCltReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCltReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCltReport.BorderRadius = 0;
            this.btnCltReport.ButtonText = "كشف حساب الزبون";
            this.btnCltReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCltReport.DisabledColor = System.Drawing.Color.Gray;
            this.btnCltReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCltReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCltReport.Iconimage = null;
            this.btnCltReport.Iconimage_right = null;
            this.btnCltReport.Iconimage_right_Selected = null;
            this.btnCltReport.Iconimage_Selected = null;
            this.btnCltReport.IconMarginLeft = 0;
            this.btnCltReport.IconMarginRight = 0;
            this.btnCltReport.IconRightVisible = true;
            this.btnCltReport.IconRightZoom = 0D;
            this.btnCltReport.IconVisible = true;
            this.btnCltReport.IconZoom = 90D;
            this.btnCltReport.IsTab = false;
            this.btnCltReport.Location = new System.Drawing.Point(893, 649);
            this.btnCltReport.Margin = new System.Windows.Forms.Padding(33, 55, 33, 55);
            this.btnCltReport.Name = "btnCltReport";
            this.btnCltReport.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnCltReport.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCltReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCltReport.selected = false;
            this.btnCltReport.Size = new System.Drawing.Size(166, 47);
            this.btnCltReport.TabIndex = 3;
            this.btnCltReport.Text = "كشف حساب الزبون";
            this.btnCltReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCltReport.Textcolor = System.Drawing.Color.White;
            this.btnCltReport.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCltReport.Click += new System.EventHandler(this.btnCltReport_Click);
            // 
            // FRM_COSTUMER
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 701);
            this.Controls.Add(this.btnCltReport);
            this.Controls.Add(this.DetlClientBtn);
            this.Controls.Add(this.DelClinetBtn);
            this.Controls.Add(this.EditClientBtn);
            this.Controls.Add(this.NewClientBtn);
            this.Controls.Add(this.ClientDataGrid);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FRM_COSTUMER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_COSTUMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuFlatButton NewClientBtn;
        private Bunifu.Framework.UI.BunifuFlatButton EditClientBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DelClinetBtn;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ClientDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton DetlClientBtn;
        private Bunifu.Framework.UI.BunifuFlatButton btnCltReport;
    }
}