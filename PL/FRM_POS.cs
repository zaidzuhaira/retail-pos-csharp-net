using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CrystalDecisions.Shared;

namespace SaleManagementSystem.PL
{
    public partial class FRM_POS : Form
    {
        BL.CLS_ORDER cs_order = new BL.CLS_ORDER();
        BL.CLS_PRODUCT cs_product = new BL.CLS_PRODUCT();
        BL.CLS_COSTUMER cs_costumer = new BL.CLS_COSTUMER();
        public string CltName;
        public string OrderID;
        public string btnMode = "add";
        public decimal LastRemainMoney;
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
        public DataTable Bill = new DataTable();
        void CreateDataTable()
        {
            Bill.Columns.Add("اسم المنتج");
            Bill.Columns.Add("العدد");
            Bill.Columns.Add("الكمية");
            Bill.Columns.Add("سعر المفرد");
            Bill.Columns.Add("المجموع");
            OrderDataGrid.DataSource = Bill;
            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            btn.Image = global::SaleManagementSystem.Properties.Resources.delete_sign_40px;
            OrderDataGrid.Columns.Add(btn);
            btn.HeaderText = "ازالة المنتج";
            OrderDatepicker.Value = DateTime.Today;
        }
        void ClearProdBoxes()
        {
            CBProdName.SelectedItem = null;
            ProdQtyTextBox.Clear();
            ProdBagsTextBox.Clear();
            ProdPriceTextBox.Text = string.Empty;
        }
        void ClearClientBoxes()
        {
            CBClientName.SelectedItem = null;
            ClientAmountTextBox.Clear();
            ClientAddressTextBox.Clear();
            ClientPhoneTextBox.Clear();
        }
        void ClearOrderBoxes()
        {
            TxtDriver.Clear();
            TxtOrderNotes.Clear();
            TxtDiscount.Clear();
            TxtSumTotals.Clear();
            TxtRemainMoney.Clear();
            TxtReceivedMoney.Clear();
            Bill.Rows.Clear();
            OrderDataGrid.Refresh();
        }
        void SumAllAmount()
        {
            TxtSumTotals.Text = (from DataGridViewRow row in OrderDataGrid.Rows
                                 where row.Cells[5].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            if(btnCash.Checked == true)
            {
                btnCash_CheckedChanged(null, null);
            }
            else if(btnDebit.Checked == true)
            {
                btnDebit_CheckedChanged(null, null);
            }
        }
        public FRM_POS()
        {
            InitializeComponent();
            CreateDataTable();
            DelOrderBtn.Enabled = false;
            PrintOrderBtn.Enabled = false;
        }

        public void FRM_POS_Load(object sender, EventArgs e)
        {
            if (OrderID != null)
                OrderIDTextBox.Text = OrderID;
            else
                OrderIDTextBox.Text = (int.Parse(cs_order.Get_Last_ID().Rows[0][0].ToString()) + 1).ToString();
            DataTable dt = new DataTable();
            dt = cs_product.Get_All_Product();
            List<ProdInfo> ids = new List<ProdInfo>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
                ids.Add(new ProdInfo() { ProdName = (string)row["اسم المنتج"], ProdID = (string)row["رقم المنتج"] });
            CBProdName.DataSource = ids;
            CBProdName.DisplayMember = "ProdName";

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
        }
        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            OrderIDTextBox.Text = (int.Parse(cs_order.Get_Last_ID().Rows[0][0].ToString()) + 1).ToString();
            ClearClientBoxes();
            ClearProdBoxes();
            ClearOrderBoxes();
            CBClientName.Focus();
            PrintOrderBtn.Enabled = false;
            SaveOrderBtn.Enabled = true;
        }
        private void CBClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CBClientName.DroppedDown = true;
            CBClientName.DropDownHeight = 150;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            string str = CBClientName.Text.Substring(0, CBClientName.SelectionStart) + e.KeyChar;
            Int32 index = CBClientName.FindStringExact(str);
            if (index == -1)
            {
                index = CBClientName.FindString(str);
            }
            this.CBClientName.SelectedIndex = index;
            this.CBClientName.SelectionStart = str.Length;
            this.CBClientName.SelectionLength = this.CBClientName.Text.Length - this.CBClientName.SelectionStart;
            e.Handled = true;

        }
        bool IsMouse = false;
        private void CBClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
            if (IsMouse)
            {
                if (Clt != null)
                {
                    ClientAmountTextBox.Text = cs_order.Get_Costumer_Info(Clt.ClientID).Rows[0][0].ToString();
                    ClientPhoneTextBox.Text = cs_order.Get_Costumer_Info(Clt.ClientID).Rows[0][1].ToString();
                    ClientAddressTextBox.Text = cs_order.Get_Costumer_Info(Clt.ClientID).Rows[0][2].ToString();
                }
            }
            else
            {
                if (Clt != null)
                {
                    ClientAmountTextBox.Text = cs_order.Get_Costumer_Info(Clt.ClientID).Rows[0][0].ToString();
                    ClientPhoneTextBox.Text = cs_order.Get_Costumer_Info(Clt.ClientID).Rows[0][1].ToString();
                    ClientAddressTextBox.Text = cs_order.Get_Costumer_Info(Clt.ClientID).Rows[0][2].ToString();
                }
            }

            IsMouse = false;
            ClearProdBoxes();
            if (btnMode == "add")
            {
                if (Clt != null && Clt.ClientID == 1)
                {
                    btnCash.Checked = true;
                    btnDebit.Enabled = false;
                    TxtReceivedMoney.ReadOnly = true;
                }
                else
                {
                    btnDebit.Checked = true;
                    TxtReceivedMoney.ReadOnly = false;
                }
            }
        }
        private void CBProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdInfo Prod = CBProdName.SelectedItem as ProdInfo;
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
            if (IsMouse)
            {
                if (Clt != null && Prod != null)
                {
                    if ((cs_order.Get_Costumer_Price(Clt.ClientID, Prod.ProdID) != null && cs_order.Get_Costumer_Price(Clt.ClientID, Prod.ProdID).Rows.Count > 0))
                    {
                        ProdPriceTextBox.Text = cs_order.Get_Costumer_Price(Clt.ClientID, Prod.ProdID).Rows[0][0].ToString();
                        ProdQtyTextBox.Text = "1";
                        ProdBagsTextBox.Text = cs_order.Get_Product_Info(Prod.ProdID).Rows[0][2].ToString();
                    }
                    else
                    {
                        ProdPriceTextBox.Text = cs_order.Get_Product_Info(Prod.ProdID).Rows[0][0].ToString();
                        ProdQtyTextBox.Text = "1";
                        ProdBagsTextBox.Text = cs_order.Get_Product_Info(Prod.ProdID).Rows[0][2].ToString();
                    }
                }
            }
            else
            {
                if (Clt != null && Prod != null)
                {
                    if ((cs_order.Get_Costumer_Price(Clt.ClientID, Prod.ProdID) != null && cs_order.Get_Costumer_Price(Clt.ClientID, Prod.ProdID).Rows.Count > 0))
                    {
                        ProdPriceTextBox.Text = cs_order.Get_Costumer_Price(Clt.ClientID, Prod.ProdID).Rows[0][0].ToString();
                        ProdQtyTextBox.Text = "1";
                        ProdBagsTextBox.Text = cs_order.Get_Product_Info(Prod.ProdID).Rows[0][2].ToString();
                    }
                    else
                    {
                        ProdPriceTextBox.Text = cs_order.Get_Product_Info(Prod.ProdID).Rows[0][0].ToString();
                        ProdQtyTextBox.Text = "1";
                        ProdBagsTextBox.Text = cs_order.Get_Product_Info(Prod.ProdID).Rows[0][2].ToString();
                    }
                }
            }
            IsMouse = false;
        }

        private void CBProdName_MouseCaptureChanged(object sender, EventArgs e)
        {
            IsMouse = true;
        }

        private void ProdQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            ProdInfo Prod = CBProdName.SelectedItem as ProdInfo;
            if (Prod != null)
            {
                int Qty;
                Int32.TryParse(ProdQtyTextBox.Text, out Qty);
                int bags = int.Parse(cs_order.Get_Product_Info(Prod.ProdID).Rows[0][2].ToString());
                ProdBagsTextBox.Text = (Qty * bags).ToString();
            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            if (CBClientName.SelectedItem != null && CBProdName.SelectedItem != null && ProdQtyTextBox.Text != string.Empty && ProdBagsTextBox.Text != string.Empty && ProdPriceTextBox.Text != string.Empty)
            {
                ProdInfo Prod = CBProdName.SelectedItem as ProdInfo;
                if (cs_order.Verify_Prod_Qty(Prod.ProdID, int.Parse(ProdQtyTextBox.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية المدخلة غير متوفرة في المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var dataSource = OrderDataGrid.DataSource as BindingSource;
                // flag so we know if there was one dupe
                bool updated = false;

                // go through every row
                foreach (DataGridViewRow row in OrderDataGrid.Rows)
                {
                    // check if there already is a row with the same id
                    if (row.Cells[1].Value.ToString() == Prod.ProdName)
                    {
                        // update your row
                        row.Cells[2].Value = ProdQtyTextBox.Text;
                        row.Cells[3].Value = ProdBagsTextBox.Text;
                        row.Cells[4].Value = ProdPriceTextBox.Text;
                        row.Cells[5].Value = (int.Parse(ProdBagsTextBox.Text) * int.Parse(ProdPriceTextBox.Text)).ToString();
                        updated = true;
                        break; // no need to go any further
                    }
                }

                // if not found, so it's a new one
                if (!updated)
                {
                    double Amount = Convert.ToInt32(ProdBagsTextBox.Text) * Convert.ToDouble(ProdPriceTextBox.Text);
                    Bill.Rows.Add(Prod.ProdName, ProdQtyTextBox.Text, ProdBagsTextBox.Text, ProdPriceTextBox.Text, (Amount).ToString());
                }
                SumAllAmount();
                ClearProdBoxes();
                CBProdName.Focus();
            }
        }

        private void OrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == OrderDataGrid.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == 0)
            {
                int row = OrderDataGrid.CurrentCell.RowIndex;
                OrderDataGrid.Rows.RemoveAt(row);
                SumAllAmount();
            }
        }

        private void OrderDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CBProdName.SelectedIndex = CBProdName.FindStringExact(OrderDataGrid.CurrentRow.Cells[1].Value.ToString());
            ProdQtyTextBox.Text = OrderDataGrid.CurrentRow.Cells[2].Value.ToString();
            ProdBagsTextBox.Text = OrderDataGrid.CurrentRow.Cells[3].Value.ToString();
            ProdPriceTextBox.Text = OrderDataGrid.CurrentRow.Cells[4].Value.ToString();
            ProdQtyTextBox.SelectionStart = 0;
            ProdQtyTextBox.SelectionLength = 8;
        }

        private void OrderDataGrid_Enter(object sender, EventArgs e)
        {
            ProdQtyTextBox.Focus();
        }

        private void CBProdName_DropDownClosed(object sender, EventArgs e)
        {
            ProdQtyTextBox.Focus();
        }

        private void CBClientName_DropDownClosed(object sender, EventArgs e)
        {
            CBProdName.Focus();
        }

        private void ProdQtyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNewBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void OrderDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            OrderDataGrid.ClearSelection();
        }

        private void ProdQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ProdQtyTextBox_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () {
                ProdQtyTextBox.SelectAll();
            });
        }

        private void ProdPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void btnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSumTotals.Text != string.Empty)
            {
                TxtRemainMoney.Text = "0";
                TxtReceivedMoney.Text = TxtSumTotals.Text;
            }
        }

        private void btnDebit_CheckedChanged(object sender, EventArgs e)
        {
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
                if (CBClientName.SelectedItem != null) {
                    if (TxtSumTotals.Text != string.Empty)
                    {
                        TxtReceivedMoney.Text = "0";
                        TxtRemainMoney.Text = TxtSumTotals.Text;
                    }
                }
                else
                {
                    btnCash.Checked = true;
                }
        }

        private void TxtReceivedMoney_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () {
                TxtReceivedMoney.SelectAll();
            });
        }

        private void TxtReceivedMoney_TextChanged(object sender, EventArgs e)
        { 
            if (TxtSumTotals.Text != string.Empty && TxtReceivedMoney.Text != string.Empty && TxtDiscount.Text == string.Empty)
            {
                TxtRemainMoney.Text = (Convert.ToDouble(TxtSumTotals.Text) - Convert.ToDouble(TxtReceivedMoney.Text)).ToString();
            }
            else if (TxtDiscount.Text != string.Empty && TxtSumTotals.Text != string.Empty && TxtReceivedMoney.Text != string.Empty)
                TxtRemainMoney.Text = (Convert.ToDouble(TxtSumTotals.Text) - Convert.ToDouble(TxtReceivedMoney.Text) - Convert.ToDouble(TxtDiscount.Text)).ToString();
        }

        private void TxtReceivedMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void TxtOrderNotes_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtOrderNotes.Text == "الملاحظات")
            {
                TxtOrderNotes.Clear();
                TxtOrderNotes.ForeColor = Color.Black;
            }
        }
        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (TxtSumTotals.Text != string.Empty && TxtDiscount.Text != string.Empty)
                if (btnCash.Checked == true)
                {
                    TxtReceivedMoney.Text = (Convert.ToDouble(TxtSumTotals.Text) - Convert.ToDouble(TxtDiscount.Text)).ToString();
                }
                else
                    TxtRemainMoney.Text = (Convert.ToDouble(TxtSumTotals.Text) - Convert.ToDouble(TxtDiscount.Text)).ToString();
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
            if(e.Handled != true)
            {
                if (e.KeyChar == 8)
                {
                    TxtDiscount.Text = "0";
                    TxtDiscount.SelectionStart = 0;
                    TxtDiscount.SelectionLength = 9;
                }
            }
        }

        private void TxtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () {
                TxtDiscount.SelectAll();
            });
        }
        private void TxtOrderNotes_Leave(object sender, EventArgs e)
        {
            if (TxtOrderNotes.Text == string.Empty)
            {
                TxtOrderNotes.Text = "الملاحظات";
                TxtOrderNotes.ForeColor = Color.DimGray;
            }
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
            ProdInfo Prod = CBProdName.SelectedItem as ProdInfo;
            if (Clt == null || Bill.Rows.Count == 0) { return; };
            if (TxtDiscount.Text == string.Empty) { TxtDiscount.Text = "0"; };
            if (TxtReceivedMoney.Text == string.Empty) { TxtReceivedMoney.Text = "0"; };
            TxtReceivedMoney_TextChanged(null, null);
            if (TxtOrderNotes.Text == string.Empty) { TxtOrderNotes.Text = null; };
            if (TxtDriver.Text == string.Empty) { TxtDriver.Text = null; };
            if(TxtOrderNotes.Text == "الملاحظات") { TxtOrderNotes.Text = null; };
            if (btnMode == "add")
            {
                cs_order.ADD_CLIENT_REMAIN(Clt.ClientID, Convert.ToDecimal(TxtRemainMoney.Text),Clt.ClientName);
                cs_order.SAVE_ORDER(Convert.ToInt32(OrderIDTextBox.Text), OrderDatepicker.Value, Clt.ClientID, Convert.ToDecimal(TxtDiscount.Text), Convert.ToDecimal(TxtSumTotals.Text), Convert.ToDecimal(TxtReceivedMoney.Text), Convert.ToDecimal(TxtRemainMoney.Text), TxtDriver.Text, TxtOrderNotes.Text,Convert.ToDecimal(ClientAmountTextBox.Text));
                foreach (DataRow row in Bill.Rows)
                {
                    string Prod_Id = cs_product.Search_Product(row["اسم المنتج"].ToString()).Rows[0][0].ToString();
                    cs_order.SAVE_ORDER_DETAIL(Prod_Id, Convert.ToInt32(row["العدد"].ToString()), Convert.ToInt32(row["الكمية"].ToString()), Convert.ToDecimal(row["سعر المفرد"].ToString(), CultureInfo.CurrentCulture), Convert.ToDecimal(row["المجموع"].ToString(), CultureInfo.CurrentCulture), Convert.ToInt32(OrderIDTextBox.Text));
                }
                SaveOrderBtn.Enabled = false;
                PrintOrderBtn.Enabled = true;
            }
            else if (btnMode == "edit")
            {
                cs_order.ADD_CLIENT_REMAIN(Clt.ClientID, (Convert.ToDecimal(TxtRemainMoney.Text) - LastRemainMoney),Clt.ClientName);
                cs_order.Update_Order(Convert.ToInt32(OrderIDTextBox.Text), OrderDatepicker.Value, Clt.ClientID, Convert.ToDecimal(TxtDiscount.Text, CultureInfo.CurrentCulture), Convert.ToDecimal(TxtSumTotals.Text, CultureInfo.CurrentCulture), Convert.ToDecimal(TxtReceivedMoney.Text, CultureInfo.CurrentCulture), Convert.ToDecimal(TxtRemainMoney.Text, CultureInfo.CurrentCulture), TxtDriver.Text, TxtOrderNotes.Text);
                cs_order.DELETE_ORDER_DETAILS(Convert.ToInt32(OrderIDTextBox.Text));
                foreach (DataRow row in Bill.Rows)
                {
                    string Prod_Id = cs_product.Search_Product(row["اسم المنتج"].ToString()).Rows[0][0].ToString();
                    cs_order.SAVE_ORDER_DETAIL(Prod_Id, Convert.ToInt32(row["العدد"].ToString()), Convert.ToInt32(row["الكمية"].ToString()), Convert.ToDecimal(row["سعر المفرد"].ToString(), CultureInfo.CurrentCulture), Convert.ToDecimal(row["المجموع"].ToString(), CultureInfo.CurrentCulture), Convert.ToInt32(OrderIDTextBox.Text));
                }
                MessageBox.Show("تم تعديل الفاتورة بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintOrderBtn_Click(object sender, EventArgs e)
        {
            int ID_Order;
            if (OrderID != null)
                ID_Order = Convert.ToInt32(OrderID);
            else
                 ID_Order = Convert.ToInt32(cs_order.Get_Last_ID().Rows[0][0]);
            RPT.OrderCrystalReport report = new RPT.OrderCrystalReport();
            //RPT.FORM_ORDER_RPT frm = new RPT.FORM_ORDER_RPT();
            report.SetDataSource(cs_order.GetOrderDetails(ID_Order));
            //frm.crystalReportViewer1.ReportSource = report;
            //frm.crystalReportViewer1.RightToLeft = RightToLeft.Yes;
            //frm.ShowDialog();
            //report.PrintOptions.PrinterName = "Microsoft Print to PDF";
            report.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
            report.PrintOptions.PaperSize = PaperSize.PaperA4;
            //PageMargins margins = new PageMargins();
            //margins = report.PrintOptions.PageMargins;
            //margins.bottomMargin = 350;
            //margins.leftMargin = 350;
            //margins.rightMargin = 350;
            //margins.topMargin = 350;
            //report.PrintOptions.ApplyPageMargins(margins);
            report.PrintToPrinter(1,false, 0, 0);
        }

        private void DelOrderBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف الفاتورة؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClientInfo Clt = CBClientName.SelectedItem as ClientInfo;
                cs_order.ADD_CLIENT_REMAIN(Clt.ClientID, (- Convert.ToDecimal(TxtRemainMoney.Text)),Clt.ClientName);
                cs_order.Delete_Order(Convert.ToInt32(OrderIDTextBox.Text));
                cs_order.DELETE_ORDER_DETAILS(Convert.ToInt32(OrderIDTextBox.Text));
                FRM_MAIN.getMainForm.btnOrders.PerformClick();
            }
        }

        private void NewCltBtn_Click(object sender, EventArgs e)
        {
            FRM_NEW_COSTUMER frm = new FRM_NEW_COSTUMER();
            frm.ShowDialog();
            FRM_POS_Load(null, null);
            CBClientName.Focus();
        }

        private void CBProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProdQtyTextBox.Focus();
            }
        }
    }
}