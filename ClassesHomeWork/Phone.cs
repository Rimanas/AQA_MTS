
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Phone
    {
    long number;
    string model;
    int weight;
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


}
