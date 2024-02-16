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
    }
}
