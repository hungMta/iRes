using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title.DAO;
using Title.VO;

namespace Title.BUS {
    class Bus {
        public static DataTable GetListNhanVien() {
            return Dao.GetListNhanVien();
        }

        public static int InsertNhanVien(NhanVien nv) {
            return Dao.InsertNhanVien(nv);
        }

        public static int UpdateNhanVien(NhanVien nv) {
            return Dao.UpdateNhanVien(nv);
        }
        
        public static int DeleteNhanVien(NhanVien nv) {
            return Dao.DeleteNhanVien(nv);
        }

        public static DataTable GetListKhachHang()
        {
            return Dao.GetListKhachHang();
        }

        public static int InsertKhachHang(KhachHang kh)
        {
            return Dao.InsertKhachHang(kh);
        }

        public static int UpdateKhachHang(KhachHang kh)
        {
            return Dao.UpdateKhachHang(kh);
        }

        public static int  DeleteKhachHang(KhachHang kh)
        {
            return Dao.DeleteKhachHang(kh);
        }
        
        public static DataTable  GetListMonAn()
        {
            return Dao.GetListMonAn();
        }
    }
}
