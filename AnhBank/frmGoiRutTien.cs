using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

            dateEditNgay.DateTime = DateTime.Now;
            string[] ngay = DateTime.Now.ToString().Split(' ');
            dateEditNgay.Text = ngay[0];

            txtMaNV.Text = Program.username;
            spinEditSoTien.Properties.MinValue = 0;
            spinEditSoTien.Value = 0;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }
    }
}
