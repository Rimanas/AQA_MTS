using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public class RectangularTriangle : Triangles
    {
        //Разносторонний треугольник
        public RectangularTriangle(int a, int b, int c) : base(a, b, c)
        {
        }
        public override double CalcScuare()
        {
            if (A > B && A > C)
            {
                return (B * C) / (double)2;
            }

            if (B > A && B > C)
            {
                return (A * C) / (double)2;
            }

            if (C > A && C > B)
            {
                return (A * B) / (double)2;
            }

            return base.CalcScuare();
        }
    }
}
