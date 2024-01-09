using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

public class CreditCard
{
    public long invoiceNumber;
    public double balans;
    public CreditCard(long invoiceNumber, double balans)
    {
        this.invoiceNumber = invoiceNumber;
        this.balans = balans;
    }

    public void AddMoneyToCard(double addMoney)
    {
        this.balans = this.balans + addMoney;
    }

    public void WithDrowMoneyFromCard(double withDrowMoney)
    {
        if ((this.balans - withDrowMoney) >= 0)
        { this.balans = this.balans - withDrowMoney; }
        else 
        { Console.WriteLine("Недостатчоно средств на карте для снятия денег"); }
        
    }


    public void Print() => Console.WriteLine($"Номер Счёта: {invoiceNumber}  Сумма на карте: {balans}");

}
