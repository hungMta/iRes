using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Login.Database;
using System.Data;

namespace iResTestCase {
    [TestClass]
    public class TestDatabase {
        [TestMethod]
        public void TestReadDatabase() {
            DataSet dataset = Database.Read("Employee");
            Assert.IsTrue(dataset.Tables[0].Rows.Count >= 5);
            dataset = Database.Read("Tables");
            Assert.IsTrue(dataset.Tables[0].Rows.Count >= 6);
        }

        [TestMethod]
        public void TestInsertDatabase() {
            string strQueryInsert = @"Insert into Tables(Status, OrderId, BookId)" +
                                    @"values('free', 0, 1)";
            int res = Database.Update(strQueryInsert);
            Assert.IsTrue(res == 1);
        }

        [TestMethod]
        public void TestDeleteDatabase() {
            string strQueryDelete = @"delete Tables " + 
                                    @"where Id = 10";
            int res = Database.Delete(strQueryDelete);
            Assert.IsTrue(res == -1);
        }

        [TestMethod]
        public void TestDeleteDatabaseWhereIdEqual9() {
            string strQueryDelete = @"delete Tables " + 
                                    @"where Id = 9";
            int res = Database.Delete(strQueryDelete);
            Assert.IsTrue(res == 1);
        }
    }
}
