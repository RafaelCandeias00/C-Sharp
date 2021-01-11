using System;
using System.Globalization;

namespace Seção_4___Aula_45___Exercício_1 {
    class Retangulo {
        public double medidaLargura;
        public double medidaAltura;

        public double Area() {
            return medidaLargura * medidaAltura;
        }
        public double Perimetro() {
            return 2 * (medidaLargura + medidaAltura);
        }
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(medidaLargura,2) + Math.Pow(medidaAltura,2));
        }

        public override string ToString() {
            return "Area: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
