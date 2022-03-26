using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleManagementSystem.BL
{
    class CLS_ORDER
    {
        DAL.DataAccess da = new DAL.DataAccess();
        public DataTable Get_Last_ID()
        {
            return da.SelectData("Get_Last_ID", null);
        }
        public DataTable Get_Costumer_Info(int id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            return da.SelectData("Get_Costumer_Info", p);
        }
        public DataTable Get_Product_Info(string id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            p[0].Value = id;
            return da.SelectData("Get_Product_Info", p);
        }
        public DataTable Get_Costumer_Price(int id, string id_product)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@id_product", SqlDbType.NVarChar,50);
            p[1].Value = id_product;

            return da.SelectData("Get_Costumer_Price", p);
        }
        public void SAVE_ORDER(int Order_ID, DateTime Order_date, int ID_COSTUMER, decimal Discount, decimal Total_Amount, decimal Received_Money, decimal Remain_Money, string Driver_Name, string Order_Notes, decimal last_balance)
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            p[0].Value = Order_ID;
            p[1] = new SqlParameter("@Order_date", SqlDbType.DateTime);
            p[1].Value = Order_date;
            p[2] = new SqlParameter("@ID_COSTUMER", SqlDbType.Int);
            p[2].Value = ID_COSTUMER;
            p[3] = new SqlParameter("@Discount", SqlDbType.Decimal);
            p[3].Value = Discount;
            p[4] = new SqlParameter("@Total_Amount", SqlDbType.Decimal);
            p[4].Value = Total_Amount;
            p[5] = new SqlParameter("@Received_Money", SqlDbType.Decimal);
            p[5].Value = Received_Money;
            p[6] = new SqlParameter("@Remain_Money", SqlDbType.Decimal);
            p[6].Value = Remain_Money;
            p[7] = new SqlParameter("@Driver_Name", SqlDbType.NVarChar, 50);
            p[7].Value = Driver_Name;
            p[8] = new SqlParameter("@Order_Notes", SqlDbType.NVarChar);
            p[8].Value = Order_Notes;
            p[9] = new SqlParameter("@last_balance", SqlDbType.Decimal);
            p[9].Value = last_balance;

            da.open();
            da.Excutecommand("SAVE_ORDER", p);
            da.close();
        }
        public void SAVE_ORDER_DETAIL(string ID_Product, int Qty, int Bags, decimal Sale_price, decimal Amount,int Order_ID)
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar,50);
            p[0].Value = ID_Product;
            p[1] = new SqlParameter("@Qty", SqlDbType.Int);
            p[1].Value = Qty;
            p[2] = new SqlParameter("@Bags", SqlDbType.Int);
            p[2].Value = Bags;
            p[3] = new SqlParameter("@Sale_price", SqlDbType.Decimal);
            p[3].Value = Sale_price;
            p[4] = new SqlParameter("@Amount", SqlDbType.Decimal);
            p[4].Value = Amount;
            p[5] = new SqlParameter("@Order_ID", SqlDbType.Int);
            p[5].Value = Order_ID;
            
            da.open();
            da.Excutecommand("SAVE_ORDER_DETAIL", p);
            da.close();
        }
        public DataTable Verify_Prod_Qty(string ID_Product, int qty)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 50);
            p[0].Value = ID_Product;
            p[1] = new SqlParameter("@qty", SqlDbType.Int);
            p[1].Value = qty;
          
            return da.SelectData("Verify_Prod_Qty", p);
        }
        public void ADD_CLIENT_REMAIN(int id_costumer, decimal remain_money , string Costumer_name)
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@id_costumer", SqlDbType.Int);
            p[0].Value = id_costumer;
            p[1] = new SqlParameter("@remain_money", SqlDbType.Decimal);
            p[1].Value = remain_money;
            p[2] = new SqlParameter("@Costumer_name", SqlDbType.NVarChar,50);
            p[2].Value = Costumer_name;

            da.open();
            da.Excutecommand("ADD_CLIENT_REMAIN", p);
            da.close();
        }
        public DataTable GetOrderDetails(int ID_Order)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            p[0].Value = ID_Order;

            return da.SelectData("GetOrderDetails", p);
        }
        public DataTable Search_Orders(string keyword)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@keyword", SqlDbType.NVarChar,50);
            p[0].Value = keyword;

            return da.SelectData("Search_Orders", p);
        }
        public void Delete_Order(int Order_Id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@Order_Id", SqlDbType.Int);
            p[0].Value = Order_Id;

            da.open();
            da.Excutecommand("Delete_Order", p);
            da.close();
        }
        public void Update_Order(int Order_ID, DateTime Order_date, int ID_COSTUMER, decimal Discount, decimal Total_Amount, decimal Received_Money, decimal Remain_Money, string Driver_Name, string Order_Notes)
        {
            SqlParameter[] p = new SqlParameter[9];
            p[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            p[0].Value = Order_ID;
            p[1] = new SqlParameter("@Order_date", SqlDbType.DateTime);
            p[1].Value = Order_date;
            p[2] = new SqlParameter("@ID_COSTUMER", SqlDbType.Int);
            p[2].Value = ID_COSTUMER;
            p[3] = new SqlParameter("@Discount", SqlDbType.Decimal);
            p[3].Value = Discount;
            p[4] = new SqlParameter("@Total_Amount", SqlDbType.Decimal);
            p[4].Value = Total_Amount;
            p[5] = new SqlParameter("@Received_Money", SqlDbType.Decimal);
            p[5].Value = Received_Money;
            p[6] = new SqlParameter("@Remain_Money", SqlDbType.Decimal);
            p[6].Value = Remain_Money;
            p[7] = new SqlParameter("@Driver_Name", SqlDbType.NVarChar, 50);
            p[7].Value = Driver_Name;
            p[8] = new SqlParameter("@Order_Notes", SqlDbType.NVarChar);
            p[8].Value = Order_Notes;

            da.open();
            da.Excutecommand("Update_Order", p);
            da.close();
        }
        public void Update_Order_Details(string ID_Product, int Qty, int Bags, decimal Sale_price, decimal Amount, int Order_ID)
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 50);
            p[0].Value = ID_Product;
            p[1] = new SqlParameter("@Qty", SqlDbType.Int);
            p[1].Value = Qty;
            p[2] = new SqlParameter("@Bags", SqlDbType.Int);
            p[2].Value = Bags;
            p[3] = new SqlParameter("@Sale_price", SqlDbType.Decimal);
            p[3].Value = Sale_price;
            p[4] = new SqlParameter("@Amount", SqlDbType.Decimal);
            p[4].Value = Amount;
            p[5] = new SqlParameter("@Order_ID", SqlDbType.Int);
            p[5].Value = Order_ID;

            da.open();
            da.Excutecommand("Update_Order_Details", p);
            da.close();
        }
        public void DELETE_ORDER_DETAILS(int Order_ID)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            p[0].Value = Order_ID;

            da.open();
            da.Excutecommand("DELETE_ORDER_DETAILS", p);
            da.close();
        }
    }
}
