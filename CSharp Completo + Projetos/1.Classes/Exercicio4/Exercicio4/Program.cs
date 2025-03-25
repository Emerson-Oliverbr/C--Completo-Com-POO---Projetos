using System;
using System.Globalization;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(funcionario);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumentoSalarial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumentoSalarial);
            Console.WriteLine($"Dados atualizados: {funcionario}");

            Console.ReadKey();
        }
    }
}

