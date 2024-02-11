using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AbstractHomeWorkFigures
{
    public class Rectangle : Figures
    {
        public Rectangle(double a, double b) : base(a, b)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Длина сторон прямоугольника: A : {A} см, B : {B} см ");
        }
        public override double CalcScuare()
        {
            double square = A * B;
            return square;
        }
        public override double CalcPerimetr()
        {
            double perimetr = (A + B)*2;
            return perimetr;
        }
    }
}
