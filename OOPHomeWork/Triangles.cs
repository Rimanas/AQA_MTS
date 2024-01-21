using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    internal class Triangles: Shapes
    {
        public Triangles(int a, int b, int c) : base(a, b, c)
        {
            Console.WriteLine("Triangle:" + base.GetHashCode());
        }
        public void Print()
        {
            Console.WriteLine($"Длина сторон треугольника: A : {A} см, B : {B} см и C : {C} см");
        }


    }
}
