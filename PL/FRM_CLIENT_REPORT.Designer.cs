namespace SaleManagementSystem.PL
{
    partial class FRM_CLIENT_REPORT
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
            this.StatementDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CBClientName = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStatement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddMoney = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PrintStatement = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.StatementDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StatementDataGrid
            // 
            this.StatementDataGrid.AllowDrop = true;
            this.StatementDataGrid.AllowUserToAddRows = false;
            this.StatementDataGrid.AllowUserToDeleteRows = false;
            this.StatementDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatementDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StatementDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatementDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StatementDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.StatementDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatementDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StatementDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatementDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StatementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatementDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.StatementDataGrid.DoubleBuffered = true;
            this.StatementDataGrid.EnableHeadersVisualStyles = false;
            this.StatementDataGrid.GridColor = System.Drawing.Color.White;
            this.StatementDataGrid.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.StatementDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.StatementDataGrid.Location = new System.Drawing.Point(12, 101);
            this.StatementDataGrid.MultiSelect = false;
            this.StatementDataGrid.Name = "StatementDataGrid";
            this.StatementDataGrid.ReadOnly = true;
            this.StatementDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatementDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.StatementDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatementDataGrid.RowTemplate.ReadOnly = true;
            this.StatementDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StatementDataGrid.ShowEditingIcon = false;
            this.StatementDataGrid.Size = new System.Drawing.Size(1192, 600);
            this.StatementDataGrid.TabIndex = 3;
            // 
            // CBClientName
            // 
            this.CBClientName.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CBClientName.FormattingEnabled = true;
            this.CBClientName.Location = new System.Drawing.Point(185, 29);
            this.CBClientName.Name = "CBClientName";
            this.CBClientName.Size = new System.Drawing.Size(239, 42);
            this.CBClientName.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(49, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 34);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = " اسم الزبون";
            // 
            // btnStatement
            // 
            this.btnStatement.Activecolor = System.Drawing.Color.DimGray;
            this.btnStatement.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStatement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatement.BorderRadius = 0;
            this.btnStatement.ButtonText = "كشف الحساب";
            this.btnStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatement.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStatement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatement.Iconimage = null;
            this.btnStatement.Iconimage_right = null;
            this.btnStatement.Iconimage_right_Selected = null;
            this.btnStatement.Iconimage_Selected = null;
            this.btnStatement.IconMarginLeft = 0;
            this.btnStatement.IconMarginRight = 0;
            this.btnStatement.IconRightVisible = true;
            this.btnStatement.IconRightZoom = 0D;
            this.btnStatement.IconVisible = true;
            this.btnStatement.IconZoom = 90D;
            this.btnStatement.IsTab = false;
            this.btnStatement.Location = new System.Drawing.Point(495, 27);
            this.btnStatement.Margin = new System.Windows.Forms.Padding(33, 55, 33, 55);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnStatement.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnStatement.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStatement.selected = false;
            this.btnStatement.Size = new System.Drawing.Size(166, 47);
            this.btnStatement.TabIndex = 6;
            this.btnStatement.Text = "كشف الحساب";
            this.btnStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatement.Textcolor = System.Drawing.Color.White;
            this.btnStatement.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click);
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Activecolor = System.Drawing.Color.DimGray;
            this.btnAddMoney.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMoney.BorderRadius = 0;
            this.btnAddMoney.ButtonText = "ادخال سند قبض";
            this.btnAddMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMoney.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddMoney.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddMoney.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddMoney.Iconimage = null;
            this.btnAddMoney.Iconimage_right = null;
            this.btnAddMoney.Iconimage_right_Selected = null;
            this.btnAddMoney.Iconimage_Selected = null;
            this.btnAddMoney.IconMarginLeft = 0;
            this.btnAddMoney.IconMarginRight = 0;
            this.btnAddMoney.IconRightVisible = true;
            this.btnAddMoney.IconRightZoom = 0D;
            this.btnAddMoney.IconVisible = true;
            this.btnAddMoney.IconZoom = 90D;
            this.btnAddMoney.IsTab = false;
            this.btnAddMoney.Location = new System.Drawing.Point(709, 27);
            this.btnAddMoney.Margin = new System.Windows.Forms.Padding(33, 55, 33, 55);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnAddMoney.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnAddMoney.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddMoney.selected = false;
            this.btnAddMoney.Size = new System.Drawing.Size(166, 47);
            this.btnAddMoney.TabIndex = 6;
            this.btnAddMoney.Text = "ادخال سند قبض";
            this.btnAddMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMoney.Textcolor = System.Drawing.Color.White;
            this.btnAddMoney.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // PrintStatement
            // 
            this.PrintStatement.Activecolor = System.Drawing.Color.DimGray;
            this.PrintStatement.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PrintStatement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintStatement.BorderRadius = 0;
            this.PrintStatement.ButtonText = "طباعة الكشف";
            this.PrintStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintStatement.DisabledColor = System.Drawing.Color.Gray;
            this.PrintStatement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintStatement.Iconcolor = System.Drawing.Color.Transparent;
            this.PrintStatement.Iconimage = null;
            this.PrintStatement.Iconimage_right = null;
            this.PrintStatement.Iconimage_right_Selected = null;
            this.PrintStatement.Iconimage_Selected = null;
            this.PrintStatement.IconMarginLeft = 0;
            this.PrintStatement.IconMarginRight = 0;
            this.PrintStatement.IconRightVisible = true;
            this.PrintStatement.IconRightZoom = 0D;
            this.PrintStatement.IconVisible = true;
            this.PrintStatement.IconZoom = 90D;
            this.PrintStatement.IsTab = false;
            this.PrintStatement.Location = new System.Drawing.Point(926, 27);
            this.PrintStatement.Margin = new System.Windows.Forms.Padding(33, 55, 33, 55);
            this.PrintStatement.Name = "PrintStatement";
            this.PrintStatement.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.PrintStatement.OnHovercolor = System.Drawing.Color.DimGray;
            this.PrintStatement.OnHoverTextColor = System.Drawing.Color.White;
            this.PrintStatement.selected = false;
            this.PrintStatement.Size = new System.Drawing.Size(166, 47);
            this.PrintStatement.TabIndex = 6;
            this.PrintStatement.Text = "طباعة الكشف";
            this.PrintStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintStatement.Textcolor = System.Drawing.Color.White;
            this.PrintStatement.TextFont = new System.Drawing.Font("PNU Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintStatement.Click += new System.EventHandler(this.PrintStatement_Click);
            // 
            // FRM_CLIENT_REPORT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 713);
            this.ControlBox = false;
            this.Controls.Add(this.PrintStatement);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.btnStatement);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CBClientName);
            this.Controls.Add(this.StatementDataGrid);
            this.Font = new System.Drawing.Font("PNU Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CLIENT_REPORT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_CLIENT_REPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatementDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid StatementDataGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatement;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddMoney;
        public System.Windows.Forms.ComboBox CBClientName;
        private Bunifu.Framework.UI.BunifuFlatButton PrintStatement;
    }
}