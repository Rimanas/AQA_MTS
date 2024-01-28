using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public class EquilateralTriangle: Triangles
    {
        // Равносторонний треугольник
        public EquilateralTriangle(int a, int b, int c) : base(a, b, c)
        {
        }
        public override double CalcScuare()
        {
            double square = (Math.Sqrt(3) / 4) * Math.Pow(A, 2); ;
            return square;
        }
    }
}
