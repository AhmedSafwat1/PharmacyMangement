using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_CITY
    {
        public static int sp_city_insert(string City_Name, int country_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_city_insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@city_name", SqlDbType.VarChar, City_Name),
                DataAccessLayer.CreateParameter("@country_ID", SqlDbType.Int, country_ID));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_city_diplay()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_city_diplay", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;

        }
        public static DataTable sp_city_search(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_city_search", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_city_update(int city_ID, string city_Name, int coutry_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_city_update", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@city_ID", SqlDbType.Int, city_ID),
                DataAccessLayer.CreateParameter("@city_name", SqlDbType.VarChar, city_Name),
                DataAccessLayer.CreateParameter("@country_ID", SqlDbType.Int, coutry_ID));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_city_delete(int city_Id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_city_delete", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@city_ID", SqlDbType.Int, city_Id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
