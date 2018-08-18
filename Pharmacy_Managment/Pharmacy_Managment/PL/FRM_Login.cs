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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == string.Empty)
            {
                MessageBox.Show("you must enter username");
                return;
            }
            if (txtUPass.Text == string.Empty)
            {
                MessageBox.Show("you must enter the password");
                return;
            }
            DataTable dt = CLASS_LOGIN.splogin(txtUName.Text, txtUPass.Text);
            if (dt.Rows.Count > 0)
            {
                FRM_MAIN.check = true;
                FRM_MAIN.P_ID = int.Parse(dt.Rows[0]["per_ID"].ToString());
                Program.USERFULLNAME = dt.Rows[0]["U_Full_Name"].ToString();
                this.Close();
            }
            else
                MessageBox.Show("username or password is wrong");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
