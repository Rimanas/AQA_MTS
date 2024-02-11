using System;
using System.Collections.Generic;
namespace AbstractHomeWorkProduct
{
    public class SetOfProduct : BaseProduct
    {
        public string ListofProducts;
        public SetOfProduct(string name,double price, string listOfProducts) :
            base(name, price)
        {
            ListofProducts = listOfProducts;
        }
        public override void DisplayInformation()
        {
            Console.WriteLine($"Комплект: {Name}, Цена: {Price},Перечень: {ListofProducts}");
        }
        public override bool IsExpiredDate()
        {
            throw new NotImplementedException();
        }
    }
}
