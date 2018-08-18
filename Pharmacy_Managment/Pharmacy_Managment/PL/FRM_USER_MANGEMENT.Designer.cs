namespace Pharmacy_Managment.PL
{
    partial class FRM_USER_MANGEMENT
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
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNDISPLAY = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_Users = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Location = new System.Drawing.Point(122, 12);
            this.txtSEARCH.Multiline = true;
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(334, 23);
            this.txtSEARCH.TabIndex = 7;
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.Location = new System.Drawing.Point(6, 19);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(75, 35);
            this.BTNCANCEL.TabIndex = 4;
            this.BTNCANCEL.Text = "خروج";
            this.BTNCANCEL.UseVisualStyleBackColor = true;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Location = new System.Drawing.Point(134, 19);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(128, 35);
            this.BTNDELETE.TabIndex = 3;
            this.BTNDELETE.Text = "حذف مستخدم";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Location = new System.Drawing.Point(292, 19);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(128, 35);
            this.BTNUPDATE.TabIndex = 2;
            this.BTNUPDATE.Text = "تعديل بيانات مستخدم";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.Location = new System.Drawing.Point(582, 19);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(128, 35);
            this.BTNADD.TabIndex = 1;
            this.BTNADD.Text = "اضافة مستخدم";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNDISPLAY
            // 
            this.BTNDISPLAY.Location = new System.Drawing.Point(445, 19);
            this.BTNDISPLAY.Name = "BTNDISPLAY";
            this.BTNDISPLAY.Size = new System.Drawing.Size(115, 35);
            this.BTNDISPLAY.TabIndex = 0;
            this.BTNDISPLAY.Text = "عرض المستخدمين";
            this.BTNDISPLAY.UseVisualStyleBackColor = true;
            this.BTNDISPLAY.Click += new System.EventHandler(this.BTNDISPLAY_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_Users);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل المستخدمين";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grid_Users
            // 
            this.grid_Users.AllowUserToAddRows = false;
            this.grid_Users.AllowUserToDeleteRows = false;
            this.grid_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Users.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Users.Location = new System.Drawing.Point(3, 18);
            this.grid_Users.MultiSelect = false;
            this.grid_Users.Name = "grid_Users";
            this.grid_Users.ReadOnly = true;
            this.grid_Users.RowHeadersVisible = false;
            this.grid_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Users.Size = new System.Drawing.Size(760, 309);
            this.grid_Users.TabIndex = 0;
            this.grid_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSUPPLIER_CellContentClick);
            // 
            // FRM_USER_MANGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(783, 456);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_USER_MANGEMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة المستخدمين";
            this.Activated += new System.EventHandler(this.FRM_USER_MANGEMENT_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Users)).EndInit();
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
        private System.Windows.Forms.DataGridView grid_Users;
    }
}