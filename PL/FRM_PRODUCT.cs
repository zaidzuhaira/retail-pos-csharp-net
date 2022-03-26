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
    public partial class FRM_PRODUCT : Form
    {
        BL.CLS_PRODUCT cs_prod = new BL.CLS_PRODUCT();
        public FRM_PRODUCT()
        {
            InitializeComponent();
        }
        public void RefreshDataGrid()
        {
            ProductDataGrid.DataSource = cs_prod.Get_All_Product();
        }
        private void FRM_PRODUCT_Load(object sender, EventArgs e)
        {
            ProductDataGrid.DataSource = cs_prod.Get_All_Product();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            ProductDataGrid.DataSource = cs_prod.Search_Product(bunifuMaterialTextbox1.Text);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FRM_NEW_PRODUCT Add_Window = new FRM_NEW_PRODUCT();
            Add_Window.ShowDialog();
            ProductDataGrid.DataSource = cs_prod.Get_All_Product();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف العنصر المحدد؟" , "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                cs_prod.Delete_Product(ProductDataGrid.CurrentRow.Cells[0].Value.ToString());
                ProductDataGrid.DataSource = cs_prod.Get_All_Product();
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            FRM_NEW_PRODUCT frm = new FRM_NEW_PRODUCT();
            frm.ProdNameText.Text = this.ProductDataGrid.CurrentRow.Cells[1].Value.ToString();
            frm.ProdPriceText.Text = this.ProductDataGrid.CurrentRow.Cells[2].Value.ToString();
            frm.ProdQtyText.Text = this.ProductDataGrid.CurrentRow.Cells[3].Value.ToString();
            frm.ProdBagText.Text = this.ProductDataGrid.CurrentRow.Cells[4].Value.ToString();
            frm.NewProdTitle.Text = "تعديل المنتج: " + this.ProductDataGrid.CurrentRow.Cells[1].Value.ToString();
            frm.bunifuFlatButton1.Text = "تعديل";
            frm.state = "edit";
            frm.number = this.ProductDataGrid.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            ProductDataGrid.DataSource = cs_prod.Get_All_Product();
        }
    }
}
