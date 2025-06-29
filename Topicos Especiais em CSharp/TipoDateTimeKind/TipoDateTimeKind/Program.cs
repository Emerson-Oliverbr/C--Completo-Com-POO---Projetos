namespace TipoDateTimeKind;
class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
        DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
        DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

        Console.WriteLine($"D1: {d1}");
        Console.WriteLine($"D1 kind: {d1.Kind}");
        Console.WriteLine($"D1 ToLocal: {d1.ToLocalTime()}");
        Console.WriteLine($"D1 Utc: {d1.ToUniversalTime()} \n");

        Console.WriteLine($"D1: {d2}");
        Console.WriteLine($"D1 kind: {d2.Kind}");
        Console.WriteLine($"D1 ToLocal: {d2.ToLocalTime()}");
        Console.WriteLine($"D1 Utc: {d2.ToUniversalTime()} \n");

        Console.WriteLine($"D1: {d3}");
        Console.WriteLine($"D1 kind: {d3.Kind}");
        Console.WriteLine($"D1 ToLocal: {d3.ToLocalTime()}");
        Console.WriteLine($"D1 Utc: {d3.ToUniversalTime()}");

        Console.ReadKey();
    }
}