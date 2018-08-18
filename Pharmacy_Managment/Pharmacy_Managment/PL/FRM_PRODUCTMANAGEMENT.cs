using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Managment.BL;
using System.IO;
using CrystalDecisions.Shared;

namespace Pharmacy_Managment.PL
{
    public partial class FRM_PRODUCTMANAGEMENT : Form
    {
        public FRM_PRODUCTMANAGEMENT()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_PRODUCTMANAGEMENT_Load(object sender, EventArgs e)
        {

        }

        public static int ID;

        private void button4_Click(object sender, EventArgs e)
        {
              ID = int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString());

            DialogResult dr= MessageBox.Show("هل تريد حذف المنتج المحدد","تحذير",MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                CLASS_PRODUCTS.SP_PRODUCTSDELETE(ID);
                MessageBox.Show("تم الحذف بنجاح");

            }
        }
        //public static bool ISUPDATE_INSERT = false; اضافة
        private void BTNDISPLAY_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCTS.SP_PRODUCTSELECT();
            dgvPRODUCTS.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvPRODUCTS.Rows.Add(dr[0],dr[1],dr[2],dr[3],dr[4],dr[5],dr[6],dr[7],dr[8],dr[9]);
            }
        }

        private void FRM_PRODUCTMANAGEMENT_Activated(object sender, EventArgs e)
        {
            BTNDISPLAY_Click(null, null);
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCTS.SP_PRODUCTSEARCH(TXTSEARCH.Text);
            dgvPRODUCTS.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvPRODUCTS.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
            }
        }

        private void BTNDISPALYIMG_Click(object sender, EventArgs e)
        {
            byte[] arr = CLASS_PRODUCTS.SP_PRODUCTSGETIMG(int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString()));
            MemoryStream ms = new MemoryStream(arr);
            FRM_PRODUCTIMG frm = new FRM_PRODUCTIMG();
            frm.PICIMG.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }

        private void BTNDISPLAYEXPIREDATE_Click(object sender, EventArgs e)
        {
            DataTable DT = CLASS_PRODUCTS.SP_PRODUCTEXPDATES(int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString()));
            if (DT.Rows.Count > 0)
            {
                FRM_PRODUCTEXPIERDATES frm = new FRM_PRODUCTEXPIERDATES();
                frm.DGVPRODUCTEXP.DataSource = DT;
                frm.ShowDialog();
            }
            else {
                MessageBox.Show("لا يوجد تاريخ صلاحية لهذا المنتج");
            }
        }

        private void BTNADDNEWPROF_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWPRODUCT(false).ShowDialog();
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWPRODUCT(true).ShowDialog();
            ID = int.Parse(dgvPRODUCTS.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNPRINTALL_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_ALLPRODUCT PRODUCTS = new RPT.RPT_ALLPRODUCT();
            frm.crystalReportViewer1.ReportSource = PRODUCTS;
            frm.ShowDialog();
        }

        private void BTNPRINTSELECTEDPROD_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_PRINTSELECTEDPRODUCT SINGLEPRODUCT = new RPT.RPT_PRINTSELECTEDPRODUCT();
            SINGLEPRODUCT.SetParameterValue("@ID",dgvPRODUCTS.SelectedRows[0].Cells[0].Value);
            frm.crystalReportViewer1.ReportSource = SINGLEPRODUCT;
            frm.ShowDialog();
        }

        private void BTNSAVETOEXCEL_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALLPRODUCT report = new RPT.RPT_ALLPRODUCT();
            DiskFileDestinationOptions Destination = new DiskFileDestinationOptions();
            Destination.DiskFileName = "G:\\report.xls";
            ExcelFormatOptions excelformat =new ExcelFormatOptions();
            ExportOptions export =new ExportOptions();
            export =report.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportDestinationOptions = Destination;
            export.ExportFormatOptions = excelformat;
            report.Export();
            MessageBox.Show("Export success");

        }
    }
}
