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
    public partial class FRM_NEW_PRICE : Form
    {
        BL.CLS_PRODUCT cs_product = new BL.CLS_PRODUCT();
        BL.CLS_COSTUMER cs_costumer = new BL.CLS_COSTUMER();
        public string ClientName;
        public string ProdName;
        public string state = "add";
        public class ProdInfo
        {
            public string ProdName { get; set; }
            public string ProdID { get; set; }
        }
        public class ClientInfo
        {
            public string ClientName { get; set; }
            public int ClientID { get; set; }
        }
        public FRM_NEW_PRICE()
        {
            InitializeComponent();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ProdInfo Prod = comboBox1.SelectedItem as ProdInfo;
            ClientInfo Clt = comboBox2.SelectedItem as ClientInfo;
            if (state == "add")
            { 
            cs_costumer.NEW_COSTUMER_PRICE(Clt.ClientID,Prod.ProdName,int.Parse(bunifuCustomTextbox1.Text), Prod.ProdID);
            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(state == "edit")
            {
            cs_costumer.UPDATE_CLIENT_PRICE(Clt.ClientID,Prod.ProdID, int.Parse(bunifuCustomTextbox1.Text));
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void FRM_NEW_PRICE_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cs_product.Get_All_Product();
            List<ProdInfo> ids = new List<ProdInfo>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
                ids.Add(new ProdInfo() { ProdName = (string)row["اسم المنتج"], ProdID = (string)row["رقم المنتج"] });
            comboBox1.DataSource = ids;
            comboBox1.DisplayMember = "ProdName";
            if (ProdName != null)
            {
                comboBox1.SelectedIndex = comboBox1.FindStringExact(ProdName);
            }

            DataTable dtc = new DataTable();
            dtc = cs_costumer.Get_All_Costumers();
            List<ClientInfo> idsc = new List<ClientInfo>(dtc.Rows.Count);
            foreach (DataRow row in dtc.Rows)
                idsc.Add(new ClientInfo() { ClientName = (string)row["اسم الزبون"], ClientID = Convert.ToInt32(row["معرف الزبون"]) });
            comboBox2.DataSource = idsc;
            comboBox2.DisplayMember = "ClientName";
            if (ClientName != null)
            {
                comboBox2.SelectedIndex = comboBox2.FindStringExact(ClientName);
            }
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
