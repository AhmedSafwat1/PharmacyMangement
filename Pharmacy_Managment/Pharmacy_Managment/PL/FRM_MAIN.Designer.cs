namespace Pharmacy_Managment.PL
{
    partial class FRM_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSNFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMResotre = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMTypesManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMActiveMaterialManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddActiveMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSceintificNameManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddSceintificName = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCustomerManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBuyManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMCountryManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمدنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSuppliersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSellesMAnagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewSell = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUsersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNFile,
            this.TSMProducts,
            this.TSMCustomers,
            this.TSMSuppliers,
            this.TSMUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSNFile
            // 
            this.TSNFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMLogin,
            this.TSMLogout,
            this.toolStripSeparator1,
            this.TSMBackup,
            this.TSMResotre});
            this.TSNFile.Name = "TSNFile";
            this.TSNFile.Size = new System.Drawing.Size(42, 20);
            this.TSNFile.Text = "ملف";
            // 
            // TSMLogin
            // 
            this.TSMLogin.Image = ((System.Drawing.Image)(resources.GetObject("TSMLogin.Image")));
            this.TSMLogin.Name = "TSMLogin";
            this.TSMLogin.Size = new System.Drawing.Size(152, 22);
            this.TSMLogin.Text = "تسجيل الدخول ";
            this.TSMLogin.Click += new System.EventHandler(this.TSMLogin_Click);
            // 
            // TSMLogout
            // 
            this.TSMLogout.Image = ((System.Drawing.Image)(resources.GetObject("TSMLogout.Image")));
            this.TSMLogout.Name = "TSMLogout";
            this.TSMLogout.Size = new System.Drawing.Size(152, 22);
            this.TSMLogout.Text = "تسجيل الخروج";
            this.TSMLogout.Click += new System.EventHandler(this.TSMLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // TSMBackup
            // 
            this.TSMBackup.Image = ((System.Drawing.Image)(resources.GetObject("TSMBackup.Image")));
            this.TSMBackup.Name = "TSMBackup";
            this.TSMBackup.Size = new System.Drawing.Size(152, 22);
            this.TSMBackup.Text = "backup";
            this.TSMBackup.Click += new System.EventHandler(this.TSMBackup_Click);
            // 
            // TSMResotre
            // 
            this.TSMResotre.Image = ((System.Drawing.Image)(resources.GetObject("TSMResotre.Image")));
            this.TSMResotre.Name = "TSMResotre";
            this.TSMResotre.Size = new System.Drawing.Size(152, 22);
            this.TSMResotre.Text = "Restore";
            this.TSMResotre.Click += new System.EventHandler(this.TSMResotre_Click);
            // 
            // TSMProducts
            // 
            this.TSMProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMProductManagement,
            this.TSMAddProduct,
            this.toolStripSeparator2,
            this.TSMTypesManagement,
            this.TSMAddType,
            this.toolStripSeparator3,
            this.TSMActiveMaterialManagement,
            this.TSMAddActiveMaterial,
            this.toolStripSeparator4,
            this.TSMSceintificNameManagement,
            this.TSMAddSceintificName});
            this.TSMProducts.Name = "TSMProducts";
            this.TSMProducts.Size = new System.Drawing.Size(62, 20);
            this.TSMProducts.Text = "المنتجات";
            // 
            // TSMProductManagement
            // 
            this.TSMProductManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMProductManagement.Image")));
            this.TSMProductManagement.Name = "TSMProductManagement";
            this.TSMProductManagement.Size = new System.Drawing.Size(180, 22);
            this.TSMProductManagement.Text = "ادارة المنتجات ";
            this.TSMProductManagement.Click += new System.EventHandler(this.TSMProductManagement_Click);
            // 
            // TSMAddProduct
            // 
            this.TSMAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddProduct.Image")));
            this.TSMAddProduct.Name = "TSMAddProduct";
            this.TSMAddProduct.Size = new System.Drawing.Size(180, 22);
            this.TSMAddProduct.Text = "اضافة منتج جديد";
            this.TSMAddProduct.Click += new System.EventHandler(this.TSMAddProduct_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMTypesManagement
            // 
            this.TSMTypesManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMTypesManagement.Image")));
            this.TSMTypesManagement.Name = "TSMTypesManagement";
            this.TSMTypesManagement.Size = new System.Drawing.Size(180, 22);
            this.TSMTypesManagement.Text = "ادارة الاصناف";
            this.TSMTypesManagement.Click += new System.EventHandler(this.TSMTypesManagement_Click);
            // 
            // TSMAddType
            // 
            this.TSMAddType.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddType.Image")));
            this.TSMAddType.Name = "TSMAddType";
            this.TSMAddType.Size = new System.Drawing.Size(180, 22);
            this.TSMAddType.Text = "اضافة صنف جديد";
            this.TSMAddType.Click += new System.EventHandler(this.TSMAddType_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMActiveMaterialManagement
            // 
            this.TSMActiveMaterialManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMActiveMaterialManagement.Image")));
            this.TSMActiveMaterialManagement.Name = "TSMActiveMaterialManagement";
            this.TSMActiveMaterialManagement.Size = new System.Drawing.Size(180, 22);
            this.TSMActiveMaterialManagement.Text = "ادارة المواد الفعالة ";
            this.TSMActiveMaterialManagement.Click += new System.EventHandler(this.TSMActiveMaterialManagement_Click);
            // 
            // TSMAddActiveMaterial
            // 
            this.TSMAddActiveMaterial.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddActiveMaterial.Image")));
            this.TSMAddActiveMaterial.Name = "TSMAddActiveMaterial";
            this.TSMAddActiveMaterial.Size = new System.Drawing.Size(180, 22);
            this.TSMAddActiveMaterial.Text = "اضافة مادة فعالة ";
            this.TSMAddActiveMaterial.Click += new System.EventHandler(this.TSMAddActiveMaterial_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMSceintificNameManagement
            // 
            this.TSMSceintificNameManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMSceintificNameManagement.Image")));
            this.TSMSceintificNameManagement.Name = "TSMSceintificNameManagement";
            this.TSMSceintificNameManagement.Size = new System.Drawing.Size(180, 22);
            this.TSMSceintificNameManagement.Text = "ادارة الاسماء العلمية";
            this.TSMSceintificNameManagement.Click += new System.EventHandler(this.TSMSceintificNameManagement_Click);
            // 
            // TSMAddSceintificName
            // 
            this.TSMAddSceintificName.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddSceintificName.Image")));
            this.TSMAddSceintificName.Name = "TSMAddSceintificName";
            this.TSMAddSceintificName.Size = new System.Drawing.Size(180, 22);
            this.TSMAddSceintificName.Text = "اضافة الاسماء العلمية";
            this.TSMAddSceintificName.Click += new System.EventHandler(this.TSMAddSceintificName_Click);
            // 
            // TSMCustomers
            // 
            this.TSMCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMCustomerManagement,
            this.TSMAddCustomer,
            this.TSMBuyManagement,
            this.TSMNewBuy,
            this.toolStripSeparator5,
            this.TSMCountryManagement,
            this.ادارةالمدنToolStripMenuItem});
            this.TSMCustomers.Name = "TSMCustomers";
            this.TSMCustomers.Size = new System.Drawing.Size(52, 20);
            this.TSMCustomers.Text = "العملاء";
            // 
            // TSMCustomerManagement
            // 
            this.TSMCustomerManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMCustomerManagement.Image")));
            this.TSMCustomerManagement.Name = "TSMCustomerManagement";
            this.TSMCustomerManagement.Size = new System.Drawing.Size(159, 22);
            this.TSMCustomerManagement.Text = "ادارة العملاء";
            this.TSMCustomerManagement.Click += new System.EventHandler(this.TSMCustomerManagement_Click);
            // 
            // TSMAddCustomer
            // 
            this.TSMAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddCustomer.Image")));
            this.TSMAddCustomer.Name = "TSMAddCustomer";
            this.TSMAddCustomer.Size = new System.Drawing.Size(159, 22);
            this.TSMAddCustomer.Text = "اضافة عميل جديد";
            this.TSMAddCustomer.Click += new System.EventHandler(this.TSMAddCustomer_Click);
            // 
            // TSMBuyManagement
            // 
            this.TSMBuyManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMBuyManagement.Image")));
            this.TSMBuyManagement.Name = "TSMBuyManagement";
            this.TSMBuyManagement.Size = new System.Drawing.Size(159, 22);
            this.TSMBuyManagement.Text = "ادارة المبيعات";
            this.TSMBuyManagement.Click += new System.EventHandler(this.TSMBuyManagement_Click);
            // 
            // TSMNewBuy
            // 
            this.TSMNewBuy.Image = ((System.Drawing.Image)(resources.GetObject("TSMNewBuy.Image")));
            this.TSMNewBuy.Name = "TSMNewBuy";
            this.TSMNewBuy.Size = new System.Drawing.Size(159, 22);
            this.TSMNewBuy.Text = "عمليه بيع جديد";
            this.TSMNewBuy.Click += new System.EventHandler(this.TSMNewBuy_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
            // 
            // TSMCountryManagement
            // 
            this.TSMCountryManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMCountryManagement.Image")));
            this.TSMCountryManagement.Name = "TSMCountryManagement";
            this.TSMCountryManagement.Size = new System.Drawing.Size(159, 22);
            this.TSMCountryManagement.Text = "ادارة الدول";
            this.TSMCountryManagement.Click += new System.EventHandler(this.ادارةالدولToolStripMenuItem_Click);
            // 
            // ادارةالمدنToolStripMenuItem
            // 
            this.ادارةالمدنToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارةالمدنToolStripMenuItem.Image")));
            this.ادارةالمدنToolStripMenuItem.Name = "ادارةالمدنToolStripMenuItem";
            this.ادارةالمدنToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ادارةالمدنToolStripMenuItem.Text = "ادارة المدن";
            this.ادارةالمدنToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمدنToolStripMenuItem_Click);
            // 
            // TSMSuppliers
            // 
            this.TSMSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMSuppliersManagement,
            this.TSMAddSupplier,
            this.TSMSellesMAnagement,
            this.TSMNewSell});
            this.TSMSuppliers.Name = "TSMSuppliers";
            this.TSMSuppliers.Size = new System.Drawing.Size(61, 20);
            this.TSMSuppliers.Text = "الموردين";
            // 
            // TSMSuppliersManagement
            // 
            this.TSMSuppliersManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMSuppliersManagement.Image")));
            this.TSMSuppliersManagement.Name = "TSMSuppliersManagement";
            this.TSMSuppliersManagement.Size = new System.Drawing.Size(156, 22);
            this.TSMSuppliersManagement.Text = "ادارة الموردين ";
            this.TSMSuppliersManagement.Click += new System.EventHandler(this.TSMSuppliersManagement_Click);
            // 
            // TSMAddSupplier
            // 
            this.TSMAddSupplier.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddSupplier.Image")));
            this.TSMAddSupplier.Name = "TSMAddSupplier";
            this.TSMAddSupplier.Size = new System.Drawing.Size(156, 22);
            this.TSMAddSupplier.Text = "اضافة مورد جديد";
            this.TSMAddSupplier.Click += new System.EventHandler(this.TSMAddSupplier_Click);
            // 
            // TSMSellesMAnagement
            // 
            this.TSMSellesMAnagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMSellesMAnagement.Image")));
            this.TSMSellesMAnagement.Name = "TSMSellesMAnagement";
            this.TSMSellesMAnagement.Size = new System.Drawing.Size(156, 22);
            this.TSMSellesMAnagement.Text = "ادارة المشتريات ";
            this.TSMSellesMAnagement.Click += new System.EventHandler(this.TSMSellesMAnagement_Click);
            // 
            // TSMNewSell
            // 
            this.TSMNewSell.Image = ((System.Drawing.Image)(resources.GetObject("TSMNewSell.Image")));
            this.TSMNewSell.Name = "TSMNewSell";
            this.TSMNewSell.Size = new System.Drawing.Size(156, 22);
            this.TSMNewSell.Text = "عملية شراء جديد";
            this.TSMNewSell.Click += new System.EventHandler(this.TSMNewSell_Click);
            // 
            // TSMUsers
            // 
            this.TSMUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMUsersManagement,
            this.TSMAddUser});
            this.TSMUsers.Name = "TSMUsers";
            this.TSMUsers.Size = new System.Drawing.Size(79, 20);
            this.TSMUsers.Text = "المستخدمين";
            // 
            // TSMUsersManagement
            // 
            this.TSMUsersManagement.Image = ((System.Drawing.Image)(resources.GetObject("TSMUsersManagement.Image")));
            this.TSMUsersManagement.Name = "TSMUsersManagement";
            this.TSMUsersManagement.Size = new System.Drawing.Size(174, 22);
            this.TSMUsersManagement.Text = "ادارة المستخدمين ";
            this.TSMUsersManagement.Click += new System.EventHandler(this.TSMUsersManagement_Click);
            // 
            // TSMAddUser
            // 
            this.TSMAddUser.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddUser.Image")));
            this.TSMAddUser.Name = "TSMAddUser";
            this.TSMAddUser.Size = new System.Drawing.Size(174, 22);
            this.TSMAddUser.Text = "اضافة مستخدم جديد";
            this.TSMAddUser.Click += new System.EventHandler(this.TSMAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MAIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مشرع ادارة مبيعات ومشتريات صيدلية";
            this.Activated += new System.EventHandler(this.FRM_MAIN_Activated);
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSNFile;
        private System.Windows.Forms.ToolStripMenuItem TSMProducts;
        private System.Windows.Forms.ToolStripMenuItem TSMCustomers;
        private System.Windows.Forms.ToolStripMenuItem TSMSuppliers;
        private System.Windows.Forms.ToolStripMenuItem TSMUsers;
        private System.Windows.Forms.ToolStripMenuItem TSMLogin;
        private System.Windows.Forms.ToolStripMenuItem TSMLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMBackup;
        private System.Windows.Forms.ToolStripMenuItem TSMResotre;
        private System.Windows.Forms.ToolStripMenuItem TSMProductManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMTypesManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddType;
        private System.Windows.Forms.ToolStripMenuItem TSMCustomerManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem TSMBuyManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMNewBuy;
        private System.Windows.Forms.ToolStripMenuItem TSMSuppliersManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddSupplier;
        private System.Windows.Forms.ToolStripMenuItem TSMSellesMAnagement;
        private System.Windows.Forms.ToolStripMenuItem TSMNewSell;
        private System.Windows.Forms.ToolStripMenuItem TSMUsersManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMActiveMaterialManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddActiveMaterial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMSceintificNameManagement;
        private System.Windows.Forms.ToolStripMenuItem TSMAddSceintificName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TSMCountryManagement;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمدنToolStripMenuItem;
    }
}