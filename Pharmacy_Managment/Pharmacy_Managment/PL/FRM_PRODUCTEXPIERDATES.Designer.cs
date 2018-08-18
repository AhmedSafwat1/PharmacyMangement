namespace Pharmacy_Managment.PL
{
    partial class FRM_PRODUCTEXPIERDATES
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
            this.DGVPRODUCTEXP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRODUCTEXP)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPRODUCTEXP
            // 
            this.DGVPRODUCTEXP.AllowUserToAddRows = false;
            this.DGVPRODUCTEXP.AllowUserToDeleteRows = false;
            this.DGVPRODUCTEXP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPRODUCTEXP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVPRODUCTEXP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPRODUCTEXP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPRODUCTEXP.Location = new System.Drawing.Point(0, 0);
            this.DGVPRODUCTEXP.MultiSelect = false;
            this.DGVPRODUCTEXP.Name = "DGVPRODUCTEXP";
            this.DGVPRODUCTEXP.ReadOnly = true;
            this.DGVPRODUCTEXP.RowHeadersVisible = false;
            this.DGVPRODUCTEXP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPRODUCTEXP.Size = new System.Drawing.Size(594, 261);
            this.DGVPRODUCTEXP.TabIndex = 0;
            // 
            // FRM_PRODUCTEXPIERDATES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.DGVPRODUCTEXP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTEXPIERDATES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض صلاحيات المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRODUCTEXP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVPRODUCTEXP;
    }
}