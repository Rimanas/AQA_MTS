﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkBus
{
    public class Plane: KindOfTransport
    {
        public override string TypeOfTransport()
        {
            return "AirTransport";
        }
    }
}