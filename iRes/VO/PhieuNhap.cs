using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class PhieuNhap {
        public PhieuNhap() { }
        public PhieuNhap(string maPhieuNhap, int tongTien, DateTime thoiGian, string maNhanVien) {
            this.MaPhieuNhap = MaPhieuNhap;
            this.TongTien = tongTien;
            this.ThoiGian = thoiGian;
            this.MaNhanVien = maNhanVien;
        }
        public string MaPhieuNhap { get; set; }
        public int TongTien { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaNhanVien { get; set; }
    }
}
