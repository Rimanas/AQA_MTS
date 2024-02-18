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
        string name;
        string author;
        int year;
        public Books(string author, string name,  int year)
        {
            this.author = author;
            this.name = name;
            this.year = year;
        }
        public string Author { get => author; set => author = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public override string ToString()
        {
            return string.Format("Автор: {Author}, Название: {Name}, Издательство: {Year}", Author, Name, Year);
        }       
    }
}