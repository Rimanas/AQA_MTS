using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkDoctors
{
    internal class Surgeon: Doctors
    {
        public override void Heal()
        {
            Console.WriteLine("Применяется метод Лечить врача Хирурга");
        }
    }
}