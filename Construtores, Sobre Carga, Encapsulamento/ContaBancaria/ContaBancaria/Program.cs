using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char respostaDepositoInicial = char.Parse(Console.ReadLine());

            if(respostaDepositoInicial == 's' || respostaDepositoInicial == 'S')
            {
                Console.Write("Digite o valor do deposito: ");
                double primeiroDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, titularConta, primeiroDeposito);                
            }
            else
            {
                conta = new ContaBancaria(numeroConta, titularConta);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Digite um valor para deposito: ");
            double valorADepositar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorADepositar);
            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Digite um valor para sacar: ");
            double valorASacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorASacar);           
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}

