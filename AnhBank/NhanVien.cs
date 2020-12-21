using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnhBank
{
    class NhanVien : IThaoTacSQL
    {
        private int thaotac;
        private string maNV,ho, ten, diachi, phai,sdt;

        public int getThaoTac() { return this.thaotac;}
        public string getMaNV() { return this.maNV; }
        public string getHo() { return this.ho; }
        public string getTen() { return this.ten; }
        public string getDiaChi() { return this.diachi; }
        public string getPhai() { return this.phai; }
        public string getSdt() { return this.sdt; }

        public void setThaoTac(int thaotac) { this.thaotac = thaotac; }
        public void setMaNV(string manv) { this.maNV = manv; }
        public void setHo(string ho) { this.ho = ho; }
        public void setTen(string ten) { this.ten = ten; }
        public void setDiaChi(string diachi) { this.diachi = diachi; }
        public void setPhai(string phai) { this.phai = phai; }
        public void setSdt(string sdt) { this.sdt = sdt; }

        public void insert()
        {
            int result = Program.ExecSqlNonQuery("UPDATE NHANVIEN SET TrangThaiXoa = 0 WHERE MANV = '" + this.maNV + "'");
            if(result != 0)
            {
                MessageBox.Show("Thêm nhân viên không được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete()
        {
            int result = Program.ExecSqlNonQuery("UPDATE NHANVIEN SET TrangThaiXoa = 1 WHERE MANV = '" + this.maNV + "'");
            if (result != 0)
            {
                MessageBox.Show("Xóa nhân viên không được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update()
        {
            String sql = "UPDATE NHANVIEN ";
            sql+=(" SET HO =N'"+this.ho+"', ");
            sql+=(" TEN =N'"+this.ten+"', ");
            sql+=(" DIACHI =N'"+this.diachi+"', ");
            sql+=(" PHAI ='"+this.phai+"', ");
            sql+=(" SODT ='" +this.sdt+ "' ");
            sql += (" WHERE MANV ='" + this.maNV + "'");
            Console.Write(sql);
            int result = Program.ExecSqlNonQuery(sql);
            if (result != 0)
            {
                MessageBox.Show("Cập nhật nhân viên không được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
