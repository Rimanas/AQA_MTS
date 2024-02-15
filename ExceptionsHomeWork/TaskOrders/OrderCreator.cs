using ExceptionsHomeWork.TaskOrders.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskOrders
{
    internal class OrderCreator
    {
        public static void CheckOrder(int orderNumber, List<Order> orders, string adress, string recipient)
        {
            if (orderNumber < 0) 
            {
                throw new InvalidOrderNumberException("Ошибка : Номер заказа не может быть отрицательным.");
            }
            if (!orders.Any())
            {
                throw new EmptyOrderException("Ошибка : Отсутсвуют товары в заказе!");
            }
            if (String.IsNullOrEmpty(adress) || String.IsNullOrEmpty(recipient)) 
            {
                throw new DeliveryInformationMissingException("Ошибка : Отсутсвуют данные для доставки: адрес или получатель..");
            }
        }
    }
}