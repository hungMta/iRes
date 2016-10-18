using Login.Modal.Entities;
using Login.Modal.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Test
{
    class TableApiTest
    {
        TableRepository tableRepo = new TableRepository();

        public void TestCreateTable()
        {
            int res = tableRepo.Create();
            Debug.Assert(res == 1);
        }

        public void TestUpdateTable()
        {
            Table table = new Table(1, "busy", 1231, 12737);
            int res = tableRepo.Update(table);
            Debug.Assert(res == 1);
        }

        public void TestReadTable()
        {
            List<Table> list = new List<Table>();
            list = tableRepo.Read();
            Debug.Assert(list[0].Id == 1);
            Debug.Assert(list[1].Id == 2);
            Debug.Assert(list[2].Id == 3);
            Debug.Assert(list[3].Id == 4);
        }
    }
}
