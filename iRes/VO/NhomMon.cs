using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.VO
{
    public class NhomMon
    {

        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public int TongSoMon { get; set; }
        public NhomMon() { }
        public NhomMon(string MaNhom, string TenNhom, int TongSoMon)
        {
            this.MaNhom = MaNhom;
            this.TenNhom = TenNhom;
            this.TongSoMon = TongSoMon;
        }
    }
}
