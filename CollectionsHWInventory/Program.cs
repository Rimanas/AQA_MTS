using CollectionsHWInventory;
using System.Collections;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("2 Задание. Inventory.");
        //MethodsInventory method = new MethodsInventory();
        Dictionary<Guid, InventoryOfGoods> goods = new Dictionary<Guid, InventoryOfGoods>
        {
            { Guid.NewGuid(), new InventoryOfGoods("Лыжи", 5400, 100) },
            { Guid.NewGuid(), new InventoryOfGoods("Ботинки для лыж", 3600, 99) },
            { Guid.NewGuid(), new InventoryOfGoods("Палки для лыж", 900 , 80) },
            { Guid.NewGuid(), new InventoryOfGoods("Чехол для палок", 140, 55) },
            { Guid.NewGuid(), new InventoryOfGoods("Мяч футбольный", 6000, 25) }
        };
        Helper.PrintInventoryInfo(goods);       // Выводим первоначальный список товаров
        Helper.PrintInventoryInfo1(goods);      // Выводим первоначальный список товаров  (2 способ реализации)
        MethodsInventory.AddNewGood(goods);     // Добавим новый товар
        MethodsInventory.AddNewGood(goods);     // Добавим еще один новый товар
        Helper.PrintInventoryInfo(goods);       // Выводим список товаров с новым товаром
        MethodsInventory.SerchGoodById(goods);  // Поиск товара по id
        MethodsInventory.RemoveGood(goods);     // Удаление товара
        Console.WriteLine("\n Список товаров после уаления:\n");
        Helper.PrintInventoryInfo(goods);       // Выводим список товаров после удаления
        MethodsInventory.UpdateGoods(goods);
        Helper.PrintInventoryInfo(goods);       // Выводим список товаров после обновления
    }
}