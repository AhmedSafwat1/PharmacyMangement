using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Managment.DAL;
using System.Data;

namespace Pharmacy_Managment.BL
 
{
    class CLASS_REQUEST
    {
        public static void SP_Request_Insert(DateTime Req_Date , string Total,int su_ID ,string Buyer_Name,DataTable Req_Det,DataTable expireddate)
        {
            DataAccessLayer.Open();
            DataAccessLayer.ExcuteNonQuery("SP_Request_Insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Req_Date", SqlDbType.Date, Req_Date.Date),
                DataAccessLayer.CreateParameter("@Total", SqlDbType.VarChar, Total),
                DataAccessLayer.CreateParameter("@SU_ID ", SqlDbType.Int, su_ID),
                DataAccessLayer.CreateParameter("@Buyer_Name", SqlDbType.VarChar, Buyer_Name),
                DataAccessLayer.CreateParameter("@ReqDet", SqlDbType.Structured,Req_Det ),
                DataAccessLayer.CreateParameter("@expireddate", SqlDbType.Structured, expireddate));
            DataAccessLayer.Close();
 
        }

        public static DataTable sp_request_Display()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_request_Display", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        
        }
        public static object max_id()
        {
            DataAccessLayer.Open();
            object o = DataAccessLayer.ExcuteScalar(" select MAX(Req_ID) from tblRequests", CommandType.Text);
            DataAccessLayer.Close();
            return o;
        }
    }
}
