namespace NUnitHomeWork;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
//будет использоваться в методах, АllowMultiple = false - запрещаем чтобы было несколько значений
public class SeverityAttribute : PropertyAttribute
{
    public SeverityAttribute(SeverityLevel level)
        : base(level.ToString()) { }
}