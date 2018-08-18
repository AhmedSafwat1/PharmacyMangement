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
    public partial class FRM_ADDSCEINTIFICNAME : Form
    {
        public FRM_ADDSCEINTIFICNAME()
        {
            InitializeComponent();
        }

        private void FRM_ADDSCEINTIFICNAME_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == string.Empty)
            {
                MessageBox.Show(" يجب ادخال الاسم العلمى");
                return;
            }
            CLASS_SCEINTIFICNAME.SP_ADDSCEINTIFICNAME(txtName.Text);
            MessageBox.Show("تم الاضافة");
            txtName.Text = string.Empty;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
