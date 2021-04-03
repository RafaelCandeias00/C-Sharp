using System;

namespace Alugando_quartos {
    class Program {
        static void Main(string[] args) {
            
            DadosEstudantes[] vect = new DadosEstudantes[10];

            Console.Write("How much rooms will be rented? ");
            int numRoom = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numRoom; i++) {
                Console.WriteLine($"Rend #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new DadosEstudantes(name, email);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Occupied rooms:");
            for (int i = 1; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine($"#{i}: {vect[i]}");
                }
            }
        }
    }
}
