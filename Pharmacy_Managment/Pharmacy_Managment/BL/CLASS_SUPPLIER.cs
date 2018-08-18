using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_SUPPLIER
    {
        public static int SP_ADDNEWSUPPLIER(string NAME, string MOBILE)
        {
            DataAccessLayer.Open();
            int  i=DataAccessLayer.ExcuteNonQuery("SP_ADDNEWSUPPLIER",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SUNAME",SqlDbType.VarChar,NAME),
                DataAccessLayer.CreateParameter("@SUMMOBLIE",SqlDbType.VarChar,MOBILE));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable SP_SUPPLIERSELECT()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECT", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;

        }
        public static DataTable SP_SUPPLIERSEARCH(string SEARCH)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_SUPPLIERSELECTBYID(int ID)
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECTBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return DT;
        }
        public static int SP_SUPPLIERUPDATE(int ID, string SU_NAME, string SU_MOBILE)
        {
            DataAccessLayer.Open();
            int i =DataAccessLayer.ExcuteNonQuery("SP_SUPPLIERUPDATE",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID",SqlDbType.Int,ID),
                DataAccessLayer.CreateParameter("@SU_NAME", SqlDbType.VarChar, SU_NAME),
                DataAccessLayer.CreateParameter("@SU_MOBILE", SqlDbType.VarChar, SU_MOBILE));
            DataAccessLayer.Close();
            return i;

        }
        public static int SP_SUPPLIERDELETE(int ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("SP_SUPPLIERDELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return i;
        }
    }
}
