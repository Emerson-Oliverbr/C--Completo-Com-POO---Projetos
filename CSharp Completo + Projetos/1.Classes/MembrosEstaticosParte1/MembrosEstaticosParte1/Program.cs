using System;
using System.Globalization;

namespace MembrosEstaticosParte1
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circufenrencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circufenrencia(double raioInit)
        {
            return 2.0 * Pi * raioInit;
        }

        static double Volume(double raioInit)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raioInit, 3); 
        }
    }
}

