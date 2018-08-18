using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_HELPER
    {
        public static void Backup_DB(string Path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("Backup Database Pharmacy_DB to Disk='{0}' ", Path);
            DataAccessLayer.ExcuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();

        }
        public static void Restore_DB(string Path)
        {
            DataAccessLayer.con = "Data Source=ESLAMNAGM; Initial Catalog=master;Integrated Security=True";
            DataAccessLayer.Open();
            string Query = string.Format("ALTER DATABASE Pharmacy_DB SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database Pharmacy_DB from Disk='{0}' ", Path);
            DataAccessLayer.ExcuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();  
        }
    }
}
