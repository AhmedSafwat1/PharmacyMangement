namespace Pharmacy_Managment.PL
{
    partial class FRM_CUSTOMER_MANEGEMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CUSTOMER_MANEGEMENT));
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNDISPLAY = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_Customer = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Location = new System.Drawing.Point(262, 18);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(334, 20);
            this.txtSEARCH.TabIndex = 7;
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "الكلمة المراد البحث عنها";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNCANCEL);
            this.groupBox2.Controls.Add(this.BTNDELETE);
            this.groupBox2.Controls.Add(this.BTNUPDATE);
            this.groupBox2.Controls.Add(this.BTNADD);
            this.groupBox2.Controls.Add(this.BTNDISPLAY);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.BackColor = System.Drawing.Color.Crimson;
            this.BTNCANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCEL.Image")));
            this.BTNCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCEL.Location = new System.Drawing.Point(31, 27);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(97, 36);
            this.BTNCANCEL.TabIndex = 4;
            this.BTNCANCEL.Text = "خروج";
            this.BTNCANCEL.UseVisualStyleBackColor = false;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Location = new System.Drawing.Point(365, 25);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(128, 41);
            this.BTNDELETE.TabIndex = 3;
            this.BTNDELETE.Text = "حذف عميل";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Location = new System.Drawing.Point(523, 25);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(128, 41);
            this.BTNUPDATE.TabIndex = 2;
            this.BTNUPDATE.Text = "تعديل بيانات  عميل";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.Location = new System.Drawing.Point(813, 25);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(128, 41);
            this.BTNADD.TabIndex = 1;
            this.BTNADD.Text = "اضافة عميل";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNDISPLAY
            // 
            this.BTNDISPLAY.Location = new System.Drawing.Point(676, 25);
            this.BTNDISPLAY.Name = "BTNDISPLAY";
            this.BTNDISPLAY.Size = new System.Drawing.Size(115, 41);
            this.BTNDISPLAY.TabIndex = 0;
            this.BTNDISPLAY.Text = "عرض كل العملاء";
            this.BTNDISPLAY.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_Customer);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملاء";
            // 
            // grid_Customer
            // 
            this.grid_Customer.AllowUserToAddRows = false;
            this.grid_Customer.AllowUserToDeleteRows = false;
            this.grid_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Customer.Location = new System.Drawing.Point(3, 16);
            this.grid_Customer.MultiSelect = false;
            this.grid_Customer.Name = "grid_Customer";
            this.grid_Customer.ReadOnly = true;
            this.grid_Customer.RowHeadersVisible = false;
            this.grid_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Customer.Size = new System.Drawing.Size(959, 311);
            this.grid_Customer.TabIndex = 0;
            // 
            // FRM_CUSTOMER_MANEGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(989, 468);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_CUSTOMER_MANEGEMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = " ادارة العملاء";
            this.Activated += new System.EventHandler(this.FRM_CUSTOMER_MANEGEMENT_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNDISPLAY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_Customer;
    }
}