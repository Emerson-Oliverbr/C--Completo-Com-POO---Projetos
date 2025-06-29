using System;
namespace TipoDateTime;
class Program
{
    static void Main(string[] args)
    {
        DateTime data1 = DateTime.Now;
        Console.WriteLine(data1);

        DateTime data2 = new DateTime(2025, 06, 18);
        Console.WriteLine(data2);
        DateTime data3 = new DateTime(2025, 06, 18, 23, 00, 00);
        Console.WriteLine(data3);

        DateTime data5 = DateTime.Today;
        Console.WriteLine(data5);
        DateTime data6 = DateTime.UtcNow;
        Console.WriteLine(data6);

        DateTime novaData = DateTime.Parse("1980-01-03");
        Console.WriteLine(novaData);
        DateTime novaData2 = DateTime.Parse("1980-01-03 13:05:58");
        Console.WriteLine(novaData2);
        DateTime novaData3 = DateTime.Parse("18/06/2025");
        Console.WriteLine(novaData3);
        DateTime novaData4 = DateTime.Parse("18/06/2025 23:12:10");
        Console.WriteLine(novaData4);

        Console.ReadKey();
    }
}