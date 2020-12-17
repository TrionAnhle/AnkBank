using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AnhBank
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dSPhanManh.V_DS_PHANMANH);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text.Trim() == "" || txtBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và Password không đc để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.servername = cmBoxServerName.SelectedValue.ToString();
            Program.mlogin = Program.mloginDN = this.txtBoxUsername.Text;
            Program.password = Program.passwordDN = this.txtBoxPassword.Text;

            if (Program.KetNoi() == 0)
            {
                Program.mlogin = Program.password = Program.mloginDN = Program.passwordDN = "";
                return;
            }

            Program.mChinhanh = cmBoxServerName.SelectedIndex;
            Program.bds_dspm = bdsPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            SqlDataReader result = Program.ExecSqlDataReader("exec SP_DANGNHAP '" + Program.mlogin + "'");
            if (result.HasRows)
            {
                result.Read();
                Program.username = result.GetString(0);
                Program.mHoten = result.GetString(1);
                Program.mGroup = result.GetString(2);
                result.Close();
                SqlDataReader trangthai = Program.ExecSqlDataReader(
                    "select trangthaixoa from nhanvien where manv ='"+Program.username+"'");
                if (trangthai.HasRows)
                {
                    trangthai.Read();
                    if (trangthai.GetInt32(0) == 1)
                    {
                        MessageBox.Show("Bạn không thể đăng nhập hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        trangthai.Close();
                    }
                    Program.frmChinh.pageQuanLy.Visible = Program.frmChinh.pageThongKe.Visible = true;
                    Program.frmChinh.barButtonThoat.Enabled = true;
                    Program.frmChinh.barButtonDangNhap.Enabled = false;
                    Program.frmChinh.hienThiStatus();
                    this.Close();
                }
            }
        }

        private void cmBoxServerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
