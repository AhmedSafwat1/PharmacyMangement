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
    public partial class FRM_ADDNEWPRODUCT : Form
    {
        bool _ISUPDATE;
        public FRM_ADDNEWPRODUCT(bool ISUPDATE )
        {
            InitializeComponent();
            this._ISUPDATE=ISUPDATE;

            DataTable DTCAT = CLASS_PRODUCTS.SP_FILLCATCMB();
            CMBCAT.DataSource = DTCAT;
            CMBCAT.DisplayMember = "Cat_Name";
            CMBCAT.ValueMember = "Cat_ID";

            DataTable DTAM = CLASS_PRODUCTS.SP_FILLAMCMB();
            CMBAM.DataSource = DTAM;
            CMBAM.DisplayMember = "Am_Name";
            CMBAM.ValueMember = "Am_ID";

            DataTable DTSN = CLASS_PRODUCTS.SP_FILLSNCMB();
            CMBSN.DataSource = DTSN;
            CMBSN.DisplayMember = "Sn_Name";
            CMBSN.ValueMember = "Sn_id";

            if (_ISUPDATE == true)
            {
                this.Text = "تعديل بيانات المنتج";
                BTNADD.Text = "تعديل";
                DataTable dt = CLASS_PRODUCTS.SP_GETSELECTEDPRODUCT(FRM_PRODUCTMANAGEMENT.ID);
                foreach (DataRow dr in dt.Rows)
                { 
                    CMBCAT.Text=dr["Cat_Name"].ToString();
                    TXTPRODUCTNAME.Text = dr["P_Name"].ToString();
                    TXTPRODUCTDESC.Text = dr["P_Description"].ToString();
                    TXTBUYPRICE.Text = dr["buyPrice"].ToString();
                    TXTSELLPRICE.Text = dr["SellPrice"].ToString();
                    CMBAM.Text = dr["Am_Name"].ToString();
                    CMBSN.Text = dr["Sn_Name"].ToString();
                    TXTBARCODE.Text = dr["Barcode"].ToString();
                    byte[] arr = (byte[])dr["P_Image"]; 
                    MemoryStream ms=new MemoryStream(arr);
                    PICIMAGE.Image=Image.FromStream(ms);
                }
                 
            }
            else {
                this.Text = "اضافة بيانات المنتج";
                BTNADD.Text = "اضافة";
            }
        }

        private void BTNCHOOSE_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*|JPG|*.jpg|PNG|*.png";
                ofd.ShowDialog();
                PICIMAGE.Image = Image.FromFile(ofd.FileName);
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PICIMAGE.Image.Save(ms, PICIMAGE.Image.RawFormat);
            byte[] arr = ms.ToArray();
            if (_ISUPDATE==false)
            {

                CLASS_PRODUCTS.SP_ADDNEWPRODUCT(TXTPRODUCTNAME.Text, TXTPRODUCTDESC.Text, arr, TXTBUYPRICE.Text, TXTSELLPRICE.Text,
                    (int)CMBCAT.SelectedValue, (int)CMBAM.SelectedValue, (int)CMBSN.SelectedValue, TXTBARCODE.Text);
                MessageBox.Show("تم اضافة المنتج");
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                }

            }
            else {
               

                CLASS_PRODUCTS.SP_PRODUCTUPDATE (FRM_PRODUCTMANAGEMENT.ID,TXTPRODUCTNAME.Text, TXTPRODUCTDESC.Text, arr, TXTBUYPRICE.Text, TXTSELLPRICE.Text,
                    (int)CMBCAT.SelectedValue, (int)CMBAM.SelectedValue, (int)CMBSN.SelectedValue, TXTBARCODE.Text);
                MessageBox.Show("تم تعديل المنتج");
            }
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
