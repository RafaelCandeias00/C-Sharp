using System;
using System.Globalization;

namespace Seção_4___Aula_48___Exercício {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double CotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double ValorEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Convertido = ConversorDeMoeda.DolarParaReal(ValorEmDolar, CotacaoDoDolar);
            Console.WriteLine($"Valor a ser pago em reais: R${Convertido.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
