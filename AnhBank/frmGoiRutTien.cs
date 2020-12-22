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
    public partial class frmGoiRutTien : Form
    {
        public frmGoiRutTien()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGRTien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGoiRutTien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            gridView1.OptionsBehavior.Editable = false;
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.servername = Program.currentServer;
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            }

            dateEditNgay.DateTime = DateTime.Now;
            string[] ngay = DateTime.Now.ToString().Split(' ');
            dateEditNgay.Text = ngay[0];

            txtMaNV.Text = Program.username;
            spinEditSoTien.Properties.MinValue = 0;
            spinEditSoTien.Value = 0;

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("GT", "Gởi Tiền");
            comboSource.Add("RT", "Rút Tiền");
            cmbLoai.DataSource = new BindingSource(comboSource, null);
            cmbLoai.DisplayMember = "Value";
            cmbLoai.ValueMember = "Key";
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlDataReader result = Program.ExecSqlDataReader("exec SP_ThongTinTaiKhoan '" + txtStk.Text + "'");
            if (result.HasRows)
            {
                result.Read();
                String thongTin = "SỐ CMND: " + result.GetString(0) + "\n";
                thongTin += ("HỌ TÊN: " + result.GetString(1) + " " + result.GetString(2) + "\n");
                thongTin += ("PHÁI: " + result.GetString(4) + "\n");
                thongTin += ("ĐỊA CHỈ: " + result.GetString(3) + "\n");
                thongTin += ("SĐT: " + result.GetString(6) + "\n");
                MessageBox.Show(thongTin, "Thông tin",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                result.Close();
            }
            else
            {
                result.Close();
                MessageBox.Show("Số tài khoản không tồn tại", "Cảnh báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (txtStk.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStk.Focus();
                return;
            }
            if (spinEditSoTien.Value < 100000)
            {
                MessageBox.Show("Số tiền giao dịch phải lớn hơn hoặc bằng 100,000", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinEditSoTien.Focus();
                return;
            }
            // kiêm tra ton tai tai khoan
            SqlDataReader result = Program.ExecSqlDataReader("exec SP_TimTaiKhoan '" + txtStk.Text + "'");
            if (!result.HasRows)
            {
                MessageBox.Show("Số tài khoản này không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStk.Focus();
                result.Close();
                return;
            }
            result.Close();
            // chuyen ve chi nhanh hien tai
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.servername = Program.currentServer;
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            }
            // thuc hien giao dich
            string ngay = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String sql = "INSERT INTO GD_GOIRUT(SOTK, LOAIGD, SOTIEN, NGAYGD, MANV) ";
            sql += (" VALUES('" + txtStk.Text + "', ");
            sql += ("'" + cmbLoai.SelectedValue + "', ");
            sql += (spinEditSoTien.Value + ", ");
            sql += ("'" + ngay + "', ");
            sql += (" " + txtMaNV.Text + ")");
            int ret = Program.ExecSqlNonQuery(sql);
            Console.WriteLine(sql);
            if(ret == 0)
            {
                int val = Program.ExecSqlNonQuery("exec SP_GoiRutTien '" + txtStk.Text + "','"
                                                +cmbLoai.SelectedValue+ "'," + spinEditSoTien.Value);
                if (val == 0)
                {
                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
                    MessageBox.Show("Giao dịch thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStk.Text =  "";
                    spinEditSoTien.Value = 0;
                    spinEditSoTien.Value = 0;
                }
                else
                {
                        MessageBox.Show("Số tiền trong tài khoản không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }else
            {
                MessageBox.Show("Giao dịch tiền thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            cmbLoai.SelectedIndex = 0;
            txtStk.Text = "";
            spinEditSoTien.Value = 0;
        }
    }
}
