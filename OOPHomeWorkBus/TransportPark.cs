using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class TransportPark
    {
        int numberTransport;                 //поле гос номер транспорта
        public int NumberTransport           //свойство поля гос номер транспорта
        {
            get { return numberTransport; }
            set
            {
                if (value > 0)
                    numberTransport = value;
            }
        }

        DateTime time;              //поле времени отправления
        public DateTime Time        //свойство поля времени отправления
        {
            get { return time; }
            set { time = value; }
        }

        int numberOfPlaces;                 //число мест в транспорте
        public int NumberOfPlaces           //свойство поля число мест
        {
            get { return numberOfPlaces; }
            set
            {
                if (value > 0)
                    numberOfPlaces = value;
            }
        }
    }
}
