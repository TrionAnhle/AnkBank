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
    public partial class frmTaiKhoan : Form
    {
        int vitri = 0;
        string macn = "";
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            grBoxThongTin.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            // TODO: This line of code loads data into the 'dSPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dSPhanManh.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);

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
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                macn = Program.getTenChiNhanh();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTK.Position;
            grBoxThongTin.Enabled = true;
            bdsTK.AddNew();
            cmbChiNhanh.Enabled = false;
            txtMaCN.Text = macn;

            this.spinEtSoDu.Properties.MinValue = 0;
            spinEtSoDu.Text = "0";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHienThi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Số CMND không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }
            if (txtStk.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStk.Focus();
                return;
            }
            /*if (int.Parse(spinEtSoDu.Text) < 0)
            {
                MessageBox.Show("Số dư phải lớn hơn hoặc bằng 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinEtSoDu.Focus();
                return;
            }*/
            Console.WriteLine(spinEtSoDu.Text);
            // Kiểm tra CMND đã có thông tin chưa
            SqlDataReader result = Program.ExecSqlDataReader("SELECT * FROM KhachHang WHERE CMND = '" + txtCMND.Text + "'");
            if (!result.HasRows)
            {
                if (MessageBox.Show("Số CMND này chưa có thông tin\nBạn có muốn tạo thông tin cho số CMND này?", "Cảnh báo",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Form frm = Program.frmChinh.CheckExits(typeof(frmKhachHang));
                    if (frm != null) frm.Activate();
                    else
                    {
                        frmKhachHang f = new frmKhachHang();
                        f.MdiParent = Program.frmChinh;
                        f.Show();
                    }
                }
                result.Close();
                return;
            }
            result.Close();
            // Kiểm tra đã tồn tại tài khoản này chưa
            SqlDataReader result2 = Program.ExecSqlDataReader("exec SP_TimTaiKhoan '" + txtStk.Text + "'");
            if (result2.HasRows)
            {
                MessageBox.Show("Số tài khoản này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStk.Focus();
                result2.Close();
                return;
            }
            result2.Close();

            try
            {
                bdsTK.EndEdit();
                bdsTK.ResetCurrentItem();
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Update(this.DS.TaiKhoan);

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
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHienThi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            grBoxThongTin.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.CancelEdit();
            if (btnThem.Enabled == false) bdsTK.Position = vitri;
            grBoxThongTin.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHienThi.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            cmbChiNhanh.Enabled = true;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlDataReader result = Program.ExecSqlDataReader("SELECT * FROM KhachHang WHERE CMND = '" + txtCMND.Text + "'");
            if (!result.HasRows)
            {
                if (MessageBox.Show("Số CMND này chưa có thông tin\nBạn có muốn tạo thông tin cho số CMND này?", "Cảnh báo",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Form frm = Program.frmChinh.CheckExits(typeof(frmKhachHang));
                    if (frm != null) frm.Activate();
                    else
                    {
                        frmKhachHang f = new frmKhachHang();
                        f.MdiParent = Program.frmChinh;
                        f.Show();
                    }
                }
                result.Close();
            }
            else
            {
                    result.Read();
                    String thongTin = "SỐ CMND: " + result.GetString(0) + "\n";
                    thongTin += ("HỌ TÊN: " + result.GetString(1) + " " + result.GetString(2) + "\n");
                    thongTin += ("PHÁI: " + result.GetString(4) + "\n");
                    thongTin += ("ĐỊA CHỈ: " + result.GetString(3) + "\n");
                    thongTin += ("SĐT: " + result.GetString(6));
                    MessageBox.Show("Số CMND này hợp lệ.\n" + thongTin, "Thông tin",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result.Close();
            }
        }

        private void btnHienThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String CMND = ((DataRowView)bdsTK[bdsTK.Position])["CMND"].ToString();
            SqlDataReader result = Program.ExecSqlDataReader("SELECT * FROM KhachHang WHERE CMND = '" + CMND + "'");
            if (result != null && result.HasRows)
            {
                result.Read();
                String thongTin = "SỐ CMND: " + result.GetString(0) + "\n";
                thongTin += ("HỌ TÊN: " + result.GetString(1) + " " + result.GetString(2) + "\n");
                thongTin += ("PHÁI: " + result.GetString(4) + "\n");
                thongTin += ("ĐỊA CHỈ: " + result.GetString(3) + "\n");
                thongTin += ("SĐT: " + result.GetString(6));
                MessageBox.Show(thongTin, "Thông tin",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                result.Close();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String stk = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            SqlDataReader result = Program.ExecSqlDataReader("exec SP_GiaoDichCuaTaiKhoan '" + stk + "'");
            if (result.HasRows)
            {
                result.Read();
                if (result.GetInt32(0) == 1)
                {
                    MessageBox.Show("Tài khoản này không được sửa vì đã phát sinh giao dịch!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result.Close();
                    return;
                }
                result.Close();
            }
            if (!result.IsClosed) result.Close();


            vitri = bdsTK.Position;
            grBoxThongTin.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHienThi.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string stk = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // kiem tra tai khoan da phat sinh giao dich chua
                stk = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
                SqlDataReader result = Program.ExecSqlDataReader("exec SP_GiaoDichCuaTaiKhoan '" + stk + "'");
                if (result.HasRows)
                {
                    result.Read();
                    if (result.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Tài khoản này không được sửa vì đã phát sinh giao dịch!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result.Close();
                        return;
                    }
                    result.Close();
                }
                result.Close();
                try
                {
                    stk = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
                    bdsTK.RemoveCurrent();
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Update(this.DS.TaiKhoan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                    bdsTK.Position = bdsTK.Find("SOTK", stk);
                    return;
                }
            }
            if (bdsTK.Count == 0) btnXoa.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
        }
    }
}
