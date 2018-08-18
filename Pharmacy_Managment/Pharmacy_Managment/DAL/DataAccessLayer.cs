using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy_Managment.DAL
{
    class DataAccessLayer
    {
        public static string con = "Data Source=SAFWAT-PC\\MSSQLSERVER2010; Initial Catalog=Pharmacy_DB;Integrated Security=True";
        public static SqlConnection cn;

        public static void Open()
        {
            cn = new SqlConnection(con);
            cn.Open();
        }
        public static void Close() 
        {
            cn = new SqlConnection(con);
            cn.Close();
        }
            // return one value
        public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
        { 
            
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type; 
            object o = cmd.ExecuteScalar();
            return o;
        }
        // update or delete number of rows
        public static int ExcuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
        { 
             
            SqlCommand cmd =new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            int n = cmd.ExecuteNonQuery();
            return n;
        }
        // return table
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr) 
        {
            
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }
    }
}
