using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWBooks
{
    internal class WrongDateException : Exception
    {
        public WrongDateException() { }
        public WrongDateException(string message) : base(message) { }
    }
}