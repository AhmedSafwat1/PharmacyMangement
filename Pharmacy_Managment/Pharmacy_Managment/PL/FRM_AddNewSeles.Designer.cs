namespace Pharmacy_Managment.PL
{
    partial class FRM_AddNewSeles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddNewSeles));
            this.TXTTOTAL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.BTNSAVEDATA = new System.Windows.Forms.Button();
            this.BTNBUYPROCESS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNSHOWPRODUCTDATA = new System.Windows.Forms.Button();
            this.TXTPRODUCTID = new System.Windows.Forms.TextBox();
            this.TXTPRODUCTNAAME = new System.Windows.Forms.TextBox();
            this.TXTPRODUCTPRICE = new System.Windows.Forms.TextBox();
            this.TXTQTY = new System.Windows.Forms.TextBox();
            this.grid_sales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNSHOWSUPPDATA = new System.Windows.Forms.Button();
            this.TXT_MOBILE = new System.Windows.Forms.TextBox();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_sellerNAME = new System.Windows.Forms.TextBox();
            this.ReqDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sales)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTTOTAL
            // 
            this.TXTTOTAL.Location = new System.Drawing.Point(18, 419);
            this.TXTTOTAL.Multiline = true;
            this.TXTTOTAL.Name = "TXTTOTAL";
            this.TXTTOTAL.ReadOnly = true;
            this.TXTTOTAL.Size = new System.Drawing.Size(170, 34);
            this.TXTTOTAL.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "الاجمالى:";
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Enabled = false;
            this.BTNDELETE.Image = ((System.Drawing.Image)(resources.GetObject("BTNDELETE.Image")));
            this.BTNDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDELETE.Location = new System.Drawing.Point(307, 470);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(135, 41);
            this.BTNDELETE.TabIndex = 18;
            this.BTNDELETE.Text = "حذف الصف المحدد";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.BackColor = System.Drawing.Color.Crimson;
            this.BTNCANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCEL.Image")));
            this.BTNCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCEL.Location = new System.Drawing.Point(31, 459);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(134, 52);
            this.BTNCANCEL.TabIndex = 17;
            this.BTNCANCEL.Text = "خروج ";
            this.BTNCANCEL.UseVisualStyleBackColor = false;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.Enabled = false;
            this.BTNPRINT.Image = ((System.Drawing.Image)(resources.GetObject("BTNPRINT.Image")));
            this.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINT.Location = new System.Drawing.Point(307, 420);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(135, 43);
            this.BTNPRINT.TabIndex = 16;
            this.BTNPRINT.Text = "طباعة الفاتورة";
            this.BTNPRINT.UseVisualStyleBackColor = true;
            // 
            // BTNSAVEDATA
            // 
            this.BTNSAVEDATA.Enabled = false;
            this.BTNSAVEDATA.Image = ((System.Drawing.Image)(resources.GetObject("BTNSAVEDATA.Image")));
            this.BTNSAVEDATA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSAVEDATA.Location = new System.Drawing.Point(562, 470);
            this.BTNSAVEDATA.Name = "BTNSAVEDATA";
            this.BTNSAVEDATA.Size = new System.Drawing.Size(127, 41);
            this.BTNSAVEDATA.TabIndex = 15;
            this.BTNSAVEDATA.Text = "حفظ بيانات الفاتورة";
            this.BTNSAVEDATA.UseVisualStyleBackColor = true;
            this.BTNSAVEDATA.Click += new System.EventHandler(this.BTNSAVEDATA_Click);
            // 
            // BTNBUYPROCESS
            // 
            this.BTNBUYPROCESS.Image = ((System.Drawing.Image)(resources.GetObject("BTNBUYPROCESS.Image")));
            this.BTNBUYPROCESS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBUYPROCESS.Location = new System.Drawing.Point(562, 418);
            this.BTNBUYPROCESS.Name = "BTNBUYPROCESS";
            this.BTNBUYPROCESS.Size = new System.Drawing.Size(127, 46);
            this.BTNBUYPROCESS.TabIndex = 14;
            this.BTNBUYPROCESS.Text = "عملية بيع جديدة";
            this.BTNBUYPROCESS.UseVisualStyleBackColor = true;
            this.BTNBUYPROCESS.Click += new System.EventHandler(this.BTNBUYPROCESS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.BTNSHOWPRODUCTDATA);
            this.groupBox3.Controls.Add(this.TXTPRODUCTID);
            this.groupBox3.Controls.Add(this.TXTPRODUCTNAAME);
            this.groupBox3.Controls.Add(this.TXTPRODUCTPRICE);
            this.groupBox3.Controls.Add(this.TXTQTY);
            this.groupBox3.Controls.Add(this.grid_sales);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 260);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(508, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "رقم المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(342, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "اسم المنتج";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(184, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "سعر المنتج";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "الكمية";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNSHOWPRODUCTDATA
            // 
            this.BTNSHOWPRODUCTDATA.Enabled = false;
            this.BTNSHOWPRODUCTDATA.Image = ((System.Drawing.Image)(resources.GetObject("BTNSHOWPRODUCTDATA.Image")));
            this.BTNSHOWPRODUCTDATA.Location = new System.Drawing.Point(668, 16);
            this.BTNSHOWPRODUCTDATA.Name = "BTNSHOWPRODUCTDATA";
            this.BTNSHOWPRODUCTDATA.Size = new System.Drawing.Size(43, 38);
            this.BTNSHOWPRODUCTDATA.TabIndex = 11;
            this.BTNSHOWPRODUCTDATA.Text = ".......";
            this.BTNSHOWPRODUCTDATA.UseVisualStyleBackColor = true;
            this.BTNSHOWPRODUCTDATA.Click += new System.EventHandler(this.BTNSHOWPRODUCTDATA_Click);
            // 
            // TXTPRODUCTID
            // 
            this.TXTPRODUCTID.Location = new System.Drawing.Point(508, 39);
            this.TXTPRODUCTID.Name = "TXTPRODUCTID";
            this.TXTPRODUCTID.ReadOnly = true;
            this.TXTPRODUCTID.Size = new System.Drawing.Size(154, 20);
            this.TXTPRODUCTID.TabIndex = 10;
            this.TXTPRODUCTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTPRODUCTNAAME
            // 
            this.TXTPRODUCTNAAME.Location = new System.Drawing.Point(342, 40);
            this.TXTPRODUCTNAAME.Name = "TXTPRODUCTNAAME";
            this.TXTPRODUCTNAAME.ReadOnly = true;
            this.TXTPRODUCTNAAME.Size = new System.Drawing.Size(160, 20);
            this.TXTPRODUCTNAAME.TabIndex = 9;
            this.TXTPRODUCTNAAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTPRODUCTPRICE
            // 
            this.TXTPRODUCTPRICE.Location = new System.Drawing.Point(184, 40);
            this.TXTPRODUCTPRICE.Name = "TXTPRODUCTPRICE";
            this.TXTPRODUCTPRICE.ReadOnly = true;
            this.TXTPRODUCTPRICE.Size = new System.Drawing.Size(152, 20);
            this.TXTPRODUCTPRICE.TabIndex = 7;
            this.TXTPRODUCTPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTQTY
            // 
            this.TXTQTY.Location = new System.Drawing.Point(6, 39);
            this.TXTQTY.MaxLength = 8;
            this.TXTQTY.Name = "TXTQTY";
            this.TXTQTY.Size = new System.Drawing.Size(166, 20);
            this.TXTQTY.TabIndex = 2;
            this.TXTQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTQTY_KeyDown);
            this.TXTQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTQTY_KeyPress);
            // 
            // grid_sales
            // 
            this.grid_sales.AllowUserToAddRows = false;
            this.grid_sales.AllowUserToDeleteRows = false;
            this.grid_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.grid_sales.Location = new System.Drawing.Point(6, 80);
            this.grid_sales.Name = "grid_sales";
            this.grid_sales.ReadOnly = true;
            this.grid_sales.RowHeadersVisible = false;
            this.grid_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_sales.Size = new System.Drawing.Size(669, 174);
            this.grid_sales.TabIndex = 0;
            this.grid_sales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_sales_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر المنتج";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الكمية";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNSHOWSUPPDATA);
            this.groupBox2.Controls.Add(this.TXT_MOBILE);
            this.groupBox2.Controls.Add(this.TXT_NAME);
            this.groupBox2.Controls.Add(this.TXT_ID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(419, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 134);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // BTNSHOWSUPPDATA
            // 
            this.BTNSHOWSUPPDATA.Enabled = false;
            this.BTNSHOWSUPPDATA.Image = ((System.Drawing.Image)(resources.GetObject("BTNSHOWSUPPDATA.Image")));
            this.BTNSHOWSUPPDATA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSHOWSUPPDATA.Location = new System.Drawing.Point(6, 27);
            this.BTNSHOWSUPPDATA.Name = "BTNSHOWSUPPDATA";
            this.BTNSHOWSUPPDATA.Size = new System.Drawing.Size(75, 23);
            this.BTNSHOWSUPPDATA.TabIndex = 6;
            this.BTNSHOWSUPPDATA.Text = ".......";
            this.BTNSHOWSUPPDATA.UseVisualStyleBackColor = true;
            this.BTNSHOWSUPPDATA.Click += new System.EventHandler(this.BTNSHOWSUPPDATA_Click);
            // 
            // TXT_MOBILE
            // 
            this.TXT_MOBILE.Location = new System.Drawing.Point(6, 96);
            this.TXT_MOBILE.Name = "TXT_MOBILE";
            this.TXT_MOBILE.ReadOnly = true;
            this.TXT_MOBILE.Size = new System.Drawing.Size(241, 20);
            this.TXT_MOBILE.TabIndex = 5;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(6, 63);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.ReadOnly = true;
            this.TXT_NAME.Size = new System.Drawing.Size(241, 20);
            this.TXT_NAME.TabIndex = 4;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(95, 28);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(152, 20);
            this.TXT_ID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم الموبايل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم العميل";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_sellerNAME);
            this.groupBox1.Controls.Add(this.ReqDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // TXT_sellerNAME
            // 
            this.TXT_sellerNAME.Location = new System.Drawing.Point(19, 75);
            this.TXT_sellerNAME.Name = "TXT_sellerNAME";
            this.TXT_sellerNAME.ReadOnly = true;
            this.TXT_sellerNAME.Size = new System.Drawing.Size(200, 20);
            this.TXT_sellerNAME.TabIndex = 3;
            // 
            // ReqDate
            // 
            this.ReqDate.Location = new System.Drawing.Point(19, 29);
            this.ReqDate.Name = "ReqDate";
            this.ReqDate.Size = new System.Drawing.Size(200, 20);
            this.ReqDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "اسم البائع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "تاريخ الفاتورة";
            // 
            // FRM_AddNewSeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(747, 512);
            this.Controls.Add(this.TXTTOTAL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNCANCEL);
            this.Controls.Add(this.BTNPRINT);
            this.Controls.Add(this.BTNSAVEDATA);
            this.Controls.Add(this.BTNBUYPROCESS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_AddNewSeles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فاتورة بيع جديدة";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sales)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTTOTAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Button BTNSAVEDATA;
        private System.Windows.Forms.Button BTNBUYPROCESS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNSHOWPRODUCTDATA;
        private System.Windows.Forms.TextBox TXTPRODUCTID;
        private System.Windows.Forms.TextBox TXTPRODUCTNAAME;
        private System.Windows.Forms.TextBox TXTPRODUCTPRICE;
        private System.Windows.Forms.TextBox TXTQTY;
        private System.Windows.Forms.DataGridView grid_sales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNSHOWSUPPDATA;
        private System.Windows.Forms.TextBox TXT_MOBILE;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_sellerNAME;
        private System.Windows.Forms.DateTimePicker ReqDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}