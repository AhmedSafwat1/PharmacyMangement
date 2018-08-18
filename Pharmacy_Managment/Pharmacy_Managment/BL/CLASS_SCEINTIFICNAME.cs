using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Managment.DAL;
using System.Data;
namespace Pharmacy_Managment.BL
{
    class CLASS_SCEINTIFICNAME
    {
        public static int SP_ADDSCEINTIFICNAME(string SNNAME)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_ADDSCEINTIFICNAME",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SNNAME", SqlDbType.VarChar, SNNAME));
            DataAccessLayer.Close();
            return I;
        }
        public static DataTable SP_SELCTALLSCEINTIFICNAME()
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SELCTALLSCEINTIFICNAME", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return DT;
        }
        public static DataTable SP_SELCTSERCHSCEINTIFICNAME(string SEARCH)
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SELCTSERCHSCEINTIFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.Close();
            return DT;
        }
        public static int SP_SCEINTIFICNAMEUPATE(int SNID, string SNNAME)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_SCEINTIFICNAMEUPATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SNID", SqlDbType.Int, SNID),
                DataAccessLayer.CreateParameter("@SNNAME", SqlDbType.VarChar, SNNAME));
            DataAccessLayer.Close();
            return I;
        }
        public static int SP_SCEINTIFICNAMEDELETE(int SNID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("SP_SCEINTIFICNAMEDELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SNID", SqlDbType.Int, SNID));
            DataAccessLayer.Close();
            return i;
        }
    }
}
