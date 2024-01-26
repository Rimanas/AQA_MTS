using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class KindOfTransport
    {
        string nameT;
        public string NameT
        {
            get { return nameT; }
        }
        string destinationT;            //поле пункта назначения
        public string DestinationT      //свойство поля пункта назначения
        {
            get { return destinationT; }
            set { destinationT = value; }
        }

        int numberT;                 //поле номера транспорта
        public int NumberT           //свойство поля номера транспорта
        {
            get { return numberT; }
            set
            {
                if (value > 0)
                    numberT = value;
            }
        }

        DateTime timeT;              //поле времени отправления
        public DateTime TimeT        //свойство поля времени отправления
        {
            get { return timeT; }
            set { timeT = value; }
        }

        int numberOfPlacesT;                 //число мест в транспорта
        public int NumberOfPlacesT           //свойство поля число мест
        {
            get { return numberOfPlacesT; }
            set
            {
                if (value > 0)
                    numberOfPlacesT = value;
            }
        }
    }
}
