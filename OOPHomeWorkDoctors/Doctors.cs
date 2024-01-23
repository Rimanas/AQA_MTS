using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkDoctors
{
    internal class Doctors
    {
        public int Id;
        public Doctors(int id)
        {
            Id = id;
        }
        public Doctors() { }
        public virtual void Heal()
        {
            Console.WriteLine("Применяется метод Лечить");
        }
    }
}
