public class Atm
{
    public int ru20;
    public int ru50;
    public int ru100;
    public int sum;
    public int bill20 = 20;
    public int bill50 = 50;
    public int bill100 = 100;

    public Atm(int ru20, int ru50, int ru100)
    {
        this.ru20 = ru20;
        this.ru50 = ru50;
        this.ru100 = ru100;
    }
    public void AddMoneyToAtm(int addRu20, int addRu50, int addRu100)
    {
        this.ru20 = ru20 + addRu20;
        this.ru50 = ru50 + addRu50;
        this.ru100 = ru100 + addRu100;
    }
    public void Print() => Console.WriteLine($"Количество купюр по 20р: {ru20}  Количство купюр по 50р: {ru50}  Количство купюр по 100р: {ru100}");
    public void SumAtm(int ru20, int ru50, int ru100, out int sum)
    {
        sum = ru20 * bill20 + ru50 * bill50 + ru100 * bill100;  
        Console.WriteLine($"Денежных средств в банкомате: {sum} ");
    }


    // ---------ПЕРЕДЕЛАТЬ -------
    /*
    public void WithDrowMoneyFromAtm(int money)
    {
        if ((sum - money) >= 0)
        { sum = sum - money; }
        else
        { Console.WriteLine("Недостатчно средств для снятия денег"); }

    }
    */


    public bool WithDrowMoneyFromAtm(int money)
    {
        return sum >= money;

    }

    //public void Print() => Console.WriteLine($"Количество купюр по 20р: {ru20}  Количство купюр по 50р: {ru50}  Количство купюр по 100р: {ru100}");
    //public void PrintSum() => Console.WriteLine($"Денежных средств в банкомате: {SumAtm.sum} ");

}
