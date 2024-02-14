using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskOrders.Exceptions
{
    internal class InvalidOrderNumberException : Exception
    {
        public InvalidOrderNumberException(string message) : base(message) { }
    }
}
