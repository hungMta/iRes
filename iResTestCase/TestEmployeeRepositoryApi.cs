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
            Assert.IsTrue(listEmployee[0].Id == 1);
        }

        [TestMethod]
        public void TestUpdateEmployeeDatabase() {
            Employee employee = new Employee();
            employee.Id = 3;
            employee.Name = "Lê Năm";
            employee.Address = "TP. Hồ Chí Minh";
            employee.Position = "Lễ Tân";
            EmployeeRepository employeeRepo = new EmployeeRepository();
            int res = employeeRepo.Update(employee);
            Assert.IsTrue(res == 1);
        }

        [TestMethod]
        public void TestGetEmployeeDatabase() {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            Employee employee = employeeRepo.Get(1);
            Assert.IsTrue(employee.Name == "Lê Hoàng");
        }
    }
}
