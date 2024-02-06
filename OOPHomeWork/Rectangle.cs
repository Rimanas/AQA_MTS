using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public class Rectangle: Shapes
    {
        public Rectangle(int a, int b) : base(a, b)
        {
        }
        public override double CalcScuare()
        {
            double square = A*B;
            return square;
        }
    }
}