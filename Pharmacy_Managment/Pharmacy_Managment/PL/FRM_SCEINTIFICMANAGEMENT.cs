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
    public partial class FRM_SCEINTIFICMANAGEMENT : Form
    {
        public FRM_SCEINTIFICMANAGEMENT()
        {
            InitializeComponent();
            btnSelectALL_Click(null, null);
        }

        private void btnSelectALL_Click(object sender, EventArgs e)
        {
            DataTable DT = CLASS_SCEINTIFICNAME.SP_SELCTALLSCEINTIFICNAME();
            dgvSceintifiecName.DataSource = DT;
        }

        private void dgvSceintifiecName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtSNID.Text = dgvSceintifiecName.Rows[e.RowIndex].Cells[0].Value.ToString();
                 txtSnName.Text = dgvSceintifiecName.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataTable DT = CLASS_SCEINTIFICNAME.SP_SELCTSERCHSCEINTIFICNAME(txtSearch.Text);
            dgvSceintifiecName.DataSource = DT;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CLASS_SCEINTIFICNAME.SP_SCEINTIFICNAMEUPATE(int.Parse(txtSNID.Text), txtSnName.Text);
            MessageBox.Show("تم التعديل بنجاح");
            btnSelectALL_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CLASS_SCEINTIFICNAME.SP_SCEINTIFICNAMEDELETE(int.Parse(txtSNID.Text));
            MessageBox.Show("تم الحذف");
            btnSelectALL_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_ALLACTIVEMATERIAL actm = new RPT.RPT_ALLACTIVEMATERIAL();
            frm.crystalReportViewer1.ReportSource = actm;
            frm.ShowDialog();
        }
    }
}
