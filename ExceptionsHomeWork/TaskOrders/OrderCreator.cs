using ExceptionsHomeWork.TaskOrders.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskOrders
{
    internal class OrderCreator
    {
        public static void CheckOrder(int orderNumber, List<Order> orders, string adress)
        {
            if (orderNumber < 0) 
            {
                throw new InvalidOrderNumberException("Ошибка : Номер заказа не может быть отрицательным");
            }
        }
    }
}
