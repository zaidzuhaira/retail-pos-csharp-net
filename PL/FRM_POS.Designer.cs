namespace SaleManagementSystem.PL
{
    partial class FRM_POS
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
            this.OrderIDLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.OrderDateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CBClientName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CBProdName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.OrderDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SaveOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PrintOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DelOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NewOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AddNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProdBagsTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ProdQtyTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtSumTotals = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtRemainMoney = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCash = new System.Windows.Forms.RadioButton();
            this.btnDebit = new System.Windows.Forms.RadioButton();
            this.TxtReceivedMoney = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtDriver = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ProdPriceTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ClientAmountTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ClientAddressTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ClientPhoneTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.OrderIDTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtOrderNotes = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NewCltBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrderIDLabel.Location = new System.Drawing.Point(12, 15);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(94, 27);
            this.OrderIDLabel.TabIndex = 0;
            this.OrderIDLabel.Text = "رقم الفاتورة";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrderDateLabel.Location = new System.Drawing.Point(223, 15);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(99, 27);
            this.OrderDateLabel.TabIndex = 0;
            this.OrderDateLabel.Text = "تاريخ الفاتورة";
            // 
            // CBClientName
            // 
            this.CBClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBClientName.BackColor = System.Drawing.Color.White;
            this.CBClientName.Cursor = System.Windows.Forms.Cursors.Default;
            this.CBClientName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBClientName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBClientName.FormattingEnabled = true;
            this.CBClientName.Location = new System.Drawing.Point(113, 73);
            this.CBClientName.MaxDropDownItems = 100;
            this.CBClientName.Name = "CBClientName";
            this.CBClientName.Size = new System.Drawing.Size(197, 37);
            this.CBClientName.Sorted = true;
            this.CBClientName.TabIndex = 0;
            this.CBClientName.SelectedIndexChanged += new System.EventHandler(this.CBClientName_SelectedIndexChanged);
            this.CBClientName.DropDownClosed += new System.EventHandler(this.CBClientName_DropDownClosed);
            this.CBClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBClientName_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 76);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 27);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "اسم الزبون";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(395, 76);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 27);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "رقم الهاتف";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(701, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 27);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "العنوان";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(1022, 53);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(122, 27);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "الحساب المتبقي";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(8, 143);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(88, 27);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "اسم المنتج";
            // 
            // CBProdName
            // 
            this.CBProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBProdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBProdName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBProdName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBProdName.FormattingEnabled = true;
            this.CBProdName.Location = new System.Drawing.Point(113, 143);
            this.CBProdName.Name = "CBProdName";
            this.CBProdName.Size = new System.Drawing.Size(197, 37);
            this.CBProdName.TabIndex = 1;
            this.CBProdName.SelectedIndexChanged += new System.EventHandler(this.CBProdName_SelectedIndexChanged);
            this.CBProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CBProdName_KeyDown);
            this.CBProdName.MouseCaptureChanged += new System.EventHandler(this.CBProdName_MouseCaptureChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(336, 148);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(48, 27);
            this.bunifuCustomLabel6.TabIndex = 4;
            this.bunifuCustomLabel6.Text = "العدد";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(711, 148);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(92, 27);
            this.bunifuCustomLabel7.TabIndex = 4;
            this.bunifuCustomLabel7.Text = "سعر المفرد";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("PNU Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(512, 148);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(58, 27);
            this.bunifuCustomLabel8.TabIndex = 4;
            this.bunifuCustomLabel8.Text = "الكمية";
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToDeleteRows = false;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.OrderDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDataGrid.DoubleBuffered = true;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.OrderDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OrderDataGrid.Location = new System.Drawing.Point(12, 197);
            this.OrderDataGrid.MultiSelect = false;
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderDataGrid.RowHeadersVisible = false;
            this.OrderDataGrid.RowHeadersWidth = 5;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.OrderDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowTemplate.ReadOnly = true;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.ShowEditingIcon = false;
            this.OrderDataGrid.Size = new System.Drawing.Size(1192, 379);
            this.OrderDataGrid.TabIndex = 7;
            this.OrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellContentClick);
            this.OrderDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellDoubleClick);
            this.OrderDataGrid.SelectionChanged += new System.EventHandler(this.OrderDataGrid_SelectionChanged);
            this.OrderDataGrid.Enter += new System.EventHandler(this.OrderDataGrid_Enter);
            // 
            // OrderDatepicker
            // 
            this.OrderDatepicker.BackColor = System.Drawing.Color.DarkSlateGray;
            this.OrderDatepicker.BorderRadius = 1;
            this.OrderDatepicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrderDatepicker.ForeColor = System.Drawing.Color.White;
            this.OrderDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderDatepicker.FormatCustom = "yyyy/MM/dd";
            this.OrderDatepicker.Location = new System.Drawing.Point(341, 9);
            this.OrderDatepicker.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.OrderDatepicker.Name = "OrderDatepicker";
            this.OrderDatepicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderDatepicker.Size = new System.Drawing.Size(200, 41);
            this.OrderDatepicker.TabIndex = 8;
            this.OrderDatepicker.Value = new System.DateTime(2020, 1, 4, 0, 0, 0, 0);
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.SaveOrderBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SaveOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveOrderBtn.BorderRadius = 0;
            this.SaveOrderBtn.ButtonText = "حفظ الفاتورة";
            this.SaveOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SaveOrderBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SaveOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveOrderBtn.Iconimage = null;
            this.SaveOrderBtn.Iconimage_right = null;
            this.SaveOrderBtn.Iconimage_right_Selected = null;
            this.SaveOrderBtn.Iconimage_Selected = null;
            this.SaveOrderBtn.IconMarginLeft = 0;
            this.SaveOrderBtn.IconMarginRight = 0;
            this.SaveOrderBtn.IconRightVisible = true;
            this.SaveOrderBtn.IconRightZoom = 0D;
            this.SaveOrderBtn.IconVisible = true;
            this.SaveOrderBtn.IconZoom = 90D;
            this.SaveOrderBtn.IsTab = false;
            this.SaveOrderBtn.Location = new System.Drawing.Point(870, 646);
            this.SaveOrderBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.SaveOrderBtn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.SaveOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveOrderBtn.selected = false;
            this.SaveOrderBtn.Size = new System.Drawing.Size(155, 49);
            this.SaveOrderBtn.TabIndex = 9;
            this.SaveOrderBtn.Text = "حفظ الفاتورة";
            this.SaveOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveOrderBtn.Textcolor = System.Drawing.Color.White;
            this.SaveOrderBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // PrintOrderBtn
            // 
            this.PrintOrderBtn.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.PrintOrderBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PrintOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintOrderBtn.BorderRadius = 0;
            this.PrintOrderBtn.ButtonText = "طباعة الفاتورة";
            this.PrintOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.PrintOrderBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PrintOrderBtn.Iconimage = null;
            this.PrintOrderBtn.Iconimage_right = null;
            this.PrintOrderBtn.Iconimage_right_Selected = null;
            this.PrintOrderBtn.Iconimage_Selected = null;
            this.PrintOrderBtn.IconMarginLeft = 0;
            this.PrintOrderBtn.IconMarginRight = 0;
            this.PrintOrderBtn.IconRightVisible = true;
            this.PrintOrderBtn.IconRightZoom = 0D;
            this.PrintOrderBtn.IconVisible = true;
            this.PrintOrderBtn.IconZoom = 90D;
            this.PrintOrderBtn.IsTab = false;
            this.PrintOrderBtn.Location = new System.Drawing.Point(870, 582);
            this.PrintOrderBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PrintOrderBtn.Name = "PrintOrderBtn";
            this.PrintOrderBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.PrintOrderBtn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.PrintOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PrintOrderBtn.selected = false;
            this.PrintOrderBtn.Size = new System.Drawing.Size(155, 49);
            this.PrintOrderBtn.TabIndex = 9;
            this.PrintOrderBtn.Text = "طباعة الفاتورة";
            this.PrintOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintOrderBtn.Textcolor = System.Drawing.Color.White;
            this.PrintOrderBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintOrderBtn.Click += new System.EventHandler(this.PrintOrderBtn_Click);
            // 
            // DelOrderBtn
            // 
            this.DelOrderBtn.Activecolor = System.Drawing.Color.Firebrick;
            this.DelOrderBtn.BackColor = System.Drawing.Color.Firebrick;
            this.DelOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DelOrderBtn.BorderRadius = 0;
            this.DelOrderBtn.ButtonText = "حذف الفاتورة";
            this.DelOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DelOrderBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DelOrderBtn.Iconimage = null;
            this.DelOrderBtn.Iconimage_right = null;
            this.DelOrderBtn.Iconimage_right_Selected = null;
            this.DelOrderBtn.Iconimage_Selected = null;
            this.DelOrderBtn.IconMarginLeft = 0;
            this.DelOrderBtn.IconMarginRight = 0;
            this.DelOrderBtn.IconRightVisible = true;
            this.DelOrderBtn.IconRightZoom = 0D;
            this.DelOrderBtn.IconVisible = true;
            this.DelOrderBtn.IconZoom = 90D;
            this.DelOrderBtn.IsTab = false;
            this.DelOrderBtn.Location = new System.Drawing.Point(1046, 646);
            this.DelOrderBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DelOrderBtn.Name = "DelOrderBtn";
            this.DelOrderBtn.Normalcolor = System.Drawing.Color.Firebrick;
            this.DelOrderBtn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.DelOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DelOrderBtn.selected = false;
            this.DelOrderBtn.Size = new System.Drawing.Size(155, 49);
            this.DelOrderBtn.TabIndex = 9;
            this.DelOrderBtn.Text = "حذف الفاتورة";
            this.DelOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelOrderBtn.Textcolor = System.Drawing.Color.White;
            this.DelOrderBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelOrderBtn.Click += new System.EventHandler(this.DelOrderBtn_Click);
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.NewOrderBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NewOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewOrderBtn.BorderRadius = 0;
            this.NewOrderBtn.ButtonText = "أنشاء فاتورة جديدة";
            this.NewOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.NewOrderBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.NewOrderBtn.Iconimage = null;
            this.NewOrderBtn.Iconimage_right = null;
            this.NewOrderBtn.Iconimage_right_Selected = null;
            this.NewOrderBtn.Iconimage_Selected = null;
            this.NewOrderBtn.IconMarginLeft = 0;
            this.NewOrderBtn.IconMarginRight = 0;
            this.NewOrderBtn.IconRightVisible = true;
            this.NewOrderBtn.IconRightZoom = 0D;
            this.NewOrderBtn.IconVisible = true;
            this.NewOrderBtn.IconZoom = 90D;
            this.NewOrderBtn.IsTab = false;
            this.NewOrderBtn.Location = new System.Drawing.Point(1046, 582);
            this.NewOrderBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.NewOrderBtn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.NewOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NewOrderBtn.selected = false;
            this.NewOrderBtn.Size = new System.Drawing.Size(155, 49);
            this.NewOrderBtn.TabIndex = 9;
            this.NewOrderBtn.Text = "أنشاء فاتورة جديدة";
            this.NewOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewOrderBtn.Textcolor = System.Drawing.Color.White;
            this.NewOrderBtn.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.AddNewBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AddNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewBtn.BorderRadius = 0;
            this.AddNewBtn.ButtonText = "اضافة المنتج";
            this.AddNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewBtn.DisabledColor = System.Drawing.Color.Gray;
            this.AddNewBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddNewBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.AddNewBtn.Iconimage = null;
            this.AddNewBtn.Iconimage_right = null;
            this.AddNewBtn.Iconimage_right_Selected = null;
            this.AddNewBtn.Iconimage_Selected = null;
            this.AddNewBtn.IconMarginLeft = 0;
            this.AddNewBtn.IconMarginRight = 0;
            this.AddNewBtn.IconRightVisible = true;
            this.AddNewBtn.IconRightZoom = 0D;
            this.AddNewBtn.IconVisible = true;
            this.AddNewBtn.IconZoom = 90D;
            this.AddNewBtn.IsTab = false;
            this.AddNewBtn.Location = new System.Drawing.Point(1015, 142);
            this.AddNewBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.AddNewBtn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.AddNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddNewBtn.selected = false;
            this.AddNewBtn.Size = new System.Drawing.Size(140, 40);
            this.AddNewBtn.TabIndex = 4;
            this.AddNewBtn.Text = "اضافة المنتج";
            this.AddNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNewBtn.Textcolor = System.Drawing.Color.White;
            this.AddNewBtn.TextFont = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // ProdBagsTextBox
            // 
            this.ProdBagsTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProdBagsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdBagsTextBox.Location = new System.Drawing.Point(587, 143);
            this.ProdBagsTextBox.Name = "ProdBagsTextBox";
            this.ProdBagsTextBox.ReadOnly = true;
            this.ProdBagsTextBox.Size = new System.Drawing.Size(100, 36);
            this.ProdBagsTextBox.TabIndex = 10;
            this.ProdBagsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProdQtyTextBox
            // 
            this.ProdQtyTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProdQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdQtyTextBox.Location = new System.Drawing.Point(391, 143);
            this.ProdQtyTextBox.MaxLength = 8;
            this.ProdQtyTextBox.Name = "ProdQtyTextBox";
            this.ProdQtyTextBox.Size = new System.Drawing.Size(100, 36);
            this.ProdQtyTextBox.TabIndex = 2;
            this.ProdQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProdQtyTextBox.TextChanged += new System.EventHandler(this.ProdQtyTextBox_TextChanged);
            this.ProdQtyTextBox.Enter += new System.EventHandler(this.ProdQtyTextBox_Enter);
            this.ProdQtyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProdQtyTextBox_KeyDown);
            this.ProdQtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdQtyTextBox_KeyPress);
            // 
            // TxtSumTotals
            // 
            this.TxtSumTotals.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSumTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSumTotals.Location = new System.Drawing.Point(638, 582);
            this.TxtSumTotals.MaxLength = 9;
            this.TxtSumTotals.Name = "TxtSumTotals";
            this.TxtSumTotals.ReadOnly = true;
            this.TxtSumTotals.Size = new System.Drawing.Size(201, 36);
            this.TxtSumTotals.TabIndex = 13;
            this.TxtSumTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(503, 588);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(120, 29);
            this.bunifuCustomLabel11.TabIndex = 12;
            this.bunifuCustomLabel11.Text = "المجموع الكلي";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(561, 629);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(62, 29);
            this.bunifuCustomLabel12.TabIndex = 12;
            this.bunifuCustomLabel12.Text = "الواصل";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(565, 665);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(58, 29);
            this.bunifuCustomLabel13.TabIndex = 12;
            this.bunifuCustomLabel13.Text = "الباقي";
            // 
            // TxtRemainMoney
            // 
            this.TxtRemainMoney.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtRemainMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRemainMoney.Location = new System.Drawing.Point(638, 665);
            this.TxtRemainMoney.MaxLength = 9;
            this.TxtRemainMoney.Name = "TxtRemainMoney";
            this.TxtRemainMoney.ReadOnly = true;
            this.TxtRemainMoney.Size = new System.Drawing.Size(201, 36);
            this.TxtRemainMoney.TabIndex = 13;
            this.TxtRemainMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(266, 588);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(94, 34);
            this.bunifuCustomLabel14.TabIndex = 12;
            this.bunifuCustomLabel14.Text = "نوع الدفع";
            // 
            // btnCash
            // 
            this.btnCash.AutoSize = true;
            this.btnCash.Location = new System.Drawing.Point(281, 627);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(70, 33);
            this.btnCash.TabIndex = 16;
            this.btnCash.Text = "نقدي";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.CheckedChanged += new System.EventHandler(this.btnCash_CheckedChanged);
            // 
            // btnDebit
            // 
            this.btnDebit.AutoSize = true;
            this.btnDebit.Location = new System.Drawing.Point(281, 662);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(57, 33);
            this.btnDebit.TabIndex = 17;
            this.btnDebit.Text = "أجل";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.CheckedChanged += new System.EventHandler(this.btnDebit_CheckedChanged);
            // 
            // TxtReceivedMoney
            // 
            this.TxtReceivedMoney.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtReceivedMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReceivedMoney.Location = new System.Drawing.Point(638, 624);
            this.TxtReceivedMoney.MaxLength = 9;
            this.TxtReceivedMoney.Name = "TxtReceivedMoney";
            this.TxtReceivedMoney.Size = new System.Drawing.Size(201, 36);
            this.TxtReceivedMoney.TabIndex = 18;
            this.TxtReceivedMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtReceivedMoney.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtReceivedMoney_MouseClick);
            this.TxtReceivedMoney.TextChanged += new System.EventHandler(this.TxtReceivedMoney_TextChanged);
            this.TxtReceivedMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReceivedMoney_KeyPress);
            // 
            // TxtDriver
            // 
            this.TxtDriver.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDriver.Location = new System.Drawing.Point(114, 585);
            this.TxtDriver.Name = "TxtDriver";
            this.TxtDriver.Size = new System.Drawing.Size(122, 36);
            this.TxtDriver.TabIndex = 19;
            this.TxtDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProdPriceTextBox
            // 
            this.ProdPriceTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProdPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdPriceTextBox.Location = new System.Drawing.Point(812, 143);
            this.ProdPriceTextBox.MaxLength = 9;
            this.ProdPriceTextBox.Name = "ProdPriceTextBox";
            this.ProdPriceTextBox.Size = new System.Drawing.Size(108, 36);
            this.ProdPriceTextBox.TabIndex = 20;
            this.ProdPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProdPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdPriceTextBox_KeyPress);
            // 
            // ClientAmountTextBox
            // 
            this.ClientAmountTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ClientAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientAmountTextBox.Location = new System.Drawing.Point(1015, 89);
            this.ClientAmountTextBox.Name = "ClientAmountTextBox";
            this.ClientAmountTextBox.ReadOnly = true;
            this.ClientAmountTextBox.Size = new System.Drawing.Size(140, 36);
            this.ClientAmountTextBox.TabIndex = 21;
            this.ClientAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientAddressTextBox
            // 
            this.ClientAddressTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ClientAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientAddressTextBox.Location = new System.Drawing.Point(779, 60);
            this.ClientAddressTextBox.Multiline = true;
            this.ClientAddressTextBox.Name = "ClientAddressTextBox";
            this.ClientAddressTextBox.ReadOnly = true;
            this.ClientAddressTextBox.Size = new System.Drawing.Size(198, 69);
            this.ClientAddressTextBox.TabIndex = 22;
            this.ClientAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientPhoneTextBox
            // 
            this.ClientPhoneTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ClientPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPhoneTextBox.Location = new System.Drawing.Point(500, 60);
            this.ClientPhoneTextBox.Multiline = true;
            this.ClientPhoneTextBox.Name = "ClientPhoneTextBox";
            this.ClientPhoneTextBox.ReadOnly = true;
            this.ClientPhoneTextBox.Size = new System.Drawing.Size(182, 69);
            this.ClientPhoneTextBox.TabIndex = 23;
            this.ClientPhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.OrderIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderIDTextBox.Location = new System.Drawing.Point(112, 12);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.ReadOnly = true;
            this.OrderIDTextBox.Size = new System.Drawing.Size(100, 36);
            this.OrderIDTextBox.TabIndex = 24;
            this.OrderIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(11, 588);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(97, 29);
            this.bunifuCustomLabel9.TabIndex = 25;
            this.bunifuCustomLabel9.Text = "اسم السائق";
            // 
            // TxtOrderNotes
            // 
            this.TxtOrderNotes.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtOrderNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOrderNotes.ForeColor = System.Drawing.Color.DimGray;
            this.TxtOrderNotes.Location = new System.Drawing.Point(13, 627);
            this.TxtOrderNotes.Multiline = true;
            this.TxtOrderNotes.Name = "TxtOrderNotes";
            this.TxtOrderNotes.Size = new System.Drawing.Size(223, 78);
            this.TxtOrderNotes.TabIndex = 13;
            this.TxtOrderNotes.Text = "الملاحظات";
            this.TxtOrderNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOrderNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtOrderNotes_MouseClick);
            this.TxtOrderNotes.Leave += new System.EventHandler(this.TxtOrderNotes_Leave);
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDiscount.Location = new System.Drawing.Point(391, 665);
            this.TxtDiscount.MaxLength = 9;
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(145, 36);
            this.TxtDiscount.TabIndex = 26;
            this.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtDiscount_MouseClick);
            this.TxtDiscount.TextChanged += new System.EventHandler(this.TxtDiscount_TextChanged);
            this.TxtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDiscount_KeyPress);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(425, 633);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(76, 29);
            this.bunifuCustomLabel10.TabIndex = 27;
            this.bunifuCustomLabel10.Text = "التخفيض";
            // 
            // NewCltBtn
            // 
            this.NewCltBtn.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.NewCltBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NewCltBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewCltBtn.BorderRadius = 0;
            this.NewCltBtn.ButtonText = "+";
            this.NewCltBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCltBtn.DisabledColor = System.Drawing.Color.Gray;
            this.NewCltBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewCltBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.NewCltBtn.Iconimage = null;
            this.NewCltBtn.Iconimage_right = null;
            this.NewCltBtn.Iconimage_right_Selected = null;
            this.NewCltBtn.Iconimage_Selected = null;
            this.NewCltBtn.IconMarginLeft = 0;
            this.NewCltBtn.IconMarginRight = 0;
            this.NewCltBtn.IconRightVisible = true;
            this.NewCltBtn.IconRightZoom = 0D;
            this.NewCltBtn.IconVisible = true;
            this.NewCltBtn.IconZoom = 90D;
            this.NewCltBtn.IsTab = false;
            this.NewCltBtn.Location = new System.Drawing.Point(319, 73);
            this.NewCltBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.NewCltBtn.Name = "NewCltBtn";
            this.NewCltBtn.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.NewCltBtn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.NewCltBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NewCltBtn.selected = false;
            this.NewCltBtn.Size = new System.Drawing.Size(65, 40);
            this.NewCltBtn.TabIndex = 28;
            this.NewCltBtn.Text = "+";
            this.NewCltBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewCltBtn.Textcolor = System.Drawing.Color.White;
            this.NewCltBtn.TextFont = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewCltBtn.Click += new System.EventHandler(this.NewCltBtn_Click);
            // 
            // FRM_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 713);
            this.Controls.Add(this.NewCltBtn);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.TxtDiscount);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.ClientPhoneTextBox);
            this.Controls.Add(this.ClientAddressTextBox);
            this.Controls.Add(this.ClientAmountTextBox);
            this.Controls.Add(this.ProdPriceTextBox);
            this.Controls.Add(this.TxtDriver);
            this.Controls.Add(this.TxtReceivedMoney);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.TxtRemainMoney);
            this.Controls.Add(this.TxtOrderNotes);
            this.Controls.Add(this.TxtSumTotals);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.ProdQtyTextBox);
            this.Controls.Add(this.ProdBagsTextBox);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.NewOrderBtn);
            this.Controls.Add(this.DelOrderBtn);
            this.Controls.Add(this.PrintOrderBtn);
            this.Controls.Add(this.SaveOrderBtn);
            this.Controls.Add(this.OrderDatepicker);
            this.Controls.Add(this.OrderDataGrid);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CBProdName);
            this.Controls.Add(this.CBClientName);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.OrderIDLabel);
            this.Font = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FRM_POS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomDataGrid OrderDataGrid;
        public Bunifu.Framework.UI.BunifuCustomLabel OrderIDLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel OrderDateLabel;
        public System.Windows.Forms.ComboBox CBClientName;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        public System.Windows.Forms.ComboBox CBProdName;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public Bunifu.Framework.UI.BunifuDatepicker OrderDatepicker;
        public Bunifu.Framework.UI.BunifuFlatButton SaveOrderBtn;
        public Bunifu.Framework.UI.BunifuFlatButton PrintOrderBtn;
        public Bunifu.Framework.UI.BunifuFlatButton DelOrderBtn;
        public Bunifu.Framework.UI.BunifuFlatButton NewOrderBtn;
        public Bunifu.Framework.UI.BunifuFlatButton AddNewBtn;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox ProdBagsTextBox;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox ProdQtyTextBox;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSumTotals;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox TxtRemainMoney;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        public System.Windows.Forms.RadioButton btnCash;
        public System.Windows.Forms.RadioButton btnDebit;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox TxtReceivedMoney;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDriver;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox ProdPriceTextBox;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox ClientAmountTextBox;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox ClientAddressTextBox;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox ClientPhoneTextBox;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox OrderIDTextBox;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox TxtOrderNotes;
        public System.Windows.Forms.TextBox TxtDiscount;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        public Bunifu.Framework.UI.BunifuFlatButton NewCltBtn;
    }
}