namespace SaleManagementSystem.PL
{
    partial class FRM_ORDERS
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
            this.btnEditSelectOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintSelectQrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OrdersListGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtSearchOrder = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditSelectOrder
            // 
            this.btnEditSelectOrder.Activecolor = System.Drawing.Color.DimGray;
            this.btnEditSelectOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSelectOrder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditSelectOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSelectOrder.BorderRadius = 0;
            this.btnEditSelectOrder.ButtonText = "تعديل الفاتورة المحددة";
            this.btnEditSelectOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSelectOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditSelectOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditSelectOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditSelectOrder.Iconimage = null;
            this.btnEditSelectOrder.Iconimage_right = null;
            this.btnEditSelectOrder.Iconimage_right_Selected = null;
            this.btnEditSelectOrder.Iconimage_Selected = null;
            this.btnEditSelectOrder.IconMarginLeft = 0;
            this.btnEditSelectOrder.IconMarginRight = 0;
            this.btnEditSelectOrder.IconRightVisible = true;
            this.btnEditSelectOrder.IconRightZoom = 0D;
            this.btnEditSelectOrder.IconVisible = true;
            this.btnEditSelectOrder.IconZoom = 90D;
            this.btnEditSelectOrder.IsTab = false;
            this.btnEditSelectOrder.Location = new System.Drawing.Point(339, 655);
            this.btnEditSelectOrder.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btnEditSelectOrder.Name = "btnEditSelectOrder";
            this.btnEditSelectOrder.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnEditSelectOrder.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnEditSelectOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditSelectOrder.selected = false;
            this.btnEditSelectOrder.Size = new System.Drawing.Size(184, 46);
            this.btnEditSelectOrder.TabIndex = 7;
            this.btnEditSelectOrder.Text = "تعديل الفاتورة المحددة";
            this.btnEditSelectOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditSelectOrder.Textcolor = System.Drawing.Color.White;
            this.btnEditSelectOrder.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditSelectOrder.Click += new System.EventHandler(this.btnEditSelectOrder_Click);
            // 
            // btnPrintSelectQrder
            // 
            this.btnPrintSelectQrder.Activecolor = System.Drawing.Color.DimGray;
            this.btnPrintSelectQrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSelectQrder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrintSelectQrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintSelectQrder.BorderRadius = 0;
            this.btnPrintSelectQrder.ButtonText = "طباعة الفاتورة المحددة";
            this.btnPrintSelectQrder.CausesValidation = false;
            this.btnPrintSelectQrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSelectQrder.DisabledColor = System.Drawing.Color.Transparent;
            this.btnPrintSelectQrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintSelectQrder.ForeColor = System.Drawing.Color.Black;
            this.btnPrintSelectQrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintSelectQrder.Iconimage = null;
            this.btnPrintSelectQrder.Iconimage_right = null;
            this.btnPrintSelectQrder.Iconimage_right_Selected = null;
            this.btnPrintSelectQrder.Iconimage_Selected = null;
            this.btnPrintSelectQrder.IconMarginLeft = 0;
            this.btnPrintSelectQrder.IconMarginRight = 0;
            this.btnPrintSelectQrder.IconRightVisible = true;
            this.btnPrintSelectQrder.IconRightZoom = 0D;
            this.btnPrintSelectQrder.IconVisible = true;
            this.btnPrintSelectQrder.IconZoom = 90D;
            this.btnPrintSelectQrder.IsTab = false;
            this.btnPrintSelectQrder.Location = new System.Drawing.Point(120, 655);
            this.btnPrintSelectQrder.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnPrintSelectQrder.Name = "btnPrintSelectQrder";
            this.btnPrintSelectQrder.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnPrintSelectQrder.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnPrintSelectQrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintSelectQrder.selected = false;
            this.btnPrintSelectQrder.Size = new System.Drawing.Size(179, 46);
            this.btnPrintSelectQrder.TabIndex = 8;
            this.btnPrintSelectQrder.Text = "طباعة الفاتورة المحددة";
            this.btnPrintSelectQrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintSelectQrder.Textcolor = System.Drawing.Color.White;
            this.btnPrintSelectQrder.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintSelectQrder.Click += new System.EventHandler(this.btnPrintSelectQrder_Click);
            // 
            // OrdersListGrid
            // 
            this.OrdersListGrid.AllowDrop = true;
            this.OrdersListGrid.AllowUserToAddRows = false;
            this.OrdersListGrid.AllowUserToDeleteRows = false;
            this.OrdersListGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrdersListGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrdersListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrdersListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersListGrid.DoubleBuffered = true;
            this.OrdersListGrid.EnableHeadersVisualStyles = false;
            this.OrdersListGrid.GridColor = System.Drawing.Color.White;
            this.OrdersListGrid.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.OrdersListGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OrdersListGrid.Location = new System.Drawing.Point(12, 70);
            this.OrdersListGrid.MultiSelect = false;
            this.OrdersListGrid.Name = "OrdersListGrid";
            this.OrdersListGrid.ReadOnly = true;
            this.OrdersListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrdersListGrid.RowHeadersVisible = false;
            this.OrdersListGrid.RowHeadersWidth = 5;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersListGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OrdersListGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersListGrid.RowTemplate.ReadOnly = true;
            this.OrdersListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersListGrid.ShowEditingIcon = false;
            this.OrdersListGrid.Size = new System.Drawing.Size(1192, 575);
            this.OrdersListGrid.TabIndex = 5;
            // 
            // TxtSearchOrder
            // 
            this.TxtSearchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchOrder.AutoSize = true;
            this.TxtSearchOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TxtSearchOrder.BackColor = System.Drawing.Color.White;
            this.TxtSearchOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchOrder.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSearchOrder.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchOrder.HintForeColor = System.Drawing.Color.Black;
            this.TxtSearchOrder.HintText = "ابحث هنا";
            this.TxtSearchOrder.isPassword = false;
            this.TxtSearchOrder.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.TxtSearchOrder.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtSearchOrder.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.TxtSearchOrder.LineThickness = 6;
            this.TxtSearchOrder.Location = new System.Drawing.Point(12, 9);
            this.TxtSearchOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtSearchOrder.Name = "TxtSearchOrder";
            this.TxtSearchOrder.Size = new System.Drawing.Size(402, 52);
            this.TxtSearchOrder.TabIndex = 4;
            this.TxtSearchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchOrder.OnValueChanged += new System.EventHandler(this.TxtSearchOrder_OnValueChanged);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "حذف الفاتورة المحددة";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(566, 655);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(184, 46);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "حذف الفاتورة المحددة";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 712);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnEditSelectOrder);
            this.Controls.Add(this.btnPrintSelectQrder);
            this.Controls.Add(this.OrdersListGrid);
            this.Controls.Add(this.TxtSearchOrder);
            this.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_ORDERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnEditSelectOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintSelectQrder;
        public Bunifu.Framework.UI.BunifuCustomDataGrid OrdersListGrid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSearchOrder;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}