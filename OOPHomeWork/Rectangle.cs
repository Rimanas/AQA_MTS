using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    internal class Rectangle: Shapes
    {
        public Rectangle(int a, int b) : base(a, b)
        {
            Console.WriteLine("Rectangle:" + base.GetHashCode());
        }
        public override double CalcScuare()
        {
            double square = A*B;
            return square;
        }
        public void Print()
        {
            Console.WriteLine($"Длина сторон треугольника: A : {A} см, B : {B} см и C : {C} см");
        }
    }
}
