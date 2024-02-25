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
                    Console.WriteLine($"\nТовар найден: {item.Key} , {item.Value}");
                }
                else i++;

                if (i == goods.Count) Console.WriteLine($"Товара с id = {item.Key} нет.");
            }
        }
        public static void RemoveGood(Dictionary<Guid, InventoryOfGoods> goods)
        {
            Console.WriteLine("\nУдаление товара из списка \n В базе имеются следуюие товары: ");
            Helper.PrintInventoryInfo(goods);
            Console.WriteLine("\nВвведите название товара, который необходимо удалить из списка: ");
            string name = Console.ReadLine();
            int i = 0;
            foreach (var item in goods)
            {
                if (item.Value.Name.Equals(name))
                {
                    Console.WriteLine($"\nТовар для удаления найден: \n Идентификтор:{item.Key} / Товар: {item.Value}");
                    goods.Remove(item.Key);
                    break;
                }
                else i++;

                if (i == goods.Count) Console.WriteLine($"\nТовара {item.Value} нет");
            }
        }
        public static void UpdateGoods(Dictionary<Guid, InventoryOfGoods> goods)
        {
            Console.WriteLine("\nОбновление товара \n В базе имеются следуюие товары: ");
            Helper.PrintInventoryInfo(goods);
            Console.WriteLine("\nВвведите id товара, который необходимо обновить: ");
            Guid id = new Guid(Console.ReadLine());
            int i = 0;
            foreach (var item in goods)
            {
                if (item.Key.Equals(id))
                {
                    Console.WriteLine($"\nТовар найден: {item.Key} , {item.Value}");
                    Console.WriteLine("" +
                        "Что необходимо обновиь?:\n" +
                        " 1 - Название товара\n" +
                        " 2 - Цену товара\n" +
                        " 3 - Количество ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Обновление названия. Введите новое значение названия:");
                            item.Value.Name = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Обновление Цены. Введите новое значение Цены:");
                            item.Value.Price = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Обновление Количества товара. Введите новое значение:");
                            item.Value.Count = Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Номер характеристики указан не верно");
                            break;
                    }
                    Console.WriteLine($"Измененный товар:\n " +
                        $"Название: {item.Value.Name} , " +
                        $"Цена: {item.Value.Price} , " +
                        $"Количество: {item.Value.Count} ");
                }
                else i++;

                if (i == goods.Count) Console.WriteLine($"Товара с id = {item.Key} нет.");
            }
        }
    }
}