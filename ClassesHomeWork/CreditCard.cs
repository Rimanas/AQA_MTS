using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

public class CreditCard
{
    public long invoiceNumber;
    public double currentSum;
    public CreditCard(long invoiceNumber, double currentSum)
    {
        this.invoiceNumber = invoiceNumber;
        this.currentSum = currentSum;
    }

    public void AddMoneyToCard(double addMoney)
    {
        this.currentSum = this.currentSum + addMoney;
    }

    public void WithDrowMoneyFromCard(double withDrowMoney)
    {
        this.currentSum = this.currentSum - withDrowMoney;
    }

    public void Print() => Console.WriteLine($"Номер Счёта: {invoiceNumber}  Сумма на карте: {currentSum}");

}
