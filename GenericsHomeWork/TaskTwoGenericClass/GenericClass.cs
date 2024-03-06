using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomeWork.TaskTwoGenericClass
{
    internal class GenericClass<T>
    {
        private T[] array;
        int sizeArray;  //размер массива
        public void Add(T element)
        {
            var tmp = new List<T>(array);
            tmp.Add(element);
            array = tmp.ToArray();
        }
    }
}
