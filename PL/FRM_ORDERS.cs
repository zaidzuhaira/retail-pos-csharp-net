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
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDER cs_order = new BL.CLS_ORDER();
        public void RefreshDataGrid()
        {
            OrdersListGrid.DataSource = cs_order.Search_Orders("");
        }
        public FRM_ORDERS()
        {
            InitializeComponent();
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {
            OrdersListGrid.DataSource = cs_order.Search_Orders("");
        }

        private void TxtSearchOrder_OnValueChanged(object sender, EventArgs e)
        {
            OrdersListGrid.DataSource = cs_order.Search_Orders(TxtSearchOrder.Text);
        }

        private void btnPrintSelectQrder_Click(object sender, EventArgs e)
        {
            int Order_ID = Convert.ToInt32(OrdersListGrid.CurrentRow.Cells[0].Value);
            RPT.OrderCrystalReport report = new RPT.OrderCrystalReport();
            RPT.FORM_ORDER_RPT frm = new RPT.FORM_ORDER_RPT();
            report.SetDataSource(cs_order.GetOrderDetails(Order_ID));
            frm.crystalReportViewer1.ReportSource = report;
            frm.crystalReportViewer1.RightToLeft = RightToLeft.Yes;
            frm.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int Order_ID = Convert.ToInt32(OrdersListGrid.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("هل انت متأكد من حذف العنصر المحدد؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cs_order.ADD_CLIENT_REMAIN(-1,(-Convert.ToDecimal(OrdersListGrid.CurrentRow.Cells[5].Value)),OrdersListGrid.CurrentRow.Cells[2].Value.ToString());
                cs_order.Delete_Order(Order_ID);
                cs_order.DELETE_ORDER_DETAILS(Order_ID);
                OrdersListGrid.DataSource = cs_order.Search_Orders("");
            }
        }

        private void btnEditSelectOrder_Click(object sender, EventArgs e)
        {
            PL.FRM_POS POS = new PL.FRM_POS();
            int Order_ID = Convert.ToInt32(OrdersListGrid.CurrentRow.Cells[0].Value);
            DataTable Dt = new DataTable();
            Dt = cs_order.GetOrderDetails(Order_ID);
            POS.OrderID = Dt.Rows[0][5].ToString();
            POS.CltName = Dt.Rows[0][18].ToString();
            POS.CBClientName.Enabled = false;
            POS.TxtDiscount.Text = Dt.Rows[0][17].ToString();
            POS.TxtSumTotals.Text = Dt.Rows[0][14].ToString();
            POS.TxtReceivedMoney.Text = Dt.Rows[0][15].ToString();
            POS.TxtRemainMoney.Text = Dt.Rows[0][16].ToString();
            POS.TxtDriver.Text = Dt.Rows[0][13].ToString();
            POS.TxtOrderNotes.Text = Dt.Rows[0][12].ToString();
            POS.OrderDatepicker.Value = Convert.ToDateTime(Dt.Rows[0][7]);
            foreach (DataRow row in Dt.Rows)
            {

                POS.Bill.Rows.Add(row["اسم المنتج"], row["العدد"], row["الكمية"], row["سعر المفرد"], row["المجموع"]);
            }
            POS.btnMode = "edit";
            POS.SaveOrderBtn.Text = "تعديل الفاتورة";
            POS.NewOrderBtn.Enabled = false;
            POS.DelOrderBtn.Enabled = true;
            POS.PrintOrderBtn.Enabled = true;
            POS.LastRemainMoney = Convert.ToDecimal(Dt.Rows[0][16]);
            FRM_MAIN.getMainForm.label1.Text = ("تعديل الفاتورة");
            FRM_MAIN.getMainForm.P_MAIN.Controls.Clear();
            POS.TopLevel = false;
            FRM_MAIN.getMainForm.P_MAIN.Controls.Add(POS);
            POS.Show();
        }
    }
}
