using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace AnhBank
{
    public partial class Xr_DSTaiKhoanTheoThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        public Xr_DSTaiKhoanTheoThoiGian(DateTime tu, DateTime den)
        {
            InitializeComponent();
            string ngayTu = tu.ToString("yyyy-MM-dd HH:mm:ss");
            string ngayDen = den.ToString("yyyy-MM-dd HH:mm:ss");
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayTu;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayDen;
            this.sqlDataSource1.Fill();
        }

    }
}
