using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Title.VO;
using Title.DAO;
using System.Data;

namespace iResTestCase {
    [TestClass]
    public class TestDataProviderMethod {
        [TestMethod]
        public void TestInsertNhanVien() {
            DateTime date = DateTime.Parse("2/16/2008");
            DateTime d = DateTime.ParseExact("11/11/1992", "dd/mm/yyyy", null);
            NhanVien nv = new NhanVien("NV0005", "Lê Kim Huệ", d, "Hà Tĩnh", 4000000, "Đầu bếp", "");
            int res = Dao.InsertNhanVien(nv);
            Assert.IsTrue(res == -1);
        }

        [TestMethod]
        public void TestGetListNhanVien() {
            DataTable dataTable = DataProvider.GetData("GetListNhanVien");
            Assert.IsTrue(dataTable.Rows.Count >= 6);
        }
    }
}
