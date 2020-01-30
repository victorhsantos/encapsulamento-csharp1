using System;

namespace Banco
{
    class ContaBancaria
    {
        private double TaxaSaque = 5.0;
        public string NomeTitular { get; set; }
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(string nomeTitular, int numeroConta)
        {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
        }

        public ContaBancaria(string nomeTitular, int numeroConta, double saldoConta) : this(nomeTitular, numeroConta)
        {
            SaldoConta = saldoConta;
        }

        public void Deposito(double valor)
        {
            SaldoConta += valor;
        }

        public void Saque(double valor)
        {
            SaldoConta -= (valor + TaxaSaque);
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: R$" + SaldoConta.ToString("F2");
        }

    }
}
