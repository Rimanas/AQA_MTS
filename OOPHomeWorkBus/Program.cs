using System.Numerics;
using System.Xml.Linq;

namespace OOPHomeWorkBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.Destination = "Kazan";
            bus.NumberBus = 111;
            bus.Time = DateTime.Now;    
            bus.NumberOfPlaces = 200;

            Console.WriteLine($"Информация об автобусе \n Пункт назначения: {bus.Destination}\n "+
                $"Номер автобуса : {bus.NumberBus}\n Время отпрвления : {bus.Time}\n " +
                $"Количество мест : {bus.NumberOfPlaces}");
        }
    }
}