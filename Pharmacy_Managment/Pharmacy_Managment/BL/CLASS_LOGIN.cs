using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_LOGIN
    {
        public static DataTable splogin(string UName, string pass)
        {
            DataAccessLayer.Open();
            DataTable dt=  DataAccessLayer.ExecuteTable("SP_LOGIN", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@UNAME", SqlDbType.VarChar, UName),
                DataAccessLayer.CreateParameter("@UPASS", SqlDbType.VarChar, pass));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
