using iRes.Configuration;
using Login.Modal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modal.Repository {
    class TableRepository {

        public Configuration config = new Configuration();

        public int Create() {
            int res = -1;
            try {
                string query = "INSERT INTO Tables (Status, OrderId, BookId) VALUES('free', null, null)";
                res = Database.Database.Update(query, config.GetTablesTableName());
            } catch (Exception e) {
                Console.Write(e.Message);
            }
            return res;
        }

        public List<Table> Read() {
            List<Table> listTable = new List<Table>();
            DataTable dataTable = Database.Database.Read(config.GetTablesTableName());
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Table table = new Table();
                try {
                    table.Id = (int)dataTable.Rows[i][0];
                    table.Status = (string)dataTable.Rows[i][1];
                    try {
                        table.OrderId = (int)dataTable.Rows[i][2];
                    } catch { }
                    try {
                        table.BookId = (int)dataTable.Rows[i][3];
                    } catch { }
                    listTable.Add(table);
                } catch {
                    Console.WriteLine("[ERROR] - The data in Table Database is not valid");
                }
            }
            return listTable;
        }

        public int Update(Table table) {
            int res = -1;
            try {
                string query = @"UPDATE Tables
                                 SET Status = '" + table.Status
                                 + @"', OrderId = " + table.OrderId
                                 + @", BookId = " + table.BookId
                                 + @"WHERE Id = " + table.Id;
                res = Database.Database.Update(query, config.GetTablesTableName());
            } catch { }
            return res;
        }
    }
}
