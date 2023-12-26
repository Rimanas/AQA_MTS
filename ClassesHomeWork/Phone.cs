
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Phone
{
    public long number;
    public string model;
    public string name;
    public int weight;
    //public string name;
    //конструтор без параметров
    public Phone() { number = 89000000000; model = "Nokia"; weight = 100; }

    /*
    //конструктор с двумя параметрами
    public Phone(long number, string model)
    {
        this.number = number;
        this.model = model;
        weight = 100;
    }
    */
    

    // вызов 2 конструктора из 3 конгструктора
    public Phone(long number, string model) : this(number, model, 100) { }

    // 3 конструктор c тремя параметрами
    public Phone(long number, string model, int weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }



public void ReceiveCall (string name)
        {
        Console.WriteLine($"Звонит: {name}");
        }

    public long GetNumber(long number)
    {
        return number;
    }
    // или другой вариант, сразу возвращать нужный номер
    public long GetNumber1()
    {
        return 89600426000;
    }


    public void SendMessage(params long[] numbers)
    {
        Console.WriteLine("Номера телефонов, которым будет отправлено сообщение:");
        for (long i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Номер телефона  = " + numbers[i]);
        }
    }

    


}
