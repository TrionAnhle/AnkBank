using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace AnhBank
{
    public partial class XfrmDSSaoKeGiaoDich : Form
    {
        public XfrmDSSaoKeGiaoDich()
        {
            InitializeComponent();
        }

        private void XfrmDSSaoKeGiaoDich_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dSPhanManh.V_DS_PHANMANH);

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            SqlDataReader result = Program.ExecSqlDataReader("SELECT SOTK,KhachHang.CMND,CONCAT(HO,' ',TEN) AS HOTEN"
                                                 +" FROM TaiKhoan, KhachHang WHERE TaiKhoan.CMND = KhachHang.CMND");
            if (result.HasRows)
            {
                while (result.Read())
                {
                    string value = result.GetString(0) + "-" + result.GetString(1) + "-" + result.GetString(2);
                    comboSource.Add(result.GetString(0), value);
                }
                result.Close();
            }
            result.Close();

            cmbStk.DataSource = new BindingSource(comboSource, null);
            cmbStk.DisplayMember = "Value";
            cmbStk.ValueMember = "Key";
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cmbChiNhanh.SelectedValue);
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
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                SqlDataReader result = Program.ExecSqlDataReader("SELECT SOTK,KhachHang.CMND,CONCAT(HO,' ',TEN) AS HOTEN"
                                                     + " FROM TaiKhoan, KhachHang WHERE TaiKhoan.CMND = KhachHang.CMND");
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        string value = result.GetString(0) + "-" + result.GetString(1) + "-" + result.GetString(2);
                        comboSource.Add(result.GetString(0), value);
                    }
                }
                result.Close();

                cmbStk.DataSource = new BindingSource(comboSource, null);
                cmbStk.DisplayMember = "Value";
                cmbStk.ValueMember = "Key";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dETu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dETu.Focus(); return;
            }
            if (dEDen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dEDen.Focus(); return;
            }

            Xr_DSSaoKeGiaoDich rp = new Xr_DSSaoKeGiaoDich(cmbStk.SelectedValue.ToString(),dETu.DateTime, dEDen.DateTime);
            String tu = dETu.DateTime.ToString("dd/MM/yyyy");
            String den = dEDen.DateTime.ToString("dd/MM/yyyy");
            rp.lblSTK.Text = "STK: " + cmbStk.SelectedValue.ToString();
            rp.lblTu.Text = tu;
            rp.lblDen.Text = den;
            
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
