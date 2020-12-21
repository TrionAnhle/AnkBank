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

namespace AnhBank
{
    public partial class XfrmDSKhachHang : Form
    {
        public XfrmDSKhachHang()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Xr_DanhSachKhachHang rp = new Xr_DanhSachKhachHang();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
