using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWorkDoctors
{
    internal class TreatmentPlan: Doctors
    {
        public int code;
        public TreatmentPlan(int code)
        { this.code = code; }
        Doctors dantist = new Dantist();
        Doctors surgeon = new Surgeon();  
        Doctors therapist = new Therapist();    
        public TreatmentPlan() { }
        public void Plan(int code)
        {
            switch (code)
            {
                case 1:
                    Console.WriteLine("У пациента код лечения 1. Назначить хирурга");
                    surgeon.Heal();
                    break;
                case 2:
                    Console.WriteLine("У пациента код лечения 2. Назначить дантиста");
                    dantist.Heal();
                    break;
                default:
                    Console.WriteLine("У пациента код лечения иной. Назначить терапевта");
                    therapist.Heal();
                    break;
            }
        }
    }
}
