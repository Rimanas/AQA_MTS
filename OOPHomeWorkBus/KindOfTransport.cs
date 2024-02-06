using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    public abstract class KindOfTransport
    {
        public string NameT {  get; set; }
        public int Number { get; set; }
        public int NumberOfPlace {  get; set; }
        public string Destination { get; set; }
        public TimeOnly Time { get; set; }
        public abstract string TypeOfTransport();
        public void PrintTransportInfo() // метод вывода информации о транспорте\ нельзя переопределить
        {
            Console.WriteLine($"{this.GetType().Name}: Транспорт = {NameT}, Номер = {Number}, Количество мест = {NumberOfPlace}, Пункт Прибытия = {Destination}, Время отправления: {Time}");
        }
    }
}