using CollectionsHWBooks;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        MethodsBook book = new MethodsBook();
        ArrayList books = new ArrayList();
        books.Add(new Books("Мастер и Маргарита", "М.А.Булгаков", 1893));
        books.Add(new Books("Пётр Первый", "А.Н. Толстой", 1877));
        books.Add(new Books("Двенадцать", "А. Блок", 1904));
        books.Add(new Books("Антоновские яблоки", "И.А. Бунин", 1911));
        books.Add(new Books("Гранатовый браслет", "А.И. куприн", 1891));
        //book.AddNewBook(books);
        Helper.PrintBooksInfo(books);
    }
}