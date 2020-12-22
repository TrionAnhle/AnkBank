using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace AnhBank
{
    public partial class Xr_DSSaoKeGiaoDich : DevExpress.XtraReports.UI.XtraReport
    {
        public Xr_DSSaoKeGiaoDich(String stk, DateTime from, DateTime to)
        {
            InitializeComponent();
            string ngayTu = from.ToString("yyyy-MM-dd HH:mm:ss");
            string ngayDen = to.ToString("yyyy-MM-dd HH:mm:ss");
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = stk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayTu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngayDen;
            this.sqlDataSource1.Fill();
        }

    }
}
