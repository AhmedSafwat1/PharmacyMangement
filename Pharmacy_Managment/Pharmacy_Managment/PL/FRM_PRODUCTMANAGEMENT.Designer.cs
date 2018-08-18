namespace Pharmacy_Managment.PL
{
    partial class FRM_PRODUCTMANAGEMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PRODUCTMANAGEMENT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPRODUCTS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNDISPLAYEXPIREDATE = new System.Windows.Forms.Button();
            this.BTNEXIT = new System.Windows.Forms.Button();
            this.BTNSAVETOEXCEL = new System.Windows.Forms.Button();
            this.BTNPRINTSELECTEDPROD = new System.Windows.Forms.Button();
            this.BTNPRINTALL = new System.Windows.Forms.Button();
            this.BTNDISPALYIMG = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADDNEWPROF = new System.Windows.Forms.Button();
            this.BTNDISPLAY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPRODUCTS);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            // 
            // dgvPRODUCTS
            // 
            this.dgvPRODUCTS.AllowUserToAddRows = false;
            this.dgvPRODUCTS.AllowUserToDeleteRows = false;
            this.dgvPRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPRODUCTS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvPRODUCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRODUCTS.Location = new System.Drawing.Point(3, 16);
            this.dgvPRODUCTS.MultiSelect = false;
            this.dgvPRODUCTS.Name = "dgvPRODUCTS";
            this.dgvPRODUCTS.ReadOnly = true;
            this.dgvPRODUCTS.RowHeadersVisible = false;
            this.dgvPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRODUCTS.Size = new System.Drawing.Size(963, 315);
            this.dgvPRODUCTS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم المنتج";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الماده الفعالة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الاسم العلمى";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "سعر الشراء";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "السعر للجمهور";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "الكمية فى المخزن";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "الباركود";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "الوصف";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNDISPLAYEXPIREDATE);
            this.groupBox2.Controls.Add(this.BTNEXIT);
            this.groupBox2.Controls.Add(this.BTNSAVETOEXCEL);
            this.groupBox2.Controls.Add(this.BTNPRINTSELECTEDPROD);
            this.groupBox2.Controls.Add(this.BTNPRINTALL);
            this.groupBox2.Controls.Add(this.BTNDISPALYIMG);
            this.groupBox2.Controls.Add(this.BTNDELETE);
            this.groupBox2.Controls.Add(this.BTNUPDATE);
            this.groupBox2.Controls.Add(this.BTNADDNEWPROF);
            this.groupBox2.Controls.Add(this.BTNDISPLAY);
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BTNDISPLAYEXPIREDATE
            // 
            this.BTNDISPLAYEXPIREDATE.Image = ((System.Drawing.Image)(resources.GetObject("BTNDISPLAYEXPIREDATE.Image")));
            this.BTNDISPLAYEXPIREDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDISPLAYEXPIREDATE.Location = new System.Drawing.Point(103, 20);
            this.BTNDISPLAYEXPIREDATE.Name = "BTNDISPLAYEXPIREDATE";
            this.BTNDISPLAYEXPIREDATE.Size = new System.Drawing.Size(126, 46);
            this.BTNDISPLAYEXPIREDATE.TabIndex = 9;
            this.BTNDISPLAYEXPIREDATE.Text = "عرض صلاحية المنتج";
            this.BTNDISPLAYEXPIREDATE.UseVisualStyleBackColor = true;
            this.BTNDISPLAYEXPIREDATE.Click += new System.EventHandler(this.BTNDISPLAYEXPIREDATE_Click);
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.BackColor = System.Drawing.Color.Crimson;
            this.BTNEXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTNEXIT.Image")));
            this.BTNEXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEXIT.Location = new System.Drawing.Point(103, 75);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(126, 41);
            this.BTNEXIT.TabIndex = 8;
            this.BTNEXIT.Text = "خروج";
            this.BTNEXIT.UseVisualStyleBackColor = false;
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // BTNSAVETOEXCEL
            // 
            this.BTNSAVETOEXCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNSAVETOEXCEL.Image")));
            this.BTNSAVETOEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSAVETOEXCEL.Location = new System.Drawing.Point(409, 75);
            this.BTNSAVETOEXCEL.Name = "BTNSAVETOEXCEL";
            this.BTNSAVETOEXCEL.Size = new System.Drawing.Size(134, 41);
            this.BTNSAVETOEXCEL.TabIndex = 7;
            this.BTNSAVETOEXCEL.Text = "حفظ قايمة المنتجات EXECL";
            this.BTNSAVETOEXCEL.UseVisualStyleBackColor = true;
            this.BTNSAVETOEXCEL.Click += new System.EventHandler(this.BTNSAVETOEXCEL_Click);
            // 
            // BTNPRINTSELECTEDPROD
            // 
            this.BTNPRINTSELECTEDPROD.Image = ((System.Drawing.Image)(resources.GetObject("BTNPRINTSELECTEDPROD.Image")));
            this.BTNPRINTSELECTEDPROD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINTSELECTEDPROD.Location = new System.Drawing.Point(568, 75);
            this.BTNPRINTSELECTEDPROD.Name = "BTNPRINTSELECTEDPROD";
            this.BTNPRINTSELECTEDPROD.Size = new System.Drawing.Size(143, 41);
            this.BTNPRINTSELECTEDPROD.TabIndex = 6;
            this.BTNPRINTSELECTEDPROD.Text = "طباعة المنتج المحدد";
            this.BTNPRINTSELECTEDPROD.UseVisualStyleBackColor = true;
            this.BTNPRINTSELECTEDPROD.Click += new System.EventHandler(this.BTNPRINTSELECTEDPROD_Click);
            // 
            // BTNPRINTALL
            // 
            this.BTNPRINTALL.Image = ((System.Drawing.Image)(resources.GetObject("BTNPRINTALL.Image")));
            this.BTNPRINTALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINTALL.Location = new System.Drawing.Point(734, 75);
            this.BTNPRINTALL.Name = "BTNPRINTALL";
            this.BTNPRINTALL.Size = new System.Drawing.Size(131, 41);
            this.BTNPRINTALL.TabIndex = 5;
            this.BTNPRINTALL.Text = "طباعة كل المنتجات ";
            this.BTNPRINTALL.UseVisualStyleBackColor = true;
            this.BTNPRINTALL.Click += new System.EventHandler(this.BTNPRINTALL_Click);
            // 
            // BTNDISPALYIMG
            // 
            this.BTNDISPALYIMG.Image = ((System.Drawing.Image)(resources.GetObject("BTNDISPALYIMG.Image")));
            this.BTNDISPALYIMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDISPALYIMG.Location = new System.Drawing.Point(252, 75);
            this.BTNDISPALYIMG.Name = "BTNDISPALYIMG";
            this.BTNDISPALYIMG.Size = new System.Drawing.Size(126, 41);
            this.BTNDISPALYIMG.TabIndex = 4;
            this.BTNDISPALYIMG.Text = "عرض صورة المنتج";
            this.BTNDISPALYIMG.UseVisualStyleBackColor = true;
            this.BTNDISPALYIMG.Click += new System.EventHandler(this.BTNDISPALYIMG_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Image = ((System.Drawing.Image)(resources.GetObject("BTNDELETE.Image")));
            this.BTNDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDELETE.Location = new System.Drawing.Point(252, 20);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(126, 45);
            this.BTNDELETE.TabIndex = 3;
            this.BTNDELETE.Text = "حذف المنتج المحدد";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Image = ((System.Drawing.Image)(resources.GetObject("BTNUPDATE.Image")));
            this.BTNUPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNUPDATE.Location = new System.Drawing.Point(409, 20);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(134, 45);
            this.BTNUPDATE.TabIndex = 2;
            this.BTNUPDATE.Text = "تعديل المنتج المحدد";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADDNEWPROF
            // 
            this.BTNADDNEWPROF.Image = ((System.Drawing.Image)(resources.GetObject("BTNADDNEWPROF.Image")));
            this.BTNADDNEWPROF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNADDNEWPROF.Location = new System.Drawing.Point(568, 20);
            this.BTNADDNEWPROF.Name = "BTNADDNEWPROF";
            this.BTNADDNEWPROF.Size = new System.Drawing.Size(143, 45);
            this.BTNADDNEWPROF.TabIndex = 1;
            this.BTNADDNEWPROF.Text = "اضافة منتج جديد";
            this.BTNADDNEWPROF.UseVisualStyleBackColor = true;
            this.BTNADDNEWPROF.Click += new System.EventHandler(this.BTNADDNEWPROF_Click);
            // 
            // BTNDISPLAY
            // 
            this.BTNDISPLAY.Image = ((System.Drawing.Image)(resources.GetObject("BTNDISPLAY.Image")));
            this.BTNDISPLAY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDISPLAY.Location = new System.Drawing.Point(734, 20);
            this.BTNDISPLAY.Name = "BTNDISPLAY";
            this.BTNDISPLAY.Size = new System.Drawing.Size(131, 45);
            this.BTNDISPLAY.TabIndex = 0;
            this.BTNDISPLAY.Text = "عرض كل المنتجات";
            this.BTNDISPLAY.UseVisualStyleBackColor = true;
            this.BTNDISPLAY.Click += new System.EventHandler(this.BTNDISPLAY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الكلمة المراد البحث عنها";
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Location = new System.Drawing.Point(297, 13);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(366, 20);
            this.TXTSEARCH.TabIndex = 3;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // FRM_PRODUCTMANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(990, 504);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTMANAGEMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة المنتجات";
            this.Activated += new System.EventHandler(this.FRM_PRODUCTMANAGEMENT_Activated);
            this.Load += new System.EventHandler(this.FRM_PRODUCTMANAGEMENT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPRODUCTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTSEARCH;
        private System.Windows.Forms.Button BTNSAVETOEXCEL;
        private System.Windows.Forms.Button BTNPRINTSELECTEDPROD;
        private System.Windows.Forms.Button BTNPRINTALL;
        private System.Windows.Forms.Button BTNDISPALYIMG;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNADDNEWPROF;
        private System.Windows.Forms.Button BTNDISPLAY;
        private System.Windows.Forms.Button BTNEXIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button BTNDISPLAYEXPIREDATE;
    }
}