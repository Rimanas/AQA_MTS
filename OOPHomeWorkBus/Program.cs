using System.Numerics;
using System.Xml.Linq;

namespace OOPHomeWorkBus
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportServices methods = new TransportServices();
            // Информация об автобусе 1 способ
            Bus bus1 = new Bus();
            bus1.Destination = "Kazan";
            bus1.NumberBus = 111;
            bus1.Time = DateTime.Now;
            bus1.NumberOfPlaces = 200;
            // ИЛИ 2 способ
            Bus bus2 = new Bus() { Destination = "Kazan", NumberBus = 200, Time = DateTime.Now, NumberOfPlaces = 300 };
            //Вывод информации об автобусе на консоль
            bus1.Print();
            bus2.Print();

            //Виды транспорта
            KindOfTransport[] kindOfTransports = new KindOfTransport[]
            {
                new Tramcar(){NameT = "Tramcar", Number = 200, NumberOfPlace = 50, Destination = "Kazan", Time = new TimeOnly(11, 00) },
                new TrollyeBus(){NameT = "TrollyeBus", Number = 100, NumberOfPlace = 30, Destination = "Kazan", Time = new TimeOnly(11, 30) },
                new Taxi(){NameT = "Taxi", Number = 899, NumberOfPlace = 4, Destination = "Kazan", Time = new TimeOnly(10,50)},
                new Train(){NameT = "Train", Number = 812200, NumberOfPlace =4000, Destination = "Kazan", Time = new TimeOnly(21,50)},
                new Carriage(){NameT = "Карета", Number = 0001, NumberOfPlace = 2, Destination = "Kazan", Time = new TimeOnly(09,00)}
            };
            Console.WriteLine("\n Типы транспорта в Транспортном Парке:");
            foreach (var transport in kindOfTransports)
            {
                methods.PrintTransportType(transport);
            }
            Console.WriteLine("\n Сортировка транспорта по количеству мест. вывод объектов в консоль:");
            kindOfTransports = methods.SortByNumberOfPlace(kindOfTransports);
            foreach (var transport in kindOfTransports)
            {
                transport.PrintTransportInfo();
            }
            // --------
            var searchTransport = new KindOfTransport[kindOfTransports.Length];
            int index = 0;
            bool isFound = false;
            Console.WriteLine("\n Введите время отправления в формате чч:мм");
            string timeDeparture = Console.ReadLine();
            TimeOnly? time = null;
            if (timeDeparture != string.Empty)
            {
                time = new TimeOnly(int.Parse(timeDeparture.Split(':')[0]), int.Parse(timeDeparture.Split(':')[1]));
            }
            foreach (var transport in kindOfTransports)
            {
                if (!(timeDeparture == string.Empty ||
                      (timeDeparture != string.Empty && transport.Time > time)))

                searchTransport[index] = transport;
                index++;
            }
            foreach (var transport in searchTransport)
            {
                if (transport != null)
                {
                    transport.PrintTransportInfo();
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Нет подъодящего транспорта на заданное время");
            }

        }
    }
}
