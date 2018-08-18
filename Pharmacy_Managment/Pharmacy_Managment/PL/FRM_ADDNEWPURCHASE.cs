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
    public partial class FRM_ADDNEWPURCHASE : Form
    {
        public FRM_ADDNEWPURCHASE()
        {
            InitializeComponent();
            TXT_BUYERNAME.Text = Program.USERFULLNAME;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_SEARCH FRM = new FRM_SEARCH("supplier");
            FRM.ShowDialog();
           TXTSU_ID.Text= FRM.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           TXTSU_NAME.Text= FRM.dataGridView1.CurrentRow.Cells[1].Value.ToString();
           TXTSU_MOBILE.Text= FRM.dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void BTNSHOWPRODUCTDATA_Click(object sender, EventArgs e)
        {
            FRM_SEARCH frm = new FRM_SEARCH("product");
            frm.ShowDialog();
            TXTPRODUCTID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTPRODUCTNAAME.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTPRODUCTPRICE.Text = frm.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void TXTQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d=char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;
            }
        }

        private void TXTQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TXTPRODUCTID.Text == "")
                {
                    MessageBox.Show("يجب اختيار المنتج");
                    return;
                }
                if (TXTQTY.Text == "" || double.Parse(TXTQTY.Text) <= 0)
                {
                    MessageBox.Show("يجب ادخال كمية المنتج وتكون موجبة");
                    return;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (TXTPRODUCTID.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("هذا المنتج موجود ");
                        return;
                    }
                }
                string date="";
                if (dateTimePicker2.Checked)
                {
                    date = dateTimePicker2.Text;
                    dataGridView1.Rows.Add(TXTPRODUCTID.Text, TXTPRODUCTNAAME.Text, date, TXTPRODUCTPRICE.Text, TXTQTY.Text);
                }
                
                TXTPRODUCTID.Text = TXTPRODUCTNAAME.Text = TXTPRODUCTPRICE.Text = TXTQTY.Text = "";
                BTNDELETE.Enabled = true;
                calctotal();
            }
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            calctotal();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTPRODUCTID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTPRODUCTNAAME.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
            {
                dateTimePicker2.Checked = false;
            }
            else
            {
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


                TXTPRODUCTPRICE.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TXTQTY.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }

            BTNDELETE_Click(null, null);
        }

        void calctotal()
        {
            double total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            TXTTOTAL.Text = total.ToString();
        }

        private void TXTTOTAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBUYPROCESS_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            TXTTOTAL.Text = "";
            TXTSU_ID.Text = TXTSU_MOBILE.Text = TXTSU_NAME.Text = TXTPRODUCTID.Text = TXTPRODUCTPRICE.Text = TXTQTY.Text = "";
            BTNSHOWPRODUCTDATA.Enabled = BTNSHOWSUPPDATA.Enabled = BTNSAVEDATA.Enabled = true;
            BTNBUYPROCESS.Enabled = false;
        }

        private void BTNSAVEDATA_Click(object sender, EventArgs e)
        {
            //try
            //{
                DataTable dtreqdet = new DataTable();
                dtreqdet.Columns.Add("P_ID");
                dtreqdet.Columns.Add("QTY");
                dtreqdet.Columns.Add("P_Price");

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    dtreqdet.Rows.Add(dr.Cells[0].Value, dr.Cells[4].Value, dr.Cells[3].Value);
                }

                DataTable dtexpired = new DataTable();
                dtexpired.Columns.Add("ex_date");
                dtexpired.Columns.Add("P_Id");
                dtexpired.Columns.Add("QTY");

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    object expired;
                    //MessageBox.Show(dr.Cells[2].Value.ToString());
                    if (dr.Cells[2].Value.ToString() == "")
                    {
                        expired = null;
                    }
                    else
                    {
                        expired = DateTime.Parse(dr.Cells[2].Value.ToString());
                    }
                        dtexpired.Rows.Add(expired, dr.Cells[0].Value, dr.Cells[4].Value);
                }
                CLASS_REQUEST.SP_Request_Insert(ReqDate.Value.Date, TXTTOTAL.Text, int.Parse(TXTSU_ID.Text),
                    TXT_BUYERNAME.Text, dtreqdet, dtexpired);
                
                 
                MessageBox.Show("success");
                BTNPRINT.Enabled = BTNBUYPROCESS.Enabled = true;
            //}
            // catch (Exception ex)
            // { MessageBox.Show(ex.Message); }
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_REQUEST rpt = new RPT.RPT_REQUEST();
            rpt.SetParameterValue("@Req_ID", CLASS_REQUEST.max_id());
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
    }
}
