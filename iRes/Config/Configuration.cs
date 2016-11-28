using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Title.Config {
    public class Configuration {

        public string DATA_SOURCE = @"Data Source=.\SQLEXPRESS;Initial Catalog=iResDatabase;Integrated Security=True";

        public string PROC_GET_LIST_NHANVIEN = "GetListNhanVien";

        public string PROC_INSERT_NHANVIEN = "InsertNhanVien";

    }
}
