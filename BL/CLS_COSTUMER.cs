using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleManagementSystem.BL
{
    class CLS_COSTUMER
    {
        DAL.DataAccess da = new DAL.DataAccess();
        public DataTable Get_All_Costumers()
        {
            return da.SelectData("Get_All_Costumers", null);
        }
        public DataTable Search_Costumers(string keyword)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@keyword", SqlDbType.NVarChar, 50);
            p[0].Value = keyword;
            return da.SelectData("Search_Costumers", p);
        }
        public void DELETE_COSTUMER(string id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            da.open();
            da.Excutecommand("DELETE_COSTUMER", p);
            da.close();
        }
        public DataTable Client_Price(int id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            return da.SelectData("Client_Price", p);
        }
        public void NEW_COSTUMER_PRICE(int id_costumer, string name, int price, string id_product)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id_costumer", SqlDbType.Int);
            parameters[0].Value = id_costumer;
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@price", SqlDbType.Int);
            parameters[2].Value = price;

            parameters[3] = new SqlParameter("@id_product", SqlDbType.NVarChar,50);
            parameters[3].Value = id_product;

           
            da.open();
            da.Excutecommand("NEW_COSTUMER_PRICE", parameters);
            da.close();
        }
        public void Add_New_Costumer(string name, decimal amount, string phone, string address)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            parameters[0].Value = name;
            parameters[1] = new SqlParameter("@amount", SqlDbType.Decimal);
            parameters[1].Value = amount;

            parameters[2] = new SqlParameter("@phone", SqlDbType.NVarChar,50);
            parameters[2].Value = phone;

            parameters[3] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[3].Value = address;


            da.open();
            da.Excutecommand("Add_New_Costumer", parameters);
            da.close();
        }
        public void Update_Costumer(int id,string name,string phone, string address)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            parameters[2].Value = phone;

            parameters[3] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[3].Value = address;


            da.open();
            da.Excutecommand("Update_Costumer", parameters);
            da.close();
        }
        public void DELETE_CLIENT_PRICE(int id, string id_product)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@id_product", SqlDbType.NVarChar,50);
            p[1].Value = id_product;
            da.open();
            da.Excutecommand("DELETE_CLIENT_PRICE", p);
            da.close();
        }
        public void UPDATE_CLIENT_PRICE(int id,string id_product, int price)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            parameters[1] = new SqlParameter("@id_product", SqlDbType.NVarChar,50);
            parameters[1].Value = id_product;
            parameters[2] = new SqlParameter("@price", SqlDbType.Int);
            parameters[2].Value = price;

            da.open();
            da.Excutecommand("UPDATE_CLIENT_PRICE", parameters);
            da.close();
        }
        public void Save_Client_State(int ID_COSTUMER ,DateTime Date , decimal Recieved_Amount ,string Notes)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@ID_COSTUMER", SqlDbType.Int);
            parameters[0].Value = ID_COSTUMER;
            parameters[1] = new SqlParameter("@Date", SqlDbType.Date);
            parameters[1].Value = Date;

            parameters[2] = new SqlParameter("@Recieved_Amount", SqlDbType.Decimal);
            parameters[2].Value = Recieved_Amount;

            parameters[3] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            parameters[3].Value = Notes;


            da.open();
            da.Excutecommand("Save_Client_State", parameters);
            da.close();
        }
        public DataTable Get_Client_State(int ID_COSTUMER)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@ID_COSTUMER", SqlDbType.Int);
            p[0].Value = ID_COSTUMER;
            return da.SelectData("Get_Client_State", p);
        }
    }
}
