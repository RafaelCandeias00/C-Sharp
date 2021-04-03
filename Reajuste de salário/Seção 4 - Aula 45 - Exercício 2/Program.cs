using System;
using System.Globalization;

namespace Seção_4___Aula_45___Exercício_2 {
    class Program {
        static void Main(string[] args) {
            Funcionario func;
            func = new Funcionario();

            double acressentarImposto;

            Console.Write("Nome: ");
            func.nomeFuncionario = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine($"Funcionário: {func.nomeFuncionario}, R${func.SalarioLiquido()}");

            Console.WriteLine("");
            Console.Write($"Digite a porcentagem para aumentar o salário: ");
            acressentarImposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(acressentarImposto);

            Console.WriteLine($"{func}");
        }
    }
}
