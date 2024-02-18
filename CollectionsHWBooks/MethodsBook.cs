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
            if (year.ToString().Length > 4 || year.ToString().Length < 4 || year.ToString().Contains(' '))
            {
                throw new WrongDateException("Некорректная дата");
            }
            try
            {
                books.Add(new Books(author, name, year));
            }
            catch (Exception e) when (e is WrongDateException)
            {
                Console.WriteLine($"Ошибка : {e.Message}");
            }
        }
        public void RemoveBook1(ArrayList books)
        {
            Console.WriteLine("\nУдаление книги из списка \n В базе библиотеки имеются следуюие книги: ");    
            Helper.PrintBooksInfo(books);
            Console.WriteLine("\nВвведите название книги, которую необходимо удалить из списка: ");
            string name = Console.ReadLine();
                int i = 0;
            foreach (Books item in books)
            {
                if (item.Name.Equals(name))
                {
                    Console.WriteLine($"\nКнига для удаления найдена: \n Автор:{item.Author} / Название: {item.Name} / Издательство: {item.Year}");
                    books.Remove(item);
                    break;
                }
                else i++;

                if (i == books.Count) Console.WriteLine($"\nКниг автора {item.Author} нет в библиотеке");
            }           
        }
        public void RemoveBook(ArrayList book)
        {
            book.Remove(book);
        }
       public void SerchBookByAythor(ArrayList books)
        {
            Console.WriteLine("\nВвведите автора книги, которую необходимо найти: ");
            string author = Console.ReadLine();
            int i = 0;
            foreach (Books item in books)
            {
                if (item.Author.Equals(author))
                {
                    Console.WriteLine($"\nКнига найдена: \n Автор:{item.Author} / Название: {item.Name} / Издательство: {item.Year}") ;
                }
                else i++;

                if (i == books.Count) Console.WriteLine($"Книг автора {item.Author} нет в библиотеке");
            }
        }
        public void Exit()
        {
            Console.WriteLine("\nЕсли хотите завершить проограмму введите Y, затем нажмите Enter:\n");
            string q = Convert.ToString(Console.ReadLine());
            if (q == "Y")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Write("\nПрограмма не завершена\n");
            }
        }
    }
}