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
        Helper.PrintInventoryInfo(goods);
        Helper.PrintInventoryInfo1(goods);
        MethodsInventory.AddNewGood(goods);
        Helper.PrintInventoryInfo(goods);
        Helper.PrintInventoryInfo1(goods);
        MethodsInventory.SerchGoodById(goods);
    }
}