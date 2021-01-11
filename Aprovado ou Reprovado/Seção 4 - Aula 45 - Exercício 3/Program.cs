using System;
using System.Globalization;

namespace Seção_4___Aula_45___Exercício_3 {
    class Program {
        static void Main(string[] args) {
            DadosDoAluno Aluno = new DadosDoAluno();

            Console.Write("Nome do aluno: ");
            Aluno.nomeAluno = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            Aluno.notaAluno1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a segunda nota: ");
            Aluno.notaAluno2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a terceira nota: ");
            Aluno.notaAluno3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Nota final: {Aluno.notaFinal().ToString("f2", CultureInfo.InvariantCulture)}");
            if (Aluno.Aprovado()) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {Aluno.notaRestante().ToString("f2", CultureInfo.InvariantCulture)} pontos");
            }
        }
    }
}
