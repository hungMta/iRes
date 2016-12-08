using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Title.Config {
    public class Configuration {

        public string GetProjectLinkDirectory() {
            string currentLink = Directory.GetCurrentDirectory();
            string binLink = Directory.GetParent(currentLink).FullName;
            string projectLink = Directory.GetParent(binLink).FullName;
            return projectLink;
        }

        public string CURRENT_NHAN_VIEN = "001";

        public string DATA_SOURCE = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";
        //public string DATA_SOURCE = @"Data Source=DESKTOP-8IKVHJR;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        //public string DATA_SOURCE = @"Data Source=DESKTOP-8IKVHJR;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";

        // Property of KhachHang
        public string KHACHHANG_MAKH = "MaKH";
        public string KHACHHANG_TENKH = "TenKH";
        public string KHACHHANG_DIACHI = "DiaChi";
        public string KHACHHANG_SDT = "SDT";
        public string KHACHHANG_EMAIL = "Email";
        public string KHACHHANG_SOLANAN = "SoLanAn";
        public string KHACHHANG_TONGTIEN = "TongTienDaChi";
        public string KHACHHANG_PHANLOAI = "PhanLoaiKH";

        // Property of MonAn
        public string MONAN_MAMON = "MaMon";
        public string MONAN_TENMON = "TenMon";
        public string MONAN_MANHOM = "MaNhom";
        public string MONAN_HINHANH = "HinhAnh";
        public string MONAN_SOLUONG = "SoLuong";
        public string MONAN_DONGIA = "DonGia";

        // Property of BanAn
        public string BANAN_MABAN = "MaBan";
        public string BANAN_TRANGTHAI = "TrangThai";
        public string BANAN_MAHOADON = "MaHD";
        public string BANAN_TRANGTHAI_DANG_DUNG = "Đang dùng";
        public string BANAN_TRANGTHAI_TRONG = "Trống";

        // Property of ChiTietHoaDon
        public string CHI_TIET_HOA_DON_MA_HOA_DON = "MaHD";
        public string CHI_TIET_HOA_DON_MA_MON = "MaMon";
        public string CHI_TIET_HOA_DON_SO_LUONG = "SoLuong";
        public string CHI_TIET_HOA_DON_GIA_MON = "GiaMon";
        public string CHI_TIET_HOA_DON_THANH_TIEN = "ThanhTien";
        public string CHI_TIET_HOA_DON_GHI_CHU = "GhiChu";

        // Property of HoaDon
        public string HOA_DON_MA_HOA_DON = "MaHD";
        public string HOA_DON_THOI_GIAN = "ThoiGianAn";
        public string HOA_DON_MA_KHACH_HANG = "MaKH";
        public string HOA_DON_MA_NHAN_VIEN = "MaNV";
        public string HOA_DON_THANH_TIEN = "ThanhTien";
        public string HOA_DON_CHIET_KHAU = "ChietKhau";
        public string HOA_DON_TONG_TIEN = "TongTien";
        public string PRINT_HOA_DON = "printed";

        // Property of NguyenLieu
        public string NGUYEN_LIEU_MA_NGUYEN_LIEU = "MaNL";
        public string NGUYEN_LIEU_TEN_NGUYEN_LIEU= "TenNL";
        public string NGUYEN_LIEU_DON_VI = "DonVi";
        public string NGUYEN_LIEU_DON_GIA = "DonGia";

        // Property of PhieuNhap
        public string PHIEU_NHAP_MA_PHIEU_NHAP = "MaPN";
        public string PHIEU_NHAP_TONG_TIEN = "TongTien";
        public string PHIEU_NHAP_THOI_GIAN = "ThoiGianNhap";
        public string PHIEU_NHAP_MA_NHAN_VIEN = "MaNV";

        // Property of ChiTietPhieuNhap
        public string CHI_TIET_PHIEU_NHAP_MA_PHIEU_NHAP = "MaPN";
        public string CHI_TIET_PHIEU_NHAP_MA_NGUYEN_LIEU = "MaNL";
        public string CHI_TIET_PHIEU_NHAP_DON_GIA = "DonGia";
        public string CHI_TIET_PHIEU_NHAP_SO_LUONG = "SoLuong";
        public string CHI_TIET_PHIEU_NHAP_THANH_TIEN = "ThanhTien";
        public string CHI_TIET_PHIEU_NHAP_GHI_CHU = "GhiChu";
        
        // Proceduces of NhanVien
        public string PROC_GET_LIST_NHANVIEN = "DanhSachNhanVien";
        public string PROC_INSERT_NHANVIEN = "ThemNhanVien";
        public string PROC_DELETE_NHANVIEN = "XoaNhanVien";
        public string PROC_UPDATE_NHANVIEN = "SuaNhanVien";

        // Proceduces of KhachHang
        public string PROC_GET_LIST_KHACHHANG = "DanhSachKhachHang";
        public string PROC_UPDATE_KHACHHANG = "SuaKhachHang";
        public string PROC_DELETE_KHACHHANG = "XoaKhachHang";
        public string PROC_INSERT_KHACHHANG  = "ThemKhachHang";

        // Proceduces of MonAn
        public string PROC_GET_LIST_MONAN = "DanhSachMonAn";
        public string PROC_GET_LIST_MONAN_BY_NHOM_MON = "DanhSachMonAnByNhomMon";
        public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\khanhlq\Documents\Visual Studio 2015\Projects\DevExpress\iRes\iRes\Resources\MonAn\'
                                                + HinhAnh as nvarchar(4000)) as [Hình ảnh],
                                                MaMon as [Mã món ăn], 
                                                TenMon as [Tên món ăn],
                                                MaNhom as [Mã nhóm],
                                                DonGia as [Đơn giá],
                                                SoLuongDangCo as [Số lương] from MonAn";

        //public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\tran\Documents\Visual Studio 2012\Projects\iRes\iRes\Resources\MonAn\'
        //                                        + HinhAnh as nvarchar(4000)) as [Hình ảnh],
        //                                        MaMon as [Mã món ăn], 
        //                                        TenMon as [Tên món ăn],
        //                                        MaNhom as [Mã nhóm],
        //                                        DonGia as [Đơn giá],
        //                                        SoLuongDangCo as [Số lương] from MonAn";

        // Proceduces of NhomMon
        public string PROC_GET_LIST_NHOMMON = "DanhSachNhomMon";

        // Proceduces of BanAn
        public string PROC_GET_LIST_BANAN = "DanhSachBanAn";
        public string PROC_UPDATE_BAN_AN = "SuaBanAn";
        public string PROC_SET_BAN_AN_TRONG = "SuaBanAnThanhTrong";

        // Procedures of ChiTietHoaDon
        public string PROC_GET_LIST_CHITIET_HOADON = "DanhSachChiTietHoaDon";
        public string PROC_INSET_CHITIET_HOADON = "ThemChiTietHoaDon";

        // Procedures of HoaDon
        public string PROC_INSERT_HOADON = "ThemHoaDon";
        public string PROC_GET_LAST_HOADON = "GetLastHoaDon";
        public string PROC_HOA_DON_GET_INFO_KHACH_HANG = "ThongTinKhachHangTheoMaHoaDon";
        public string PROC_INFO_HOA_DON = "XemThongTinHoaDonTheoMa";
        public string PROC_EDIT_HOADON = "SuaHoaDon";
        public string PROC_GET_INFO_HOADON = "XemThongTinHoaDon";

        // Procedures of PhieuNhap
        public string PROC_GET_LIST_PHIEU_NHAP = "DanhSachPhieuNhap";
        public string PROC_GET_INSERT_PHIEU_NHAP = "ThemPhieuNhap";

        // Procedures of NguyenLieu
        public string PROC_GET_LIST_NGUYEN_LIEU = "DanhSachNguyenLieu";

        // Procedures of ChiTietPhieuNhap
        public string PROC_INSERT_CHI_TIET_PHIEU_NHAP = "ThemChiTietPhieuNhap";
        public string PROC_INSERT_GET_CHI_TIET_PHIEU_NHAP_BY_MA_PHIEU_NHAP = "GetChiTietPhieuNhapByMaPhieuNhap";

        // Tab Name
        public string TAB_NHAN_VIEN = "TabNhanVien";
        public string TAB_KHACH_HANG = "TabKhachHang";
        public string TAB_MON_AN = "TabMonAn";
        public string TAB_NHOM_MON = "TabNhomMon";
        public string TAB_GOI_MON_THEO_BAN = "TabGoiMonTheoBan";
        public string TAB_NHAP_HANG = "TabNhapHang";

        // Resource Path
        public string NHANVIEN_IMAGE_RESOURCE = @"\Resources\NhanVien\";
        public string BANAN_IMAGE_RESOURCE = @"\Resources\BanAn\";

    }
}
