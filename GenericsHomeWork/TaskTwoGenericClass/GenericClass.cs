using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericsHomeWork.TaskTwoGenericClass
{
    internal class GenericClass<T>
    {


        private T[] Arr { get; set; }
       // public GenericClass(int length) => Arr = new T[length];
        public void Insert(ref T[] arr, T elment, int index)
        {
            T[] newArr = new T[arr.Length+1];
            newArr[index] = elment;
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i]; 
        }

        public T[] MyArray { get; set; }
        public GenericClass(int lenght) => MyArray = new T[lenght];
        public void AddElement(T element)
        {
            var tmp = new List<T>(MyArray);
            tmp.Add(element);
            MyArray = tmp.ToArray();
        }

        public void PrintArray()
        {
            foreach (var item in MyArray)
                Console.Write(item + " ");

            Console.WriteLine();
        }

    }
}
