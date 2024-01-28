using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkShapes
{
    public abstract class Shapes
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
        // Виртуальный метод для расчёта площади
        public abstract double CalcScuare();
    }
}
