using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace AnhBank
{
    public partial class XfrmDSTaiKhoanTheoThoiGian : Form
    {
        public XfrmDSTaiKhoanTheoThoiGian()
        {
            InitializeComponent();
        }

        private void XfrmDSTaiKhoanTheoThoiGian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dSPhanManh.V_DS_PHANMANH);
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG") cmbChiNhanh.Enabled = true;
            else cmbChiNhanh.Enabled = false;
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
                
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(dETu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                dETu.Focus();return;
            }
            if (dEDen.Text.Trim()  == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dEDen.Focus(); return;
            }

            Xr_DSTaiKhoanTheoThoiGian rp = new Xr_DSTaiKhoanTheoThoiGian(dETu.DateTime,dEDen.DateTime);
            String tu = dETu.DateTime.ToString("dd/MM/yyyy");
            String den = dEDen.DateTime.ToString("dd/MM/yyyy");
            rp.lblTu.Text = tu;
            rp.lblDen.Text = den;
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
