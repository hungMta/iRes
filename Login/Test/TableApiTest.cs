using Login.Modal.Repository;
using System;
using System.Collections.Generic;
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
            int res = tableRepo.CreateTable();
            Console.Write(res);
        }
    }
}
