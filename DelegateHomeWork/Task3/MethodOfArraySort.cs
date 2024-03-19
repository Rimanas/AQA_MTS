using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.Task3
{
    public class MethodOfArraySort
    {
        //Создание рандомного массива
        public int[] MethodOfArrayCreate()
        {
            int lenght = new Random().Next(5, 15);
            int[] array = new int[lenght];
            Random random = new Random();
            for (int y = 0; y < lenght; y++)
            {
                array[y] = random.Next(-10, 10);
            }
            return array;
        }

        //Пузырьковая Сортировка
        public int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
        /*Сортировка Шелла.
         * При сортировке Шелла сначала сравниваются и сортируются между собой значения, 
         * стоящие один от другого на некотором расстоянии d (о выборе значения d). 
         * После этого процедура повторяется для некоторых меньших значений d, 
         * а завершается сортировка Шелла упорядочиванием элементов при d=1 
         * (то есть обычной сортировкой вставками). 
         * Эффективность сортировки Шелла в определённых случаях обеспечивается тем, 
         * что элементы «быстрее» встают на свои места (в простых методах сортировки, например, 
         * пузырьковой, каждая перестановка двух элементов уменьшает количество инверсий в списке
         * максимум на 1, а при сортировке Шелла это число может быть больше).
         */
        public int[] ShellSort(int[] array)
        {
            int step = array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int value = array[i];
                    for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                        array[j + step] = array[j];
                    array[j + step] = value;
                }
                step /= 2;
            }
            return array;
        }
        // Метод вывода массива

        public void PrintArray(int[] array)
        {
            //Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}