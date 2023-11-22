// See https://aka.ms/new-console-template for more information

namespace FerstApp
{
    static class Programm
    {
        static void Main1(string[] args)
        {
            {
                //comment
                /*
                 1 comment
                 2 comment
                 */
                //  =================================        Урок 6   14.11.2023   ==========
                  
                /*    ======   1 part
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Hi!");
                const int MINUTES_IN_HOUR = 60;

                int price = 1000;
                    Console.WriteLine(price);
                string name;
                string Name;

                name = "Peter";
                Console.WriteLine(name);
                name = "Vasya";
                Console.WriteLine(name);

                Console.WriteLine(true);
                Console.WriteLine(false);

                Console.WriteLine(1.24);
                Console.WriteLine(1.24F);

                Console.WriteLine('H');

                Console.WriteLine("It is a \t nice day!");
                Console.WriteLine("It is a \n nice day!");
                Console.WriteLine("It is a '\' nice day!");

                float a = 3.14F;
                float a1 = 3.14F;

                decimal c = 2.4M;


                Console.WriteLine(c);

                var d = 2000;
                var d1 = 3.14F;
                var d2 = 'D';

                Console.WriteLine(d);

                var message = "Hello";
                Console.WriteLine(message);
               
                Console.WriteLine("Добро пожаловать!");
                Console.Write("Надеюсь Вы");
                Console.Write("постигните Си Шарп");
                Console.WriteLine("Все будет Гуд");
                */


               /*   =========   2 part
               
                
                int j;
                j = 20;

                Console.WriteLine("J = " + j);

                string name = "Tom";
                int age = 34;
                double height = 1.7;

                // Этот метод удобнее   вывода сообщения на экран
                Console.WriteLine($"Имя: {name} Возрст: {age} Рост: {height}");
                Console.WriteLine("Имя: {0} Возрст: {2} Рост: {1}", name, height, age);

                Console.WriteLine("Inter your name:");
                string? name1 = Console.ReadLine();   
                Console.WriteLine($"Your name: {name1}");

                Console.WriteLine("Inter your age");
                string? age_str = Console.ReadLine();
                int age1 = Convert.ToInt32(age_str);    
                Console.WriteLine($"Your age: {age1}");



                //Task
                //Create data


                bool isWhiteBreadFresh = true;
                ushort whiteBreadPrice = 150;
                ushort butterPrice = 230;
                ushort milkPrice = 170;
                float milkPercentage = 1.2F;
               */



                /*   ==============================================Урок 16/11/2023
                Console.WriteLine("Write your name");
                string? name = Console.ReadLine();  //здесь знак вопроса позволяет ничего не записывать в поле. и будет иметь значение nullв таком случае
                Console.WriteLine($"Your name: {name}");



                Console.WriteLine("Write your age");
                string? age_str = Console.ReadLine();  //здесь знак вопроса позволяет ничего не записывать в поле. и будет иметь значение nullв таком случае
                int age = Convert.ToInt32(age_str);
                Console.WriteLine($"Your age: {age}");


                switch (x)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    default;
                        Console.WriteLine("not value");
                        break;

                }

                switch (name)
                {
                    case "Alex":
                        Console.WriteLine("Alex");
                        break;
                    case "Tom":
                        Console.WriteLine("Tom");
                        break;
                }

                Console.WriteLine(DoOperation(1));

                // вот это блок основной
                int DoOperation(int x)
                {
                    switch(x)
                    {
                        case 1:
                            return 1; //result будет единица

                        case 2:
                            return 2;
                            default: return 0;
                   }
                }

                int DoOperation1(int x)
                {
                    int result = x switch
                    {
                        1 => 1,
                        2 => 2,
                        _ => 0
                    };
                }

                int DoOperation2(int x) => x switch
                {

                        1 => 1,
                        2 => 2,
                        _ => 0

                };
                */

                /*  =============================================Урок 18/11/2023

                // ==================================================Массивы


                // int[] array = { 1, 9, 3, 6, 5 };    //  array - это имя

                
                int[] array1;
                int n = 4;
                array1 = new int[n];    


                int[] array2 = new int[5] { 1, 9, 3, 6, 5 };

                //Console.WriteLine(array[4]);    // выводит 4 элемент массива  
                //array[0] = 10;                  // присвоить первому элементу массива с индексом 0 значение 10


                Console.WriteLine($"Last item in array: {array[array.Length -1]}");  //Выводит последний элемент
                Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}");  //Выводит последний элемент. !!!!!Самый правильный вариант
                Console.WriteLine($"Last item in array: {array[^2]}");

                //Console.WriteLine(array[array.Length-2]);

                Console.WriteLine("Rank: " + array.Rank);    //  ранк массива - это разрядность массива. если ономерный, то ранк -1
                Console.WriteLine("Lenght: " + array.Length);    //  количество всех элементов
                Console.WriteLine("GetLenght(0): " + array.GetLength(0));    //  количество строк - длина текущей строки . Здесь длина нулевой строки
                Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));    //  Верхний индекс первой (нулевой) строки. Если 5 элементов  (где есть нулевой индекс), то здесь =4
                Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));    //  Нижний индекс строки



                // =========  ======   Циклы    =====

                for (int i = 0; i < array.GetLength(0); i++)  // GetLength - выволит 5
                {
                    Console.Write($"{array[i]}");
                }
                Console.WriteLine(0);

                // другой вариант

                for (int i = 0; i <= array.GetUpperBound(0); i++)  //GetUpperBound - выводит верхний индекс. то есть выведет 4. Если просто < то получим перебор по индексу 0,1,2,3. а у нас 4 карйний индекс
                {
                    Console.Write($"{array[i]}");
                }

                

                //  третий вариант. Нужно пройти по всем элементам массива. Одномерный - здесь


                
                int[] array = { 1, 9, 3, 6, 5 };


                for (int i = 0; i <= array.GetUpperBound(0); i++)  //GetUpperBound - выводит верхний индекс. то есть выведет 4. Если просто < то получим перебор по индексу 0,1,2,3. а у нас 4 карйний индекс
                {
                    array[i] = new Random().Next(100);   // изменили элементы массива
                }

                Console.WriteLine();    

                foreach (int item in array)
                {
                    Console.Write($"{item}");    

                }

                Console.WriteLine();

                




               

                // 10 раз вывести слово HELLO
                for (int i=1; i<=10; i++)
                {
                    Console.WriteLine($"{i} Hello!!");
                }

                Console.WriteLine();

                //Вывести только четные
                //Здесь мы работаем и мы можем поменять значение
                for (int i = 0; i <= 10; i+=2)       // здесь шаг =2
                {
                    Console.WriteLine($"{i}");
                }

                // foreach ничего не меняет. а берет какуе-то последовательность (множество)
                //

                Console.WriteLine();
                string text = "Hello!!!";      // слово - это последовательность (множество) символов
                foreach (char ch in text)
                {
                    Console.Write($"{ch}") ;
                    Console.WriteLine(ch);


                

                /*
                //   ============   ERROR/ так делать не получится=======
                int[] arr1 = new int(6);   // Массив не проиницииализирован, там нет значений.. поэтому здес foreach не получится использовать
                foreach (int item in arr1)
                {
                    item = new Random().Next(10);
                }
                


               
                //Внутри циклов есть 2 операции , которые добавляют логику в них
                // 1. Вывести толко четные 
                // 2. Не выводить число 6

                
                for (int i=0; i<=10;i+=2)
                {
                    if (i != 6)
                    {
                        Console.WriteLine();
                    }
                }

                for (int i = 1; i <= 10; i++)
                {
                    if (i == 5)
                        break;
                    Console.Write($"{i}");
                }

                Console.WriteLine();

                for (int i = 1; i <= 10; i++)
                {
                    if (i == 5)
                        continue;
                    Console.Write($"{i}");
                }

                

                Console.WriteLine();

                //цикл do и while - для повторения опред действий
                // но здесь нет увеличения или уменьшения какой-то переменной
                //здесь только условие какое-то

                
                int u = 6;
                bool flag = true;
                do
                {
                    if (u < 0) flag = false;
                    Console.WriteLine($"{u}");
                    u--;                                // уменьшаем u на  1 единицу
                } while (flag);

                int u1 = 6;
                do
                {
                    Console.WriteLine($"{u1}");
                    u1--;                                // уменьшаем u на  1 единицу
                } while (u >= 0);



                //====================   Двумерный массив   =========================  

                int[,] array3 = new int[4, 5];     // 4 стрроки , в каждой строке 5 элементов. начинаетсчя с 0..0

                Console.WriteLine("Lenght: " + array3.Length);    //  количество всех элементов
                Console.WriteLine("Rank: " + array3.Rank);    //  ранк массива
                Console.WriteLine("GetLenght(0): " + array3.GetLength(0));    //  количество строк
                Console.WriteLine("GetUpperBound(0): " + array3.GetUpperBound(0));    //  Верхний индекс строки
                Console.WriteLine("GetLenght(1): " + array3.GetLength(1));    //  количество столбцов

                Console.WriteLine("GetUpperBound(1): " + array3.GetUpperBound(1));    //  Верхний индекс столбцов
                Console.WriteLine("GetLowerBound(0): " + array3.GetLowerBound(0));    //  Нижний индекс строки
                Console.WriteLine("GetLowerBound(1): " + array3.GetLowerBound(1));    //  Нижний индекс столбцов

                Console.WriteLine("======");



                int t = 1;
                //Задание значений

                for (int i = 0; i < array3.GetLength(0); i++)
                {
                    for (int j = 0; j < array3.GetLength(1); j++)
                    {
                        array3[i, j] = i + j;
                    }
                    Console.WriteLine();
                }

                int rows = array3.GetLength(0);        // считает количество стррок
                int columns = array3.GetLength(1);
                //int columns = array3.GetLength / rows;           // считает количество колонок

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{array3[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                foreach (int item in array3)
                {
                    Console.Write($"{item}");
                }

                */


                /////  ============ ===================================    УРОК 9     21.11.2023   =========

                ////   ====    Трехмерный массив  =====


                /*

                int[,,] array3D = new int[,,]
{
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    },
    {
        { 7, 8, 9 },
        { 10, 11, 12 }
    }
};

                Console.WriteLine("Length: " + array3D.Length);                       // количество всех элементов
                Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
                Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
                Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
                Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
                Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
                Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
                Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

                Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
                Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
                Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов
               
                for (int i = 0; i <= array3D.GetUpperBound(0); i++)
                {
                    Console.WriteLine($"-========= Level {i} ==========-");
                    for (int j = 0; j <= array3D.GetUpperBound(1); j++)
                    {
                        for (int k = 0; k <= array3D.GetUpperBound(2); k++)
                        {
                            Console.Write($"{array3D[i, j, k]} \t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"-============================-");
               
                }
                */


                /// ========    Зубчатые массивы    =====


                int[][] numbers =
{
    new int[] { 1, 2 },
    new int[] { 1, 2, 3, 4, 5 },
    new int[] { 1, 2, 3 }
};


                foreach (int[] row in numbers)
                {
                    for (int i = 0; i < row.Length; i++)
                    {
                        row[i] = new Random().Next(100);
                    }
                }

                for (int i = 0; i <= numbers.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
                    {
                        Console.Write($"{numbers[i][j]} \t");
                    }

                    Console.WriteLine();
                }



            }
        }
    }
}



