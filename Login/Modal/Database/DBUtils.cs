using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using iRes.Configuration;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection(string databaseName)
        {
            Configuration config = new Configuration();
            string datasource = config.GetDataSource();
            string database = databaseName;
            string username = config.GetUsernameSqlServer();
            string password = config.GetPasswordSqlServer();
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}