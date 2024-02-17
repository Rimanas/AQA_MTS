using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CollectionsHWBooks
{
    internal class MethodsBook
    {
        public void AddNewBook(ArrayList books)
        {
            Console.WriteLine("Ввведите название книги");
            string name = Console.ReadLine();
            Console.WriteLine("Ввведите автора книги");
            string author = Console.ReadLine();
            Console.WriteLine("Ввведите год издания книги");
            int year = Convert.ToInt32(Console.ReadLine());
        }
    }
}