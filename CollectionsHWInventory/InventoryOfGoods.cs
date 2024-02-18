using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWInventory
{
    internal class InventoryOfGoods
    {
        string name;
        double price;
        int count;
        public InventoryOfGoods(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public override string? ToString()
        {
            return string.Format($"Название: {Name}, Цена: {Price}, Количество: {Count}", Name, Price, Count);
        }
    }
}
