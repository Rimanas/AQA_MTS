using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    internal class Creator : Shapes
    {
        public Creator(int a, int b, int c) : base(a, b, c)
        {
            Console.WriteLine("Triangle:" + base.GetHashCode());
        }
        Shapes triangle1 = new EquilateralTriangle(1,1,1);
        /*
        public override double CalcScuare()
        {
            double square = (Math.Sqrt(3) / 4) * Math.Pow(A, 2); ;
            return square;
        }
        */
        public void CreateTriangels(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("Это не треугольник!");
            else if (a == b && b == c)
                Console.WriteLine($"Это равносторонний треугольник!: {triangle1.CalcScuare()}");
            else if (a == b || a == c || b == c) 
                Console.WriteLine("Это равнобедренный треугольник!");
            else
                Console.WriteLine($"Это треугольник.: {base.CalcScuare()}");


            
      
        }

    }
}
