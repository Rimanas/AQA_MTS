using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public static class Creator
    {
        public static Triangles CreateTriangels(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Это не треугольник!");
            }
            if (a==0 || b==0 || c==0)
            {
                Console.WriteLine("Это не треугольник, так как одна сторона 0");
            }
            if (a == b && b == c)
            {
                return new EquilateralTriangle(a, b, c);   //равносторонний
            }
            if (a == b || a == c || b == c)
            {
                return new IsoscelesTriangle(a, b, c);   //равнобедренный
            }
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                return new RectangularTriangle(a, b, c);  // прямоугольный
            }
            return new Triangles(a, b, c);
        }   

    }
}
