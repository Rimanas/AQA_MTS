using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWBooks
{
    internal class Helper
    {
        public static void PrintBooksInfo(System.Collections.IList book)
        {
            foreach (Books item in book)
            {
                Console.WriteLine($"Автор:{item.Author} / Название: {item.Name} / Издательство: {item.Year}");
            }
        }
    }
}