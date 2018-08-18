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
    public partial class FRM_CITY : Form
    {
        public FRM_CITY()
        {
            InitializeComponent();
            cmb_country_ID.DataSource = CLASS_COUNTRY.sp_country_display();
            cmb_country_ID.DisplayMember = "اسم الدولة";
            cmb_country_ID.ValueMember = "رقم الدولة";
            btn_Display_Click(null, null);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            { 
                if(txt_Name.Text =="")
                {
                    MessageBox.Show("يجب ادخال اسم المدينة");
                    return;
                }
                CLASS_CITY.sp_city_insert(txt_Name.Text,int.Parse(cmb_country_ID.SelectedValue.ToString()));
                MessageBox.Show("تم الاضافة");
                btn_Display_Click(null, null);
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = CLASS_CITY.sp_city_diplay();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgvCity.DataSource = CLASS_CITY.sp_city_search(txt_Search.Text);             
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txt_ID.Text != "")
                {
                    CLASS_CITY.sp_city_update(int.Parse(txt_ID.Text), txt_Name.Text, int.Parse(cmb_country_ID.SelectedValue.ToString()));
                    MessageBox.Show("تم التعديل");
                    btn_Display_Click(null, null);
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgvCity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgvCity.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name.Text = dgvCity.SelectedRows[0].Cells[1].Value.ToString();
            cmb_country_ID.Text = dgvCity.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txt_ID.Text != "")
                {
                    CLASS_CITY.sp_city_delete(int.Parse(txt_ID.Text));
                    MessageBox.Show("تم الحذف");
                    btn_Display_Click(null, null);
                    txt_ID.Text = txt_Name.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
