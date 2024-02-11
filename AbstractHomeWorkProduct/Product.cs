﻿namespace AbstractHomeWorkProduct
{
    public class Product : BaseProduct
    {
        public Product(string name, double price, DateOnly dateOfManufacture, DateOnly expirationDate) :
            base(name, price, dateOfManufacture, expirationDate)
        {
        }
        public override void DisplayInformation()
        {
            Console.WriteLine($"Наименование товара: {Name}, Цена: {Price}," +
                $" Изготовлен {DateOfManufacture}, Срок годности до: {ExpirationDate}"); ;
        }
        public override bool IsExpiredDate()
        { 
            return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate; ;
        }
    }
}
