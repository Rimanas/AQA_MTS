using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
//будет использоваться в методах, АllowMultiple = false - запрещаем чтобы было несколько значений
public class SeverityAttribute : PropertyAttribute
{
    public SeverityAttribute(SeverityLevel level)
        : base(level.ToString()) { }
}

// PropertyAttribute - стандартный класс это
