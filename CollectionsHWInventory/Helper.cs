using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CollectionsHWInventory
{
    internal class Helper
    {
        public static void PrintInventoryInfo(Dictionary<Guid, InventoryOfGoods> dictionary)
        {
            Console.WriteLine("\nСписок всех товаров в магазине, включая название, цену и количество на складе:");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void PrintInventoryInfo1(Dictionary<Guid, InventoryOfGoods> dictionary) 
        {
            Console.WriteLine("\nСписок всех товаров в магазине (2 способ):");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} , {item.Value}");
            }
        }
    }
}