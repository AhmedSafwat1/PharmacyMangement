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
    public partial class FRM_USER_MANGEMENT : Form
    {
        public FRM_USER_MANGEMENT()
        {
            InitializeComponent();
        }

        private void dgvSUPPLIER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTNDISPLAY_Click(object sender, EventArgs e)
        {
            grid_Users.DataSource = CLASS_USER.sp_user_display();
        }

        private void FRM_USER_MANGEMENT_Activated(object sender, EventArgs e)
        {
            BTNDISPLAY_Click(null, null);
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            grid_Users.DataSource = CLASS_USER.sp_user_search(txtSEARCH.Text);
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWUSER(false).ShowDialog();
        }

        public static DataGridViewRow row;
        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            if(grid_Users.SelectedRows.Count > 0)
            {
                row = grid_Users.SelectedRows[0];
                new FRM_ADDNEWUSER(true).ShowDialog();
            }
            else
            { MessageBox.Show("يجب اختيار مستخدم "); }
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (grid_Users.SelectedRows.Count > 0)
            {
                row = grid_Users.SelectedRows[0];
                CLASS_USER.sp_user_delete(int.Parse(row.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحذف ");
            }
            else
            { MessageBox.Show("يجب اختيار مستخدم "); }
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
