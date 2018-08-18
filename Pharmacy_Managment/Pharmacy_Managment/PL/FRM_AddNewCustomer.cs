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
using System.IO;

namespace Pharmacy_Managment.PL
{
    public partial class FRM_AddNewCustomer : Form
    {
        bool ISUpdate;
        public FRM_AddNewCustomer(bool _ISUpdate)
        {
            
            InitializeComponent();

            this.ISUpdate = _ISUpdate;
            cmb_country.DataSource = CLASS_COUNTRY.sp_country_display();
            cmb_country.DisplayMember = "اسم الدولة";
            cmb_country.ValueMember = "رقم الدولة";
            cmb_country_SelectionChangeCommitted(null, null);
            if(ISUpdate)
            {
                this.Text ="تعديل بيانات العميل";
                btn_ok.Text ="تعديل";
                txt_Name.Text = FRM_CUSTOMER_MANEGEMENT.row.Cells[1].Value.ToString();
                txt_Addres.Text = FRM_CUSTOMER_MANEGEMENT.row.Cells[2].Value.ToString();
                txt_Mobile.Text = FRM_CUSTOMER_MANEGEMENT.row.Cells[3].Value.ToString();
                MemoryStream ms = new MemoryStream(FRM_CUSTOMER_MANEGEMENT.row.Cells[4].Value as byte[]);
                pic_Image.Image = Image.FromStream(ms);
                cmb_country.Text = FRM_CUSTOMER_MANEGEMENT.row.Cells[5].Value.ToString();
                cmb_city.Text = FRM_CUSTOMER_MANEGEMENT.row.Cells[6].Value.ToString();
            }else
            {
                 this.Text ="اضافة بيانات العميل ";
                btn_ok.Text ="اضافة ";
            }

        }

        private void cmb_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_city.DataSource = CLASS_CUSTOMER.sp_city_country_ID(int.Parse(cmb_country.SelectedValue.ToString()));
            cmb_city.DisplayMember = "City_Name";
            cmb_city.ValueMember = "City_ID";
        }

        private void pic_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MemoryStream ms =new MemoryStream();
            pic_Image.Image.Save(ms,pic_Image.Image.RawFormat);
            byte[] cu_image =ms.ToArray();

            if( txt_Name.Text =="")
            {
                MessageBox.Show("يجب ادخال اسم العميل");
                return;
            }
            if(ISUpdate)
            {
                CLASS_CUSTOMER.sp_customer_update(int.Parse(FRM_CUSTOMER_MANEGEMENT.row.Cells[0].Value.ToString()),txt_Name.Text,
                    txt_Addres.Text, txt_Mobile.Text, cu_image, int.Parse(cmb_city.SelectedValue.ToString()));
                MessageBox.Show("تم التعديل ");
            }
            else{
                CLASS_CUSTOMER.sp_customer_insert(txt_Name.Text,txt_Addres.Text,txt_Mobile.Text,cu_image,int.Parse(cmb_city.SelectedValue.ToString()));
                MessageBox.Show("تم الاضافة");
                txt_Name.Text = txt_Addres.Text = txt_Mobile.Text = "";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
