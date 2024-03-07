// See https://aka.ms/new-console-template for more information
using GenericsHomeWork.TaskOnePoint;
using GenericsHomeWork.TaskTwoGenericClass;
using System;

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

Console.WriteLine("Задание 2");
GenericClass<int> arrayInt = new(3);
GenericClass<string> arrayString = new(3);
for (int i = 0; i < 3; i++)
{
    arrayInt.MyArray[i] = new Random().Next(25);
}
for (int i = 0; i < 3; i++)
{
    arrayString.MyArray[i] = ((char)new Random().Next('a', 'z' + 4)).ToString();

}
arrayInt.PrintArray();
arrayString.PrintArray();
Console.WriteLine("Добавление элементов в массив");
arrayInt.AddElement(1);
arrayString.AddElement("Q");
arrayInt.PrintArray();
arrayString.PrintArray();
Console.WriteLine("Удаление элемента из массива");
Console.WriteLine("Удаление элемента из целочисленного массива");
arrayInt.DeleteElement(1);
arrayInt.PrintArray();
Console.WriteLine("Удаление элемента из строкового массива");
arrayString.DeleteElement("A");
arrayString.PrintArray();
Console.WriteLine("Вывод элемента по индексу из целочисленного массива");
arrayInt.GetElementByIndex(1);
arrayInt.GetElementByIndex(4);
Console.WriteLine("Вывод элемента по индексу из строкового  массива");
arrayString.GetElementByIndex(0);
arrayString.GetElementByIndex(10);
Console.WriteLine("Длина целочисленного массива");
arrayInt.GetArrayLenght();
Console.WriteLine("Длина строкового массива");
arrayString.GetArrayLenght();