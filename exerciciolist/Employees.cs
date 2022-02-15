using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exerciciolist {
    internal class Employees {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employees(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage) {
            Salary = Salary + (Salary * percentage / 100);
        }
        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
