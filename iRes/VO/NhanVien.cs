using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class NhanVien {
        public NhanVien () {
        }

        public NhanVien (string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string sDT, string diaChi, int luong, string chucVu, string MatKhau, string hinhAnh, string tinhTrangLamViec) {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Luong = luong;
            this.ChucVu = chucVu;
            this.MatKhau = MatKhau;
            this.HinhAnh = hinhAnh;
            this.TinhTrangLamViec = tinhTrangLamViec;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi{ get; set; }
        public int Luong { get; set; }
        public string ChucVu { get; set; }
        public string MatKhau { get; set; }
        public string HinhAnh { get; set; }
        public string TinhTrangLamViec { get; set; }
    }
}
