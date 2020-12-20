using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnhBank
{
    public partial class frmChuyenTien : Form
    {
        public frmChuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChuyenTien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            gridView1.OptionsBehavior.Editable = false;
            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.servername = Program.currentServer;
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            }

            dateEditNgay.DateTime = DateTime.Now;
            string[] ngay = DateTime.Now.ToString().Split(' ');
            dateEditNgay.Text = ngay[0];

            txtMaNV.Text = Program.username;
            spinEditSoTien.Properties.MinValue = 0;
            spinEditSoTien.Value = 0;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (txtSTKChuyen.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản chuyển không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTKChuyen.Focus();
                return;
            }
            if (txtSTKNhan.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản nhận không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTKNhan.Focus();
                return;
            }
            if(txtSTKChuyen.Text.Trim() == txtSTKNhan.Text.Trim())
            {
                MessageBox.Show("Số tài khoản chuyển và nhận giống nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTKNhan.Focus();
                return;
            }
            if (spinEditSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền chuyển phải lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinEditSoTien.Focus();
                return;
            }
            // kiem tra ton tai tai khoan
            SqlDataReader result = Program.ExecSqlDataReader("exec SP_TimTaiKhoan '" + txtSTKChuyen.Text + "'");
            if (!result.HasRows)
            {
                MessageBox.Show("Số tài khoản chuyển này không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTKChuyen.Focus();
                result.Close();
                return;
            }
            result.Close();
            SqlDataReader result2 = Program.ExecSqlDataReader("exec SP_TimTaiKhoan '" + txtSTKNhan.Text + "'");
            if (!result2.HasRows)
            {
                MessageBox.Show("Số tài khoản nhận này không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTKNhan.Focus();
                result2.Close();
                return;
            }
            result2.Close();
            // chuyen ve chi nhanh hien tai
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.servername = Program.currentServer;
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            // thuc hien giao dich
            string ngay = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String sql = "INSERT INTO GD_CHUYENTIEN(SOTK_CHUYEN, SOTK_NHAN, SOTIEN, NGAYGD, MANV) ";
            sql += (" VALUES('" + txtSTKChuyen.Text + "', ");
            sql += ("'" + txtSTKNhan.Text + "', ");
            sql += (spinEditSoTien.Value + ", ");
            sql += ("'" + ngay + "', ");
            sql += (" " + txtMaNV.Text + ")");
            int ret = Program.ExecSqlNonQuery(sql);
            if(ret == 0)
            {           
                int val = Program.ExecSqlNonQuery("exec SP_ChuyenTien '" + txtSTKChuyen.Text + "','"
                                                + txtSTKNhan.Text + "'," + spinEditSoTien.Value);
                if (val == 0)
                {
                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
                    MessageBox.Show("Chuyển tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSTKChuyen.Text = txtSTKNhan.Text = "";
                    spinEditSoTien.Value = 0;
                }
                else
                {
                    if (ret == 1)
                    {
                        MessageBox.Show("Số tiền trong tài khoản chuyển không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }else
            {
                MessageBox.Show("Chuyển tiền thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtSTKChuyen.Text = txtSTKNhan.Text = "";
            spinEditSoTien.Value = 0;
        }

        private void btnKiemTraStkChuyen_Click(object sender, EventArgs e)
        {
            kiemTraTonTaiStk(txtSTKChuyen.Text);
        }

        private void btnKiemTraStkNhan_Click(object sender, EventArgs e)
        {
            kiemTraTonTaiStk(txtSTKNhan.Text);
        }

        private void kiemTraTonTaiStk(String stk)
        {
            SqlDataReader result = Program.ExecSqlDataReader("exec SP_TimTaiKhoan '" + stk + "'");
            if (result.HasRows)
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
            }else
            {
                result.Close();
                MessageBox.Show("Số tài khoản không tồn tại", "Cảnh báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
