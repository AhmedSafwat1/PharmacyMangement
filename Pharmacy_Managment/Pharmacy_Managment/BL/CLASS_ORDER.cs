using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_ORDER
    {
        public static int sp_Order_Insert(DateTime order_Date, string total, int cu_ID, string seller_name, DataTable OrderDet)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("sp_Order_Insert", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@order_Date", SqlDbType.Date, order_Date.Date),
                DataAccessLayer.CreateParameter("@total", SqlDbType.VarChar, total),
                DataAccessLayer.CreateParameter("@cu_ID", SqlDbType.Int, cu_ID),
                DataAccessLayer.CreateParameter("@seller_name", SqlDbType.VarChar, seller_name),
                DataAccessLayer.CreateParameter("@OrderDet", SqlDbType.Structured, OrderDet));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_Order_Select()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_Order_Select", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
    }
}
