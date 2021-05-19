using System;
using System.Globalization;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            ContaBancaria conta;

            Console.Write("Entre com o numero do titular da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor que deseja depositar: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor de depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CI);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CI);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

        }
    }
}
