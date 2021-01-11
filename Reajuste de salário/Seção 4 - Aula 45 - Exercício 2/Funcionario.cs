using System;
using System.Globalization;

namespace Seção_4___Aula_45___Exercício_2 {
    class Funcionario {
        public string nomeFuncionario;
        public double salarioBruto;
        public double Imposto; 

        public double SalarioLiquido() {
            return salarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagemImposto) {
            salarioBruto = (salarioBruto + (porcentagemImposto / 100 * salarioBruto ));
        }
        public override string ToString() {
            return $"Dados atualizados: {nomeFuncionario}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
