using System;
using System.Globalization;
using System.Collections.Generic;

namespace Seção_6___Aula_78___Exercício {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numRegister = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numRegister; i++) {
                Console.WriteLine();
                Console.WriteLine($"Emplyoee #{i}");
                Console.Write("ID: ");
                int idEmplyoee = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameEmplyoee = Console.ReadLine();
                Console.Write("Salary: ");
                double salaryEmplyoee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(idEmplyoee, nameEmplyoee, salaryEmplyoee));
            }

            Console.WriteLine();

            Console.Write("Enter the employee ID that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee id = list.Find(x => x.ID == searchID);

            if (id != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                id.increaseSalary(percentage);
            } else {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
