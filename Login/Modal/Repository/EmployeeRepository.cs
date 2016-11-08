using iRes.Configuration;
using Login.Modal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modal.Repository {
    public class EmployeeRepository {
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

        public List<Employee> Read() {
            List<Employee> listEmployee = new List<Employee>();
            DataTable dataTable = Database.Database.Read(config.GetEmployeeTableName());
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Employee employee = new Employee();
                try {
                    employee.Id = (int)dataTable.Rows[i][0];
                    employee.Name = (string)dataTable.Rows[i][1];
                    try {
                        DateTime date = (DateTime)dataTable.Rows[i][2];
                        employee.Birthday = date.ToShortDateString();
                    } catch {
                        employee.Birthday = "";
                    }
                    employee.Address = dataTable.Rows[i][3].ToString();
                    try {
                        employee.Salary = (int)dataTable.Rows[i][4];
                    } catch {
                        employee.Salary = 0;
                    }
                    employee.Position = dataTable.Rows[i][5].ToString();
                    listEmployee.Add(employee);
                } catch {
                    Console.WriteLine("[ERROR] - The data in Table Database is not valid");
                }
            }
            return listEmployee;
        }

        public int Update(Employee employee) {
            int res = -1;
            try {
                string query = @"UPDATE " + config.GetEmployeeTableName() 
                                 + " SET Name = N'" + employee.Name
                                 + @"', Birthday = '" + employee.Birthday
                                 + @"', Address = N'" + employee.Address
                                 + @"', Salary = " + employee.Salary
                                 + @", Position = N'" + employee.Position
                                 + @"' WHERE Id = " + employee.Id;
                res = Database.Database.Update(query, config.GetEmployeeTableName());
            } catch { }
            return res;
        }

        public Employee Get(int id) {
            Employee employee = new Employee();
            string query = @"Select * from" + config.GetEmployeeTableName()
                            + "where Id = " + id.ToString();
            employee.Id = 1;
            return employee;
        }
    }
}
