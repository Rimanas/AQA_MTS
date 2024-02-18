using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CollectionsHWInventory
{
    internal class MethodsInventory
    {
        public static void AddNewGood(Dictionary<Guid, InventoryOfGoods> goods)
        {
            Guid id = Guid.NewGuid();
            Console.WriteLine("Добавление товара в список\n");
            Console.WriteLine("Ввведите назание товара, который необходимо добавить в список");
            string name = Console.ReadLine();
            Console.WriteLine("Ввведите цену товара");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите количество товара");
            int count = Convert.ToInt32(Console.ReadLine());
            try
            {
                goods.Add(id, new InventoryOfGoods(name, price, count));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка : {e.Message}");
            }
        }
        public static void SerchGoodById(Dictionary<Guid, InventoryOfGoods> goods)
        {
            Console.WriteLine("\nВвведите id товара, который необходимо найти: ");
            Guid id = new Guid(Console.ReadLine());
            int i = 0;
            foreach (var item in goods)
            {
                if (item.Key.Equals(id))
                {
                    Console.WriteLine($"\nТовар найден: {item.Value}");
                }
                else i++;

                if (i == goods.Count) Console.WriteLine($"Книг автора {item.Key} нет в библиотеке");
            }
        }
    }
}
