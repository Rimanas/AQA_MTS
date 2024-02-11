   public class TreatmentPlan
{
    public int code;
    public TreatmentPlan(int code)
    { this.code = code; }      
    //Методы лечить врачей
    public void HealTherapist()
    {
        Console.WriteLine("Применяется метод Лечить врача Терапевта");
    }
    public void HealSurgeon()
    {
        Console.WriteLine("Применяется метод Лечить врача Хирурга");
    }
    public void HealDantist()
    {
        Console.WriteLine("Применяется метод Лечить Дантиста");
    }
    public void Plan(int code)
    {
        switch (code)
        {
            case 1:
                Console.WriteLine("У пациента код лечения 1. Назначить хирурга");
                HealSurgeon();
        break;
            case 2:
                Console.WriteLine("У пациента код лечения 2. Назначить дантиста");
                HealDantist();
                break;
            default:
                Console.WriteLine("У пациента код лечения иной. Назначить терапевта");
                HealTherapist();
                break;
        }
    }              
}

