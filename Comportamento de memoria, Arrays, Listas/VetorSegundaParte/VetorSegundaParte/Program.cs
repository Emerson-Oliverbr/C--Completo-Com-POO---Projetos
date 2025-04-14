using System;
using System.Globalization;

using VetorSegundaParte;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i=0; i<n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double somaDosPrecos = 0.0;

            for (int i = 0; i < n; i++)
            {
                somaDosPrecos += vect[i].Preco;
            }

            double media = somaDosPrecos / n;

            Console.WriteLine($"Media dos preços = R${media.ToString("F2",CultureInfo.InvariantCulture)} ");

            Console.ReadKey();
        }
    }
}

