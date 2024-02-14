using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskOrders.Exceptions
{
    internal class EmptyOrderException : Exception
    {
        public EmptyOrderException(string message) : base(message) { }
    }
}
