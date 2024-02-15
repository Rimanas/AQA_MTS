using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskOrders.Exceptions
{
    internal class DeliveryInformationMissingException :Exception
    {
        public DeliveryInformationMissingException(string message) : base(message) { }
    }
}