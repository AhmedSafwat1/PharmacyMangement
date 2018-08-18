namespace Pharmacy_Managment.PL
{
    partial class FRM_ADDNEWPRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDNEWPRODUCT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNCHOOSE = new System.Windows.Forms.Button();
            this.PICIMAGE = new System.Windows.Forms.PictureBox();
            this.TXTBARCODE = new System.Windows.Forms.TextBox();
            this.TXTPRODUCTDESC = new System.Windows.Forms.TextBox();
            this.TXTBUYPRICE = new System.Windows.Forms.TextBox();
            this.TXTSELLPRICE = new System.Windows.Forms.TextBox();
            this.TXTPRODUCTNAME = new System.Windows.Forms.TextBox();
            this.CMBAM = new System.Windows.Forms.ComboBox();
            this.CMBSN = new System.Windows.Forms.ComboBox();
            this.CMBCAT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.BTNCANCEL);
            this.groupBox1.Controls.Add(this.BTNADD);
            this.groupBox1.Controls.Add(this.BTNCHOOSE);
            this.groupBox1.Controls.Add(this.PICIMAGE);
            this.groupBox1.Controls.Add(this.TXTBARCODE);
            this.groupBox1.Controls.Add(this.TXTPRODUCTDESC);
            this.groupBox1.Controls.Add(this.TXTBUYPRICE);
            this.groupBox1.Controls.Add(this.TXTSELLPRICE);
            this.groupBox1.Controls.Add(this.TXTPRODUCTNAME);
            this.groupBox1.Controls.Add(this.CMBAM);
            this.groupBox1.Controls.Add(this.CMBSN);
            this.groupBox1.Controls.Add(this.CMBCAT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.BackColor = System.Drawing.Color.Crimson;
            this.BTNCANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCEL.Image")));
            this.BTNCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCEL.Location = new System.Drawing.Point(29, 414);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(95, 37);
            this.BTNCANCEL.TabIndex = 20;
            this.BTNCANCEL.Text = "الغاء";
            this.BTNCANCEL.UseVisualStyleBackColor = false;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BTNADD.Image = ((System.Drawing.Image)(resources.GetObject("BTNADD.Image")));
            this.BTNADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNADD.Location = new System.Drawing.Point(167, 414);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(97, 37);
            this.BTNADD.TabIndex = 19;
            this.BTNADD.Text = "اضافة";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNCHOOSE
            // 
            this.BTNCHOOSE.Location = new System.Drawing.Point(287, 335);
            this.BTNCHOOSE.Name = "BTNCHOOSE";
            this.BTNCHOOSE.Size = new System.Drawing.Size(75, 23);
            this.BTNCHOOSE.TabIndex = 18;
            this.BTNCHOOSE.Text = "اختيار صورة المنتج";
            this.BTNCHOOSE.UseVisualStyleBackColor = true;
            this.BTNCHOOSE.Click += new System.EventHandler(this.BTNCHOOSE_Click);
            // 
            // PICIMAGE
            // 
            this.PICIMAGE.Image = ((System.Drawing.Image)(resources.GetObject("PICIMAGE.Image")));
            this.PICIMAGE.Location = new System.Drawing.Point(12, 278);
            this.PICIMAGE.Name = "PICIMAGE";
            this.PICIMAGE.Size = new System.Drawing.Size(264, 89);
            this.PICIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICIMAGE.TabIndex = 17;
            this.PICIMAGE.TabStop = false;
            // 
            // TXTBARCODE
            // 
            this.TXTBARCODE.Location = new System.Drawing.Point(12, 252);
            this.TXTBARCODE.Name = "TXTBARCODE";
            this.TXTBARCODE.Size = new System.Drawing.Size(264, 20);
            this.TXTBARCODE.TabIndex = 16;
            // 
            // TXTPRODUCTDESC
            // 
            this.TXTPRODUCTDESC.Location = new System.Drawing.Point(12, 88);
            this.TXTPRODUCTDESC.Multiline = true;
            this.TXTPRODUCTDESC.Name = "TXTPRODUCTDESC";
            this.TXTPRODUCTDESC.Size = new System.Drawing.Size(264, 53);
            this.TXTPRODUCTDESC.TabIndex = 15;
            // 
            // TXTBUYPRICE
            // 
            this.TXTBUYPRICE.Location = new System.Drawing.Point(12, 147);
            this.TXTBUYPRICE.Name = "TXTBUYPRICE";
            this.TXTBUYPRICE.Size = new System.Drawing.Size(264, 20);
            this.TXTBUYPRICE.TabIndex = 14;
            // 
            // TXTSELLPRICE
            // 
            this.TXTSELLPRICE.Location = new System.Drawing.Point(12, 173);
            this.TXTSELLPRICE.Name = "TXTSELLPRICE";
            this.TXTSELLPRICE.Size = new System.Drawing.Size(264, 20);
            this.TXTSELLPRICE.TabIndex = 13;
            // 
            // TXTPRODUCTNAME
            // 
            this.TXTPRODUCTNAME.Location = new System.Drawing.Point(12, 62);
            this.TXTPRODUCTNAME.Name = "TXTPRODUCTNAME";
            this.TXTPRODUCTNAME.Size = new System.Drawing.Size(264, 20);
            this.TXTPRODUCTNAME.TabIndex = 12;
            // 
            // CMBAM
            // 
            this.CMBAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBAM.FormattingEnabled = true;
            this.CMBAM.Location = new System.Drawing.Point(12, 198);
            this.CMBAM.Name = "CMBAM";
            this.CMBAM.Size = new System.Drawing.Size(264, 21);
            this.CMBAM.TabIndex = 11;
            // 
            // CMBSN
            // 
            this.CMBSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBSN.FormattingEnabled = true;
            this.CMBSN.Location = new System.Drawing.Point(12, 225);
            this.CMBSN.Name = "CMBSN";
            this.CMBSN.Size = new System.Drawing.Size(264, 21);
            this.CMBSN.TabIndex = 10;
            // 
            // CMBCAT
            // 
            this.CMBCAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCAT.FormattingEnabled = true;
            this.CMBCAT.Location = new System.Drawing.Point(12, 35);
            this.CMBCAT.Name = "CMBCAT";
            this.CMBCAT.Size = new System.Drawing.Size(264, 21);
            this.CMBCAT.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "الباركود";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "صورة المنتج";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "الاسم العلمى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "الماده الفعالة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "السعر للجمهور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "سعر الشراء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "وصف المنتج ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتج ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // FRM_ADDNEWPRODUCT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(378, 473);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADDNEWPRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICIMAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNCHOOSE;
        private System.Windows.Forms.PictureBox PICIMAGE;
        private System.Windows.Forms.TextBox TXTBARCODE;
        private System.Windows.Forms.TextBox TXTPRODUCTDESC;
        private System.Windows.Forms.TextBox TXTBUYPRICE;
        private System.Windows.Forms.TextBox TXTSELLPRICE;
        private System.Windows.Forms.TextBox TXTPRODUCTNAME;
        private System.Windows.Forms.ComboBox CMBAM;
        private System.Windows.Forms.ComboBox CMBSN;
        private System.Windows.Forms.ComboBox CMBCAT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}