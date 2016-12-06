using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class ChiTietHoaDon {
        public ChiTietHoaDon() { }
        public ChiTietHoaDon(string maHoaDon, string maMon, int soLuong, int giaMon, int thanhTien, string ghiChu) {
            this.MaHoaDon = maHoaDon;
            this.MaMon = maMon;
            this.SoLuong = soLuong;
            this.GiaMon = giaMon;
            this.ThanhTien = thanhTien;
            this.GhiChu = ghiChu;
        }
        public ChiTietHoaDon(string maHoaDon, string maMon, int soLuong) {
            this.MaHoaDon = maHoaDon;
            this.MaMon = maMon;
            this.SoLuong = soLuong;
        }
        public string MaHoaDon { get; set; }
        public string MaMon { get; set; }
        public int SoLuong { get; set; }
        public int GiaMon { get; set; }
        public int ThanhTien { get; set; }
        public string GhiChu { get; set; }
    }
}
