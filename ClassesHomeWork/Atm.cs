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

    public bool WithDrowMoneyFromAtm(int money)
    {
        return sum >= money;

    }

    // метод очень грубый: не учитывает , что нет необходимого количества купюр,
    // не учитывает сумму , которая не кратна имеющимся купюрам 
    public void CalculateNotes(int money, ref int ru20, ref int ru50, ref int ru100)
    {
        int ostatok1 = money % bill100;
        ru100 = (money - ostatok1) / bill100;
        int ostatok2 = ostatok1 % bill50;
        ru50 = (ostatok1 - ostatok2) / bill50;
        int ostatok3 = ostatok2 % bill20;
        ru20 = (ostatok2 - ostatok3) / bill20;
        Console.WriteLine($"Купюр по 100 : {ru100} , Купюр по 50 : {ru50}, Купюр по 20 : {ru20}");
    }


}
