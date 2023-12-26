using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassesHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1 Задание. Работа с классом Phone
            Console.WriteLine("1 Задание. Работа с классом Phone \n");

            //Создание 1 экзмепляра класса Phone, используя 1 конструктор
            Phone phone1 = new Phone();
            //Вызов методов из класса Phone
            Console.WriteLine($"Номер телефона: {phone1.GetNumber(89600000000)}");
            Console.WriteLine($"Номер телефона 2: {phone1.GetNumber1()}");
            phone1.ReceiveCall("Kate");
            phone1.SendMessage(89600000000, 89600000001, 89600000002, 89600000003);
            //Вывести значения класса из 1 конструткора
            Console.WriteLine($"Номер телефона 1 экземпляра: {phone1.number}");
            Console.WriteLine($"Модель телефона 1 экземпляра: {phone1.model}");
            Console.WriteLine($"Вес  телефона 1 экземпляра: {phone1.weight} \n");

            //Создание 2 экзмепляра класса Phone, используя 2 конструктор
            Phone phone2 = new Phone(89172898000, "Samsung");
                //Вывести значения класса из 2 конструткора
            Console.WriteLine($"Номер телефона 2 экземпляра: {phone2.number}");
            Console.WriteLine($"Модель телефона 2 экземпляра: {phone2.model} \n");

            //Создание 3 экзмепляра класса Phone, используя 3 конструктор
            Phone phone3 = new Phone(89172898000, "LG", 200);
            //Вывести значения класса из 1 конструткора
            Console.WriteLine($"Номер телефона 3 экземпляра: {phone3.number}");
            Console.WriteLine($"Модель телефона 3 экземпляра: {phone3.model}");
            Console.WriteLine($"Вес  телефона 3 экземпляра: {phone3.weight} \n");


        }


    }
            
    
}
