namespace Pharmacy_Managment.PL
{
    partial class FRM_Order_Manegenment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Order_Manegenment));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_request = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_request)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(20, 329);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 39);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "خروج";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(471, 329);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(132, 39);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "طباعة الفاتورة المحدده";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(662, 329);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(140, 39);
            this.btn_display.TabIndex = 5;
            this.btn_display.Text = "عرض كل الفواتير";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_request);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 306);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل فواتير البيع";
            // 
            // grid_request
            // 
            this.grid_request.AllowUserToAddRows = false;
            this.grid_request.AllowUserToDeleteRows = false;
            this.grid_request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_request.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_request.Location = new System.Drawing.Point(3, 16);
            this.grid_request.Name = "grid_request";
            this.grid_request.ReadOnly = true;
            this.grid_request.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_request.Size = new System.Drawing.Size(793, 287);
            this.grid_request.TabIndex = 0;
            // 
            // FRM_Order_Manegenment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(816, 378);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_Order_Manegenment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = " ادارة فواتير البيع";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_request)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_request;
    }
}