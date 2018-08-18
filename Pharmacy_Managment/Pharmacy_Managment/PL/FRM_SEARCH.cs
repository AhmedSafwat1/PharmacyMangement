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
    public partial class FRM_SEARCH : Form
    {
        public FRM_SEARCH( string _ch)
        {
            InitializeComponent();
            if (_ch == "supplier")
            {
                DataTable dt = CLASS_SUPPLIER.SP_SUPPLIERSELECT();
                dataGridView1.DataSource = dt;
                this.Text = "بيانات الموردين ";
            }
            else if (_ch == "product")
            {
                this.Text = "بيانات المنتجات";
                dataGridView1.DataSource = CLASS_PRODUCTS.SP_PRODUCTSELECT();
            }
            else if (_ch == "customer")
            {
                this.Text = "بيانات العملاء";
                dataGridView1.DataSource = CLASS_CUSTOMER.sp_customer_display();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
