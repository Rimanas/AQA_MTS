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
            Console.WriteLine("Добавление книги в список");
            Console.WriteLine("Ввведите автора книги");
            string author = Console.ReadLine();
            Console.WriteLine("Ввведите название книги");
            string name = Console.ReadLine();;
            Console.WriteLine("Ввведите год издания книги");
            int year = Convert.ToInt32(Console.ReadLine());
            try
            {
                books.Add(new Books(author, name, year));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка : {e.Message}");
            }
        }
        public void RemoveBook1(ArrayList books)
        {
            Console.WriteLine("Удаление книги из списка");
            Console.WriteLine("Ввведите название книги");
            string name = Console.ReadLine();
            try
            {
                foreach (Books item in books)
                    if (item.Name.Equals(name))
                    {
                        books.Remove(books);
                       
                    }
                    else
                    {
                        Console.WriteLine($"Книги с названием {name} не найдено");
                        break;
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка удаления: {e.Message}");
            }

        }
        public void RemoveBook(ArrayList books)
        {
            books.Remove(books);
        }


        public void SerchBookByAythor(ArrayList books)
        {
            Console.WriteLine("Ввведите автора книги");
            string author = Console.ReadLine();
            int count = 0;
            foreach (Books item in books)
            {
                if (item.Author.Equals(author))
                {
                    Console.WriteLine($"Автор:{item.Author} / Название: {item.Name} / Издательство: {item.Year}") ;
                }
                else count++;

                if (count == books.Count) Console.WriteLine($"Книг автора {item.Author} нет в библиотеке");
            }
        }
    }
}