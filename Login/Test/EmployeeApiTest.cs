using Login.Modal.Entities;
using Login.Modal.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Test {
    class EmployeeApiTest {
        EmployeeRepository employeeRepo = new EmployeeRepository();

        public void TestCreateEmployee() {
            Employee employee = new Employee("John", "1990-08-09", "Canada", 15000000, "Manager");
            int res = employeeRepo.Create(employee);
            Debug.Assert(res == 1);
        }
    }
}
