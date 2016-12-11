using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO
{
    public class MonAn
    {
        public MonAn() { }

        public MonAn(string tenMon, string maNhom, decimal donGia, int soLuong, string hinhanh) {
            this.TenMon = tenMon;
            this.MaNhom = maNhom;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.hinhanh = hinhanh;
        }

        public MonAn(string maMon, string tenMon, string maNhom, decimal donGia, int soLuong, string hinhanh) {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.MaNhom = maNhom;
            this.TenMon = tenMon;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.hinhanh = hinhanh;
        }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string MaNhom { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string hinhanh { get; set; }
    }
}
