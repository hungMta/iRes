using iRes.Configuration;
using Login.Modal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modal.Repository {
    class EmployeeRepository {
        public Configuration config = new Configuration();

        public int Create(Employee employee) {
            int res = -1;
            try {
                string query = @"INSERT INTO Employee(Name, Birthday, Address, Salary, Position)
                                 VALUES('" + employee.Name +
                                 @"', '" + employee.Birthday + 
                                 @"', '" + employee.Address +
                                 @"', " + employee.Salary +
                                 @", '" + employee.Position +
                                 @"')";
                res = Database.Database.Update(query, config.GetEmployeeTableName());
            } catch (Exception e) {
                Console.Write(e.Message);
            }
            return res;
        }

        public int Read() {
            return -1;
        }
    }
}
