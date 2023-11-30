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
            int[] array = new int[j];

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0,1000);
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
            
            Console.WriteLine("1 ЗАДАНИЕ. Удаление всех вхождений заданного числа из массива. Создание нового массива");
            Console.WriteLine();
            Console.WriteLine("Есть массив целых чисел");

            int number1;
            int j1;
            Console.WriteLine("Задайте размер массива, затем нажмите Enter:");
            j1 = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine(String.Join(",", array1));
            }
            else
            {
                Console.WriteLine($"Число {number1} не принадлежит массиву чисел");
            }
            Console.WriteLine();

        }
    }
}