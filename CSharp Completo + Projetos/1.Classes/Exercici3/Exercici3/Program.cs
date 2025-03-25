using System;
using System.Globalization;

namespace Exercici3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA: = {retangulo.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO: = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}

