using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO
{
  public  class KhanhHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int SoLanAn { get; set; }
        public decimal TongTien { get; set; }
        public string PhanLoai { get; set; }

        KhanhHang()
        {

        }

        KhanhHang(string maKH , string tenKH , string diaChi,string sdt, string email,int soLanAn, decimal tongTien,string phanLoai)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
            this.SDT = sdt;
            this.Email = email;
            this.SoLanAn = soLanAn;
            this.TongTien = tongTien;
            this.PhanLoai = phanLoai;
        }
    }
}
