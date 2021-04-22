using System;
using System.Globalization;
using System.Collections.Generic;
using Seção_14___Aula_199___Exercício.Entities;
using Seção_14___Aula_199___Exercício.Services;

namespace Seção_14___Aula_199___Exercício {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, valueContract);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberInstallments);

            Console.WriteLine();

            Console.WriteLine("Installments:");
            foreach(Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
}
