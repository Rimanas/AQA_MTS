using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenericsHomeWork.TaskOnePoint
{
    public class Point<T>
    {
        private T _x;
        private T _y;
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x, T y)
        {
            _x = x;
            _y = y;
        }
        public void Print()
        {
            Console.WriteLine($"Абсцисса x: {_x}, Ордината y: {_y}");
        }
    }
}
