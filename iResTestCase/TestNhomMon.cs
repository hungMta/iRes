using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Login.Database;

namespace iResTestCase {
    [TestClass]
    public class TestNhomMon {
        [TestMethod]
        public void TestReadTableNhomMon() {
            string strQueryReadTable = "NhomMon";
            DataSet dataset = new DataSet();
            dataset = Database.Read(strQueryReadTable);
            Assert.IsTrue(dataset.Tables[0].Rows.Count > 4);
        }
        
        [TestMethod]
        public void TestInsertTableNhomMon() {
            string strQueryInsert =  @"insert into NhomMon(MaNhom, TenNhom, SoLuongMon)" +
                                     @" values('" + "N07" + 
                                     @" ', N'" + "Cơm Rang" +
                                     @" ', " + "15" +
                                     @" )";
            int res = Database.Update(strQueryInsert);
            Assert.IsTrue(res == 1);
        }
    }
}
