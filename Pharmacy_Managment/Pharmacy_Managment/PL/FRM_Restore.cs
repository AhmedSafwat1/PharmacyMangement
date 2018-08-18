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
    public partial class FRM_Restore : Form
    {
        public FRM_Restore()
        {
            InitializeComponent();
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog  ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = ofd.FileName;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            try 
            {
                string path = txt_Path.Text;
                CLASS_HELPER.Restore_DB(path);
                MessageBox.Show("Restore database");
      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
