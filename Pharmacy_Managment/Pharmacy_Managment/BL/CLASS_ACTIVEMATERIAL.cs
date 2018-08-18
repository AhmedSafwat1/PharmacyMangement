using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Managment.DAL;
using System.Data;

namespace Pharmacy_Managment.BL
{
    class CLASS_ACTIVEMATERIAL
    {
        public static int SP_ADDACTIVEMATERIAL(string AMNAME,string AMDESC)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_ADDACTIVEMATERIAL", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@AMNAME", SqlDbType.VarChar, AMNAME),
                DataAccessLayer.CreateParameter("@AMDESC", SqlDbType.VarChar, AMDESC));
            DataAccessLayer.Close();
            return I;
        }
        public static DataTable SP_SELECTALLACTIVEMATERIALS()
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SELECTALLACTIVEMATERIALS", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return DT;

        }
        public static DataTable SP_SELECTSEARCHACTIVEMATERIALS(string SEARCH)
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SELECTSEARCHACTIVEMATERIALS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar,SEARCH));
            DataAccessLayer.Close();
            return DT;

        }
        public static int SP_ACTIVEMATERIALUPDATE(int AMID, string AMNAME, string AMDESC)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_ACTIVEMATERIALUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ACID", SqlDbType.Int, AMID),
                DataAccessLayer.CreateParameter("@ACNAME", SqlDbType.VarChar, AMNAME),
                DataAccessLayer.CreateParameter("@ACDESC", SqlDbType.VarChar, AMDESC));
            DataAccessLayer.Close();
            return I;
        }
        public static int SP_ACTIVEMATERIALDELETE(int AMID)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_ACTIVEMATERIALDELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ACID", SqlDbType.Int, AMID));
            DataAccessLayer.Close();
            return I;
        }
    }
}
