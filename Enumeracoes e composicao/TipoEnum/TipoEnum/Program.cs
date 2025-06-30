using TipoEnum.Entities;
using TipoEnum.Entities.Enums;

namespace TipoEnum;

class Program()
{
    static void Main(string[] args)
    {
        Order order = new Order()
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        Console.WriteLine($"Status atual: {order}");

        string txt = OrderStatus.PendingPayment.ToString();

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(os);
        Console.WriteLine(txt);

        Console.ReadKey();
    }
}