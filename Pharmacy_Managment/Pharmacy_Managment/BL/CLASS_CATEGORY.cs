using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Managment.DAL;
using System.Data;

namespace Pharmacy_Managment.BL
{
    class CLASS_CATEGORY
    {   // add new category 
        // return the number of inserted rows

        public static int SP_ADDNEWCATEGORY(string CAT_NAME) 
        {
            DataAccessLayer.Open();
            int COUNT = DataAccessLayer.ExcuteNonQuery("SP_ADDNEWCATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CAT_NAME", SqlDbType.VarChar,CAT_NAME));
            DataAccessLayer.Close();
            return COUNT;
        }
        public static DataTable SP_SELECTALLCATEGORIES()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLCATEGORIES", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt ;
        }
        //select search categories
        //string value 
        public static DataTable SP_SEARCECATEGORIES(string SEARCH)
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SEARCECATEGORIES", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.Close();
            return DT;
        }
        public static int SP_UPDATECATEGORY(int CATID, string CATNAME)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_UPDATECATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, CATID),
                DataAccessLayer.CreateParameter("@CAT_NAME", SqlDbType.VarChar, CATNAME));
            DataAccessLayer.Close();
            return I;
        }
        public static int SP_DELETECATEGORY(int CATID)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_DELETECATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, CATID));
            return I;

        }

    }
}
