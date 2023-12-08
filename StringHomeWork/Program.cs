using System;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace StringHomeWork
{
    class Programm
    {
        static void Main(string[] args)
        {
            // ===== 1 ЗАДАНИЕ. Заменить в строке 'test' на 'testing'. Удалить из текста все символы-цифры  ======

            // 1 способ . Исходный текст проинициализирован в задаче
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

            // 2 способ . Исходный текст прочитан из файла
            Console.WriteLine() ;
            Console.WriteLine("Второй способ");
            string path = @"C:\\Users\\Alina\\Documents\\work\\AQA_MTS\\StringHomeWork\\TextFile.txt";
            string textFromFile = File.ReadAllText(path);
            Console.WriteLine("Текст из файла");
            Console.WriteLine(textFromFile);
            textFromFile = textFromFile.ToLower();
            string replaceTextFromFile = textFromFile.Replace("test", "testing");
            Console.WriteLine("Имененный текст:");
            string changeText = Regex.Replace(replaceTextFromFile, "[0-9]", "");
            Console.WriteLine(changeText);

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

            Console.WriteLine("Another способ");
            string all = s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5;
            string[] allString = all.Split(" ");
            foreach (var item in allString) Console.Write($" \"{item}\" .");
           


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
            Console.WriteLine();
            string textOne = "Плохой день.";
            Console.WriteLine(textOne);
            Console.WriteLine(textOne.Length);
            //int lengh = textOne.Length;
            string mainWord = "день";
            string newWord = "Замечательный";
            string newsymbols = "!!!!!!!!!";
            string newSymbol = "?";
            //1 способ
            Console.WriteLine("Первый способ");
            Console.WriteLine();
            // удаляем лишний символ в конце - . точку
            textOne = textOne.Substring(0, textOne.Length - 1);
            // сохраняем все с 6 индекса - то есть убираем слово Плохой
            textOne = textOne.Substring(6);
            Console.WriteLine(textOne);
            // Всталяем с 0 индекса новое слово - Замечательный
            textOne = textOne.Insert(0, newWord);
            // В конец предложения вставляем знаки восклицания - 9 знаков !
            textOne = textOne.Insert(textOne.Length, newsymbols);   
            Console.WriteLine(textOne);
            // Обрезаем строку. Убираем один знак ! в конце 
            textOne = textOne.Substring(0, textOne.Length - 1);
            // Вставляем в конец предложения знак ?
            textOne = textOne.Insert(textOne.Length, newSymbol);
            Console.WriteLine(textOne);
            Console.WriteLine();

            //2 способ
            Console.WriteLine("Второй способ");
            Console.WriteLine();
            string textTwo = "Плохой день.";
            Console.WriteLine(textTwo);
            int indexOne = textTwo.IndexOf(mainWord); // находим индекс первого вхождения - ДО - слово день
            // удаляем лишний символ в конце - . точку
            string textTwo1 = textTwo.Substring(0, textTwo.Length - 1);
            // Удаляем слово Плохой
            string textTwo2 = textTwo1.Substring(indexOne-1);
            // Всталяем с 0 индекса новое слово - Замечательный....и далее как в 1 способе
            textTwo2 = textTwo2.Insert(0, newWord);
            textTwo2 = textTwo2.Insert(textTwo2.Length, newsymbols);
            textTwo2 = textTwo2.Substring(0, textTwo2.Length - 1);
            textTwo2 = textTwo2.Insert(textTwo2.Length, newSymbol);
            Console.WriteLine(textTwo2);

            // ===== 6 ЗАДАНИЕ. Заменить знаки табуляции на пробелы в строке, двойные пробелы заменит на один пробел  ======
            Console.WriteLine();
            Console.WriteLine(" ЗАДАНИЕ. Заменить знаки табуляции на пробелы в строке, двойные пробелы заменит на один пробел ");
            Console.WriteLine();
            string text6 = "Hello.\t My name \tis Alina. Stop  Stop stop  stop. Hello\thello\thello\thello";
            Console.WriteLine(text6);
            Console.WriteLine(text6.Length);
            //заменяем знаки табуляции на пробел
            string newText6 = System.Text.RegularExpressions.Regex.Replace(text6, "\t+", " ");
            //заменяем здвойные пробелы на 1 пробел
            string nextNewText6 = System.Text.RegularExpressions.Regex.Replace(newText6, "  ", " ");
            Console.WriteLine(newText6);
            Console.WriteLine(nextNewText6);

            // ===== 7 ЗАДАНИЕ. Упорядочить слова в строке по алфавиту  ======
            Console.WriteLine();
            Console.WriteLine("7 ЗАДАНИЕ. Упорядочить слова в строке по алфавиту ");
            Console.WriteLine();
            string text7 = "i  want to go sleep  because i am already tired but i have to do my favorite hw meow \t meow";
            Console.WriteLine(text7);
            Console.WriteLine(text7.Length);
            // Убираем знаки табуляции и двойные прбелы с заменой на 1 пробел
            string newText7 = System.Text.RegularExpressions.Regex.Replace(text7, "\t+", " ");
            string nextNewText7 = System.Text.RegularExpressions.Regex.Replace(newText7, "  ", " ");
            Console.WriteLine(nextNewText7);
            // Использование готового метода для преобразования строки слов в массив слов.
            // преобразовыаем строку слов в массив слов для дальнейшей сортировки
            string[] words = nextNewText7.Split(" ");
            foreach (string word in words)
            {
                Console.WriteLine(word + " ");

            }
            // Сортировка массива слов - готовый метод
            Console.WriteLine("Отсортированный массив имен");
            Array.Sort(words);

            // Выводим массив в строку
            foreach (string sortWords in words)
            {
                Console.Write(sortWords + " ");
            }
            Console.WriteLine();

            // ===== 5 ЗАДАНИЕ. Операции с номером документа  ======
            Console.WriteLine();
            Console.WriteLine(" 5 ЗАДАНИЕ. Операции с номером документа  ");
            Console.WriteLine();
            DocMethods doc = new DocMethods();
            doc.numberDoc = "5551-AAA-2222-ABC-1a2b";
            // печатаем полный номер документа
            doc.PrintDocument();
            // печатаем первые два блока цифр из полного номера документа
            doc.PrintNumberDoc();
            // Замена трех букв на *
            doc.ChangeLetters();
            // печатаем только буквы документа через знак /
            doc.PrintOnlyLetters();
            // печатаем только Заглавные буквы документа через знак /
            doc.PrintUpperLetters();
            // 1 способ. проверка вхождений букв abc в номер документа
            doc.CheckOccurence();
            // 2 способ. проверка вхождений букв abc в номер документа
            doc.CheckOccurence1();
            // Проверка . Начинается ли номер документа с цифер 555
            doc.CheckStart();
            //Проверка.Заканчивается ли номер документа на 1a2b?
            doc.CheckEnd();
        }
    }
}