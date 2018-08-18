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
    public partial class FRM_CUSTOMER_MANEGEMENT : Form
    {
        public FRM_CUSTOMER_MANEGEMENT()
        {
            InitializeComponent();
        }

        private void FRM_CUSTOMER_MANEGEMENT_Activated(object sender, EventArgs e)
        {
            grid_Customer.DataSource = CLASS_CUSTOMER.sp_customer_display();
            grid_Customer.Columns[4].Width = 100;
            
            foreach(DataGridViewColumn col in grid_Customer.Columns    )
            {
                 //if( col is DataGridViewIamgeColumn)
                 //{
                 //   (DataGridViewIamgeColumn)col).IamgeLayout = DataGridViewImageCellLayout.Stretch;
                 //}
                //55-16:27

            }
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            grid_Customer.DataSource = CLASS_CUSTOMER.sp_customer_sreach(txtSEARCH.Text);
            grid_Customer.Columns[4].Width = 100;
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            new FRM_AddNewCustomer(false).ShowDialog();
        }

        public static DataGridViewRow row = null;
        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            if (grid_Customer.SelectedRows.Count > 0)
            {
                row = grid_Customer.SelectedRows[0];
            }
            else {
                MessageBox.Show("يجب اختيار عميل");
            }
            new FRM_AddNewCustomer(true).ShowDialog();

        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (grid_Customer.SelectedRows.Count > 0)
            {
                row = grid_Customer.SelectedRows[0];
                CLASS_CUSTOMER.sp_customer_delete(int.Parse(row.Cells[0].Value.ToString()));
                MessageBox.Show(" تم الحذف بنجاح ");
            }
            else
            {
                MessageBox.Show("يجب اختيار عميل");
            }
        }
    }
}
