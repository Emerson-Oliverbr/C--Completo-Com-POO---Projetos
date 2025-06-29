
namespace PropriedadesDateTime;
class Program
{
    static void Main(string[] args)
    {
        DateTime data = new DateTime(2001, 8, 15, 13, 45, 58, 275);
        Console.WriteLine(data);
        Console.WriteLine($"1) Data: {data.Date}");
        Console.WriteLine($"2) Dia: {data.Day}");
        Console.WriteLine("3) Day da Semana: " + data.DayOfWeek);
        Console.WriteLine("4) Dia do Ano: " + data.DayOfYear);
        Console.WriteLine("5) Hora: " + data.Hour);
        Console.WriteLine("6) Tipo: " + data.Kind);
        Console.WriteLine("7) Milisegundos: " + data.Millisecond);
        Console.WriteLine("8) Minuto: " + data.Minute);
        Console.WriteLine("9) Mes: " + data.Month);
        Console.WriteLine("10) Secondos: " + data.Second);
        Console.WriteLine("11) Ticks: " + data.Ticks);
        Console.WriteLine("12) Hora do dia: " + data.TimeOfDay);
        Console.WriteLine("13) Ano: " + data.Year + "\n");

        Console.WriteLine(data.ToShortDateString());
        Console.WriteLine(data.ToLongDateString());
        Console.WriteLine(data.ToLongTimeString());
        Console.WriteLine(data.ToShortDateString());
        

        Console.ReadKey();
    }
}