using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_CUSTOMER
    {
        public static DataTable sp_city_country_ID(int Country_ID)
        {
            DataAccessLayer.Open();
            DataTable dt =DataAccessLayer.ExecuteTable("sp_city_country_ID",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@country_ID",SqlDbType.Int,Country_ID));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_customer_insert( string cu_name,string cu_add,string cu_mobile,byte[] cu_iamge,int city_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_customer_insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cu_Name", SqlDbType.VarChar, cu_name),
                DataAccessLayer.CreateParameter("@cu_Address", SqlDbType.VarChar, cu_add),
                DataAccessLayer.CreateParameter("@cu_mobile", SqlDbType.VarChar, cu_mobile),
                DataAccessLayer.CreateParameter("@cu_image", SqlDbType.Image, cu_iamge),
                DataAccessLayer.CreateParameter("@city_id", SqlDbType.Int, city_id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_customer_display()
        {
            DataAccessLayer.Open();
            DataTable dt =DataAccessLayer.ExecuteTable("sp_customer_display",CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_customer_sreach( string sreach)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_customer_sreach", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search",SqlDbType.VarChar,sreach));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_customer_update(int cu_id,string cu_name, string cu_add, string cu_mobile, byte[] cu_iamge, int city_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_customer_update", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cu_id", SqlDbType.Int, cu_id),
                DataAccessLayer.CreateParameter("@cu_Name", SqlDbType.VarChar, cu_name),
                DataAccessLayer.CreateParameter("@cu_Address", SqlDbType.VarChar, cu_add),
                DataAccessLayer.CreateParameter("@cu_mobile", SqlDbType.VarChar, cu_mobile),
                DataAccessLayer.CreateParameter("@cu_image", SqlDbType.Image, cu_iamge),
                DataAccessLayer.CreateParameter("@city_id", SqlDbType.Int, city_id));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_customer_delete(int cu_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery(" sp_customer_delete", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cu_id", SqlDbType.Int, cu_id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
