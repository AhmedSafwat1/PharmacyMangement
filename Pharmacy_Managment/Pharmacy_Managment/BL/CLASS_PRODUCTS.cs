using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.BL
{
    class CLASS_PRODUCTS
    {
        public static DataTable SP_FILLCATCMB()
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_FILLCATCMB", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return DT;
        }
        public static DataTable SP_FILLAMCMB()
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_FILLAMCMB", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return DT;
        }
        public static DataTable SP_FILLSNCMB()
        {
            DataAccessLayer.Open();
            DataTable DT=DataAccessLayer.ExecuteTable("SP_FILLSNCMB",CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return DT;
        }
        public static int SP_ADDNEWPRODUCT(string PNAME, string PDESC, byte[] IMG, string BUYPRICE, string SELLPRICE, int CATID, int AMID, int SNID, string BARCODE)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_ADDNEWPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@PNAME", SqlDbType.VarChar,PNAME),
                DataAccessLayer.CreateParameter("@PDESC", SqlDbType.VarChar,PDESC),
                DataAccessLayer.CreateParameter("@PIMG", SqlDbType.Image,IMG),
                DataAccessLayer.CreateParameter("@BUYPRICE", SqlDbType.VarChar,BUYPRICE),
                DataAccessLayer.CreateParameter("@SELLPRICE", SqlDbType.VarChar,SELLPRICE),
                DataAccessLayer.CreateParameter("@CATID", SqlDbType.Int,CATID),
                DataAccessLayer.CreateParameter("@AMID", SqlDbType.Int,AMID),
                DataAccessLayer.CreateParameter("@SNID", SqlDbType.Int,SNID),
                DataAccessLayer.CreateParameter("@BARCODE", SqlDbType.VarChar,BARCODE));
            DataAccessLayer.Close();
            return I;

        }
        public static DataTable SP_PRODUCTSELECT()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODUCTSELECT", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_PRODUCTSEARCH(string SEARCH)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODUCTSEARCH ", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH",SqlDbType.VarChar,SEARCH));
            DataAccessLayer.Close();
            return dt;

        }
        public static byte[] SP_PRODUCTSGETIMG(int ID)
        {
            DataAccessLayer.Open();
            byte[] arr =(byte[]) DataAccessLayer.ExcuteScalar("SP_PRODUCTSGETIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, ID));
            DataAccessLayer.Close();
            return arr;
        }
        public static DataTable SP_PRODUCTEXPDATES(int ID)
        {
         
            DataAccessLayer.Open();
            DataTable  DT=DataAccessLayer.ExecuteTable("SP_PRODUCTEXPDATES",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, ID));
            DataAccessLayer.Close();
            return DT;
        }
        public static int SP_PRODUCTSDELETE(int ID)
        {
            DataAccessLayer.Open();
            int I=DataAccessLayer.ExcuteNonQuery("SP_PRODUCTSDELETE",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID",SqlDbType.BigInt,ID));
            DataAccessLayer.Close();
            return I;
        }
        public static DataTable SP_GETSELECTEDPRODUCT(int ID)
        {
            DataAccessLayer.Open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_GETSELECTEDPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return DT;

        }
        public static int SP_PRODUCTUPDATE (int ID ,string PNAME, string PDESC, byte[] IMG, string BUYPRICE, string SELLPRICE, int CATID, int AMID, int SNID, string BARCODE)
        {
            DataAccessLayer.Open();
            int I = DataAccessLayer.ExcuteNonQuery("SP_PRODUCTUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, ID),
                DataAccessLayer.CreateParameter("@PNAME", SqlDbType.VarChar, PNAME),
                DataAccessLayer.CreateParameter("@PDESC", SqlDbType.VarChar, PDESC),
                DataAccessLayer.CreateParameter("@PIMG", SqlDbType.Image, IMG),
                DataAccessLayer.CreateParameter("@BUYPRICE", SqlDbType.VarChar, BUYPRICE),
                DataAccessLayer.CreateParameter("@SELLPRICE", SqlDbType.VarChar, SELLPRICE),
                DataAccessLayer.CreateParameter("@CATID", SqlDbType.Int, CATID),
                DataAccessLayer.CreateParameter("@AMID", SqlDbType.Int, AMID),
                DataAccessLayer.CreateParameter("@SNID", SqlDbType.Int, SNID),
                DataAccessLayer.CreateParameter("@BARCODE", SqlDbType.VarChar, BARCODE));
            DataAccessLayer.Close();
            return I;

        }

    }
}
