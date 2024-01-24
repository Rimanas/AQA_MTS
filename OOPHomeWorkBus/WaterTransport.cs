using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    internal class WaterTransport:TransportType
    {
        public WaterTransport() { }
        public override string TypeOfTransport()
        {
            return "WaterTransport";
        }
    }
}
