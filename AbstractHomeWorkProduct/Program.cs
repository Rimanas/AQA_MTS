namespace AbstractHomeWorkProduct
{
    class Program
    {
        List<BaseProduct> products = new List<BaseProduct>()
        {
            new Product("Хлеб", 40.4, new DateOnly(2024, 02, 10), new DateOnly(2024, 02, 12) ),
            new Product("Молоко", 36, new DateOnly(2024, 02, 10), new DateOnly(2024, 02, 17) ),
            new Product("Чай", 100, new DateOnly(2023, 11, 25), new DateOnly(2024, 11, 25) ),
            new Product("Сыр", 650, new DateOnly(2024, 02, 02), new DateOnly(2024, 04, 01) ),
            new Product("Бананы", 130, new DateOnly(2024, 02, 02), new DateOnly(2024, 03, 11) )
        };
    }
}

