using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRes.Configuration
{
    public class Configuration
    {
        public Configuration() {
        }

        public string GetDataSource() {
            return @"DESKTOP-8IKVHJR"; //Thay doi cai nay oke con gi nua khong?

        }

        public string GetUsernameSqlServer() {
            return "abc";
        }

        public string GetPasswordSqlServer() {
            return "1234";
        }

        public String GetDatabaseName() {
            return "QuanLyNhaHang";
        }

        public String GetAccountTableName() {
            return "Account";
        }

        public String GetTablesTableName() {
            return "Tables";
        }

        public String GetEmployeeTableName() {
            return "Employee";
        }
    }
}
