using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class GraundTransport: TransportType
    {
        public GraundTransport() { }
        public override string TypeOfTransport()
        {
            return "GraundTransport";
        }
    }
}
