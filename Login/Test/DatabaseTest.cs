using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Test
{
    class DatabaseTest
    {
        public void TestConnect()
        {
            int resConnect = Database.Database.Connect("Account");
            Console.WriteLine(resConnect);
            Debug.Assert(resConnect == 1);
        }

        public void TestReadAccountTable()
        {
            int resConnect = Database.Database.Connect("Account");
            DataTable dataTable = Database.Database.Read("Account");
            Console.WriteLine(dataTable.Rows.Count);
        }

        public void TestReadTablesTable()
        {
            DataTable dataTable = Database.Database.Read("Tables");
            Console.WriteLine(dataTable.Rows.Count);
            Debug.Assert(dataTable.Rows.Count > 3);
        }

        public void TestUpdateTablesTable()
        {
            string query = "INSERT INTO Tables (Status, OrderId, BookId) VALUES('busy', 1, null)";
            int res = Database.Database.Update(query, "Tables");
            Debug.Assert(res == 1);
        }


    }
}
