using System;

namespace TipoTimeSpan;
class Program
{
    static void Main(string[] args)
    {
        TimeSpan t1 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(0, 1, 30);
        TimeSpan t3 = new TimeSpan(900000000L);
        TimeSpan t4 = new TimeSpan(23, 06, 25);
        TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
        TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t2.Ticks);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);
        Console.WriteLine(t6 + "\n");

        TimeSpan t7 = TimeSpan.FromDays(1.5);
        Console.WriteLine(t7);
        TimeSpan t8 = TimeSpan.FromHours(1.5);
        Console.WriteLine(t8);
        TimeSpan t9 = TimeSpan.FromMinutes(1.5);
        Console.WriteLine(t9);
        TimeSpan t10 = TimeSpan.FromTicks(900000000L);
        Console.WriteLine(t10);
    }
}