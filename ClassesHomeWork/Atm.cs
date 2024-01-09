public class Atm
{
    public int numberOfBill20;
    public int numberOfBill50;
    public int numberOfBill100;
    public double bill20 = 20.00;
    public double bill50 = 50.00;
    public double bill100 = 100.00;

    //public double sumAtm = numberOfBill20 * bill20;

    public Atm(int numberOfBill20, int numberOfBill50, int numberOfBill100)
    {
        this.numberOfBill20 = numberOfBill20;
        this.numberOfBill50 = numberOfBill50;
        this.numberOfBill100 = numberOfBill100;
    }
    public void AddMoneyToAtm(int addNumberOfBill20, int addNumberOfBill50, int addNumberOfBill100)
    {
        this.numberOfBill20 = numberOfBill20+ addNumberOfBill20;
        this.numberOfBill50 = numberOfBill50+ addNumberOfBill50;
        this.numberOfBill100 = numberOfBill100+ addNumberOfBill100;
    }
    public void Print() => Console.WriteLine($"Количство купюр по 20р: {numberOfBill20}  Количство купюр по 50р: {numberOfBill50}  Количство купюр по 100р: {numberOfBill100}");
    
    
}
