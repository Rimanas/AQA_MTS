using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject;
public static class Calc  //статичный, чтобы не инициализировать каждый раз
{
    public static int Sum(int x, int y) => x + y;
}
