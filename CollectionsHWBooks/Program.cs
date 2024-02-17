using CollectionsHWBooks;
using System.Collections;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("1 Задание. Books.");
        ArrayList books = new ArrayList();
        MethodsBook method = new MethodsBook();
        ArrayList bookDelete = new("Delete", "Delete", 2005);
        books.Add(new Books("М.А.Булгаков", "Мастер и Маргарита", 1893));
        books.Add(new Books("А.Н. Толстой", "Пётр Первый", 1877));
        books.Add(new Books("А. Блок", "Двенадцать", 1904));
        books.Add(new Books("И.А. Бунин", "Антоновские яблоки", 1911));
        books.Add(new Books("Куприн", "Гранатовый браслет", 1891));
        method.AddNewBook(books);     // Добавить книгу с консоли
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка
        //book.RemoveBook1(books);
        method.RemoveBook(bookDelete);
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка
        method.SerchBookByAythor(books);
    }
}