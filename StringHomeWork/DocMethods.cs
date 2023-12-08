
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

public class DocMethods
{
        public string numberDoc;
    public int startIndex1 = 0;
    public int startIndex2 = 8;
    public int lenght = 4;

    public void PrintDocument()
        {
            Console.WriteLine($" Number of Document: {numberDoc}");
        }

    public void PrintNumberDoc()
    {
        // Извлечение нужных подстрок из из определенного диапазона позиций
        string substring1 = numberDoc.Substring(startIndex1, lenght);
        string substring2 = numberDoc.Substring(startIndex2, lenght+1); 
        //Соединение двух подстрок
        substring1 += substring2;
        //вывод
        Console.WriteLine($" Two blocks of Numbers: {substring1}");
    }

    public void ChangeLetters()
    {
        string pattern1 = @"[a-z]{3}"; // = @"[a-z]{3}" Шаблон: 3 символа
        string replacement1 = "***";    // замена на *
        string result1 = Regex.Replace(numberDoc, pattern1, replacement1);
        Console.WriteLine($" Number of Document with * : {result1}");
    }


    public void PrintOnlyLetters()
    {
        // Не очень красивый вариант!!!!! . Ничего больше не смогла придумать ((((

        // заменяем цифры на знак /
        string pattern2 = @"[0-9]+"; // = @"[a-z]{3}" Шаблон: 3 символа
        string replacement2 = "/";
        string result2 = Regex.Replace(numberDoc, pattern2, replacement2);
        // Удаляем знак -
        string newresult2 = Regex.Replace(result2, "-", "");
        // Извлекаем все кроме 1 символа
        string docOnlyLetters = newresult2.Substring(1);
        Console.WriteLine($" Number of Document with only letters : {docOnlyLetters}");

}
    public void PrintUpperLetters()
    {
        string pattern2 = @"[0-9]+"; // = @"[a-z]{3}" Шаблон: 3 символа
        string replacement2 = "/";
        string result2 = Regex.Replace(numberDoc, pattern2, replacement2);
        // Удаляем знак -
        string newresult2 = Regex.Replace(result2, "-", "");
        // Извлекаем все кроме 1 символа
        string docOnlyLetters = newresult2.Substring(1);
        StringBuilder sb1 = new StringBuilder(docOnlyLetters);
        Console.WriteLine($"Letters: {sb1.ToString().ToUpper()}");
    }

    public void CheckOccurence()
    {
        Regex regex = new Regex(@"abc");
        MatchCollection matches = regex.Matches(numberDoc.ToLower());
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
                Console.WriteLine($"Occurence: {match.Value}");
        }
        else
        {
            Console.WriteLine("Совпадений не найдено");
        }
    }

    public void CheckOccurence1()
    {
        string patternOcc = @"aaa"; // Группа для извлечения abc

        MatchCollection matches = Regex.Matches(numberDoc.ToLower(), patternOcc);

        if (matches.Count > 0)
        {
            Console.WriteLine($"Найдено {matches.Count} вхождений:");

            foreach (Match matchItem in matches)
            {
                string letters = matchItem.Value;
                Console.WriteLine($"Извлеченные буквы: {letters}");
            }
        }
        else
        {
            Console.WriteLine("Дата не найдена.");
        }
    }

 
        public void CheckStart()
        {
            string start = "555";
            bool checkStart = numberDoc.Any(prefix => numberDoc.StartsWith(start));
            Console.WriteLine($"Начинается ли номер документа с цифер 555?: {checkStart}");        // True
        }

        public void CheckEnd()
        {
            string end = "1a2b";
            bool checkEnd = numberDoc.EndsWith(end);
            Console.WriteLine($"Заканчивается ли номер документа на 1a2b?: {checkEnd}");        // True
        }





}
