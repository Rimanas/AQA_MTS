using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArraysHomeWork
{
    class Programm
    {
        static void Main(string[] args)
        {
            //=================  1 ЗАДАНИЕ. Проверка принадлежности числа массиву целых чисел ===========

            Console.WriteLine("1 ЗАДАНИЕ. Проверка принадлежности числа массиву целых чисел");
            Console.WriteLine();
            Console.WriteLine("Есть массив целых чисел");

            int number;
            int j;
            Console.WriteLine("Задайте размер массива, затем нажмите Enter:");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш массив");
            int[] array = new int[j];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 1000);
            }
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + "");
            Console.WriteLine();
            Console.WriteLine("Введите любое целое число, затем нажмите Enter:");
            number = Convert.ToInt32(Console.ReadLine());
            if (array.Contains(number))
            {
                Console.WriteLine($"Число {number} принадлежит массиву чисел");
            }
            else
            {
                Console.WriteLine($"Число {number} не принадлежит массиву чисел");
            }
            Console.WriteLine();

            //======= 2 ЗАДАНИЕ. Удаление всех вхождений заданного числа из массива. Создание нового массива ===========

            Console.WriteLine("2 ЗАДАНИЕ. Удаление всех вхождений заданного числа из массива. Создание нового массива");
            Console.WriteLine();
            Console.WriteLine("Есть массив целых чисел");

            int number1;
            int j1;
            Console.WriteLine("Задайте размер массива, затем нажмите Enter:");
            j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш массив");
            int[] array1 = new int[j1];


            for (int i1 = 0; i1 < array1.Length; i1++)
            {
                array1[i1] = new Random().Next(0, 10);
            }
            for (int i1 = 0; i1 < array1.Length; i1++)

                Console.WriteLine(array1[i1] + "");

            Console.WriteLine();
            Console.WriteLine("Введите любое целое число, затем нажмите Enter:");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (array1.Contains(number1))
            {
                array1 = array1.Where(e => e != number1).ToArray();
                Console.WriteLine("Новый массив");
                Console.WriteLine(string.Join(",", array1));
            }
            else
            {
                Console.WriteLine($"Число {number1} не принадлежит массиву чисел");
            }
            Console.WriteLine();

            //======= 3 ЗАДАНИЕ. Нахождение  max, min, avg значений рандомного массива чисел  ===========

            Console.WriteLine("3 ЗАДАНИЕ. Нахождение  max, min, avg значений рандомного массива чисел");
            Console.WriteLine();
            Console.WriteLine("Создайте массив случайных чисел от 10 до 50");

            int size;
            Console.WriteLine("Задайте размер массива, затем нажмите Enter:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш массив");
            int[] array2 = new int[size];
            for (int k = 0; k < array2.Length; k++)
            {
                array2[k] = new Random().Next(10, 50);
            }
            for (int k = 0; k < array2.Length; k++)

                Console.WriteLine(array2[k] + "");
            //Array.Sort(array2);

            // Ручная сортировка
            int temp;
            for (int k = 0; k < array2.Length - 1; k++)
            {
                for (int n = k + 1; n < array2.Length; n++)
                {
                    if (array2[k] > array2[n])
                    {
                        temp = array2[k];
                        array2[k] = array2[n];
                        array2[n] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int k = 0; k < array2.Length; k++)
            {
                Console.WriteLine(array2[k]);
            }

            int avg = array2.Length / 2;
            Console.WriteLine(avg);
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива: {array2[0]}");
            Console.WriteLine($"Максимальный элемент массива:{array2[array2.GetUpperBound(0)]}");

            if (size % 2 == 1)
            {
                Console.WriteLine($"Средний элемент ОТСОРТИРОВАННОГО массива:{array2[avg]}");

            }
            else
            {
                Console.WriteLine("Средние элементы ОТСОРТИРОВАННОГО массива:");
                Console.WriteLine(array2[avg-1]);
                Console.WriteLine(array2[avg]);
            }
            Console.WriteLine();

            //======= 4 ЗАДАНИЕ. Сравнение среднего арифмитического двух массивов  ===========

            Console.WriteLine("4 ЗАДАНИЕ. Сравнение среднего арифмитического двух массивов");
            Console.WriteLine();
            int[] arr1 = new int[5];
            for (int y = 0; y < 5; y++)
            {
                arr1[y] = new Random().Next(0, 10);
            }
            int[] arr2 = new int[5];
            for (int y = 0; y < 5; y++)
            {
                arr2[y] = new Random().Next(0, 10);
            }

            int summ1 = 0;
            int summ2 = 0;

            Console.WriteLine("Первый массив : ");
            var s1 = string.Join(" ", arr1);
            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine("Второй массив : ");
            var s2 = string.Join(" ", arr2);
            Console.WriteLine(s2);
            Console.WriteLine();

            Console.WriteLine("Среднее арифмитическое Первого массива : ");
            for (int i = 0; i < arr1.Length; i++)
                summ1 += arr1[i];
            int avg1 = summ1 / arr1.Length;
            Console.WriteLine(avg1);

            Console.WriteLine();
            Console.WriteLine("Среднее арифмитическое Второго массива : ");
            for (int i = 0; i < arr2.Length; i++)
                summ2 += arr2[i];
            int avg2 = summ2 / arr2.Length;
            Console.WriteLine(avg2);
            if (avg1 > avg2)
            {
                Console.WriteLine("Среднее арифметическое 1 массива больше, чем 2 массива");
            }
            else if (avg2 > avg1)
            {
                Console.WriteLine("Среднее арифметическое 2 массива больше, чем 1 массива");
            }
            else {
                Console.WriteLine("Среднее арифметическое двух массивов равно!");

            }



            //======= 5 ЗАДАНИЕ. Создание массива из случайных чисел. Создание массива только из четных элементв  ===========

            Console.WriteLine("5 ЗАДАНИЕ. Создание массива из случайных чисел. Создание массива только из четных элементв");
            Console.WriteLine();
            Console.WriteLine("Создайте массив из случайных чисел");

            int sizeArr;
            int newSizeArr = 0;
            int even = 0;
            int numb1 = 5;
            int numb2 = 10;
            Console.WriteLine("Задайте размер массива, затем нажмите Enter:");
            sizeArr = Convert.ToInt32(Console.ReadLine());
             
            //Условие, удовлетворяющее размерности массива 
            do
            {


                if (sizeArr > numb1 && sizeArr <= numb2)
                {
                    Console.WriteLine("Ваш массив");
                    int[] array5 = new int[sizeArr];
                    for (int i = 0; i < array5.Length; i++)
                    {
                        array5[i] = new Random().Next(0, 50);
                    }
                    for (int i = 0; i < array5.Length; i++)

                        Console.WriteLine(array5[i] + "");


                    Console.WriteLine("Массив из четных элементов массива:");

                    for (int i = 0; i < array5.Length; i++)
                    {
                        if (array5[i] % 2 == 0)
                        {
                            newSizeArr++;

                        }
                    }
                    int[] newArray5 = new int[newSizeArr];
                    for (int i = 0, x = 0; i < array5.Length; i++)
                    {
                        if (array5[i] % 2 == 0)
                        {
                            newArray5[x++] = array5[i];
                        }
                    }
                    Console.WriteLine(string.Join(",", newArray5));

                    break;
                }
                else
                {
                    Console.WriteLine("Размер массива должен быть больше 5 и меньше или равно 10");
                }
                Console.WriteLine("Задайте размер массива, затем нажмите Enter:");
                sizeArr = Convert.ToInt32(Console.ReadLine());
            }
            while (true);

            //======= 7 ЗАДАНИЕ. Создание массива произвольных имен людей. Сортировка ===========

            Console.WriteLine("7 ЗАДАНИЕ. Создание массива произвольных имен людей. Сортировка ");
            Console.WriteLine();
            Console.WriteLine("Массив из случайных имен");
            string[] people = { "Alan", "Samanta", "Daril", "Tommy", "Kate", "Bob" };
            foreach (string str in people)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            // Сортировка массива имен 
            Console.WriteLine("Отсортированный массив имен");
            Array.Sort(people);

            foreach (string sortPeople in people)
            {
                Console.Write(sortPeople + " ");
            }

        }


        



    }
        
}