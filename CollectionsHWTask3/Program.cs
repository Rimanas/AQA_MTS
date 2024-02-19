using CollectionsHWTask3;
using System.Collections;

internal class Program
{
    private static void Main()
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 4, 5 };
        Helper.Print(nums);
        //Создадим HashSet из первоначального листа для удаления дубликатов
        HashSet<int> myHashset = new HashSet<int>(nums);
        Console.WriteLine("\nНовый набор чисел без повторений:");
        Helper.Print(myHashset);
    }
}