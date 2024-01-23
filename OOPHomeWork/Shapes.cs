using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    internal class Shapes
    {
        //public string nameOfShape;
        public int A, B, C;

        public Shapes(int a, int b, int c) 
        {
            A= a; B = b; C= c;
        }
        public Shapes(int a, int b)
        {
            A = a; B = b;
        }
        // Виртуальный метод для расчёта периметра треугольника
        public virtual int CalcPerimeter()
        {
            int p = A + B + C;
            return p;
        }
        // Виртуальный метод для расчёта площади
        public virtual double CalcScuare()
        {
            double semiP = (A + B + C) / (double)2;
            //double square = Math.Sqrt(semiP * (semiP - A) * (semiP - B) * (semiP - C));
            return semiP;
        }

    }
}
