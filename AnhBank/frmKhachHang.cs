using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnhBank
{
    public partial class frmKhachHang : Form
    {
        int vitri = 0, them = 0, sua = 1, trangthai = -1;
        string macn = "";

        

        public frmKhachHang()
        {
            InitializeComponent();
        }

        

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            grBoxThongTin.Enabled = false;
            btnGhiKH.Enabled = btnPhucHoiKH.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            // xy ly combobo phai
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("nam", "nam");
            comboSource.Add("nu", "nu");
            cmbPhai.DataSource = new BindingSource(comboSource, null);
            cmbPhai.DisplayMember = "Value";
            cmbPhai.ValueMember = "Key";
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            // TODO: This line of code loads data into the 'dSPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dSPhanManh.V_DS_PHANMANH);

            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG") cmbChiNhanh.Enabled = true;
            else cmbChiNhanh.Enabled = false;
            macn = Program.getTenChiNhanh();

        }

        private void btnPhucHoiKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btnThemKH.Enabled == false) bdsKH.Position = vitri;
            grBoxThongTin.Enabled = false;
            btnThemKH.Enabled = btnSuaKH.Enabled = btnXoaKH.Enabled = true;
            btnGhiKH.Enabled = btnPhucHoiKH.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }

        private void btnSuaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            grBoxThongTin.Enabled = true;
            trangthai = sua;
            txtCMND.Enabled = false;

            btnThemKH.Enabled = btnSuaKH.Enabled = btnXoaKH.Enabled = false;
            btnGhiKH.Enabled = btnPhucHoiKH.Enabled = true;
        }

        private void btnXoaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmnd = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // kiem tra da tao tai khoan chua
                SqlDataReader result = Program.ExecSqlDataReader("exec SP_TimTaiKhoanCuaKhachHang '" + txtCMND.Text + "'");
                if (result.HasRows)
                {
                    MessageBox.Show("Không được xóa khách hàng\nKhách hàng đã mở tài khoản!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result.Close();
                    return;
                }
                result.Close();
                try
                {
                    cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
                    bdsKH.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.DS.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.DS.KhachHang);
                    bdsKH.Position = bdsKH.Find("CMND", cmnd);
                    return;
                }
            }
            if (bdsKH.Count == 0) btnXoaKH.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChiNhanh.SelectedIndex < 0) return;
                if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            }
            catch (System.NullReferenceException ex) { return; }

            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
                macn = Program.getTenChiNhanh();
            }
        }

        private void btnThemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            grBoxThongTin.Enabled = true;
            bdsKH.AddNew();
            txtCMND.Enabled = true;
            cmbPhai.SelectedIndex = 0;
            cmbChiNhanh.Enabled = false;

            txtMaCN.Text = macn;
            dateEditNgayCap.DateTime = DateTime.Now;
            string[] ngay = DateTime.Now.ToString().Split(' ');
            dateEditNgayCap.Text = ngay[0];
            trangthai = them;
            btnThemKH.Enabled = btnSuaKH.Enabled = btnXoaKH.Enabled = false;
            btnGhiKH.Enabled = btnPhucHoiKH.Enabled = true;
        }

        private void btnGhiKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Số CMND không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
            if (cmbPhai.SelectedValue.ToString().Trim() == "")
            {
                MessageBox.Show("Giới tính khách hàng không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPhai.Focus();
                return;
            }
            try
            {
                SqlDataReader result = Program.ExecSqlDataReader("SELECT * FROM KhachHang WHERE CMND = '" + txtCMND.Text + "'");
                if (result.HasRows && trangthai == them)
                {
                    if (result.HasRows)
                    {
                        MessageBox.Show("Đã có thông tin khách hàng với số CMND này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCMND.Focus();
                        result.Close();
                        return;
                    }
                }
                result.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Number);
            }

            // kiểm tra số điện thoại hợp lệ

            try
            {
                bdsKH.EndEdit();
                bdsKH.ResetCurrentItem();
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Update(this.DS.KhachHang);

            }
            catch (SqlException ex)
            {
                if (ex.Number == 515)
                    MessageBox.Show("Lỗi ghi khách hàng.\nSố CMND không được trùng\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hang.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            }
            btnThemKH.Enabled = btnSuaKH.Enabled = btnXoaKH.Enabled = true;
            btnGhiKH.Enabled = btnPhucHoiKH.Enabled = false;
            grBoxThongTin.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }
    }
}
