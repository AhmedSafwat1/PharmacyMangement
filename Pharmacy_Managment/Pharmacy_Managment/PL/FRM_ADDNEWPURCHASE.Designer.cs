namespace Pharmacy_Managment.PL
{
    partial class FRM_ADDNEWPURCHASE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDNEWPURCHASE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_BUYERNAME = new System.Windows.Forms.TextBox();
            this.ReqDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNSHOWSUPPDATA = new System.Windows.Forms.Button();
            this.TXTSU_MOBILE = new System.Windows.Forms.TextBox();
            this.TXTSU_NAME = new System.Windows.Forms.TextBox();
            this.TXTSU_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNSHOWPRODUCTDATA = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TXTPRODUCTID = new System.Windows.Forms.TextBox();
            this.TXTPRODUCTNAAME = new System.Windows.Forms.TextBox();
            this.TXTPRODUCTPRICE = new System.Windows.Forms.TextBox();
            this.TXTQTY = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNBUYPROCESS = new System.Windows.Forms.Button();
            this.BTNSAVEDATA = new System.Windows.Forms.Button();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTTOTAL = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_BUYERNAME);
            this.groupBox1.Controls.Add(this.ReqDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // TXT_BUYERNAME
            // 
            this.TXT_BUYERNAME.Location = new System.Drawing.Point(19, 75);
            this.TXT_BUYERNAME.Name = "TXT_BUYERNAME";
            this.TXT_BUYERNAME.ReadOnly = true;
            this.TXT_BUYERNAME.Size = new System.Drawing.Size(200, 20);
            this.TXT_BUYERNAME.TabIndex = 3;
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
            this.label5.Location = new System.Drawing.Point(264, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "اسم المشترى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "تاريخ الفاتورة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNSHOWSUPPDATA);
            this.groupBox2.Controls.Add(this.TXTSU_MOBILE);
            this.groupBox2.Controls.Add(this.TXTSU_NAME);
            this.groupBox2.Controls.Add(this.TXTSU_ID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المورد";
            // 
            // BTNSHOWSUPPDATA
            // 
            this.BTNSHOWSUPPDATA.Enabled = false;
            this.BTNSHOWSUPPDATA.Image = ((System.Drawing.Image)(resources.GetObject("BTNSHOWSUPPDATA.Image")));
            this.BTNSHOWSUPPDATA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSHOWSUPPDATA.Location = new System.Drawing.Point(83, 27);
            this.BTNSHOWSUPPDATA.Name = "BTNSHOWSUPPDATA";
            this.BTNSHOWSUPPDATA.Size = new System.Drawing.Size(75, 23);
            this.BTNSHOWSUPPDATA.TabIndex = 6;
            this.BTNSHOWSUPPDATA.Text = ".......";
            this.BTNSHOWSUPPDATA.UseVisualStyleBackColor = true;
            this.BTNSHOWSUPPDATA.Click += new System.EventHandler(this.button6_Click);
            // 
            // TXTSU_MOBILE
            // 
            this.TXTSU_MOBILE.Location = new System.Drawing.Point(83, 96);
            this.TXTSU_MOBILE.Name = "TXTSU_MOBILE";
            this.TXTSU_MOBILE.ReadOnly = true;
            this.TXTSU_MOBILE.Size = new System.Drawing.Size(241, 20);
            this.TXTSU_MOBILE.TabIndex = 5;
            // 
            // TXTSU_NAME
            // 
            this.TXTSU_NAME.Location = new System.Drawing.Point(83, 63);
            this.TXTSU_NAME.Name = "TXTSU_NAME";
            this.TXTSU_NAME.ReadOnly = true;
            this.TXTSU_NAME.Size = new System.Drawing.Size(241, 20);
            this.TXTSU_NAME.TabIndex = 4;
            // 
            // TXTSU_ID
            // 
            this.TXTSU_ID.Location = new System.Drawing.Point(172, 28);
            this.TXTSU_ID.Name = "TXTSU_ID";
            this.TXTSU_ID.ReadOnly = true;
            this.TXTSU_ID.Size = new System.Drawing.Size(152, 20);
            this.TXTSU_ID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم الموبايل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المورد";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.BTNSHOWPRODUCTDATA);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.TXTPRODUCTID);
            this.groupBox3.Controls.Add(this.TXTPRODUCTNAAME);
            this.groupBox3.Controls.Add(this.TXTPRODUCTPRICE);
            this.groupBox3.Controls.Add(this.TXTQTY);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(657, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "رقم المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(491, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "اسم المنتج";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(330, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "تاريخ الصلاحية";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(172, 9);
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
            this.label7.Location = new System.Drawing.Point(0, 9);
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
            this.BTNSHOWPRODUCTDATA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSHOWPRODUCTDATA.Location = new System.Drawing.Point(817, 9);
            this.BTNSHOWPRODUCTDATA.Name = "BTNSHOWPRODUCTDATA";
            this.BTNSHOWPRODUCTDATA.Size = new System.Drawing.Size(46, 38);
            this.BTNSHOWPRODUCTDATA.TabIndex = 11;
            this.BTNSHOWPRODUCTDATA.Text = ".......";
            this.BTNSHOWPRODUCTDATA.UseVisualStyleBackColor = true;
            this.BTNSHOWPRODUCTDATA.Click += new System.EventHandler(this.BTNSHOWPRODUCTDATA_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(330, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // TXTPRODUCTID
            // 
            this.TXTPRODUCTID.Location = new System.Drawing.Point(657, 32);
            this.TXTPRODUCTID.Name = "TXTPRODUCTID";
            this.TXTPRODUCTID.ReadOnly = true;
            this.TXTPRODUCTID.Size = new System.Drawing.Size(154, 20);
            this.TXTPRODUCTID.TabIndex = 10;
            this.TXTPRODUCTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTPRODUCTNAAME
            // 
            this.TXTPRODUCTNAAME.Location = new System.Drawing.Point(491, 33);
            this.TXTPRODUCTNAAME.Name = "TXTPRODUCTNAAME";
            this.TXTPRODUCTNAAME.ReadOnly = true;
            this.TXTPRODUCTNAAME.Size = new System.Drawing.Size(160, 20);
            this.TXTPRODUCTNAAME.TabIndex = 9;
            this.TXTPRODUCTNAAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTPRODUCTPRICE
            // 
            this.TXTPRODUCTPRICE.Location = new System.Drawing.Point(172, 33);
            this.TXTPRODUCTPRICE.Name = "TXTPRODUCTPRICE";
            this.TXTPRODUCTPRICE.ReadOnly = true;
            this.TXTPRODUCTPRICE.Size = new System.Drawing.Size(152, 20);
            this.TXTPRODUCTPRICE.TabIndex = 7;
            this.TXTPRODUCTPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTQTY
            // 
            this.TXTQTY.Location = new System.Drawing.Point(0, 33);
            this.TXTQTY.MaxLength = 8;
            this.TXTQTY.Name = "TXTQTY";
            this.TXTQTY.Size = new System.Drawing.Size(166, 20);
            this.TXTQTY.TabIndex = 2;
            this.TXTQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTQTY_KeyDown);
            this.TXTQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTQTY_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(857, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // Column3
            // 
            this.Column3.HeaderText = "تاريخ الصلاحية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            // BTNBUYPROCESS
            // 
            this.BTNBUYPROCESS.Image = ((System.Drawing.Image)(resources.GetObject("BTNBUYPROCESS.Image")));
            this.BTNBUYPROCESS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBUYPROCESS.Location = new System.Drawing.Point(98, 456);
            this.BTNBUYPROCESS.Name = "BTNBUYPROCESS";
            this.BTNBUYPROCESS.Size = new System.Drawing.Size(120, 43);
            this.BTNBUYPROCESS.TabIndex = 3;
            this.BTNBUYPROCESS.Text = "عملية شراء جديدة";
            this.BTNBUYPROCESS.UseVisualStyleBackColor = true;
            this.BTNBUYPROCESS.Click += new System.EventHandler(this.BTNBUYPROCESS_Click);
            // 
            // BTNSAVEDATA
            // 
            this.BTNSAVEDATA.Enabled = false;
            this.BTNSAVEDATA.Image = ((System.Drawing.Image)(resources.GetObject("BTNSAVEDATA.Image")));
            this.BTNSAVEDATA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSAVEDATA.Location = new System.Drawing.Point(265, 456);
            this.BTNSAVEDATA.Name = "BTNSAVEDATA";
            this.BTNSAVEDATA.Size = new System.Drawing.Size(127, 43);
            this.BTNSAVEDATA.TabIndex = 4;
            this.BTNSAVEDATA.Text = "حفظ بيانات الفاتورة";
            this.BTNSAVEDATA.UseVisualStyleBackColor = true;
            this.BTNSAVEDATA.Click += new System.EventHandler(this.BTNSAVEDATA_Click);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.Enabled = false;
            this.BTNPRINT.Image = ((System.Drawing.Image)(resources.GetObject("BTNPRINT.Image")));
            this.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINT.Location = new System.Drawing.Point(458, 456);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(130, 43);
            this.BTNPRINT.TabIndex = 5;
            this.BTNPRINT.Text = "طباعة الفاتورة";
            this.BTNPRINT.UseVisualStyleBackColor = true;
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCEL.Image")));
            this.BTNCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCEL.Location = new System.Drawing.Point(672, 456);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(132, 43);
            this.BTNCANCEL.TabIndex = 6;
            this.BTNCANCEL.Text = "خروج ";
            this.BTNCANCEL.UseVisualStyleBackColor = true;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.BackColor = System.Drawing.Color.Crimson;
            this.BTNDELETE.Enabled = false;
            this.BTNDELETE.Image = ((System.Drawing.Image)(resources.GetObject("BTNDELETE.Image")));
            this.BTNDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDELETE.Location = new System.Drawing.Point(15, 391);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(135, 43);
            this.BTNDELETE.TabIndex = 7;
            this.BTNDELETE.Text = "حذف الصف المحدد";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "الاجمالى:";
            // 
            // TXTTOTAL
            // 
            this.TXTTOTAL.Location = new System.Drawing.Point(628, 403);
            this.TXTTOTAL.Multiline = true;
            this.TXTTOTAL.Name = "TXTTOTAL";
            this.TXTTOTAL.ReadOnly = true;
            this.TXTTOTAL.Size = new System.Drawing.Size(176, 36);
            this.TXTTOTAL.TabIndex = 9;
            this.TXTTOTAL.TextChanged += new System.EventHandler(this.TXTTOTAL_TextChanged);
            // 
            // FRM_ADDNEWPURCHASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(884, 511);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADDNEWPURCHASE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عملية شراء جديدة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNBUYPROCESS;
        private System.Windows.Forms.Button BTNSAVEDATA;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.TextBox TXT_BUYERNAME;
        private System.Windows.Forms.DateTimePicker ReqDate;
        private System.Windows.Forms.Button BTNSHOWSUPPDATA;
        private System.Windows.Forms.TextBox TXTSU_MOBILE;
        private System.Windows.Forms.TextBox TXTSU_NAME;
        private System.Windows.Forms.TextBox TXTSU_ID;
        private System.Windows.Forms.Button BTNSHOWPRODUCTDATA;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox TXTPRODUCTID;
        private System.Windows.Forms.TextBox TXTPRODUCTNAAME;
        private System.Windows.Forms.TextBox TXTPRODUCTPRICE;
        private System.Windows.Forms.TextBox TXTQTY;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTTOTAL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}