using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    internal class EquilateralTriangle: Triangles
    {
        public EquilateralTriangle(int a, int b, int c) : base(a, b, c)
        {
            Console.WriteLine("EquilateralTriangle:" + base.GetHashCode());
        }

        //public void EquilateralTriangle() { }
        public override double CalcScuare()
        {
            double square = (Math.Sqrt(3) / 4) * Math.Pow(A, 2); ;
            return square;
        }
    }
}
