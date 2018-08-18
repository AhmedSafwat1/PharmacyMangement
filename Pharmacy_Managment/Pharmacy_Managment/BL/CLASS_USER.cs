using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Managment.DAL;
using System.Data;


namespace Pharmacy_Managment.BL
{
    class CLASS_USER
    {
        public static int sp_user_insert(string U_name, string U_pass, string U_full_name, int Per_ID)
        {
            DataAccessLayer.Open();
            int i =DataAccessLayer.ExcuteNonQuery("sp_user_insert",CommandType.StoredProcedure,
                   DataAccessLayer.CreateParameter("@U_name",SqlDbType.VarChar,U_name),
                   DataAccessLayer.CreateParameter("@U_pass",SqlDbType.VarChar,U_pass),
                   DataAccessLayer.CreateParameter("@U_full_name",SqlDbType.VarChar,U_full_name),
                   DataAccessLayer.CreateParameter("@Per_ID",SqlDbType.Int,Per_ID));
            DataAccessLayer.Close();
            return i;
        
        }
        public static DataTable sp_permission()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_permission", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_user_display()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_user_display", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_user_search(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_user_search", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_user_update(int U_ID,string U_name, string U_pass, string U_full_name, int Per_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_user_update", CommandType.StoredProcedure,
                   DataAccessLayer.CreateParameter("@U_ID", SqlDbType.Int, U_ID),
                   DataAccessLayer.CreateParameter("@U_name", SqlDbType.VarChar, U_name),
                   DataAccessLayer.CreateParameter("@U_pass", SqlDbType.VarChar, U_pass),
                   DataAccessLayer.CreateParameter("@U_full_name", SqlDbType.VarChar, U_full_name),
                   DataAccessLayer.CreateParameter("@Per_ID", SqlDbType.Int, Per_ID));
            DataAccessLayer.Close();
            return i;

        }
        public static int sp_user_delete(int U_ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_user_delete", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@U_ID", SqlDbType.Int, U_ID));  
            DataAccessLayer.Close();
            return i;
        }

    }

    
}
