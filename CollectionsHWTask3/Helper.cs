using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHWTask3
{
    internal class Helper
    {
        public static void Print(IEnumerable collection)
        {
            foreach (int item in collection)
            {
                Console.Write($"{item} ");
            }
        }
    }
}