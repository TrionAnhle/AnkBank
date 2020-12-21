namespace AnhBank
{
    partial class frmChuyenTien
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
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label mANVLabel;
            this.DS = new AnhBank.DS();
            this.bdsCTien = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new AnhBank.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new AnhBank.DSTableAdapters.TableAdapterManager();
            this.gD_CHUYENTIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spinEditSoTien = new DevExpress.XtraEditors.SpinEdit();
            this.txtSTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtSTKChuyen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.dateEditNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnKiemTraStkNhan = new System.Windows.Forms.Button();
            this.btnKiemTraStkChuyen = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AnhBank.WaitForm1), true, true);
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(21, 221);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(185, 17);
            sOTK_CHUYENLabel.TabIndex = 0;
            sOTK_CHUYENLabel.Text = "SỐ TÀI KHOẢN CHUYỂN:";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Location = new System.Drawing.Point(289, 221);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(166, 17);
            sOTK_NHANLabel.TabIndex = 2;
            sOTK_NHANLabel.Text = "SỐ TÀI KHOẢN NHẬN:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(77, 366);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(68, 17);
            sOTIENLabel.TabIndex = 4;
            sOTIENLabel.Text = "SỐ TIỀN:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(21, 140);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(53, 17);
            nGAYGDLabel.TabIndex = 6;
            nGAYGDLabel.Text = "NGÀY:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(226, 140);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(123, 17);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MÃ NHÂN VIÊN:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCTien
            // 
            this.bdsCTien.DataMember = "GD_CHUYENTIEN";
            this.bdsCTien.DataSource = this.DS;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AnhBank.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.bdsCTien;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(495, 486);
            this.gD_CHUYENTIENGridControl.TabIndex = 1;
            this.gD_CHUYENTIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK_CHUYEN,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_NHAN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.Caption = "MÃ GD";
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 66;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.Caption = "STK CHUYỂN";
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            this.colSOTK_CHUYEN.Width = 92;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.Caption = "NGÀY";
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 92;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.Caption = "TIỀN";
            this.colSOTIEN.DisplayFormat.FormatString = "N0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 92;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.Caption = "STK NHẬN";
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 4;
            this.colSOTK_NHAN.Width = 92;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.spinEditSoTien);
            this.groupBox1.Controls.Add(this.txtSTKNhan);
            this.groupBox1.Controls.Add(this.txtSTKChuyen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.dateEditNgay);
            this.groupBox1.Controls.Add(this.btnKiemTraStkNhan);
            this.groupBox1.Controls.Add(this.btnKiemTraStkChuyen);
            this.groupBox1.Controls.Add(this.btnHuyBo);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(nGAYGDLabel);
            this.groupBox1.Controls.Add(sOTIENLabel);
            this.groupBox1.Controls.Add(sOTK_NHANLabel);
            this.groupBox1.Controls.Add(sOTK_CHUYENLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(495, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyển tiền";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AnhBank.Properties.Resources.icons8_right_96px;
            this.pictureBox2.Location = new System.Drawing.Point(207, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnhBank.Properties.Resources.icons8_handshake_96px;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // spinEditSoTien
            // 
            this.spinEditSoTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditSoTien.Location = new System.Drawing.Point(151, 360);
            this.spinEditSoTien.Name = "spinEditSoTien";
            this.spinEditSoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditSoTien.Properties.Appearance.Options.UseFont = true;
            this.spinEditSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSoTien.Properties.DisplayFormat.FormatString = "N0";
            this.spinEditSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditSoTien.Size = new System.Drawing.Size(187, 28);
            this.spinEditSoTien.TabIndex = 18;
            // 
            // txtSTKNhan
            // 
            this.txtSTKNhan.Location = new System.Drawing.Point(292, 251);
            this.txtSTKNhan.Name = "txtSTKNhan";
            this.txtSTKNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTKNhan.Properties.Appearance.Options.UseFont = true;
            this.txtSTKNhan.Size = new System.Drawing.Size(163, 28);
            this.txtSTKNhan.TabIndex = 17;
            // 
            // txtSTKChuyen
            // 
            this.txtSTKChuyen.Location = new System.Drawing.Point(24, 251);
            this.txtSTKChuyen.Name = "txtSTKChuyen";
            this.txtSTKChuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTKChuyen.Properties.Appearance.Options.UseFont = true;
            this.txtSTKChuyen.Size = new System.Drawing.Size(177, 28);
            this.txtSTKChuyen.TabIndex = 16;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(355, 134);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(100, 28);
            this.txtMaNV.TabIndex = 15;
            // 
            // dateEditNgay
            // 
            this.dateEditNgay.EditValue = null;
            this.dateEditNgay.Enabled = false;
            this.dateEditNgay.Location = new System.Drawing.Point(80, 134);
            this.dateEditNgay.Name = "dateEditNgay";
            this.dateEditNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditNgay.Properties.Appearance.Options.UseFont = true;
            this.dateEditNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Size = new System.Drawing.Size(121, 28);
            this.dateEditNgay.TabIndex = 14;
            // 
            // btnKiemTraStkNhan
            // 
            this.btnKiemTraStkNhan.Location = new System.Drawing.Point(335, 299);
            this.btnKiemTraStkNhan.Name = "btnKiemTraStkNhan";
            this.btnKiemTraStkNhan.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTraStkNhan.TabIndex = 13;
            this.btnKiemTraStkNhan.Text = "Kiểm tra";
            this.btnKiemTraStkNhan.UseVisualStyleBackColor = true;
            this.btnKiemTraStkNhan.Click += new System.EventHandler(this.btnKiemTraStkNhan_Click);
            // 
            // btnKiemTraStkChuyen
            // 
            this.btnKiemTraStkChuyen.Location = new System.Drawing.Point(80, 299);
            this.btnKiemTraStkChuyen.Name = "btnKiemTraStkChuyen";
            this.btnKiemTraStkChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTraStkChuyen.TabIndex = 12;
            this.btnKiemTraStkChuyen.Text = "Kiểm tra";
            this.btnKiemTraStkChuyen.UseVisualStyleBackColor = true;
            this.btnKiemTraStkChuyen.Click += new System.EventHandler(this.btnKiemTraStkChuyen_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHuyBo.FlatAppearance.BorderSize = 4;
            this.btnHuyBo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.Red;
            this.btnHuyBo.ImageKey = "(none)";
            this.btnHuyBo.Location = new System.Drawing.Point(386, 425);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(93, 31);
            this.btnHuyBo.TabIndex = 11;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThucHien.FlatAppearance.BorderSize = 4;
            this.btnThucHien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThucHien.Location = new System.Drawing.Point(275, 425);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(93, 31);
            this.btnThucHien.TabIndex = 10;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChuyenTien";
            this.Text = "Chuyển Tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsCTien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnKiemTraStkNhan;
        private System.Windows.Forms.Button btnKiemTraStkChuyen;
        private DevExpress.XtraEditors.DateEdit dateEditNgay;
        private DevExpress.XtraEditors.SpinEdit spinEditSoTien;
        private DevExpress.XtraEditors.TextEdit txtSTKNhan;
        private DevExpress.XtraEditors.TextEdit txtSTKChuyen;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}