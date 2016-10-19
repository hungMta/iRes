using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modal.Entities {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }

        public Employee() { }

        public Employee(string name, string birthday, string address, int salary, string position ) {
            this.Name = name;
            this.Birthday = birthday;
            this.Address = address;
            this.Salary = salary;
            this.Position = position;
        }
    }
}
