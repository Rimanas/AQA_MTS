namespace GenericsHomeWork.TaskTwoGenericClass
{
    internal class GenericClass<T>
    {
        public T[] MyArray { get; set; }
        public GenericClass(int lenght) => MyArray = new T[lenght];
        public void PrintArray()
        {
            foreach (var item in MyArray)
                Console.Write(item + " ");

            Console.WriteLine();
        }
        public void AddElement(T element)
        {
            var tmp = new List<T>(MyArray);
            tmp.Add(element);
            MyArray = tmp.ToArray();
        }
        public void DeleteElement(T element)
        {
            if (MyArray.Contains(element))
            {
                List<T> tmp = new(MyArray);
                tmp.Remove(element);
                MyArray = tmp.ToArray();
            }
            else
            {
                Console.WriteLine("Данного элемента нет в массиве");
            }
        }
        public void GetElementByIndex(int index)
        {
            if (index < 0 || index > MyArray.Length - 1)
                Console.WriteLine("Индекс вышел за пределы массива");
            else
                Console.WriteLine($"Индексу {index} соответсвует элемент: {MyArray[index]}");
        }
        public void GetArrayLenght()
        {
            Console.WriteLine($"Длина массива : {MyArray.Length}");
        }

    }
}