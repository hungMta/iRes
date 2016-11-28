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
    }
}
