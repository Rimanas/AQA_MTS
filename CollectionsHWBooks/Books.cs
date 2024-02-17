using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsHWBooks
{
    internal class Books
    {
        public Books(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }
        public string Author { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }
        public override string ToString()
        {
            return string.Format("Автор: {Author}, Название: {Name}, Издательство: {Year}", Name, Author, Year);
        }
        public static bool CheckData(string name, string author, string year)
        {
            if (name.Length < 1 || name.Contains(" "))
            {
                throw new Exception(".....!");
            }
            else if (author.Length < 2 || author.Contains(" "))
            {
                throw new Exception(" ....!");
            }
            else if (year.ToString().Length > 0 || year.ToString().Length < 5 || year.ToString().Contains(' '))
            {
                throw new Exception("lfnf!");
            }
            else
                return true;
        }
    }
}