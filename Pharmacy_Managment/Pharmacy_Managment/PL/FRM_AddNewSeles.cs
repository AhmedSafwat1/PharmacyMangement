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
    public partial class FRM_AddNewSeles : Form
    {
        public FRM_AddNewSeles()
        {
            InitializeComponent();
            TXT_sellerNAME.Text = Program.USERFULLNAME;
        }

        private void BTNSHOWSUPPDATA_Click(object sender, EventArgs e)
        {
            FRM_SEARCH frm = new FRM_SEARCH("customer");
            frm.ShowDialog();
            TXT_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXT_NAME.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXT_MOBILE.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BTNBUYPROCESS_Click(object sender, EventArgs e)
        {
            BTNSHOWPRODUCTDATA.Enabled = BTNSHOWSUPPDATA.Enabled = true;
            BTNBUYPROCESS.Enabled = false;
            TXT_ID.Text = TXT_MOBILE.Text = TXT_NAME.Text = TXTPRODUCTID.Text = TXTPRODUCTNAAME.Text = TXTPRODUCTPRICE.Text = TXTQTY.Text = TXTTOTAL.Text = "";
            grid_sales.Rows.Clear();
        }

        float totalQty;
        private void BTNSHOWPRODUCTDATA_Click(object sender, EventArgs e)
        {
            FRM_SEARCH frm = new FRM_SEARCH("product");
            frm.ShowDialog();
            TXTPRODUCTID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTPRODUCTNAAME.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTPRODUCTPRICE.Text = frm.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            totalQty = float.Parse(frm.dataGridView1.CurrentRow.Cells[7].Value.ToString());
        }

        private void TXTQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;
            }
        }

        private void TXTQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(TXTPRODUCTID.Text =="")
                {
                    MessageBox.Show("يجب اختيار المنتج");
                    return;
                }
                 if(TXTQTY.Text ==""|| float.Parse(TXTQTY.Text)<= 0)
                 {
                     MessageBox.Show(" يجب ادخال الكمية بالموجب");
                     return;
                 }
                if(float.Parse(TXTQTY.Text)> totalQty)
                {
                    MessageBox.Show("الكمية المطلوبة اكبر من الكمية الموجوده فى المخزن");
                    return;

                }
                 for (int i=0; i < grid_sales.Rows.Count; i++)
                 {
                    if(TXTPRODUCTID.Text==grid_sales.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("هذا المنتج موجود بالفعل ");
                        return;
                    }
                 }
                 grid_sales.Rows.Add(TXTPRODUCTID.Text,TXTPRODUCTNAAME.Text,TXTPRODUCTPRICE.Text,TXTQTY.Text);
                 BTNDELETE.Enabled = true;
                 TXTQTY.Text = TXTPRODUCTPRICE.Text = TXTPRODUCTNAAME.Text = TXTPRODUCTID.Text = "";
                 calcorderTotal();
                 BTNSAVEDATA.Enabled = true;
            }
        }
        void calcorderTotal()
        {
            float total = 0;
            for (int i = 0; i< grid_sales.Rows.Count; i++)
            {
                total += float.Parse(grid_sales.Rows[i].Cells[2].Value.ToString()) * float.Parse(grid_sales.Rows[i].Cells[3].Value.ToString());

            }
            TXTTOTAL.Text = total.ToString();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            grid_sales.Rows.Remove(grid_sales.CurrentRow);
            calcorderTotal();
        }

        private void grid_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTPRODUCTID.Text = grid_sales.CurrentRow.Cells[0].Value.ToString();
            TXTPRODUCTNAAME.Text = grid_sales.CurrentRow.Cells[1].Value.ToString();
            TXTPRODUCTPRICE.Text = grid_sales.CurrentRow.Cells[2].Value.ToString();
            TXTQTY.Text = grid_sales.CurrentRow.Cells[3].Value.ToString();
            BTNDELETE_Click(null, null);
        }

        private void BTNSAVEDATA_Click(object sender, EventArgs e)
        {
            //try
            //{
                DataTable orderDet = new DataTable();
                orderDet.Columns.Add("P_ID");
                orderDet.Columns.Add("Qty");
                orderDet.Columns.Add("P_Price");

                for (int i = 0; i< grid_sales.Rows.Count; i++)
                {
                    orderDet.Rows.Add(grid_sales.Rows[i].Cells[0].Value,
                        grid_sales.Rows[i].Cells[3].Value,
                        grid_sales.Rows[i].Cells[2].Value);
                    
                }
                CLASS_ORDER.sp_Order_Insert(ReqDate.Value,TXTTOTAL.Text, int.Parse(TXT_ID.Text),
                    TXT_sellerNAME.Text, orderDet);
                MessageBox.Show("success");

                BTNPRINT.Enabled = BTNBUYPROCESS.Enabled=true;
                BTNSAVEDATA.Enabled = false;

               
            //}
            //catch(Exception ex)
            //{ MessageBox.Show(ex.Message); }
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
