using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title.Config;
using Title.VO;

namespace Title.DAO {
    public class Dao {
        public static Configuration config = new Configuration();

        public static DataTable GetListNhanVien() {
            return DataProvider.GetData(config.PROC_GET_LIST_NHANVIEN);
        }

        public static int InsertNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.DiaChi),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@Luong", nv.Luong),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@MatKhau", nv.MatKhau),
                new SqlParameter("@HinhAnh", nv.HinhAnh),
                new SqlParameter("@TrangThai", nv.TinhTrangLamViec)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHANVIEN, para);
        }

        public static int UpdateNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@Luong", nv.Luong),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@MatKhau", nv.MatKhau),
                new SqlParameter("@HinhAnh", nv.HinhAnh),
                new SqlParameter("@TrangThai", nv.TinhTrangLamViec)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NHANVIEN, para);
        }

        public static int DeleteNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNV", nv.MaNV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHANVIEN, para);
        }

        public static DataTable GetListKhachHang()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_KHACHHANG);
        }

        public static int InsertKhachHang(KhachHang kh)
        {
            SqlParameter[] para = new SqlParameter[]
              {
                  new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),
                  new SqlParameter("@"+config.KHACHHANG_TENKH, kh.TenKH),
                  new SqlParameter("@"+config.KHACHHANG_DIACHI, kh.DiaChi),
                  new SqlParameter("@"+config.KHACHHANG_SDT, kh.SDT),
                  new SqlParameter("@"+config.KHACHHANG_EMAIL, kh.Email),
                  new SqlParameter("@"+config.KHACHHANG_SOLANAN, kh.SoLanAn),
                  new SqlParameter("@"+config.KHACHHANG_TONGTIEN, kh.TongTien),
                  new SqlParameter("@"+config.KHACHHANG_PHANLOAI, kh.PhanLoai)


              };
               return DataProvider.ExecuteNonQuery(config.PROC_INSERT_KHACHHANG, para);
        }

        public static int UpdateKhachHang(KhachHang kh)
        {
            SqlParameter[] para = new SqlParameter[]
              {
                  new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),
                  new SqlParameter("@"+config.KHACHHANG_TENKH, kh.TenKH),
                  new SqlParameter("@"+config.KHACHHANG_DIACHI, kh.DiaChi),
                  new SqlParameter("@"+config.KHACHHANG_SDT, kh.SDT),
                  new SqlParameter("@"+config.KHACHHANG_EMAIL, kh.Email),
                  new SqlParameter("@"+config.KHACHHANG_SOLANAN, kh.SoLanAn),
                  new SqlParameter("@"+config.KHACHHANG_TONGTIEN, kh.TongTien),
                  new SqlParameter("@"+config.KHACHHANG_PHANLOAI, kh.PhanLoai)
              };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_KHACHHANG, para);
        }

        public static int DeleteKhachHang(KhachHang kh)
        {
            SqlParameter[] para = new SqlParameter[]
              {
                  new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),            
              };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_KHACHHANG, para);
        }

        public static DataTable GetListMonAn()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_MONAN);
        }

    }
}
