using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    internal class VersatileTriangle: Triangles
    {
        public VersatileTriangle(int a, int b, int c) : base(a, b, c)
        {
            Console.WriteLine("VersatileTriangle:" + base.GetHashCode());
        }
        public override double CalcScuare()
        {
            double semiP = (A + B + C) / (double)2;
            double square = Math.Sqrt(semiP * (semiP - A) * (semiP - B) * (semiP - C));
            return square;
        }
    }
}
