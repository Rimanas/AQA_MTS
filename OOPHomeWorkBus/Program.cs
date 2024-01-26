using System.Numerics;
using System.Xml.Linq;

namespace OOPHomeWorkBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            TransportType transportType1 = new AirTransport();
            TransportType transportType2 = new GraundTransport();
            TransportType transportType3 = new RailTransport();
            TransportType transportType4 = new WaterTransport();
            // Информация об автобусе
            bus.Destination = "Kazan";
            bus.NumberBus = 111;
            bus.Time = DateTime.Now;
            bus.NumberOfPlaces = 200;

            Console.WriteLine($"Информация об автобусе \n Пункт назначения: {bus.Destination}\n " +
                $"Номер автобуса : {bus.NumberBus}\n Время отпрвления : {bus.Time}\n " +
                $"Количество мест : {bus.NumberOfPlaces}");

            //Информация о типах транспорта
            Console.WriteLine($"\n Информация о типе транспорта \n " +
                $"Тип транспорта: {transportType1.TypeOfTransport()}");
            Console.WriteLine($"\n Информация о типе транспорта \n " +
                $"Тип транспорта: {transportType2.TypeOfTransport()}");
            Console.WriteLine($"\n Информация о типе транспорта \n " +
                $"Тип транспорта: {transportType3.TypeOfTransport()}");
            Console.WriteLine($"\n Информация о типе транспорта \n " +
                $"Тип транспорта: {transportType4.TypeOfTransport()}");

            //Виды транспорта
            KindOfTransport trollyeBus = new TrollyeBus();
            // Информация об автобусе
            trollyeBus.DestinationT = "Kazan";
            trollyeBus.NumberT = 111;
            trollyeBus.TimeT = DateTime.Now;
            trollyeBus.NumberOfPlacesT = 200;
            Console.WriteLine(trollyeBus.NameT);
            Console.WriteLine($"Информация об автобусе \n Пункт назначения: {trollyeBus.DestinationT}\n " +
                $"Номер автобуса : {trollyeBus.NumberT}\n Время отпрвления : {trollyeBus.TimeT}\n " +
                $"Количество мест : {trollyeBus.NumberOfPlacesT} транспорт:{trollyeBus.NameT}");
        }
    }
}
