using System;
using System.Globalization;

namespace Seção_5___Aula_60___Exercício {
    class ContaBancaria {

        private string _titularConta;
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }

        public string TitularConta{
            get { return _titularConta; }
            set {
                if (value != null && value.Length > 1) {
                    _titularConta = value;
                }
            }
        }

        public ContaBancaria(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            _titularConta = titularConta;
        }

        public ContaBancaria(int numeroConta, string titularConta, double saldo) : this(numeroConta, titularConta){
            Saldo = saldo;
        }
       

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }

        public override string ToString() {
            return $"Conta: {NumeroConta} / Titular: {TitularConta} / Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
