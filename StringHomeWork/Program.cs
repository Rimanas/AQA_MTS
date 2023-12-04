using System;
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

            // ===== 2 ЗАДАНИЕ. Вывод текста в консоль. Конкатинация  ======
            Console.WriteLine();
            Console.WriteLine("2 ЗАДАНИЕ. Вывод текста в консоль. Конкатинация ");
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "the";
            string s4 = "TMS";
            string s5 = "lessons";
            // использование разных методов конкатинации , слова без кавычек
            string s12 = s1 + " " + s2;
            string s34 = s3 + " " + s4;
            string s15 = s12 + " " + s34 + " " + s5;
            s15 = string.Concat(s15, ".");
            Console.WriteLine(s15);
            // использование конкатинации , слова с кавычкамик
            string s11 = "Welcome";
            string s21 = "to";
            string s31 = "the";
            string s41 = "TMS";
            string s51 = "lessons";

            string stringNew = "\"" + s11 + "\"" + " " + "\"" + s21 + "\"" + " " + "\"" + s31 + "\"" + " " + "\"" + s41 + "\"" + " " + "\"" + s51 + "\"";
            stringNew = string.Concat(stringNew, ".");
            Console.WriteLine(stringNew);

            // ===== 3 ЗАДАНИЕ. Разделение строки на До и После  ======
            Console.WriteLine();
            Console.WriteLine("3 ЗАДАНИЕ. Разделение строки на До и После ");
            string fullString = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            Console.WriteLine(fullString);
            string substring = "abc";
            int indexOfSubstring = fullString.IndexOf(substring); // находим индекс первого вхождения - ДО
            string beforeText = fullString.Substring(0, indexOfSubstring);
            Console.WriteLine($"index: {indexOfSubstring}");
            Console.WriteLine("Первая часть текста до символов abc");
            Console.WriteLine(beforeText);
            Console.WriteLine();
            Console.WriteLine("Вторая часть текста после символов abc");
            string afterText = fullString.Substring(indexOfSubstring+3);
            Console.WriteLine(afterText);



            // ===== 4 ЗАДАНИЕ. Удаление \ Вставка слова. Замена символа  ======
            Console.WriteLine();
            Console.WriteLine("4 ЗАДАНИЕ. Удаление - Вставка слова. Замена символа ");









            string text = "Welcome to the TMS lessons.";
            Console.WriteLine();
        }
    }
}