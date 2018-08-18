using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Managment.DAL;

namespace Pharmacy_Managment.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }
        public static bool check = false;

        public static int P_ID = 0;

        private void TSMLogin_Click(object sender, EventArgs e)
        {
            FRM_Login frm = new FRM_Login();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            if (P_ID == 1)
            {
                TSMProducts.Enabled = TSMCustomers.Enabled = TSMSuppliers.Enabled = TSMUsers.Enabled = TSMCustomerManagement.Enabled = TSMAddCustomer.Enabled = TSMBuyManagement.Enabled = TSMCountryManagement.Enabled = ادارةالمدنToolStripMenuItem.Enabled = true;
                    TSMBackup.Enabled = TSMResotre.Enabled = true;
            }
            else if (P_ID == 2)
            {
                TSMCustomerManagement.Enabled = TSMAddCustomer.Enabled = TSMBuyManagement.Enabled = TSMCountryManagement.Enabled = ادارةالمدنToolStripMenuItem.Enabled = false;
                TSMCustomers.Enabled= TSMNewBuy.Enabled = check;
            }
            else if (P_ID == 0)
            {
                TSMProducts.Enabled = TSMCustomers.Enabled = TSMSuppliers.Enabled = TSMUsers.Enabled =
                    TSMBackup.Enabled = TSMResotre.Enabled = check;
            }
            
        }

        private void TSMAddType_Click(object sender, EventArgs e)
        {
           // FRM_ADDCATEGORY cat = new FRM_ADDCATEGORY();
            //cat.ShowDialog();
            new FRM_ADDCATEGORY().ShowDialog();
        }

        private void TSMTypesManagement_Click(object sender, EventArgs e)
        {
            //FRM_CATEGORYMANAGEMENT cat = new FRM_CATEGORYMANAGEMENT();
            //cat.ShowDialog();
            new FRM_CATEGORYMANAGEMENT().ShowDialog();
        }

        private void TSMAddActiveMaterial_Click(object sender, EventArgs e)
        {
            new FRM_ADDACTIVEMATERIAL().ShowDialog();            
        }

        private void TSMActiveMaterialManagement_Click(object sender, EventArgs e)
        {
            new FRM_ACTIVEMATERIALMANAAGEMENT().ShowDialog();
        }

        private void TSMAddSceintificName_Click(object sender, EventArgs e)
        {
            new FRM_ADDSCEINTIFICNAME().ShowDialog();

        }

        private void TSMSceintificNameManagement_Click(object sender, EventArgs e)
        {
            new FRM_SCEINTIFICMANAGEMENT().ShowDialog();
        }

        private void TSMAddProduct_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWPRODUCT(false).ShowDialog();
        }

        private void TSMProductManagement_Click(object sender, EventArgs e)
        {
            new FRM_PRODUCTMANAGEMENT().ShowDialog();
        }

        private void TSMAddSupplier_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWSUPPLIER(true).ShowDialog();
        }

        private void TSMSuppliersManagement_Click(object sender, EventArgs e)
        {
            new FRM_SUPPLIERMANEGEMENT().ShowDialog();
        }

        private void TSMSellesMAnagement_Click(object sender, EventArgs e)
        {
            new FRM_REQUEST_MANAGEMENT().ShowDialog();
        }

        private void TSMNewSell_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWPURCHASE().ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void TSMLogout_Click(object sender, EventArgs e)
        {
            if (check)
            {
                P_ID = 0;
                TSMProducts.Enabled = TSMCustomers.Enabled = TSMSuppliers.Enabled = TSMUsers.Enabled =
                        TSMBackup.Enabled = TSMResotre.Enabled = check = false;
                new FRM_Login().ShowDialog();
            }
        }

        private void TSMBackup_Click(object sender, EventArgs e)
        {
            new FRM_BACKUP().ShowDialog();
        }

        private void TSMResotre_Click(object sender, EventArgs e)
        {
            new FRM_Restore().ShowDialog();
        }

        private void TSMAddUser_Click(object sender, EventArgs e)
        {
            new FRM_ADDNEWUSER(false).ShowDialog();
        }

        private void TSMUsersManagement_Click(object sender, EventArgs e)
        {
            new FRM_USER_MANGEMENT().ShowDialog();
        }

        private void ادارةالدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_COUNTRY().ShowDialog();
        }

        private void TSMNewBuy_Click(object sender, EventArgs e)
        {
            new FRM_AddNewSeles().ShowDialog();
        }

        private void ادارةالمدنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_CITY().ShowDialog();
        }

        private void TSMAddCustomer_Click(object sender, EventArgs e)
        {
            new FRM_AddNewCustomer(false).ShowDialog();
        }

        private void TSMCustomerManagement_Click(object sender, EventArgs e)
        {
            new FRM_CUSTOMER_MANEGEMENT().ShowDialog();
        }

        private void TSMBuyManagement_Click(object sender, EventArgs e)
        {
            new FRM_Order_Manegenment().ShowDialog();
        }

        
    }
}
