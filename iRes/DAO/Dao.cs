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
            SqlParameter[] para = new SqlParameter[] {
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
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHANVIEN, para);
        }

        public static int UpdateNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[] {
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
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@MaNV", nv.MaNV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHANVIEN, para);
        }

        public static DataTable GetListKhachHang() {
            return DataProvider.GetData(config.PROC_GET_LIST_KHACHHANG);
        }

        public static int InsertKhachHang(KhachHang kh) {
            SqlParameter[] para = new SqlParameter[] {
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

        public static int UpdateKhachHang(KhachHang kh) {
            SqlParameter[] para = new SqlParameter[] {
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

        public static int DeleteKhachHang(KhachHang kh) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.KHACHHANG_MAKH, kh.MaKH),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_KHACHHANG, para);
        }

        public static DataTable GetListMonAn() {
            return DataProvider.GetData(config.PROC_GET_LIST_MONAN);
        }

        public static DataTable GetMaMonNext()
        {
            return DataProvider.GetData(config.PROC_GET_MA_MON_NEXT);
        }

        public static DataTable GetListMonAnByNhomMon(string maNhom) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.MONAN_MANHOM, maNhom),            
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_LIST_MONAN_BY_NHOM_MON, para);
        }

        public static DataTable GetMonAnByMaMon(string maMon) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.MONAN_MAMON, maMon),            
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_MONAN_BY_MA_MON, para);
        }

        public static DataTable GetListNhomMon() {
            return DataProvider.GetData(config.PROC_GET_LIST_NHOMMON);
        }

        public static DataTable GetListBanAn() {
            return DataProvider.GetData(config.PROC_GET_LIST_BANAN);
        }

        public static int UpdateBanAn(BanAn banAn) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BANAN_MABAN, banAn.MaBan),            
                new SqlParameter("@"+config.BANAN_TRANGTHAI, banAn.TrangThai),            
                new SqlParameter("@"+config.BANAN_MAHOADON, banAn.MaHoaDon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_BAN_AN, para);
        }

        public static int SetBanAnTrong(BanAn banAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BANAN_MABAN, banAn.MaBan),                    
            };
            return DataProvider.ExecuteNonQuery(config.PROC_SET_BAN_AN_TRONG, para);
        }

        public static DataTable GetListChiTietHoaDon(BanAn banAn) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BANAN_MAHOADON, banAn.MaHoaDon),            
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_LIST_CHITIET_HOADON, para);
        }

        public static int InsertChiTietHoaDon(ChiTietHoaDon chiTietHoaDon) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_HOA_DON, chiTietHoaDon.MaHoaDon),            
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_MON, chiTietHoaDon.MaMon),            
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_SO_LUONG, chiTietHoaDon.SoLuong)            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSET_CHITIET_HOADON, para);
        }

        public static int InsertHoaDon(HoaDon hoaDon) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_THOI_GIAN, hoaDon.ThoiGian),            
                new SqlParameter("@"+config.HOA_DON_MA_KHACH_HANG, hoaDon.MaKH),            
                new SqlParameter("@"+config.HOA_DON_MA_NHAN_VIEN, hoaDon.MaNV),            
                new SqlParameter("@"+config.HOA_DON_CHIET_KHAU, hoaDon.ChietKhau),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_HOADON, para);
        }

        public static DataTable GetInfoKhachHangQuaMaHoaDon(BanAn banAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON, banAn.MaHoaDon),                       
            };
            return DataProvider.GetDataByParameter(config.PROC_HOA_DON_GET_INFO_KHACH_HANG, para);
        }

        public static DataTable GetLastHoaDon() {
            return DataProvider.GetData(config.PROC_GET_LAST_HOADON);
        }

        public static DataTable GetInfoHoaDon(string maHoaDon)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON,maHoaDon),
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_INFO_HOADON, para);
        }

        public static int EditHoaDon(HoaDon hoaDon)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON,hoaDon.MaHD),
                new SqlParameter("@"+config.HOA_DON_THOI_GIAN, hoaDon.ThoiGian),            
                new SqlParameter("@"+config.HOA_DON_MA_KHACH_HANG, hoaDon.MaKH),            
                new SqlParameter("@"+config.HOA_DON_MA_NHAN_VIEN, hoaDon.MaNV),            
                new SqlParameter("@"+config.HOA_DON_CHIET_KHAU, hoaDon.ChietKhau),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_EDIT_HOADON,para);
        }

        public static DataTable GetInfoHoaDonTheoBanAn(BanAn banAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOA_DON_MA_HOA_DON, banAn.MaHoaDon),                       
            };
            return DataProvider.GetDataByParameter(config.PROC_INFO_HOA_DON, para);
        }

        public static DataTable GetListEarnMoneyByDay()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_SUM_MONEY_BY_DAY);
        }

        public static DataTable GetListPhieuNhap() {
            return DataProvider.GetData(config.PROC_GET_LIST_PHIEU_NHAP);
        }

        public static int InsertPhieuNhap(PhieuNhap phieuNhap)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.PHIEU_NHAP_THOI_GIAN, phieuNhap.ThoiGian),            
                new SqlParameter("@"+config.PHIEU_NHAP_TONG_TIEN, phieuNhap.TongTien),            
                new SqlParameter("@"+config.PHIEU_NHAP_MA_NHAN_VIEN, phieuNhap.MaNhanVien)           
            };
            return DataProvider.ExecuteNonQuery(config.PROC_GET_INSERT_PHIEU_NHAP, para);
        }

        public static DataTable GetLastPhieuNhap() 
        {
            return DataProvider.GetData(config.PROC_GET_LAST_PHIEU_NHAP);
        }

        public static DataTable GetListNguyenLieu() {
            return DataProvider.GetData(config.PROC_GET_LIST_NGUYEN_LIEU);
        }

        public static DataTable GetListChiTietPhieuNhapByMaPhieuNhap(string maPhieuNhap) {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.PHIEU_NHAP_MA_PHIEU_NHAP, maPhieuNhap)           
            };
            return DataProvider.GetDataByParameter(config.PROC_INSERT_GET_CHI_TIET_PHIEU_NHAP_BY_MA_PHIEU_NHAP, para);
        }

        public static int InsertChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.CHI_TIET_PHIEU_NHAP_MA_PHIEU_NHAP, chiTietPhieuNhap.MaPhieuNhap),            
                new SqlParameter("@"+config.CHI_TIET_PHIEU_NHAP_MA_NGUYEN_LIEU, chiTietPhieuNhap.MaNguyenLieu),            
                new SqlParameter("@"+config.CHI_TIET_PHIEU_NHAP_SO_LUONG, chiTietPhieuNhap.SoLuong),            
                new SqlParameter("@"+config.CHI_TIET_PHIEU_NHAP_DON_GIA, chiTietPhieuNhap.DonGia),            
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_CHI_TIET_PHIEU_NHAP, para);
        }

        internal static int InsertMonAn(MonAn monAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.MONAN_TENMON,monAn.TenMon),
               new SqlParameter("@"+config.MONAN_MANHOM,monAn.MaNhom),
              new SqlParameter("@"+config.MONAN_DONGIA,monAn.DonGia),
              new SqlParameter("@"+config.MONAN_SOLUONG,monAn.SoLuong),
              new SqlParameter("@"+config.MONAN_HINHANH,monAn.hinhanh),
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_MON_AN, para);
        }

        internal static int UpdateMonAN(MonAn monAn)
        {
            SqlParameter[] para = new SqlParameter[] {
                
                new SqlParameter("@"+config.MONAN_MAMON,monAn.MaMon),
                new SqlParameter("@"+config.MONAN_TENMON,monAn.TenMon),
               new SqlParameter("@"+config.MONAN_MANHOM,monAn.MaNhom),
              new SqlParameter("@"+config.MONAN_DONGIA,monAn.DonGia),
              new SqlParameter("@"+config.MONAN_SOLUONG,monAn.SoLuong),
              new SqlParameter("@"+config.MONAN_HINHANH,monAn.hinhanh),
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_MON_AN, para);
        }

        internal static int DeleteMonAn(string maMon)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.MONAN_MAMON,maMon), 
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_MON_AN, para);
        }

        internal static int DeleteNhomMon(NhomMon nhomMon)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@"+config.NHOMMON_MANHOM, nhomMon.MaNhom)
               
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHOMMON, para);
        }

        internal static DataTable GetIDNhomMon()
        {
            return DataProvider.GetData(config.GET_ID_MANHOM);
        }

        internal static int InsertNhomMon(NhomMon nhomMon)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNhom",nhomMon.MaNhom),
                new SqlParameter("@TenNhom",nhomMon.TenNhom),
                new SqlParameter("@TongSoMon",nhomMon.TongSoMon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHOMMON, para);
        }

        internal static int UpdateNhomMon(NhomMon nhomMon)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNhom",nhomMon.MaNhom),
                new SqlParameter("@TenNhom",nhomMon.TenNhom),
                new SqlParameter("@TongSoMon",nhomMon.TongSoMon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NHOMMON, para);
        }

        internal static int DeleteNguyenLieu(NguyenLieu nguyenLieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNL",nguyenLieu.MaNguyenLieu)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NGUYEN_LIEU, para);
        }

        internal static int InsertNguyenLieu(NguyenLieu nguyenLieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNL",nguyenLieu.MaNguyenLieu),
                new SqlParameter("@TenNL",nguyenLieu.TenNguyenLieu),
                new SqlParameter("@DonVi",nguyenLieu.DonVi),
                new SqlParameter("@DonGia",nguyenLieu.DonGia)             
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NGUYEN_LIEU, para);
        }

        internal static int UpdateNguyenLieu(NguyenLieu nguyenLieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNL",nguyenLieu.MaNguyenLieu),
                new SqlParameter("@TenNL",nguyenLieu.TenNguyenLieu),
                new SqlParameter("@DonVi",nguyenLieu.DonVi),
                new SqlParameter("@DonGia",nguyenLieu.DonGia)             
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NGUYEN_LIEU, para);
        }

        internal static DataTable GetIDNguyenLieu()
        {
            return DataProvider.GetData(config.PROC_GET_MA_NGUYEN_LIEU_NEXT);
        }

        internal static int EditChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_HOA_DON,chiTietHoaDon.MaHoaDon),
                new SqlParameter ("@"+config.CHI_TIET_HOA_DON_MA_MON,chiTietHoaDon.MaMon),
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_SO_LUONG,chiTietHoaDon.SoLuong)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_EDIT_CHITIET_HOADON, para);
        }

        internal static int DeleteChiTietHD(ChiTietHoaDon chiTietHoaDon)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_HOA_DON,chiTietHoaDon.MaHoaDon),
                new SqlParameter("@"+config.CHI_TIET_HOA_DON_MA_MON,chiTietHoaDon.MaMon)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_CHITIET_HOADON, para);
        }
    }
}
