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
    public partial class FRM_ADDNEWSUPPLIER : Form
    {
        bool _CHECK;
        public FRM_ADDNEWSUPPLIER( bool CHECK)
        {
            InitializeComponent();
            _CHECK = CHECK;
            if (_CHECK)
            {
                this.Text = "اضافة مورد جديد";
                BTNOK.Text = "اضافة";
            }
            else
            {
                this.Text = "تعديل مورد جديد";
                BTNOK.Text = "تعديل";
                DataTable DT = CLASS_SUPPLIER.SP_SUPPLIERSELECTBYID(FRM_SUPPLIERMANEGEMENT.id);
                foreach (DataRow dr in DT.Rows)
                {
                    TXTNAME.Text = dr["Su_Name"].ToString();
                    TXTMOBILE.Text = dr["Su_Mobile"].ToString();
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            if (_CHECK)
            {
                CLASS_SUPPLIER.SP_ADDNEWSUPPLIER(TXTNAME.Text, TXTMOBILE.Text);
                MessageBox.Show("تم الاضافة بنجاح");
                TXTNAME.Text = TXTMOBILE.Text = "";
            }
            else {
                CLASS_SUPPLIER.SP_SUPPLIERUPDATE(FRM_SUPPLIERMANEGEMENT.id, TXTNAME.Text, TXTMOBILE.Text);
                MessageBox.Show("تم التعديل");
            }
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDNEWSUPPLIER_Load(object sender, EventArgs e)
        {

        }
    }
}
