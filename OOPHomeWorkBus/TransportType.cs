using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class TransportType
    {
        string type;            //поле типа транспорта
        public string Type      //свойство поля тип траспорта
        {
            get { return type; }
            set { type = value; }
        }
        // Виртуальный метод для опроеделения типа трнспорта
        public virtual string TypeOfTransport()
        {
            Console.WriteLine("Метод возвращает тип транспорта");
            return type;
        }
    }
}
