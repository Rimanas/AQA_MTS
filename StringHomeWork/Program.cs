using System.Text.RegularExpressions;

namespace StringHomeWork
{
    class Programm
    {
        static void Main(string[] args)
        {
            // ===== 1 ЗАДАНИЕ. Заменить в строке 'test' на 'testing'. Удалить из текста все символы-цифры  ======
            Console.WriteLine();
            Console.WriteLine("1 ЗАДАНИЕ. Заменить в строке 'test' на 'testing'. Удалить из текста все символы-цифры");
            string originalText = "Test1234 is an11 important compo77nent90. Test 0911requires test11 da1ta. Test009 data is data for99 9000test!00";
            Console.WriteLine();
            Console.WriteLine("Оригинальный текст");
            Console.WriteLine(originalText);
            Console.WriteLine("Текст с заменой 'test' на 'testing'");
            originalText = originalText.ToLower();
            string replaceText = originalText.Replace("test", "testing");
            Console.WriteLine(replaceText);
            Console.WriteLine();  
            Console.WriteLine("Текст без цифр:");
            string withoutNumText = Regex.Replace(replaceText, "[0-9]", "");
            Console.WriteLine(withoutNumText);
        }
    }
}