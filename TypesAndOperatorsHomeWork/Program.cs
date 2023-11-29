using System;
using System.Globalization;
using System.Xml.Linq;

namespace FerstApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            // =================    1 ЗАДАНИЕ. Простой консольный калькулятор  ===========
            
            Console.WriteLine("1 ЗАДАНИЕ. Простой консольный калькулятор");
            double result;
            Console.WriteLine("Добро пожаловать в простой консольный калькулятор, использующий действия + , -, :, *");

            Console.WriteLine("Введите первое число, затем нажмите Enter:");
                double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знак операции  + , -, / или * , затем нажмите Enter:");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите второе число, затем нажмите Enter:");
                double secondNumber = Convert.ToDouble(Console.ReadLine());              

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
                    while (secondNumber ==0)
                    {                      
                        Console.WriteLine("Введите ненулевое число. На ноль делить нельзя! :");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                    }
                        result = firstNumber / secondNumber;
                        Console.WriteLine("Результат операции: {0}/{1}={2}", firstNumber, secondNumber, result);
                        break;
                    default:
                        Console.WriteLine("Недопустимое входное значение");
                        break;
                }
            Console.WriteLine();



            //  ============   2 ЗАДАНИЕ. Определение принадлежания числа числовым промежуткам  =========

            Console.WriteLine();
            Console.WriteLine("2 ЗАДАНИЕ. Определение принадлежания числа числовым промежуткам");
            Console.WriteLine("Имеются следующие числовые промежутки [-40, -10] [-9, 0] [1, 10]  [11, 40] ");
            int[] nums1 = new int[2] { -40, -10 };
            int[] nums2 = new int[2] { -9, 0 };
            int[] nums3 = new int[2] { 1, 10 };
            int[] nums4 = new int[2] { 11, 40 };
            int number;
            Console.WriteLine("Введите любое целое число от  -50  до 50, затем нажмите Enter:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= nums1[0] && number <= nums1[1])
            {
                Console.WriteLine($"Число {number} принадлежит первому числовому промежутку");
            }
            else if (number >= nums2[0] && number <= nums2[1])
            {
                Console.WriteLine($"Число {number} принадлежит второму числовому промежутку");
            }
            else if (number >= nums3[0] && number <= nums3[1])
            {
                Console.WriteLine($"Число {number} принадлежит третьему числовому промежутку");
            }
            else if (number >= nums4[0] && number <= nums4[1])
            {
                Console.WriteLine($"Число {number} принадлежит четвертому числовому промежутку");
            }
            else
            {
                Console.WriteLine($"Число {number} не принадлежит ни одному числовому промежутку");
            }
            Console.WriteLine();
            

            //  ============   3 ЗАДАНИЕ. Русско - английский переводчик  =========

            Console.WriteLine();
            Console.WriteLine("3 ЗАДАНИЕ. Русско - английский переводчик");
            Console.WriteLine("Добро пожаловать в консольный русско - английский переводчик о погоде, который знает 10 слов");
            //Console.WriteLine("Введите любое слово о погоде на русском языке");
            string value;
            do             
            {
                Console.WriteLine("Введите любое слово о погоде на русском языке");
                string word = Console.ReadLine();
                switch(word)
                {
                    case "погода":
                        Console.WriteLine($"{word} - wheather");
                        break;
                    case "солнечный":
                        Console.WriteLine($"{word} - sunny");
                        break;
                    case "холодный":
                        Console.WriteLine($"{word} - cold");
                        break;
                    case "жаркий":
                        Console.WriteLine($"{word} - hot");
                        break;
                    case "теплый":
                        Console.WriteLine($"{word} - warm");
                        break;
                    case "сухой":
                        Console.WriteLine($"{word} - dry");
                        break;
                    case "дождь":
                        Console.WriteLine($"{word} - rain");
                        break;
                    case "облачный":
                        Console.WriteLine($"{word} - cloudy");
                        break;
                    case "синоптик":
                        Console.WriteLine($"{word} - weatherman");
                        break;
                    case "снежно":
                        Console.WriteLine($"{word} - snowy");
                        break;
                    default:
                        Console.WriteLine("Неизвестное слово");
                        break;

                }               

                Console.ReadLine();
                Console.WriteLine("Вы хотите продолжить Y/ N, где Y - да N - нет");
                value = Console.ReadLine().ToLower();

            }
            while (value == "да");

            //  ============   4 ЗАДАНИЕ. Проверка числа на четность  =========

            Console.WriteLine();
            Console.WriteLine("4 ЗАДАНИЕ. Проверка числа на четность/ 1 способ");
            int numb;
            Console.WriteLine("Введите любое целое число, затем нажмите Enter:");
            numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.Write($"{numb} - Число четное");                
            }
            else
            {
                Console.Write($"{numb} - Число нечетное");;
            }
          
            Console.WriteLine();
            Console.WriteLine("4 ЗАДАНИЕ. Проверка числа на четность/ 2 способ");
            int numb1;
            Console.WriteLine("Введите любое целое число, затем нажмите Enter:");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((numb1 % 2 == 0) ? $"{numb1} - четное число" : $"{numb1} - нечетное число");

        }
    }



}