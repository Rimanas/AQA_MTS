namespace AbstractHomeWorkProduct
{
    public class BatchOfProduct : BaseProduct
    {
        public int Amount;
        public BatchOfProduct(string name, int amount, double price, DateOnly dateOfManufacture, DateOnly expirationDate) :
            base(name, price, dateOfManufacture, expirationDate)
        {
            Amount = amount;
        }
        public override void DisplayInformation()
        {
            Console.WriteLine($"Партия: {Name}, Количество партий: {Amount}, Цена: {Price}," +
                $" Изготовлен {DateOfManufacture}, Срок годности до: {ExpirationDate}"); ;
        }
        public override bool IsExpiredDate()
        {
            return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate; ;
        }
    }
}
