namespace AnhBank
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSuaNV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhiNV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhucHoiNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPhanManh = new AnhBank.DSPhanManh();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new AnhBank.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new AnhBank.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new AnhBank.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBoxThongTin = new System.Windows.Forms.GroupBox();
            this.txtTrangThaiNV = new System.Windows.Forms.TextBox();
            this.txtMaCNNV = new DevExpress.XtraEditors.TextEdit();
            this.txtSdtNV = new DevExpress.XtraEditors.TextEdit();
            this.cmbPhaiNV = new System.Windows.Forms.ComboBox();
            this.txtDiaChiNV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.v_DS_PHANMANHTableAdapter = new AnhBank.DSPhanManhTableAdapters.V_DS_PHANMANHTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdtNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(60, 36);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(60, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MÃ NV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(294, 34);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(518, 38);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(40, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(51, 134);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(67, 17);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(280, 88);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(47, 17);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHÁI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(509, 93);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(38, 17);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SĐT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(60, 85);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(60, 17);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "MÃ CN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(613, 134);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(102, 17);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "TRẠNG THÁI:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThemNV,
            this.barBtnSuaNV,
            this.barBtnXoaNV,
            this.barBtnGhiNV,
            this.barBtnPhucHoiNV,
            this.btnUndo,
            this.btnRedo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThemNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSuaNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoaNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGhiNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPhucHoiNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnThemNV
            // 
            this.barBtnThemNV.Caption = "Thêm";
            this.barBtnThemNV.Id = 0;
            this.barBtnThemNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThemNV.ImageOptions.SvgImage")));
            this.barBtnThemNV.Name = "barBtnThemNV";
            this.barBtnThemNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemNV_ItemClick);
            // 
            // barBtnSuaNV
            // 
            this.barBtnSuaNV.Caption = "Sửa";
            this.barBtnSuaNV.Id = 1;
            this.barBtnSuaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSuaNV.ImageOptions.SvgImage")));
            this.barBtnSuaNV.Name = "barBtnSuaNV";
            this.barBtnSuaNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSuaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSuaNV_ItemClick);
            // 
            // barBtnXoaNV
            // 
            this.barBtnXoaNV.Caption = "Xóa";
            this.barBtnXoaNV.Id = 2;
            this.barBtnXoaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnXoaNV.ImageOptions.SvgImage")));
            this.barBtnXoaNV.Name = "barBtnXoaNV";
            this.barBtnXoaNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoaNV_ItemClick);
            // 
            // barBtnGhiNV
            // 
            this.barBtnGhiNV.Caption = "Ghi";
            this.barBtnGhiNV.Id = 3;
            this.barBtnGhiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnGhiNV.ImageOptions.SvgImage")));
            this.barBtnGhiNV.Name = "barBtnGhiNV";
            this.barBtnGhiNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGhiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhiNV_ItemClick);
            // 
            // barBtnPhucHoiNV
            // 
            this.barBtnPhucHoiNV.Caption = "Hủy";
            this.barBtnPhucHoiNV.Id = 4;
            this.barBtnPhucHoiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnPhucHoiNV.ImageOptions.SvgImage")));
            this.barBtnPhucHoiNV.Name = "barBtnPhucHoiNV";
            this.barBtnPhucHoiNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnPhucHoiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhucHoiNV_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 6;
            this.btnRedo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedo.ImageOptions.SvgImage")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(984, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 526);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(984, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(984, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 4;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.vDSPHANMANHBindingSource;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(205, 18);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(270, 25);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dSPhanManh;
            // 
            // dSPhanManh
            // 
            this.dSPhanManh.DataSetName = "DSPhanManh";
            this.dSPhanManh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AnhBank.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bdsNV;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 84);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(984, 220);
            this.nhanVienGridControl.TabIndex = 9;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 210;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "PHÁI";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 40;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "SĐT";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            // 
            // grBoxThongTin
            // 
            this.grBoxThongTin.Controls.Add(trangThaiXoaLabel);
            this.grBoxThongTin.Controls.Add(this.txtTrangThaiNV);
            this.grBoxThongTin.Controls.Add(mACNLabel);
            this.grBoxThongTin.Controls.Add(this.txtMaCNNV);
            this.grBoxThongTin.Controls.Add(sODTLabel);
            this.grBoxThongTin.Controls.Add(this.txtSdtNV);
            this.grBoxThongTin.Controls.Add(pHAILabel);
            this.grBoxThongTin.Controls.Add(this.cmbPhaiNV);
            this.grBoxThongTin.Controls.Add(dIACHILabel);
            this.grBoxThongTin.Controls.Add(this.txtDiaChiNV);
            this.grBoxThongTin.Controls.Add(tENLabel);
            this.grBoxThongTin.Controls.Add(this.txtTenNV);
            this.grBoxThongTin.Controls.Add(hOLabel);
            this.grBoxThongTin.Controls.Add(this.txtHoNV);
            this.grBoxThongTin.Controls.Add(mANVLabel);
            this.grBoxThongTin.Controls.Add(this.txtMaNV);
            this.grBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxThongTin.Location = new System.Drawing.Point(0, 304);
            this.grBoxThongTin.Name = "grBoxThongTin";
            this.grBoxThongTin.Size = new System.Drawing.Size(984, 222);
            this.grBoxThongTin.TabIndex = 14;
            this.grBoxThongTin.TabStop = false;
            this.grBoxThongTin.Text = "Thông tin nhân viên";
            // 
            // txtTrangThaiNV
            // 
            this.txtTrangThaiNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TrangThaiXoa", true));
            this.txtTrangThaiNV.Enabled = false;
            this.txtTrangThaiNV.Location = new System.Drawing.Point(722, 131);
            this.txtTrangThaiNV.Name = "txtTrangThaiNV";
            this.txtTrangThaiNV.Size = new System.Drawing.Size(25, 25);
            this.txtTrangThaiNV.TabIndex = 15;
            // 
            // txtMaCNNV
            // 
            this.txtMaCNNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txtMaCNNV.Enabled = false;
            this.txtMaCNNV.Location = new System.Drawing.Point(122, 82);
            this.txtMaCNNV.MenuManager = this.barManager1;
            this.txtMaCNNV.Name = "txtMaCNNV";
            this.txtMaCNNV.Size = new System.Drawing.Size(135, 20);
            this.txtMaCNNV.TabIndex = 13;
            // 
            // txtSdtNV
            // 
            this.txtSdtNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "SODT", true));
            this.txtSdtNV.Location = new System.Drawing.Point(564, 90);
            this.txtSdtNV.MenuManager = this.barManager1;
            this.txtSdtNV.Name = "txtSdtNV";
            this.txtSdtNV.Size = new System.Drawing.Size(183, 20);
            this.txtSdtNV.TabIndex = 11;
            // 
            // cmbPhaiNV
            // 
            this.cmbPhaiNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "PHAI", true));
            this.cmbPhaiNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhaiNV.FormattingEnabled = true;
            this.cmbPhaiNV.Location = new System.Drawing.Point(333, 85);
            this.cmbPhaiNV.Name = "cmbPhaiNV";
            this.cmbPhaiNV.Size = new System.Drawing.Size(121, 25);
            this.cmbPhaiNV.TabIndex = 9;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDiaChiNV.Location = new System.Drawing.Point(121, 131);
            this.txtDiaChiNV.MenuManager = this.barManager1;
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(436, 20);
            this.txtDiaChiNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTenNV.Location = new System.Drawing.Point(564, 35);
            this.txtTenNV.MenuManager = this.barManager1;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(183, 20);
            this.txtTenNV.TabIndex = 5;
            // 
            // txtHoNV
            // 
            this.txtHoNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txtHoNV.Location = new System.Drawing.Point(333, 33);
            this.txtHoNV.MenuManager = this.barManager1;
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(121, 20);
            this.txtHoNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(122, 33);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(135, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.grBoxThongTin);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grBoxThongTin.ResumeLayout(false);
            this.grBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdtNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnThemNV;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaNV;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaNV;
        private DevExpress.XtraBars.BarButtonItem barBtnGhiNV;
        private DevExpress.XtraBars.BarButtonItem barBtnPhucHoiNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox grBoxThongTin;
        private System.Windows.Forms.TextBox txtTrangThaiNV;
        private DevExpress.XtraEditors.TextEdit txtMaCNNV;
        private DevExpress.XtraEditors.TextEdit txtSdtNV;
        private System.Windows.Forms.ComboBox cmbPhaiNV;
        private DevExpress.XtraEditors.TextEdit txtDiaChiNV;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtHoNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DSPhanManh dSPhanManh;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DSPhanManhTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
    }
}