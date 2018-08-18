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
    public partial class FRM_ADDACTIVEMATERIAL : Form
    {
        public FRM_ADDACTIVEMATERIAL()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المادة الفعالة");
                return;
            }
            int i = CLASS_ACTIVEMATERIAL.SP_ADDACTIVEMATERIAL(txtName.Text, txtDescription.Text);
            MessageBox.Show("تم اضافة عدد " + i + " من الصفوف");
            txtName.Text = txtDescription.Text = string.Empty;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDACTIVEMATERIAL_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
