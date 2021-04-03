using System;
using System.Globalization;

namespace Seção_4___Aula_48___Exercício {
    class ConversorDeMoeda {
        public static double Iof = 6.0;

        public static double DolarParaReal(double ValorEmDolar, double CotacaoDoDolar) {
            double total = ValorEmDolar * CotacaoDoDolar;
            return total + total * Iof / 100.0;
        }
    }
}
