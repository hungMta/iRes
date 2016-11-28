using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title.VO;

namespace Title.DAO {
    public class Dao {
        public static DataTable GetListNhanVien() {
            return DataProvider.GetData("GetListNhanVien");
        }

        public static int InsertNhanVien(NhanVien nv) {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@QueQuan",nv.QueQuan),
                new SqlParameter("@Luong",nv.Luong),
                new SqlParameter("@ChucVu",nv.ChucVu),
                new SqlParameter("@MatKhau",nv.MatKhau)
            };
            return DataProvider.ExecuteNonQuery("ThemNhanVien", para);
        }
    }
}
