﻿using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassesHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------    1 Задание. Работа с классом Phone ---------
            Console.WriteLine("1 Задание. Работа с классом Phone \n 1 Экземпляр класса \n");
            //Создание 1 экзмепляра класса Phone, используя 1 конструктор
            Phone phone1 = new Phone();
            /*Вывести значения класса из 1 конструткора
            Console.WriteLine($"Номер телефона 1 экземпляра: {phone1.number}");
            Console.WriteLine($"Модель телефона 1 экземпляра: {phone1.model}");
            Console.WriteLine($"Вес  телефона 1 экземпляра: {phone1.weight} \n");
            */
            phone1.Print();
            //Вызов методов из класса Phone
            Console.WriteLine($"Номер телефона: {phone1.GetNumber(phone1.number)}");
            Console.WriteLine($"Номер телефона 2, возвращаемый всегда один и тот же: {phone1.GetNumber1()}");
            phone1.ReceiveCall("Kate");
            phone1.SendMessage(89600000000, 89600000001);
            phone1.SendMessage(89600000000, 89600000001, 89600000004, 89600000044, 89600000055);
            Console.WriteLine(" \n 2 Экземпляр класса \n");
            //Создание 2 экзмепляра класса Phone, используя 2 конструктор
            Phone phone2 = new Phone(89600000002, "Samsung");
            /*Вывести значения класса из 2 конструктора
            Console.WriteLine($"Номер телефона 2 экземпляра: {phone2.number}");
            Console.WriteLine($"Модель телефона 2 экземпляра: {phone2.model}");
            Console.WriteLine($"Вес  телефона 3 экземпляра: {phone2.weight} \n");
            */
            phone2.Print();
            //Вызов методов из класса Phone
            Console.WriteLine("Вызов методов 2 Экземпляра из класса Phone");
            Console.WriteLine($"Номер телефона: {phone2.GetNumber(phone2.number)}");
            Console.WriteLine($"Номер телефона 2, возвращаемый всегда один и тот же: {phone2.GetNumber1()}");
            phone2.ReceiveCall("Alice");
            phone2.SendMessage(89600000002, 89600000022);
            phone2.SendMessage(89600000002, 89600000022, 89600000004, 89600000044, 89600000055);
            Console.WriteLine(" \n 3 Экземпляр класса \n");
            //Создание 3 экзмепляра класса Phone, используя 3 конструктор
            Phone phone3 = new Phone(89600000003, "LG", 300);
            /*Вывести значения класса из 1 конструктора
            Console.WriteLine($"Номер телефона 3 экземпляра: {phone3.number}");
            Console.WriteLine($"Модель телефона 3 экземпляра: {phone3.model}");
            Console.WriteLine($"Вес  телефона 3 экземпляра: {phone3.weight} \n");
            */
            phone3.Print();
            //Вызов методов из класса Phone
            Console.WriteLine("Вызов методов 3 Экземпляра из класса Phone");
            Console.WriteLine($"Номер телефона: {phone3.GetNumber(phone3.number)}");
            Console.WriteLine($"Номер телефона 2, возвращаемый всегда один и тот же: {phone3.GetNumber1()}");
            phone3.ReceiveCall("Bob");
            phone3.SendMessage(89600000003, 89600000033);
            phone3.SendMessage(89600000003, 89600000033, 89600000004, 89600000044, 89600000055);
            // -----------   2 Задание. Работа с классом CreditCard  ---------
            Console.WriteLine("2 Задание. Работа с классом CreditCard  \n 1  КАРТОЧКА \n");
            CreditCard creditCard1 = new CreditCard(5000111122223333, 100.00);
            creditCard1.Print();
            creditCard1.AddMoneyToCard(100.00);
            Console.WriteLine($"Сумма денег на карте после зачисления:");
            creditCard1.Print();
            Console.WriteLine(" \n 2  КАРТОЧКА \n");
            CreditCard creditCard2 = new CreditCard(6000111122223333, 200.00);
            creditCard2.Print();
            creditCard2.AddMoneyToCard(200.00);
            Console.WriteLine($"Сумма денег на карте после зачисления:");
            creditCard2.Print();
            Console.WriteLine(" \n 3  КАРТОЧКА \n");
            CreditCard creditCard3 = new CreditCard(7000111122223333, 300.00);
            creditCard3.Print();
            creditCard3.WithDrowMoneyFromCard(400.99);
            Console.WriteLine($"Сумма денег на карте после снятия:");
            creditCard3.Print();
            // -----------  3 Задание. БАНКОМАТ  ---------
            Console.WriteLine("\n 3 Задание.  БАНКОМАТ \n");
            int giveSum;
            Atm atm1 = new Atm(1, 1, 1);
            Console.WriteLine($"Количество купюр в банкомате:");
            atm1.Print();
            atm1.AddMoneyToAtm(2, 2, 2);
            Console.WriteLine($"Количество купюр в банкомате после внесения:");
            atm1.Print();
            // подсчет денежных средств в банкомате
            atm1.SumAtm(atm1.ru20, atm1.ru50, atm1.ru100, out atm1.sum);
            Console.WriteLine("\n Проверка возможности снятия денег");
            Console.WriteLine($"Денежных средств (1000р) в банкомате для снятия достаточно?: {atm1.WithDrowMoneyFromAtm(1000)} ");
            Console.WriteLine($"Денежных средств (100р) в банкомате для снятия достаточно?: {atm1.WithDrowMoneyFromAtm(100)} "); 
            Console.WriteLine("Денежных средств (100р) в банкомате для снятия достаточно? - {0}", atm1.WithDrowMoneyFromAtm(100) ? "Yes" : "No");

            Console.WriteLine("\n Вывод какими купюрами и в каком количестве выдаётся сумма");
            Console.WriteLine("Введите сумму для снятия, затем нажмите Enter:");
            giveSum = Convert.ToInt32(Console.ReadLine());
            atm1.CalculateNotes(giveSum, ref atm1.ru20, ref atm1.ru50, ref atm1.ru100);
            // -----------  4 Задание. ВРАЧИ  ---------       
            Console.WriteLine("\n 4 Задание.  ВРАЧИ \n");
            Patient[] patients = new Patient[5];   
            for (int i = 0; i < patients.Length; i++)
            {
                patients[i] = new Patient();
                patients[i].name = "Bob" + i;
                patients[i].age = new Random().Next(18,100);
                patients[i].plan = new Random().Next(1,10);
            }
            foreach (Patient patient in patients)
            { 
                patient.Print();
            }
            TreatmentPlan treatmentPlan = new TreatmentPlan(0);
            foreach (Patient patient in patients)
            {
                treatmentPlan.Plan(patient.plan);
            }
        }
    }             
}