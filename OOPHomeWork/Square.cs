using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public class Square : Rectangle
    {
        public Square(int a) : base(a, a)
        {
        }
        public override double CalcScuare()
        {
            return A * A;
        }
    }
}