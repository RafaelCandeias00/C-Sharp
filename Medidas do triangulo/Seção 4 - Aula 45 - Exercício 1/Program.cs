using System;
using System.Globalization;

namespace Seção_4___Aula_45___Exercício_1 {
    class Program {
        static void Main(string[] args) {
            Retangulo medida;
            medida = new Retangulo();

            Console.Write("Entre com a largura: ");
            medida.medidaLargura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a altura: ");
            medida.medidaAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            medida.ToString();
            Console.WriteLine($"{medida}");
        }
    }
}
