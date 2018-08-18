namespace Pharmacy_Managment.PL
{
    partial class FRM_ADDNEWSUPPLIER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDNEWSUPPLIER));
            this.BTNOK = new System.Windows.Forms.Button();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.TXTMOBILE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNOK
            // 
            this.BTNOK.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BTNOK.Image = ((System.Drawing.Image)(resources.GetObject("BTNOK.Image")));
            this.BTNOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNOK.Location = new System.Drawing.Point(117, 113);
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(87, 33);
            this.BTNOK.TabIndex = 0;
            this.BTNOK.Text = "حفظ";
            this.BTNOK.UseVisualStyleBackColor = false;
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.BackColor = System.Drawing.Color.Crimson;
            this.BTNCANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCEL.Image")));
            this.BTNCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCEL.Location = new System.Drawing.Point(242, 113);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(89, 33);
            this.BTNCANCEL.TabIndex = 1;
            this.BTNCANCEL.Text = "الغاء";
            this.BTNCANCEL.UseVisualStyleBackColor = false;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم الموبايل";
            // 
            // TXTNAME
            // 
            this.TXTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNAME.Location = new System.Drawing.Point(117, 13);
            this.TXTNAME.Multiline = true;
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(214, 37);
            this.TXTNAME.TabIndex = 4;
            // 
            // TXTMOBILE
            // 
            this.TXTMOBILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMOBILE.Location = new System.Drawing.Point(117, 56);
            this.TXTMOBILE.Multiline = true;
            this.TXTMOBILE.Name = "TXTMOBILE";
            this.TXTMOBILE.Size = new System.Drawing.Size(214, 34);
            this.TXTMOBILE.TabIndex = 5;
            this.TXTMOBILE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FRM_ADDNEWSUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(368, 175);
            this.Controls.Add(this.TXTMOBILE);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNCANCEL);
            this.Controls.Add(this.BTNOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADDNEWSUPPLIER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافة مورد";
            this.Load += new System.EventHandler(this.FRM_ADDNEWSUPPLIER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNOK;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.TextBox TXTMOBILE;
    }
}