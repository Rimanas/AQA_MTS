   public class TreatmentPlan
{
    public int code;
    public TreatmentPlan(int code)
    { this.code = code; }   

    public void Plan(int code)
    {
        switch (code)
        {
            case 1:
                Console.WriteLine("Код лечения 1. Назначить хирурга");
        break;
            case 2:
                Console.WriteLine("Код лечения 2. Назначить дантиста");
                break;
            default:
                Console.WriteLine("Код лечения иной. Назначить терапевта");
                break;
        }
    }

      
         
}

