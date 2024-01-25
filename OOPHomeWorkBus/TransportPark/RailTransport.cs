using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class RailTransport: TransportType
    {
        public RailTransport() { }
        public override string TypeOfTransport()
        {
            return "RailTransport";
        }
    }
}
