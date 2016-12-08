using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class ChiTietPhieuNhap {
        public ChiTietPhieuNhap() { }
        public ChiTietPhieuNhap(string maPhieuNhap, string maNguyenLieu, int donGia, int soLuong, int thanhTien, string ghiChu) {
            this.MaPhieuNhap = maPhieuNhap;
            this.MaNguyenLieu = maNguyenLieu;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
            this.GhiChu = ghiChu;
        }
        public string MaPhieuNhap { get; set; }
        public string MaNguyenLieu { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        public string GhiChu { get; set; }
    }
}
