using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitHomeWork;
public class TestData
{
    public static object[] DivideCasesInt =
    {
        new object[] { 100, 5, 20 },
        new object[] { 100, 1, 100 },
        new object[] { 0, 4, 0 },
        new object[] { 10, 4, 2 },
        new object[] { - 15, 3, -5 },
        new object[] { - 2, -2, 1 }
    };
    public static object[] DivideCasesDouble =
   {
        new object[] { 100.66, 2.0, 50.33 },
        new object[] { 55.78, 1, 55.78 },
        new object[] { 0, 4.765, 0 },
        new object[] { 10, 2.5, 4 }
    };
}
