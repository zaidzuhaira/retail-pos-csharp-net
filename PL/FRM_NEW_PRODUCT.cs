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
    public partial class FRM_NEW_PRODUCT : Form
    {
        BL.CLS_PRODUCT cs_add = new BL.CLS_PRODUCT();
        public string state = "add";
        public string number;
        public FRM_NEW_PRODUCT()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        { if (state == "add")
            {
                DataTable dt = cs_add.Get_Last_Value();
                number = dt.Rows[0][0].ToString();
                int ID = int.Parse(number);
                ID += 1;
                cs_add.Add_New_Product(ID.ToString(), ProdNameText.Text, int.Parse(ProdPriceText.Text), int.Parse(ProdQtyText.Text), int.Parse(ProdBagText.Text));
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (state == "edit")
            {
                cs_add.Update_Product(number, ProdNameText.Text, int.Parse(ProdPriceText.Text), int.Parse(ProdQtyText.Text), int.Parse(ProdBagText.Text));
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
