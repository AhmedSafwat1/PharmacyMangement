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
    public partial class FRM_SUPPLIERMANEGEMENT : Form
    {
        public FRM_SUPPLIERMANEGEMENT()
        {
            InitializeComponent();
            BTNDISPLAY_Click(null, null);
        }

        private void BTNDISPLAY_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIER.SP_SUPPLIERSELECT();
            dgvSUPPLIER.DataSource = dt;
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIER.SP_SUPPLIERSEARCH(txtSEARCH.Text);
            dgvSUPPLIER.DataSource = dt;
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWSUPPLIER(true).ShowDialog();
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int id;
        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvSUPPLIER.SelectedRows[0].Cells[0].Value.ToString());
            new FRM_ADDNEWSUPPLIER(false).ShowDialog();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvSUPPLIER.SelectedRows[0].Cells[0].Value.ToString());
            CLASS_SUPPLIER.SP_SUPPLIERDELETE(id);
            MessageBox.Show("تم الحذف");
        }

        private void dgvSUPPLIER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_SUPPLIERMANEGEMENT_Activated(object sender, EventArgs e)
        {
            BTNDISPLAY_Click(null, null);
        }
    }
}
