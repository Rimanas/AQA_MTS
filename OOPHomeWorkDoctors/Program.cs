namespace OOPHomeWorkDoctors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив пациентов
            Patient[] patients = new Patient[5];
            for (int i = 0; i < patients.Length; i++)
            {
                patients[i] = new Patient();
                patients[i].name = "Bob" + i;
                patients[i].age = new Random().Next(18, 100);
                patients[i].plan = new Random().Next(1, 10);
            }
            foreach (Patient patient in patients)
            {
                patient.Print();
            }
            TreatmentPlan treatmentPlan = new TreatmentPlan();
            //Назначение плана лечения каждому пациенту
            foreach (Patient patient in patients)
            {
                treatmentPlan.Plan(patient.plan);
            }
        }
    }
}