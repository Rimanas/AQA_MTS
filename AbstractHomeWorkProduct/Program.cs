namespace AbstractHomeWorkProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseProduct> products = new List<BaseProduct>()
        {
            new Product("Хлеб", 40.4, new DateOnly(2024, 02, 10), new DateOnly(2024, 02, 12) ),
            new Product("Молоко", 36, new DateOnly(2024, 01, 22), new DateOnly(2024, 02, 10) ),
            new Product("Чай", 100, new DateOnly(2023, 11, 25), new DateOnly(2024, 11, 25) ),
            new Product("Сыр", 650, new DateOnly(2024, 02, 02), new DateOnly(2024, 04, 01) ),
            new Product("Бананы", 130, new DateOnly(2024, 02, 02), new DateOnly(2024, 03, 11) )
        };
            foreach (BaseProduct product in products ) 
            {
                product.DisplayInformation();
            }
            foreach (BaseProduct product in products)
            {
                if (product.IsExpiredDate())
                {
                    Console.Write("\nПросроченный товар: \n");
                    product.DisplayInformation();
                }
            }
            Console.WriteLine("\n Партии товаров: \n");
            List<BaseProduct> batchs = new List<BaseProduct>()
        {
            new BatchOfProduct("Хлеб", 10, 404, new DateOnly(2024, 02, 10), new DateOnly(2024, 02, 12) ),
            new BatchOfProduct("Молоко", 20, 720, new DateOnly(2024, 01, 22), new DateOnly(2024, 02, 10) ),         
        };
            foreach (BaseProduct batch in batchs)
            {
                batch.DisplayInformation();
            }
            foreach (BaseProduct batch in batchs)
            {
                if (batch.IsExpiredDate())
                {
                    Console.Write("\nПросроченная партия товаров: \n");
                    batch.DisplayInformation();
                }
            }
            Console.WriteLine("\n Комплекты: \n");
            List<BaseProduct> sets = new List<BaseProduct>()
        {
            new SetOfProduct("Канцелярия", 100, "Карандаши цветные" ),
            new SetOfProduct("Набор для душа", 700.99, "Гель для душа, Шампунь, Мыло"),
        };
            foreach (BaseProduct set in sets)
            {
                set.DisplayInformation();
            }
        }
    }
}

