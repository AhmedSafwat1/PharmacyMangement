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

namespace Pharmacy_Managment.PL
{
    public partial class FRM_REQUEST_MANAGEMENT : Form
    {
        public FRM_REQUEST_MANAGEMENT()
        {
            InitializeComponent();
        }

        private void FRM_REQUEST_MANAGEMENT_Load(object sender, EventArgs e)
        {
            grid_request.DataSource = CLASS_REQUEST.sp_request_Display();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            FRM_REQUEST_MANAGEMENT_Load(null, null);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_REQUEST rpt = new RPT.RPT_REQUEST();
            rpt.SetParameterValue("@Req_ID", grid_request.SelectedRows[0].Cells[0].Value);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
