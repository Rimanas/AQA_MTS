// See https://aka.ms/new-console-template for more information
using GenericsHomeWork.TaskOnePoint;


Console.WriteLine("Задание 1. Точка на координатной плоскости");
//Объекты с разными типами данных
Point<int> intPoint = new Point<int>(5, 5);
Point<double> doublePoint = new Point<double>(5.01, 5.009);
Point<float> floatPoint = new Point<float>(1.009f, 2.001f);
Point<long> longPoint = new Point<long>(-100000000000, -3000000000);
Point<string> stringPoint = new Point<string>("x", "y");
intPoint.Print();
doublePoint.Print(); 
floatPoint.Print(); 
longPoint.Print();  
stringPoint.Print();    