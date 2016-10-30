using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iRes;
using Login.Modal.Repository;
using Login.Modal.Entities;
using System.Collections.Generic;

namespace iResTestCase {
    [TestClass]
    public class TestEmployeeRepositoryApi {
        [TestMethod]
        public void TestReadAllEmployeeFromDatabase() {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            List < Employee > listEmployee = employeeRepo.Read();
            Assert.IsTrue(listEmployee.Count > 4);
        }
    }
}
