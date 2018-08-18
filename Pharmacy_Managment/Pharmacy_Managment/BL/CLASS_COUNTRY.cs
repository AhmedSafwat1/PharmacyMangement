using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_COUNTRY
    {
        public static int sp_country_insert(string Country_Name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_country_insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@country_name", SqlDbType.VarChar, Country_Name));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_country_display()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_country_display",CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_country_search(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_country_search", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_country_update(int Country_ID, string country_Name)
        {
            DataAccessLayer.Open();
            int i =DataAccessLayer.ExcuteNonQuery("sp_country_update",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@country_ID",SqlDbType.Int,Country_ID),
                DataAccessLayer.CreateParameter("@country_Name",SqlDbType.VarChar, country_Name));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_country_delete( int country_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_country_delete", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@country_ID", SqlDbType.Int, country_ID));
            DataAccessLayer.Close();
            return i;
        }
    }
}
