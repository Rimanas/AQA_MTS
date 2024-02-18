using CollectionsHWBooks;
using System.Collections;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("1 Задание. Books.");
        ArrayList books = new ArrayList();
        MethodsBook method = new MethodsBook();
        ArrayList bookDelete = new ArrayList();
        bookDelete.Add(new Books("Delete", "Delete", 2005));
        books.Add(new Books("М.А.Булгаков", "Мастер и Маргарита", 1893));
        books.Add(new Books("А.Н. Толстой", "Пётр Первый", 1877));
        books.Add(new Books("А. Блок", "Двенадцать", 1904));
        books.Add(new Books("И.А. Бунин", "Антоновские яблоки", 1911));
        books.Add(new Books("Куприн", "Гранатовый браслет", 1891));
        books.Add(new Books("Delete", "Delete", 2005)); 
        method.AddNewBook(books);     // Добавить книгу с консоли
        Console.WriteLine(" \n Книига добавлена. Обновленный список в базе книг: ");
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка
        Console.WriteLine("\n Книга для удаления:");    
        Helper.PrintBooksInfo(bookDelete);   // Вывести все книги из списка
        method.RemoveBook(bookDelete);
        Console.WriteLine("\n Список после уаления:");
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка/ не понимаю почему, но метод method.RemoveBook(bookDelete) не работает
        method.SerchBookByAythor(books);
        method.RemoveBook1(books);
        Helper.PrintBooksInfo(books);   // Вывести все книги из списка
        method.Exit();
        Helper.PrintBooksInfo(books);   // Вывести все книги из спискадля проверки метода Exit
    }
}