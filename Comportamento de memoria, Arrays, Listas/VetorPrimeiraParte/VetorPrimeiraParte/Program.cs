using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] idades = new double[n];

            for(int i=0; i<n; i++)
            {
                idades[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double media = 0.0;
            double somaDasAlturas = 0.0;

            for (int i = 0; i < n; i++)
            {
                somaDasAlturas += idades[i];                
            }

            media = somaDasAlturas / n;
            Console.WriteLine("Altura media = " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

