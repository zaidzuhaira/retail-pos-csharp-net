using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementSystem.PL
{
    public partial class FRM_CLIENT_REPORT : Form
    {
        public FRM_CLIENT_REPORT()
        {
            InitializeComponent();
            PrintStatement.Enabled = false;
        }
        public class ClientInfo
        {
            public string ClientName { get; set; }
            public int ClientID { get; set; }
        }
        public DataTable CreateDataSource()
        {
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
            DataTable Dt = new DataTable();
            Dt = cs_order.Search_Orders(Clt.ClientName);
            Dt.Columns.RemoveAt(2);
            foreach (DataRow row in (cs_costumer.Get_Client_State(Clt.ClientID).Rows))
            {
                Dt.Rows.Add(null, row["Date"], null, row["Recieved_Amount"], null, row["Notes"]);
            }
            return Dt;
        }
        BL.CLS_COSTUMER cs_costumer = new BL.CLS_COSTUMER();
        BL.CLS_ORDER cs_order = new BL.CLS_ORDER();
        public string CltName;
        private void FRM_CLIENT_REPORT_Load(object sender, EventArgs e)
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

        private void btnStatement_Click(object sender, EventArgs e)
        {
            StatementDataGrid.DataSource = CreateDataSource();
            PrintStatement.Enabled = true;
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
            PL.ADD_CLT_MONEY frm = new ADD_CLT_MONEY();
            frm.CltName = Clt.ClientName;
            frm.CBClientName.Enabled = false;
            frm.ShowDialog();
            StatementDataGrid.DataSource = CreateDataSource();
        }

        private void PrintStatement_Click(object sender, EventArgs e)
        {
            RPT.ClientStatementReport report1 = new RPT.ClientStatementReport();
            report1.SetDataSource(CreateDataSource());
            report1.SetParameterValue(1, CBClientName.Text);
            PrintDialog dialog1 = new PrintDialog();

            if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int copies = dialog1.PrinterSettings.Copies;
                int fromPage = dialog1.PrinterSettings.FromPage;
                int toPage = dialog1.PrinterSettings.ToPage;
                bool collate = dialog1.PrinterSettings.Collate;

                report1.PrintOptions.PrinterName = dialog1.PrinterSettings.PrinterName;
                report1.PrintToPrinter(copies, collate, fromPage, toPage);
            }

            report1.Dispose();
            dialog1.Dispose();
        }
    }
}
