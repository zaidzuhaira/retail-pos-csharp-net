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
    public partial class FRM_MAIN : Form
    {
        FRM_PRODUCT TempProd = new FRM_PRODUCT();
        FRM_COSTUMER TempClient = new FRM_COSTUMER();
        FRM_POS TempPOS = new FRM_POS();
        FRM_ORDERS TempOrder = new FRM_ORDERS();
        FRM_BACKUP TempBackup = new FRM_BACKUP();
        private static FRM_MAIN frm;
        static void frm_FormClosed(Object sender , FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
            return frm;
            }
        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

        }
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "المبيعات";
            P_HOME.SendToBack();
            P_MAIN.Controls.Clear();
            TempPOS.TopLevel = false;
            TempPOS.FRM_POS_Load(null, null);
            P_MAIN.Controls.Add(TempPOS);
            TempPOS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "المنتجات";
            P_HOME.SendToBack();
            P_MAIN.Controls.Clear();
            TempProd.TopLevel = false;
            TempProd.RefreshDataGrid();
            P_MAIN.Controls.Add(TempProd);
            TempProd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "الزبائن";
            P_HOME.SendToBack();
            P_MAIN.Controls.Clear();
            TempClient.TopLevel = false;
            TempClient.RefreshDataGrid();
            P_MAIN.Controls.Add(TempClient); 
            TempClient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = "الرئيسية";
            P_HOME.BringToFront();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.label1.Text = "الفواتير";
            P_HOME.SendToBack();
            P_MAIN.Controls.Clear();
            TempOrder.TopLevel = false;
            TempOrder.RefreshDataGrid();
            P_MAIN.Controls.Add(TempOrder);
            TempOrder.Show();
        }

        private void btnShowNewOrder_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void btnShowNewClient_Click(object sender, EventArgs e)
        {
            FRM_NEW_COSTUMER frm = new FRM_NEW_COSTUMER();
            frm.ShowDialog();
        }

        private void btnShowNewProduct_Click(object sender, EventArgs e)
        {
            FRM_NEW_PRODUCT frm = new FRM_NEW_PRODUCT();
            frm.ShowDialog();
        }

        private void btnShowNewPrice_Click(object sender, EventArgs e)
        {
            FRM_NEW_PRICE frm = new FRM_NEW_PRICE();
            frm.ShowDialog();
        }

        private void btnShowClientReport_Click(object sender, EventArgs e)
        {
            PL.FRM_CLIENT_REPORT CltRpt = new FRM_CLIENT_REPORT();
            FRM_MAIN.getMainForm.label1.Text = ("كشف حساب الزبون");
            P_HOME.SendToBack();
            FRM_MAIN.getMainForm.P_MAIN.Controls.Clear();
            CltRpt.TopLevel = false;
            FRM_MAIN.getMainForm.P_MAIN.Controls.Add(CltRpt);
            CltRpt.Show();
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            ADD_CLT_MONEY frm = new ADD_CLT_MONEY();
            frm.ShowDialog();
        }

        private void btnNewBackup_Click(object sender, EventArgs e)
        {
            this.label1.Text = "النسخ الاحتياطي";
            P_HOME.SendToBack();
            P_MAIN.Controls.Clear();
            TempBackup.TopLevel = false;
            P_MAIN.Controls.Add(TempBackup);
            TempBackup.Show();
        }
    }
}
