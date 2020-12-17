using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AnhBank
{
    public partial class frmNhanVien : Form
    {
        int vitri = 0,trangthai=-1,them=0,sua=1;
        String macn = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            grBoxThongTin.Enabled = false;
            barBtnGhiNV.Enabled = barBtnPhucHoiNV.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            // xy ly combobo phai
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("nam", "nam");
            comboSource.Add("nu", "nu");
            cmbPhaiNV.DataSource = new BindingSource(comboSource, null);
            cmbPhaiNV.DisplayMember = "Value";
            cmbPhaiNV.ValueMember = "Key";

            // TODO: This line of code loads data into the 'dSPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dSPhanManh.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);


            cmbChiNhanh.SelectedIndex = Program.mChinhanh; 
            if (Program.mGroup == "NGANHANG") cmbChiNhanh.Enabled = true;
            else cmbChiNhanh.Enabled = false;
            macn = Program.getTenChiNhanh();

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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                macn = Program.getTenChiNhanh();
            }
        }

        private void barBtnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            trangthai = sua;
            txtMaNV.Enabled = false;

            grBoxThongTin.Enabled = true;
            barBtnThemNV.Enabled = barBtnSuaNV.Enabled = barBtnXoaNV.Enabled = false;
            barBtnGhiNV.Enabled = barBtnPhucHoiNV.Enabled = true;
        }

        private void barBtnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                int result = Program.ExecSqlNonQuery("UPDATE NHANVIEN SET TrangThaiXoa = 1 WHERE MANV = '"+manv+"'");
                if(result == 0)
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                }else
                {
                    MessageBox.Show("Xóa nhân viên thất bại\nMời bạn thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (bdsNV.Count == 0) barBtnXoaNV.Enabled = false;
        }

        private void barBtnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            grBoxThongTin.Enabled = true;
            bdsNV.AddNew();
            trangthai = them;
            txtMaNV.Enabled = true;
            cmbChiNhanh.Enabled = false;

            txtTrangThaiNV.Text = "0";
            txtMaCNNV.Text = macn;
            barBtnThemNV.Enabled = barBtnSuaNV.Enabled = barBtnXoaNV.Enabled = false;
            barBtnGhiNV.Enabled = barBtnPhucHoiNV.Enabled = true;
        }

        private void barBtnGhiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtHoNV.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return;
            }
            if (cmbPhaiNV.SelectedValue.ToString().Trim() == "")
            {
                MessageBox.Show("Giới tính không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPhaiNV.Focus();
                return;
            }
            try
            {
                SqlDataReader result = Program.ExecSqlDataReader("exec SP_TimNhanVien '" + txtMaNV.Text + "'");
                if (result != null && trangthai == them)
                {
                    MessageBox.Show("Đã có thông tin nhân viên với mã nhân viên này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    result.Close();
                    return;

                }

            }
            catch (SqlException ex)
            {

            }
            // kiểm tra số điện thoại hợp lệ

            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);

            }
            catch (SqlException ex)
            {
                if (ex.Number == 515)
                    MessageBox.Show("Lỗi ghi nhân viên.\nSố CMND không được trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            barBtnThemNV.Enabled = barBtnSuaNV.Enabled = barBtnXoaNV.Enabled = true;
            barBtnGhiNV.Enabled = barBtnPhucHoiNV.Enabled = false;
            grBoxThongTin.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }

        private void barBtnPhucHoiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (barBtnThemNV.Enabled == false) bdsNV.Position = vitri;
            grBoxThongTin.Enabled = false;
            barBtnThemNV.Enabled = barBtnSuaNV.Enabled = barBtnXoaNV.Enabled = true;
            barBtnGhiNV.Enabled = barBtnPhucHoiNV.Enabled = false;

            cmbChiNhanh.Enabled = true;
        }
    }
}
