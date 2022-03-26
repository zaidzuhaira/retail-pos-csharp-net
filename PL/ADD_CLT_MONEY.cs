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
    public partial class ADD_CLT_MONEY : Form
    {
        public ADD_CLT_MONEY()
        {
            InitializeComponent();
        }
        public class ClientInfo
        {
            public string ClientName { get; set; }
            public int ClientID { get; set; }
        }
        BL.CLS_COSTUMER cs_costumer = new BL.CLS_COSTUMER();
        BL.CLS_ORDER cs_order = new BL.CLS_ORDER();
        public string CltName;

        private void ADD_CLT_MONEY_Load(object sender, EventArgs e)
        {
            DataTable dtc = new DataTable();
            dtc = cs_costumer.Get_All_Costumers();
            List<ClientInfo> idsc = new List<ClientInfo>(dtc.Rows.Count);
            foreach (DataRow row in dtc.Rows)
                idsc.Add(new ClientInfo() { ClientName = (string)row["اسم الزبون"], ClientID = Convert.ToInt32(row["معرف الزبون"]) });
            CBClientName.DataSource = idsc;
            CBClientName.DisplayMember = "ClientName";
            if (CltName != null)
            {
                CBClientName.SelectedIndex = CBClientName.FindStringExact(CltName);
            }
            CBClientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBClientName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
            cs_costumer.Save_Client_State(Clt.ClientID, DateTime.Today.Date, Convert.ToDecimal(TxtRecievedAmount.Text), TxtNotes.Text);
            cs_order.ADD_CLIENT_REMAIN(Clt.ClientID, (-Convert.ToDecimal(TxtRecievedAmount.Text)), Clt.ClientName);
            MessageBox.Show("تم الادخال بنجاح", "ادخال السند", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RPT.CostumerCrystalReport report = new RPT.CostumerCrystalReport();
            RPT.FRM_CLT_RPT frm = new RPT.FRM_CLT_RPT();
            report.SetParameterValue(0, this.TxtRecievedAmount.Text);
            report.SetParameterValue(1, DateTime.Today);
            report.SetParameterValue(2, this.TxtNotes.Text);
            report.SetParameterValue(3, Clt.ClientName);
            frm.clientReportViewe1.ReportSource = report;
            frm.ShowDialog();
            this.Close();
        }
    }
}
