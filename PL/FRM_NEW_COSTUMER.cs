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
    public partial class FRM_NEW_COSTUMER : Form
    {
        BL.CLS_COSTUMER new_client = new BL.CLS_COSTUMER();
        public string state = "add";
        public int id;
        public FRM_NEW_COSTUMER()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (CLientAmountText.Text == "")
            {
                CLientAmountText.Text = "0";
            }
            if (state == "add")
            {
                new_client.Add_New_Costumer(ClientNameText.Text, decimal.Parse(CLientAmountText.Text), ClientPhoneText.Text, ClientAddressText.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (state == "edit")
            {
                new_client.Update_Costumer(id, ClientNameText.Text, ClientPhoneText.Text, ClientAddressText.Text);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
