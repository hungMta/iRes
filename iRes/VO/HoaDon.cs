using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO
{
    public class HoaDon
    {
        public HoaDon() { }
        public HoaDon(DateTime thoiGian, string maKH, string maNV, int thanhTien, int chietKhau, int tongTien) {
            this.ThoiGian = thoiGian;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.ThanhTien = thanhTien;
            this.ChietKhau = chietKhau;
            this.TongTien = tongTien;
        }

        public HoaDon(string maHD ,DateTime thoiGian, string maKH, string maNV, int thanhTien, int chietKhau, int tongTien)
        {
            this.MaHD = maHD;
            this.ThoiGian = thoiGian;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.ThanhTien = thanhTien;
            this.ChietKhau = chietKhau;
            this.TongTien = tongTien;
        }

        public string MaHD { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public int ThanhTien { get; set; }
        public int ChietKhau { get; set; }
        public int TongTien { get; set; }
    }
}
