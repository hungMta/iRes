using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Plugin.NhanVien.Enitity
{
   public class NhanVienEntity
    {
        private String idNV;

        public String IdNV
        {
            get { return idNV; }
            set { idNV = value; }
        }
        private String tenNV;

        public String TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private String gioiTinh;

        public String GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }


        private String queQuan;

        public String QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
        private decimal luong;

        public decimal Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        private String chucVu;

        public String ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public NhanVienEntity()
        {

        }

        public NhanVienEntity(String idNV , String tenNV , String gioiTinh, DateTime ngaySinh, String queQuan, decimal luong, String chucVu)
        {
            this.idNV = idNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.luong = luong;
            this.ngaySinh = ngaySinh;
            this.queQuan = queQuan;
            this.chucVu = chucVu;
        }

        
    }
}
