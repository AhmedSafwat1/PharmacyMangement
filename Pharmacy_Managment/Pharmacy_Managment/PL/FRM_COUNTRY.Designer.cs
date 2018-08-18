namespace Pharmacy_Managment.PL
{
    partial class FRM_COUNTRY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_COUNTRY));
            this.txt_coSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_coSelectALL = new System.Windows.Forms.Button();
            this.btn_coUpdate = new System.Windows.Forms.Button();
            this.btn_coAdd = new System.Windows.Forms.Button();
            this.btn_coDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_coName = new System.Windows.Forms.TextBox();
            this.txt_coID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_coSearch
            // 
            this.txt_coSearch.Location = new System.Drawing.Point(163, 21);
            this.txt_coSearch.Name = "txt_coSearch";
            this.txt_coSearch.Size = new System.Drawing.Size(214, 20);
            this.txt_coSearch.TabIndex = 14;
            this.txt_coSearch.TextChanged += new System.EventHandler(this.txt_coSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "الكلمة المراد البحث عنها";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_coSelectALL);
            this.groupBox3.Controls.Add(this.btn_coUpdate);
            this.groupBox3.Controls.Add(this.btn_coAdd);
            this.groupBox3.Controls.Add(this.btn_coDelete);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 128);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(15, 53);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 42);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "خروج";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_coSelectALL
            // 
            this.btn_coSelectALL.Location = new System.Drawing.Point(273, 31);
            this.btn_coSelectALL.Name = "btn_coSelectALL";
            this.btn_coSelectALL.Size = new System.Drawing.Size(89, 29);
            this.btn_coSelectALL.TabIndex = 3;
            this.btn_coSelectALL.Text = "عرض ";
            this.btn_coSelectALL.UseVisualStyleBackColor = true;
            this.btn_coSelectALL.Click += new System.EventHandler(this.btn_coSelectALL_Click);
            // 
            // btn_coUpdate
            // 
            this.btn_coUpdate.Location = new System.Drawing.Point(119, 31);
            this.btn_coUpdate.Name = "btn_coUpdate";
            this.btn_coUpdate.Size = new System.Drawing.Size(98, 30);
            this.btn_coUpdate.TabIndex = 4;
            this.btn_coUpdate.Text = "تعديل بيانات  ";
            this.btn_coUpdate.UseVisualStyleBackColor = true;
            this.btn_coUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_coAdd
            // 
            this.btn_coAdd.Location = new System.Drawing.Point(119, 91);
            this.btn_coAdd.Name = "btn_coAdd";
            this.btn_coAdd.Size = new System.Drawing.Size(98, 23);
            this.btn_coAdd.TabIndex = 6;
            this.btn_coAdd.Text = "اضافة";
            this.btn_coAdd.UseVisualStyleBackColor = true;
            this.btn_coAdd.Click += new System.EventHandler(this.btn_coAdd_Click);
            // 
            // btn_coDelete
            // 
            this.btn_coDelete.Location = new System.Drawing.Point(273, 75);
            this.btn_coDelete.Name = "btn_coDelete";
            this.btn_coDelete.Size = new System.Drawing.Size(89, 39);
            this.btn_coDelete.TabIndex = 5;
            this.btn_coDelete.Text = "حذف ";
            this.btn_coDelete.UseVisualStyleBackColor = true;
            this.btn_coDelete.Click += new System.EventHandler(this.btn_coDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_coName);
            this.groupBox2.Controls.Add(this.txt_coID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 128);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الدولة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم الدولة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الدولة";
            // 
            // txt_coName
            // 
            this.txt_coName.Location = new System.Drawing.Point(7, 75);
            this.txt_coName.Name = "txt_coName";
            this.txt_coName.Size = new System.Drawing.Size(221, 26);
            this.txt_coName.TabIndex = 1;
            // 
            // txt_coID
            // 
            this.txt_coID.Location = new System.Drawing.Point(6, 34);
            this.txt_coID.Name = "txt_coID";
            this.txt_coID.ReadOnly = true;
            this.txt_coID.Size = new System.Drawing.Size(222, 26);
            this.txt_coID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCountry);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الدول";
            // 
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToAddRows = false;
            this.dgvCountry.AllowUserToDeleteRows = false;
            this.dgvCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCountry.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCountry.Location = new System.Drawing.Point(3, 16);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.ReadOnly = true;
            this.dgvCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountry.Size = new System.Drawing.Size(763, 221);
            this.dgvCountry.TabIndex = 0;
            this.dgvCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountry_CellClick);
            // 
            // FRM_COUNTRY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(793, 419);
            this.Controls.Add(this.txt_coSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_COUNTRY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = " ادارة الدول";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_coSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_coSelectALL;
        private System.Windows.Forms.Button btn_coUpdate;
        private System.Windows.Forms.Button btn_coAdd;
        private System.Windows.Forms.Button btn_coDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_coName;
        private System.Windows.Forms.TextBox txt_coID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.Button btn_cancel;
    }
}