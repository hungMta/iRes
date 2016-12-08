using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class NguyenLieu {
        public NguyenLieu() { }
        public NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string donVi, int donGia) {
            this.MaNguyenLieu = maNguyenLieu;
            this.TenNguyenLieu = tenNguyenLieu;
            this.DonVi = donVi;
            this.DonGia = donGia;
        }

        public string MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonVi { get; set; }
        public int DonGia { get; set; }
    }
}
