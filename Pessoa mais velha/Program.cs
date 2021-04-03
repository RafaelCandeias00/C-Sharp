using System;

namespace Seção_4___Aula_40___Exercício_1 {
    class Program {
        static void Main(string[] args) {
            Pessoa p2, p1;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("---- PESSOA MAIS VELHA ---");
            Console.WriteLine("\n");

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.nomePessoa = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idadePessoa = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            p2.nomePessoa = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idadePessoa = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            if (p1.idadePessoa > p2.idadePessoa) {
                Console.WriteLine($"Pessoa mais velha: {p1.nomePessoa}");
            }else if(p2.idadePessoa > p1.idadePessoa) {
                Console.WriteLine($"Pessoa mais velha: {p2.nomePessoa}");
            }else {
                Console.WriteLine($"{p1.nomePessoa} e {p2.nomePessoa} tem a mesma idade");
            }
        }
    }
}
