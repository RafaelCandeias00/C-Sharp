using System;
using System.Globalization;
using System.Collections.Generic;

namespace Seção_6___Aula_78___Exercício_de_fixação {
    class Empregado {
        public int IdEmpregado { get; set; }
        public string NomeEmpregado { get; set; }
        public double SalarioEmpregado { get; set; }

        public Empregado(int id, string nome, double salario) {
            IdEmpregado = id;
            NomeEmpregado = nome;
            SalarioEmpregado = salario;
        }

        public void acressimoSalario(double salario) {
            SalarioEmpregado += (salario / 100 * SalarioEmpregado);
        }

        public override string ToString() {
            return $"{IdEmpregado}, {NomeEmpregado}, R${SalarioEmpregado.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
