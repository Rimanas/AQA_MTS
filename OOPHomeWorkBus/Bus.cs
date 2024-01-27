using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    public class Bus
    {
        string destination;            //поле пункта назначения
        public string Destination      //свойство поля пункта назначения
        {
            get { return destination; }
            set { destination = value; }
        }

        int numberBus;                 //поле номера автобуса
        public int NumberBus           //свойство поля номера автобуса
        {
            get { return numberBus; }
            set
            {
                if (value > 0)
                    numberBus = value;
            }
        }
        
        DateTime time;              //поле времени отправления
        public DateTime Time        //свойство поля времени отправления
        {
            get { return time; }
            set { time = value; }
        }

        int numberOfPlaces;                 //число мест в автобусе
        public int NumberOfPlaces           //свойство поля число мест
        {
            get { return numberOfPlaces; }
            set
            {
                if (value > 0)
                    numberOfPlaces = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Информация об автобусе \n Пункт назначения: {Destination}\n " +
                $"Номер автобуса : {NumberBus}\n Время отпрвления : {Time}\n " +
                $"Количество мест : {NumberOfPlaces}");
        }
    }
}
