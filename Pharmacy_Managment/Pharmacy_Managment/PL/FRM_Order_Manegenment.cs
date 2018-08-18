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
    public partial class FRM_Order_Manegenment : Form
    {
        public FRM_Order_Manegenment()
        {
            InitializeComponent();
            btn_display_Click(null,null);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            grid_request.DataSource = CLASS_ORDER.sp_Order_Select();
        }
    }
}
