using LINQHomeWork.data;
using LINQHomeWork.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork
{
    public class NumericSequenceTask
    {
        private NumericSequenceSet _numericSequenceSet = new NumericSequenceSet();
        public void Solve1()
        {
            Console.WriteLine("Задание 1. Действия над целочисленной последоваельностью");
            PrintHelper.Print(_numericSequenceSet, i => Console.WriteLine($"Число последовательности : {i}"));
            var queryResultSequence = _numericSequenceSet.Where(num => num % 2 == 1).Distinct().Select(num => num);
            PrintHelper.Print(queryResultSequence, i => Console.WriteLine($"Число Новой Последовательности : {i}"));
        }
    }
}