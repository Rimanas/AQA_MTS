using System;
using System.Globalization;

namespace FerstApp
{
    class Programm
    {
        static void Main(string[] args)
        {
           // Задание 1. Простой консольны калькулятор

                int result;
            Console.WriteLine("Добро пожаловать в простой консольный калькулятор, использующий действия + , -, :, *");

            Console.WriteLine("Введите первое число:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак операции  + , -, : или * :");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        
                        Console.WriteLine("Результат операции:  {0}+{1}={2}", firstNumber, secondNumber, result);
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        Console.WriteLine("Результат операции: {0}-{1}={2}", firstNumber, secondNumber, result);
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        Console.WriteLine("Результат операции: {0}*{1}={2}", firstNumber, secondNumber, result);
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        Console.WriteLine("Результат операции: {0}/{1}={2}", firstNumber, secondNumber, result);
                        break;
                    default:
                        Console.WriteLine("Недопустимое значение");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                
        }
    }



}