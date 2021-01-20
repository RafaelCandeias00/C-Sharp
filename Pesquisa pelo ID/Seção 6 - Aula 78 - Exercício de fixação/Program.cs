using System;
using System.Globalization;
using System.Collections.Generic;

namespace Seção_6___Aula_78___Exercício_de_fixação {
    class Program {
        static void Main(string[] args) {
            List<Empregado> list = new List<Empregado>();

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Empregado #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Coloque o ID do empregado que terá aumento de salário: ");
            int idPesquisa = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.IdEmpregado == idPesquisa);
            if (emp != null) {
                Console.Write("Entre com a porcentagem: ");
                double acressimo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.acressimoSalario(acressimo);
            } else {
                Console.WriteLine("ID incorreto");
            }


            Console.WriteLine("Dados atualizados: ");
            foreach (Empregado obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
