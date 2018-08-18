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
    public partial class FRM_COUNTRY : Form
    {
        public FRM_COUNTRY()
        {
            InitializeComponent();
            btn_coSelectALL_Click(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_coID.Text != "")
                {
                    CLASS_COUNTRY.sp_country_update(int.Parse(txt_coID.Text), txt_coName.Text);
                    MessageBox.Show("تم التعديل بنجاح");
                    btn_coSelectALL_Click(null, null);
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_coAdd_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(txt_coName.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم الدولة ");
                    return;
                }
                CLASS_COUNTRY.sp_country_insert(txt_coName.Text);
                MessageBox.Show("تم الاضافة بنجاح");
                txt_coName.Text = "";
                btn_coSelectALL_Click(null, null);
            }
            catch( Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_coSelectALL_Click(object sender, EventArgs e)
        {
            dgvCountry.DataSource = CLASS_COUNTRY.sp_country_display();
        }

        private void txt_coSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCountry.DataSource = CLASS_COUNTRY.sp_country_search(txt_coSearch.Text);
        }

         

        private void dgvCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_coID.Text = dgvCountry.SelectedRows[0].Cells[0].Value.ToString();
            txt_coName.Text = dgvCountry.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_coDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_coID.Text != "")
                {
                    CLASS_COUNTRY.sp_country_delete(int.Parse(txt_coID.Text));
                    MessageBox.Show("تم الحذف بنجاح ");
                    txt_coID.Text = txt_coName.Text = "";
                    btn_coSelectALL_Click(null, null);
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
