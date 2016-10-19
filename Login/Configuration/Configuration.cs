using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRes.Configuration
{
    class Configuration
    {
        public Configuration()
        {

        }

        public String GetDatabaseName()
        {
            return "iRes";
        }

        public String GetAccountTableName()
        {
            return "Account";
        }

        public String GetTablesTableName()
        {
            return "Tables";
        }

        public String GetEmployeeTableName()
        {
            return "Employee";
        }
    }
}
