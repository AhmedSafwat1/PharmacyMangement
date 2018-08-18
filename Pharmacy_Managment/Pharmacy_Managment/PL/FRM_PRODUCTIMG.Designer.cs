namespace Pharmacy_Managment.PL
{
    partial class FRM_PRODUCTIMG
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
            this.PICIMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // PICIMG
            // 
            this.PICIMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PICIMG.Location = new System.Drawing.Point(0, 0);
            this.PICIMG.Name = "PICIMG";
            this.PICIMG.Size = new System.Drawing.Size(534, 349);
            this.PICIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICIMG.TabIndex = 0;
            this.PICIMG.TabStop = false;
            // 
            // FRM_PRODUCTIMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 349);
            this.Controls.Add(this.PICIMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTIMG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض صورة المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.PICIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PICIMG;

    }
}