using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork.Task3
{
    public class Task3
    {
        MethodOfArraySort methods = new MethodOfArraySort();
        public delegate int[] MethodsOfSort(int[] array);
        MethodsOfSort SelectMethodSort(TypesOfSort typesOfSort)
        {
            switch (typesOfSort)
            {
                case TypesOfSort.BubbleSort:
                    return methods.BubbleSort;
                case TypesOfSort.ShellSort:
                    return methods.ShellSort;
                default: throw new NotImplementedException("Несуществующий тип сортировки");
            }
        }
        public void RunMethodOfArraySort()
        {
            int[] arrayForSort1 = methods.MethodOfArrayCreate();
            int[] arrayForSort2 = methods.MethodOfArrayCreate();
            Console.WriteLine("\n3 Задание. Сортировка");
            Console.WriteLine("\nМассив до сортировки (для 1 метода - сортировка Пузырьком):");
            methods.PrintArray(arrayForSort1);
            MethodsOfSort bubbleSort = SelectMethodSort(TypesOfSort.BubbleSort);
            bubbleSort(arrayForSort1);
            Console.WriteLine("\nМассив после сортировки - сортировка Пузырьком:");
            methods.PrintArray(arrayForSort1);
            Console.WriteLine("\nМассив до сортировки (для 2 метода - сортировка Шелла):");
            methods.PrintArray(arrayForSort2);
            MethodsOfSort shellSort = SelectMethodSort(TypesOfSort.ShellSort);
            shellSort(arrayForSort2);
            Console.WriteLine("\nМассив после сортировки - сортировка Шелла:");
            methods.PrintArray(arrayForSort2);

        }
    }
}