using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork
{
    public class Task1
    {
        public delegate int NoParameters();
        public void RunReturnNumber()
        {
            NoParameters noParameters = ReturnNumber;
            Console.WriteLine($"1 Задание. \nСлучайное значение от 0 до 10: {noParameters()}");
        }
        private int ReturnNumber()
        {
            return new Random().Next(0, 10);
        }
    }
}