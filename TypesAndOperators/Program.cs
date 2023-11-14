// See https://aka.ms/new-console-template for more information
{
    //comment
    /*
     1 comment
     2 comment
     */
    /*
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

    float a = 3.14F;
    float a1 = 3.14F;

    decimal c = 2.4M;

    Console.WriteLine(c);

    var d = 2000;
    Console.WriteLine(d);

    var message = "Hello";

    Console.WriteLine(message);
    */

    Console.WriteLine("Добро пожаловать!");
    Console.Write("Надеюсь Вы");
    Console.Write("постигните Си Шарп");
    Console.WriteLine("Все будет Гуд");

    //Task
    //Create data

    bool isWhiteBreadFresh = true;
    ushort whiteBreadPrice = 150;
    ushort butterPrice = 230;
    ushort milkPrice = 170;
    float milkPercentage = 1.2F;


    /*
    int j;
    j = 20;

    Console.WriteLine("J = " + j);

    string name = "Tom";
    int age = 34;
    double height = 1.7;

    // Этот метод удобнее
    Console.WriteLine($"Имя: {name} Возрст: {age} Рост: {height}");

    Console.WriteLine("Имя: {0} Возрст: {2} Рост: {1}", name, height, age);
    */


    Console.WriteLine("Write your name");
    string? name = Console.ReadLine();  //здесь знак вопроса позволяет ничего не записывать в поле. и будет иметь значение nullв таком случае
    Console.WriteLine($"Your name: {name}");

    
    
    Console.WriteLine("Write your age");
    string? age_str = Console.ReadLine();  //здесь знак вопроса позволяет ничего не записывать в поле. и будет иметь значение nullв таком случае
    int age = Convert.ToInt32(age_str);
    Console.WriteLine($"Your age: {age}");

}

