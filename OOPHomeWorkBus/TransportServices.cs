using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class TransportServices
    {
        //Метод для вывода типа транспорта
        public void PrintTransportType(KindOfTransport transport)
        {
            string transportType = transport.TypeOfTransport();
            Console.WriteLine($"{transport.GetType().Name} - Тип транспорта: {transportType}");
        }
        //Метод сортировки по количеству меси
        public KindOfTransport[] SortByNumberOfPlace(KindOfTransport[] list)
        {
            for (var i = 0; i < list.Length; i++)
            {
                for (var j = 0; j < list.Length - i - 1; j++)
                {
                    if (list[j].NumberOfPlace > list[j + 1].NumberOfPlace)
                    {
                        var tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }

            return list;
        }
    }
}
