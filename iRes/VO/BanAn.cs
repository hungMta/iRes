using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO {
    public class BanAn {
        public BanAn() { }

        public BanAn(string maBan, string trangThai, string maHoaDon) {
            this.MaBan = maBan;
            this.TrangThai = trangThai;
            this.MaHoaDon = maHoaDon;
        }

        public string MaBan { get; set; }
        public string TrangThai { get; set; }
        public string MaHoaDon{ get; set; }
    }
}
