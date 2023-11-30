namespace Classes.Models;

public class Student
{
    public string name;
    public int group;
    public int diplomMark;

    
    public Student(string name)
    {  this.name = name;
        group = 1;
        diplomMark = new Random().Next.;
    }
    public void Print()
    {
        Console.Write($"Name: {Student.name}, Group: {Student.group}, Mark: {Student.diplomMArk}");
        Console.WritLine();
    }
    

}
