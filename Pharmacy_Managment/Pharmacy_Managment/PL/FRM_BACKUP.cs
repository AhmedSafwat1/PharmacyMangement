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
    public partial class FRM_BACKUP : Form
    {
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            txt_Path.Text = fd.SelectedPath;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = string.Format("{0}\\Pharmacy_DB-{1}{2}.bak", txt_Path.Text, DateTime.Now.ToShortDateString().Replace('/', '-') ,
                    DateTime.Now.ToLongTimeString().Replace(':', '-'));

                CLASS_HELPER.Backup_DB(path);
                MessageBox.Show("backup success");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
