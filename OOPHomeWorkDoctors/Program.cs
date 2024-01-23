namespace OOPHomeWorkDoctors
{
    class Program
    {
        static void Main(string[] args)
        {
        TreatmentPlan treatmentPlan = new TreatmentPlan();
            Surgeon surgeon = new Surgeon();
            Doctors doctors = new Doctors();
            doctors.Heal();
            //surgeon.Heal();
            //treatmentPlan.Plan(1);
        }
    }
}