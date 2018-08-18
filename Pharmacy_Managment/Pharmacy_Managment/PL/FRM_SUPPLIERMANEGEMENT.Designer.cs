namespace Pharmacy_Managment.PL
{
    partial class FRM_SUPPLIERMANEGEMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SUPPLIERMANEGEMENT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSUPPLIER = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNDISPLAY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUPPLIER)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSUPPLIER);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الموردين ";
            // 
            // dgvSUPPLIER
            // 
            this.dgvSUPPLIER.AllowUserToAddRows = false;
            this.dgvSUPPLIER.AllowUserToDeleteRows = false;
            this.dgvSUPPLIER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSUPPLIER.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSUPPLIER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSUPPLIER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSUPPLIER.Location = new System.Drawing.Point(3, 18);
            this.dgvSUPPLIER.MultiSelect = false;
            this.dgvSUPPLIER.Name = "dgvSUPPLIER";
            this.dgvSUPPLIER.ReadOnly = true;
            this.dgvSUPPLIER.RowHeadersVisible = false;
            this.dgvSUPPLIER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSUPPLIER.Size = new System.Drawing.Size(716, 189);
            this.dgvSUPPLIER.TabIndex = 0;
            this.dgvSUPPLIER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSUPPLIER_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNCANCEL);
            this.groupBox2.Controls.Add(this.BTNDELETE);
            this.groupBox2.Controls.Add(this.BTNUPDATE);
            this.groupBox2.Controls.Add(this.BTNADD);
            this.groupBox2.Controls.Add(this.BTNDISPLAY);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.AutoEllipsis = true;
            this.BTNCANCEL.BackColor = System.Drawing.Color.Crimson;
            this.BTNCANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCEL.Image")));
            this.BTNCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCEL.Location = new System.Drawing.Point(6, 19);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(75, 35);
            this.BTNCANCEL.TabIndex = 4;
            this.BTNCANCEL.Text = "خروج";
            this.BTNCANCEL.UseVisualStyleBackColor = false;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Image = ((System.Drawing.Image)(resources.GetObject("BTNDELETE.Image")));
            this.BTNDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDELETE.Location = new System.Drawing.Point(134, 19);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(128, 35);
            this.BTNDELETE.TabIndex = 3;
            this.BTNDELETE.Text = "حذف مورد";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Image = ((System.Drawing.Image)(resources.GetObject("BTNUPDATE.Image")));
            this.BTNUPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNUPDATE.Location = new System.Drawing.Point(287, 19);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(133, 35);
            this.BTNUPDATE.TabIndex = 2;
            this.BTNUPDATE.Text = "تعديل بيانات مورد";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.Image = ((System.Drawing.Image)(resources.GetObject("BTNADD.Image")));
            this.BTNADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNADD.Location = new System.Drawing.Point(582, 19);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(128, 35);
            this.BTNADD.TabIndex = 1;
            this.BTNADD.Text = "اضافة مورد";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNDISPLAY
            // 
            this.BTNDISPLAY.Image = ((System.Drawing.Image)(resources.GetObject("BTNDISPLAY.Image")));
            this.BTNDISPLAY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDISPLAY.Location = new System.Drawing.Point(442, 19);
            this.BTNDISPLAY.Name = "BTNDISPLAY";
            this.BTNDISPLAY.Size = new System.Drawing.Size(118, 35);
            this.BTNDISPLAY.TabIndex = 0;
            this.BTNDISPLAY.Text = "عرض الموردين";
            this.BTNDISPLAY.UseVisualStyleBackColor = true;
            this.BTNDISPLAY.Click += new System.EventHandler(this.BTNDISPLAY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الكلمة المراد البحث عنها";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Location = new System.Drawing.Point(205, 15);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(334, 20);
            this.txtSEARCH.TabIndex = 3;
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            // 
            // FRM_SUPPLIERMANEGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(746, 327);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SUPPLIERMANEGEMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة الموردين";
            this.Activated += new System.EventHandler(this.FRM_SUPPLIERMANEGEMENT_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUPPLIER)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSUPPLIER;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNDISPLAY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSEARCH;
    }
}