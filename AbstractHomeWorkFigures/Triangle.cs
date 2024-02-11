using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AbstractHomeWorkFigures
{
    public class Triangle : Figures
    {
        public Triangle(double a, double b, double c) : base(a, b, c)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Длина сторон треугольника: A : {A} см, B : {B} см и C : {C} см");
        }
        // Метод для расчёта полупериметра треугольника
        private double semiP => (A + B + C) / (double)2;
        public override double CalcScuare()
        {
            double square = Math.Sqrt(semiP * (semiP - A) * (semiP - B) * (semiP - C));
            return square;
        }
        public override double CalcPerimetr()
        {
            double perimetr = (A + B + C);
            return perimetr;
        }
    }
}