using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementSystem.PL
{
    public partial class FRM_CLIENT : Form
    {
        BL.CLS_COSTUMER cs_price = new BL.CLS_COSTUMER();
        BL.CLS_PRODUCT cs_product = new BL.CLS_PRODUCT();
        public int id;
        public string MyText;
        public FRM_CLIENT()
        {
            InitializeComponent();
        }
        private void FRM_CLIENT_Load(object sender, EventArgs e)
        {
            CustomPriceDataGrid.DataSource = cs_price.Client_Price(id);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FRM_NEW_PRICE frm_new = new FRM_NEW_PRICE();
            frm_new.ClientName = MyText;
            frm_new.comboBox2.Enabled = false;
            frm_new.ShowDialog();
            CustomPriceDataGrid.DataSource = cs_price.Client_Price(id);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف العنصر المحدد؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable dtp = new DataTable();
                dtp = cs_product.Get_Id_product(this.CustomPriceDataGrid.CurrentRow.Cells[0].Value.ToString());
                string id_product = dtp.Rows[0][0].ToString();
                cs_price.DELETE_CLIENT_PRICE(id,id_product);
                CustomPriceDataGrid.DataSource = cs_price.Client_Price(id);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FRM_NEW_PRICE frm_edit = new FRM_NEW_PRICE();
            frm_edit.NewPriceTitle.Text = "تعديل سعر: " + this.CustomPriceDataGrid.CurrentRow.Cells[0].Value.ToString();
            frm_edit.bunifuFlatButton3.Text = "تعديل";
            frm_edit.state = "edit";
            frm_edit.ClientName = MyText;
            frm_edit.ProdName = this.CustomPriceDataGrid.CurrentRow.Cells[0].Value.ToString();
            frm_edit.comboBox2.Enabled = false;
            frm_edit.comboBox1.Enabled = false;
            frm_edit.ShowDialog();
            CustomPriceDataGrid.DataSource = cs_price.Client_Price(id);
        }
    }
}
