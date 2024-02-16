using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWBooks
{
    internal class Helper
    {
        public static void PrintBooksInfo(System.Collections.IList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}