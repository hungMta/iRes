using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Plugin.NhanVien.Enitity;
namespace Login.Plugin.NhanVien.Utils
{
    class Util
    {
        public Util()
        {

        }

        public string queryInsert(NhanVienEntity nhanVien)
        {
            string date = nhanVien.NgaySinh.Year.ToString() + @"/" 
                           + nhanVien.NgaySinh.Month.ToString() + @"/" 
                            + nhanVien.NgaySinh.Day.ToString();
            string query = "Insert into NhanVien values ('" + nhanVien.IdNV + "',N'" + nhanVien.TenNV + "','" 
                             +  nhanVien.GioiTinh +  "','" + date + "','" + nhanVien.QueQuan + "','" + nhanVien.Luong 
                             + "',N'" + nhanVien.ChucVu + "')";
            return query;
        }

        public string queryUpdate(NhanVienEntity nhanVien, string oldID)
        {
            string date = nhanVien.NgaySinh.Year.ToString() + @"/"
                           + nhanVien.NgaySinh.Month.ToString() + @"/"
                            + nhanVien.NgaySinh.Day.ToString();
 

            string query = @"Update NhanVien" +
                                @" set MaNV = '"+nhanVien.IdNV +
                                    @"', TenNV = N'" + nhanVien.TenNV +
                                    @" ', GioiTinh = N'" + nhanVien.GioiTinh +
                                    @" ', NgaySinh ='"+ date +
                                    @" ', QueQuan = N'" + nhanVien.QueQuan+
                                    @" ', Luong = "+ nhanVien.Luong+
                                    @", ChucVu = N'"+ nhanVien.ChucVu +
                                    @"' where MaNV ='" +oldID +"'";
            return query;
        }

        public string queryDelete(string MaNV)                      
        {
            string query = "delete NhanVien where MaNV='" + MaNV + "'";
            return query;
        }

        public string autoMaNV()
        {



            return "";
        }

    }
}
