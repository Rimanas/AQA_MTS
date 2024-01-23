using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkDoctors
{
    internal class Patient
    {
        public string name;
        public int age;
        public int plan;

        public void Print()
        {
            Console.WriteLine($" Name: {name}, Age : {age}, PlanTreatment : {plan} ");
        }
    }
}
