using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public class Triangles: Shapes
    {
        public Triangles(int a, int b, int c) : base(a, b, c)
        {
        }
        public void Print()
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
    }
}