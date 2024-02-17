using CollectionsHWBooks;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1 Задание. Books.");
        ArrayList books = new ArrayList();
        MethodsBook book = new MethodsBook();
        books.Add(new Books("Мастер и Маргарита", "М.А.Булгаков", 1893));
        books.Add(new Books("Пётр Первый", "А.Н. Толстой", 1877));
        books.Add(new Books("Двенадцать", "А. Блок", 1904));
        books.Add(new Books("Антоновские яблоки", "И.А. Бунин", 1911));
        books.Add(new Books("Гранатовый браслет", "Куприн", 1891));
        book.AddNewBook(books);     // Добавить книгу с консоли
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка
        book.RemoveBook(books);
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка
        book.SerchBookByAythor(books);
    }
}