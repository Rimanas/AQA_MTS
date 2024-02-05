using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitHomeWork;
public static class Calculator
{
    public static int Div(int a, int b)
    {
        if (b != 0)
        Console.WriteLine("На ноль делить нельзя !");
        return a / b;
    }
    public static void Div1(int a, int b)
    {
        try 
        { int res = a / b; }
        catch (DivideByZeroException ex) 
        { Console.WriteLine(ex.Message); }
    }
}
