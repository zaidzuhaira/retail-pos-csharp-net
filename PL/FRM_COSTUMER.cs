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
    public partial class FRM_COSTUMER : Form
    {
        BL.CLS_COSTUMER cs_client = new BL.CLS_COSTUMER();
        
        public FRM_COSTUMER()
        {
            InitializeComponent();
        }
        public void RefreshDataGrid()
        {
            ClientDataGrid.DataSource = cs_client.Get_All_Costumers();
        }
        private void FRM_COSTUMER_Load(object sender, EventArgs e)
        {
            ClientDataGrid.DataSource = cs_client.Get_All_Costumers();
    }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            ClientDataGrid.DataSource = cs_client.Search_Costumers(bunifuMaterialTextbox1.Text);
        }

        private void DelClinetBtn_Click(object sender, EventArgs e)
        {
            if(ClientDataGrid.CurrentRow.Cells[0].Value.ToString() == "1") { MessageBox.Show("لا يمكن حذف الزبون النقدي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (MessageBox.Show("هل انت متأكد من حذف العنصر المحدد؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cs_client.DELETE_COSTUMER(ClientDataGrid.CurrentRow.Cells[0].Value.ToString());

                ClientDataGrid.DataSource = cs_client.Get_All_Costumers();
            }
        }
        private void DetlClientBtn_Click(object sender, EventArgs e)
        {
            FRM_CLIENT frm_client = new FRM_CLIENT();
            frm_client.id = int.Parse(ClientDataGrid.CurrentRow.Cells[0].Value.ToString());
            frm_client.bunifuCustomLabel3.Text = ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
            frm_client.MyText = ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
            frm_client.ShowDialog();
        }

        private void NewClientBtn_Click(object sender, EventArgs e)
        {
            FRM_NEW_COSTUMER frm = new FRM_NEW_COSTUMER();
            frm.ShowDialog();
            ClientDataGrid.DataSource = cs_client.Get_All_Costumers();
        }

        private void EditClientBtn_Click(object sender, EventArgs e)
        {
            FRM_NEW_COSTUMER frm_edit = new FRM_NEW_COSTUMER();
            frm_edit.ClientNameText.Text = this.ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
            frm_edit.ClientPhoneText.Text = this.ClientDataGrid.CurrentRow.Cells[3].Value.ToString();
            frm_edit.ClientAddressText.Text = this.ClientDataGrid.CurrentRow.Cells[4].Value.ToString();
            frm_edit.NewClientTitle.Text = "تعديل الزبون: " + this.ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
            frm_edit.bunifuFlatButton1.Text = "تعديل";
            frm_edit.state = "edit";
            frm_edit.id = int.Parse(this.ClientDataGrid.CurrentRow.Cells[0].Value.ToString());
            frm_edit.CLientAmountText.Text = this.ClientDataGrid.CurrentRow.Cells[2].Value.ToString();
            frm_edit.CLientAmountText.Enabled = false;
            frm_edit.ShowDialog();
            ClientDataGrid.DataSource = cs_client.Get_All_Costumers();
        }

        private void btnCltReport_Click(object sender, EventArgs e)
        {
            PL.FRM_CLIENT_REPORT CltRpt = new FRM_CLIENT_REPORT();
            CltRpt.CltName = ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
            CltRpt.CBClientName.Enabled = false;
            FRM_MAIN.getMainForm.label1.Text = ("كشف حساب الزبون");
            FRM_MAIN.getMainForm.P_MAIN.Controls.Clear();
            CltRpt.TopLevel = false;
            FRM_MAIN.getMainForm.P_MAIN.Controls.Add(CltRpt);
            CltRpt.Show();
        }
    }
}
