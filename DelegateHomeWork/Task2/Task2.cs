using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.Task2
{
    internal class Task2
    {
        double r = 10.9;
        Formulas formulas = new Formulas();
        public delegate double GeometricCalculation(double r);
        public void RunCalculation()
        {
            GeometricCalculation lenghtCalculation = formulas.CircleLenghtCalculation;
            GeometricCalculation squareCalculation = formulas.CircleSquareCalculation;
            GeometricCalculation volumeCalculation = formulas.SphereVolumeCalculation;
            Console.WriteLine($"2 Задание. \nДлина окружности: {lenghtCalculation(r)} " +
                $"\nПлощадь круга: {squareCalculation(r)} \nОбъем шара:{volumeCalculation(r)}");
        }
    }
}