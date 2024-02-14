using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskOrders
{
    internal class Order
    {
        public string Name;
        public int Number;
        public Order(string name, int number)
        {
            Name = name;
            Number = number;
        }   
    }
}
