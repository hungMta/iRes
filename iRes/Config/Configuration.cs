using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Title.Config {
    public class Configuration {

        public string GetProjectLinkDirectory()
        {
            string currentLink = Directory.GetCurrentDirectory();
            string binLink = Directory.GetParent(currentLink).FullName;
            string projectLink = Directory.GetParent(binLink).FullName;
            return projectLink;
        }

        public string DATA_SOURCE = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyGoiMonNhaHang;Integrated Security=True";
        //public string DATA_SOURCE = @"Data Source=DESKTOP-8IKVHJR;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

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
        public string PROC_GET_LIST_MONAN = "GetListMonAn";
        public string GET_LIST_MONAN_AND_IMAGE = @"select Cast('C:\Users\khanhlq\Documents\Visual Studio 2015\Projects\DevExpress\iRes\iRes\Resources\MonAn\'
                                                + HinhAnh as nvarchar(4000)) as [Hình ảnh],
                                                MaMon as [Mã món ăn], 
                                                TenMon as [Tên món ăn],
                                                MaNhom as [Mã nhóm],
                                                DonGia as [Đơn giá],
                                                SoLuongDangCo as [Số lương] from MonAn";

        // Proceduces of NhomMon
        public string PROC_GET_LIST_NHOMMON = "DanhSachNhomMon";

        // Tab Name
        public string TAB_NHAN_VIEN = "TabNhanVien";
        public string TAB_KHACH_HANG = "TabKhachHang";
        public string TAB_MON_AN = "TabMonAn";
        public string TAB_NHOM_MON = "TabNhomMon";

        // Resource Path
        public string NHANVIEN_IMAGE_RESOURCE = @"\Resources\NhanVien\";
    }
}
