namespace Pharmacy_Managment.PL
{
    partial class FRM_ADDNEWUSER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDNEWUSER));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_u_full_name = new System.Windows.Forms.TextBox();
            this.cmb_per_id = new System.Windows.Forms.ComboBox();
            this.txt_check_u_pass = new System.Windows.Forms.TextBox();
            this.txt_u_pass = new System.Windows.Forms.TextBox();
            this.txt_u_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_u_full_name);
            this.groupBox1.Controls.Add(this.cmb_per_id);
            this.groupBox1.Controls.Add(this.txt_check_u_pass);
            this.groupBox1.Controls.Add(this.txt_u_pass);
            this.groupBox1.Controls.Add(this.txt_u_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(358, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستخدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "نوع الصلاحية";
            // 
            // txt_u_full_name
            // 
            this.txt_u_full_name.Location = new System.Drawing.Point(33, 162);
            this.txt_u_full_name.Name = "txt_u_full_name";
            this.txt_u_full_name.Size = new System.Drawing.Size(169, 26);
            this.txt_u_full_name.TabIndex = 8;
            // 
            // cmb_per_id
            // 
            this.cmb_per_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_per_id.FormattingEnabled = true;
            this.cmb_per_id.Location = new System.Drawing.Point(33, 219);
            this.cmb_per_id.Name = "cmb_per_id";
            this.cmb_per_id.Size = new System.Drawing.Size(169, 28);
            this.cmb_per_id.TabIndex = 7;
            // 
            // txt_check_u_pass
            // 
            this.txt_check_u_pass.Location = new System.Drawing.Point(33, 116);
            this.txt_check_u_pass.Name = "txt_check_u_pass";
            this.txt_check_u_pass.PasswordChar = '*';
            this.txt_check_u_pass.Size = new System.Drawing.Size(169, 26);
            this.txt_check_u_pass.TabIndex = 6;
            // 
            // txt_u_pass
            // 
            this.txt_u_pass.Location = new System.Drawing.Point(33, 67);
            this.txt_u_pass.Name = "txt_u_pass";
            this.txt_u_pass.PasswordChar = '*';
            this.txt_u_pass.Size = new System.Drawing.Size(169, 26);
            this.txt_u_pass.TabIndex = 5;
            // 
            // txt_u_name
            // 
            this.txt_u_name.Location = new System.Drawing.Point(33, 27);
            this.txt_u_name.Name = "txt_u_name";
            this.txt_u_name.Size = new System.Drawing.Size(169, 26);
            this.txt_u_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "الاسم بالكامل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاكيد كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(22, 300);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 39);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "خروج";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(247, 300);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(86, 39);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "حفظ";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FRM_ADDNEWUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(397, 351);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_ADDNEWUSER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_u_full_name;
        private System.Windows.Forms.ComboBox cmb_per_id;
        private System.Windows.Forms.TextBox txt_check_u_pass;
        private System.Windows.Forms.TextBox txt_u_pass;
        private System.Windows.Forms.TextBox txt_u_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}