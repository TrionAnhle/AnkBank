namespace AnhBank
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonTKTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTKKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGuiRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTKGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonTKTaiKhoan,
            this.barButtonTKKhachHang,
            this.barButtonDangNhap,
            this.barButtonThoat,
            this.barButtonKhachHang,
            this.barButtonTaiKhoan,
            this.barButtonNhanVien,
            this.barButtonGuiRutTien,
            this.barButtonChuyenTien,
            this.barButtonTKGiaoDich});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHeThong,
            this.pageQuanLy,
            this.pageThongKe});
            this.ribbonControl1.Size = new System.Drawing.Size(998, 158);
            // 
            // barButtonTKTaiKhoan
            // 
            this.barButtonTKTaiKhoan.Caption = "Tài khoản";
            this.barButtonTKTaiKhoan.Id = 1;
            this.barButtonTKTaiKhoan.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_mastercard_credit_card_40px;
            this.barButtonTKTaiKhoan.Name = "barButtonTKTaiKhoan";
            this.barButtonTKTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonTKKhachHang
            // 
            this.barButtonTKKhachHang.Caption = "Khách hàng";
            this.barButtonTKKhachHang.Id = 2;
            this.barButtonTKKhachHang.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_team_64px;
            this.barButtonTKKhachHang.Name = "barButtonTKKhachHang";
            this.barButtonTKKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonDangNhap
            // 
            this.barButtonDangNhap.Caption = "Đăng nhập";
            this.barButtonDangNhap.Id = 3;
            this.barButtonDangNhap.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_unlock_40px;
            this.barButtonDangNhap.Name = "barButtonDangNhap";
            this.barButtonDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDangNhap_ItemClick);
            // 
            // barButtonThoat
            // 
            this.barButtonThoat.Caption = "Thoát";
            this.barButtonThoat.Id = 4;
            this.barButtonThoat.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_delete_40px;
            this.barButtonThoat.Name = "barButtonThoat";
            this.barButtonThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThoat_ItemClick);
            // 
            // barButtonKhachHang
            // 
            this.barButtonKhachHang.Caption = "Khách hàng";
            this.barButtonKhachHang.Id = 5;
            this.barButtonKhachHang.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_team_40px;
            this.barButtonKhachHang.Name = "barButtonKhachHang";
            this.barButtonKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonKhachHang_ItemClick);
            // 
            // barButtonTaiKhoan
            // 
            this.barButtonTaiKhoan.Caption = "Tài khoản";
            this.barButtonTaiKhoan.Id = 6;
            this.barButtonTaiKhoan.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_credit_card_40px;
            this.barButtonTaiKhoan.Name = "barButtonTaiKhoan";
            this.barButtonTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTaiKhoan_ItemClick);
            // 
            // barButtonNhanVien
            // 
            this.barButtonNhanVien.Caption = "Nhân viên";
            this.barButtonNhanVien.Id = 7;
            this.barButtonNhanVien.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_administrator_male_40px;
            this.barButtonNhanVien.Name = "barButtonNhanVien";
            this.barButtonNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNhanVien_ItemClick);
            // 
            // barButtonGuiRutTien
            // 
            this.barButtonGuiRutTien.Caption = "Gởi rút tiền";
            this.barButtonGuiRutTien.Id = 8;
            this.barButtonGuiRutTien.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_bank_building_64px;
            this.barButtonGuiRutTien.Name = "barButtonGuiRutTien";
            this.barButtonGuiRutTien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonChuyenTien
            // 
            this.barButtonChuyenTien.Caption = "Chuyển tiền";
            this.barButtonChuyenTien.Id = 9;
            this.barButtonChuyenTien.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_initiate_money_transfer_30px;
            this.barButtonChuyenTien.Name = "barButtonChuyenTien";
            this.barButtonChuyenTien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonTKGiaoDich
            // 
            this.barButtonTKGiaoDich.Caption = "Giao dịch";
            this.barButtonTKGiaoDich.Id = 10;
            this.barButtonTKGiaoDich.ImageOptions.Image = global::AnhBank.Properties.Resources.icons8_exchange_40px_11;
            this.barButtonTKGiaoDich.Name = "barButtonTKGiaoDich";
            this.barButtonTKGiaoDich.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // pageQuanLy
            // 
            this.pageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.pageQuanLy.Name = "pageQuanLy";
            this.pageQuanLy.Text = "Quản Lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonKhachHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonGuiRutTien);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonChuyenTien);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // pageThongKe
            // 
            this.pageThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageThongKe.Name = "pageThongKe";
            this.pageThongKe.Text = "Thống Kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonTKTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonTKKhachHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonTKGiaoDich);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMa,
            this.statusTen,
            this.statusNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(998, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMa
            // 
            this.statusMa.Name = "statusMa";
            this.statusMa.Size = new System.Drawing.Size(0, 17);
            // 
            // statusTen
            // 
            this.statusTen.Name = "statusTen";
            this.statusTen.Size = new System.Drawing.Size(0, 17);
            // 
            // statusNhom
            // 
            this.statusNhom.Name = "statusNhom";
            this.statusNhom.Size = new System.Drawing.Size(0, 17);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 699);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Ngân Hàng AnhBank";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        public DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.Ribbon.RibbonPage pageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.Ribbon.RibbonPage pageThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonTKTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonTKKhachHang;
        public DevExpress.XtraBars.BarButtonItem barButtonDangNhap;
        public DevExpress.XtraBars.BarButtonItem barButtonThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonKhachHang;
        private DevExpress.XtraBars.BarButtonItem barButtonTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonGuiRutTien;
        private DevExpress.XtraBars.BarButtonItem barButtonChuyenTien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonTKGiaoDich;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMa;
        private System.Windows.Forms.ToolStripStatusLabel statusTen;
        private System.Windows.Forms.ToolStripStatusLabel statusNhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

