using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public class IsoscelesTriangle : Triangles
    {
        // Равнобедренный треугольник
        public IsoscelesTriangle(int a, int b, int c) : base(a, b, c)
        {
        }

        public override double CalcScuare()
        {
            if (A==B)
            {
                return C / 4 * double.Sqrt(4 * double.Pow(A, 2) - double.Pow(C, 2));
            }

            if (A==C)
            {
                return B / 4 * double.Sqrt(4 * double.Pow(A, 2) - double.Pow(B, 2));
            }

            if (B==C)
            {
                return A / 4 * double.Sqrt(4 * double.Pow(B, 2) - double.Pow(A, 2));
            }

            return base.CalcScuare();
        }
    }

}
