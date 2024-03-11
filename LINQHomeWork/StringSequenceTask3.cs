using LINQHomeWork.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork
{
    internal class StringSequenceTask3
    {
        private StringSequenceSet _stringSequenceSet = new StringSequenceSet();
        public void Solve3()
        {
            Console.WriteLine("Задание 3. Действия над строковой последоваельностью");
            PrintHelper.Print(_stringSequenceSet.stringSequence, i => Console.WriteLine($"Строка последовательности : {i}"));
            var queryResultSequence = _stringSequenceSet.stringSequence.OrderBy(s => s.Length).ThenByDescending(s => s);
            PrintHelper.Print(queryResultSequence, i => Console.WriteLine($"Строка Новой Последовательности : {i}"));
        }
    }
}