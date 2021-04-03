using System;
using System.Globalization;

namespace Seção_5___Aula_60___Exercício {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá dépósito inicial (s/n): ");
            string op = Console.ReadLine();
            if(op == "s" || op == "S") {
                Console.Write("Entre com o valor de depósito inicial: R$");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, titularConta, depositoInicial);
            } else {
                conta = new ContaBancaria(numConta, titularConta);
            }
            
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para DEPÓSITO: R$");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
             Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para SAQUE: R$");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
