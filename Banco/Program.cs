using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine();

            ContaBancaria cb1;

            if (depositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine());
                cb1 = new ContaBancaria(titular, conta, valor);
            }else
                cb1 = new ContaBancaria(titular, conta);

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(cb1);

            Console.Write("\nEntre um valor para depósito: ");
            cb1.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(cb1);

            Console.Write("\nEntre um valor para saque: ");
            cb1.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(cb1);

        }
    }
}
