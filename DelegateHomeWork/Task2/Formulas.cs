using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.Task2
{
    public class Formulas
    {
        public double CircleLenghtCalculation(double r)
        {
            double lenght = 2 * Math.PI * r;
            return lenght;
        }
        public double CircleSquareCalculation(double r)
        {
            double square = Math.PI * r * r;
            return square;
        }
        public double SphereVolumeCalculation(double r)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            return volume;
        }
    }
}