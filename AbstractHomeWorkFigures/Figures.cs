using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWorkFigures
{
    public abstract class Figures
    {
        public double A, B, C, R;
        public Figures(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }
        public Figures(double a, double b)
        {
            A = a; B = b;
        }
        public Figures(double r)
        {
            R = r;
        }
        // Виртуальный метод для расчёта площади
        public abstract double CalcScuare();
        // Виртуальный метод для расчёта периметра
        public abstract double CalcPerimetr();
        public abstract void Print();
    }
}
