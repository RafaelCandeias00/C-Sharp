using Seção_9___Aula_119___Exercício.Entities.Enums;
using Seção_9___Aula_119___Exercício.Entities;
using System.Globalization;
using System;

namespace Seção_9___Aula_119___Exercício {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter department's: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Department dept = new Department(deptName);
            Worker worker = new Worker(Name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int numContracts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numContracts; i++) {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: R${worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
