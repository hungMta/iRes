using iRes.Configuration;
using Login.Modal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modal.Repository
{
    class TableRepository
    {
        public List<Table> ListTable { get; set; }

        public Configuration config = new Configuration();
        
        public int CreateTable()
        {
            int res = -1;
            try
            {
                string query = "INSERT INTO Tables (Status, OrderId, BookId) VALUES('free', null, null)";
                res = Database.Database.Update(query, config.GetTablesTableName());
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return res;
        }


    }
}
