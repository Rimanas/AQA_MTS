using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWorkFigures
{
    public class Circle : Figures
    {
        public Circle(double r) : base(r)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Радиус окружности: R : {R} см");
        }
        public override double CalcScuare()
        {
            double square = Math.PI * R * R;
            return square;
        }
        public override double CalcPerimetr()
        {
            double perimetr = Math.PI*2*R;
            return perimetr;
        }
    }
}
