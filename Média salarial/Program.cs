using System;
using System.Globalization;

namespace Seção_4___Aula_40___Exercício_2 {
    class Program {
        static void Main(string[] args) {
            double salarioMedio;

            Funcionarios func1, func2;
            func1 = new Funcionarios();
            func2 = new Funcionarios();

            Console.WriteLine("---- MÉDIA SALARIAL ---");
            Console.WriteLine("\n");

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.nomeFuncionario = Console.ReadLine();
            Console.Write("Salário: R$");
            func1.salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n");

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.nomeFuncionario = Console.ReadLine();
            Console.Write("Salário: R$");
            func2.salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (func1.salarioFuncionario + func2.salarioFuncionario) / 2.0;
            Console.WriteLine("\n");
            Console.WriteLine($"Salário médio = R${salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
