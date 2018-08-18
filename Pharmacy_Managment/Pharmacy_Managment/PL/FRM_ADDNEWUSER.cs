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
    public partial class FRM_ADDNEWUSER : Form
    {
        bool IsUpdata;
        public FRM_ADDNEWUSER(bool _IsUpdate)
        {
            InitializeComponent();
            this.IsUpdata = _IsUpdate;

            cmb_per_id.DataSource = CLASS_USER.sp_permission();
            cmb_per_id.DisplayMember = "Per_Name";
            cmb_per_id.ValueMember = "Per_ID";
            if (IsUpdata)
            {
                this.Text = " تعديل بيانات المستخدم";
                btn_ok.Text = "تعديل";
                txt_u_name.Text = FRM_USER_MANGEMENT.row.Cells[1].Value.ToString();
                txt_u_pass.Text = txt_check_u_pass.Text = FRM_USER_MANGEMENT.row.Cells[2].Value.ToString();
                txt_u_full_name.Text = FRM_USER_MANGEMENT.row.Cells[3].Value.ToString();
                cmb_per_id.Text = FRM_USER_MANGEMENT.row.Cells[4].Value.ToString();

            }
            else {
                this.Text = " اضافة بيانات المستخدم";
                btn_ok.Text = "اضافة";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_u_name.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم المستخدم ");
                    return;
                }
                else if (txt_u_pass.Text == "")
                {
                    MessageBox.Show("يجب ادخال كلمة المرور");
                    return;
                }
                else if (txt_check_u_pass.Text != txt_u_pass.Text)
                {
                    MessageBox.Show(" كلمة المرور غير مطابقة");
                    return;
                }
                else if (txt_u_full_name.Text == "")
                {
                    MessageBox.Show("يجب ادخال الاسم كاملا ");
                    return;
                }

                if (IsUpdata)
                {
                    CLASS_USER.sp_user_update(int.Parse(FRM_USER_MANGEMENT.row.Cells[0].Value.ToString()),
                        txt_u_name.Text, txt_u_pass.Text, txt_u_full_name.Text, int.Parse(cmb_per_id.SelectedValue.ToString()));
                    MessageBox.Show(" تم التعديل بنجاح ");
                }
                else
                {
                    CLASS_USER.sp_user_insert(txt_u_name.Text, txt_u_pass.Text, txt_u_full_name.Text,
                        int.Parse(cmb_per_id.SelectedValue.ToString()));
                    MessageBox.Show("تم الاضافة بنجاح");
                    foreach(Control ctr in groupBox1.Controls)
                    {
                        if (ctr is TextBox)
                            ctr.Text = "";
                    }
                }
            }catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
