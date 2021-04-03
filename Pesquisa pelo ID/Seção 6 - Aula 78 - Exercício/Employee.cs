using System;
using System.Globalization; 

namespace Seção_6___Aula_78___Exercício {
    class Employee {
        public int ID;
        public string Name;
        public double Salary;

        public Employee(int id, string name) {
            ID = id;
            Name = name;        }

        public Employee(int id, string name, double salary) : this (id, name) {
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            Salary += (percentage / 100 * Salary);
        }

        public override string ToString() {
            return $"{ID}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
