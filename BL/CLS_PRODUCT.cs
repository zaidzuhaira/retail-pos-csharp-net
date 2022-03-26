using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleManagementSystem.BL
{
    class CLS_PRODUCT
    {
        DAL.DataAccess da = new DAL.DataAccess();
        public void Add_New_Product(string ID, string name, int price, int qty, int bag)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parameters[0].Value = ID;
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@price", SqlDbType.Int);
            parameters[2].Value = price;

            parameters[3] = new SqlParameter("@qty", SqlDbType.Int);
            parameters[3].Value = qty;

            parameters[4] = new SqlParameter("@bag", SqlDbType.Int)
            {
                Value = bag
            };
            da.open();
            da.Excutecommand("Add_New_Product", parameters);
            da.close();
        }
        public DataTable Get_All_Product()
        {
            return da.SelectData("Get_All_Product", null);
        }
        public DataTable Get_Last_Value()
        {
            return da.SelectData("Get_Last_Value", null);
        }
        public DataTable Search_Product(string keyword)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@keyword", SqlDbType.NVarChar, 50);
            p[0].Value = keyword;
            return da.SelectData("Search_Product", p);
        }
        public void Delete_Product(string id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            p[0].Value = id;
            da.open();
            da.Excutecommand("Delete_Product", p);
            da.close();
        }
        public void Update_Product(string ID, string name, int price, int qty, int bag)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parameters[0].Value = ID;
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@price", SqlDbType.Int);
            parameters[2].Value = price;

            parameters[3] = new SqlParameter("@qty", SqlDbType.Int);
            parameters[3].Value = qty;

            parameters[4] = new SqlParameter("@bag", SqlDbType.Int)
            {
                Value = bag
            };
            da.open();
            da.Excutecommand("Update_Product", parameters);
            da.close();
        }
        public DataTable Get_Id_product(string name)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[0].Value = name;
            return da.SelectData("Get_Id_product", p);

        }
    }
}
