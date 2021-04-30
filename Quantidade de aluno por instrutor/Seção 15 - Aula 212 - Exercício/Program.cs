using System;
using System.Collections.Generic;
using Seção_15___Aula_212___Exercício.Entities;

namespace Seção_15___Aula_212___Exercício {
    class Program {
        static void Main(string[] args) {
            HashSet<CodeStudents> cs = new HashSet<CodeStudents>();

            Console.Write("How many students for course A? ");
            int courseA = int.Parse(Console.ReadLine());
            for(int i = 1; i <= courseA; i++) {
                Console.Write($"Digite o #{i} código: ");
                int codA = int.Parse(Console.ReadLine());
                cs.Add(new CodeStudents(codA));
            }

            Console.WriteLine();

            Console.Write("How many students for course B? ");
            int courseB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= courseB; i++) {
                Console.Write($"Digite o #{i} código: ");
                int codB = int.Parse(Console.ReadLine());
                cs.Add(new CodeStudents(codB));
            }

            Console.WriteLine();

            Console.Write("How many students for course C? ");
            int courseC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= courseC; i++) {
                Console.Write($"Digite o #{i} código: ");
                int codC = int.Parse(Console.ReadLine());
                cs.Add(new CodeStudents(codC));
            }
            Console.WriteLine();
            Console.WriteLine($"Total students: {cs.Count}");

        }
    }
}
