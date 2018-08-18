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
    public partial class FRM_ACTIVEMATERIALMANAAGEMENT : Form
    {
        public FRM_ACTIVEMATERIALMANAAGEMENT()
        {
            InitializeComponent();
            btnSlectAll_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT = CLASS_ACTIVEMATERIAL.SP_SELECTSEARCHACTIVEMATERIALS(txtSearch.Text);
            dgvActiveMaterial.DataSource = DT;
        }

        private void btnSlectAll_Click(object sender, EventArgs e)
        {
            DataTable DT = CLASS_ACTIVEMATERIAL.SP_SELECTALLACTIVEMATERIALS();
            dgvActiveMaterial.DataSource = DT;
        }

        private void dgvActiveMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                {
                    txtAMID.Text = dgvActiveMaterial.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtAMNAME.Text = dgvActiveMaterial.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtAMDescription.Text = dgvActiveMaterial.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int I = CLASS_ACTIVEMATERIAL.SP_ACTIVEMATERIALUPDATE(int.Parse(txtAMID.Text), txtAMNAME.Text,
                txtAMDescription.Text);
            MessageBox.Show("تم تعديل البيانات");
            btnSlectAll_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = CLASS_ACTIVEMATERIAL.SP_ACTIVEMATERIALDELETE(int.Parse(txtAMID.Text));
            btnSlectAll_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_ALLACTIVEMATERIAL act = new RPT.RPT_ALLACTIVEMATERIAL();
            frm.crystalReportViewer1.ReportSource = act;
            frm.ShowDialog();
        }

        private void FRM_ACTIVEMATERIALMANAAGEMENT_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
