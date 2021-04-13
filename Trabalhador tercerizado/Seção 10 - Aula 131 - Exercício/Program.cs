using System;
using System.Globalization;
using System.Collections.Generic;
using Seção_10___Aula_131___Exercício.Entities;

namespace Seção_10___Aula_131___Exercício {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data");
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double vph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'y'||op == 'Y') {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hours, vph, addCharge));
                } else {
                    list.Add(new Employee(name, hours, vph));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list) {
                Console.WriteLine($"{emp.Name}, ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
