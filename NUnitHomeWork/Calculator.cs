using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitHomeWork;
public static class Calculator
{
    public static int DivInt(int a, int b)
    {
        try 
        { int res = a / b;
            Console.WriteLine("{0} divided by {1} = {2}", a, b, res);
        }
        catch (DivideByZeroException ex) 
        { Console.WriteLine($"{ex.Message} - \"На ноль делить нельзя !\""); }
        return a / b;
    }   
    public static double DivDouble(double a, double b)
    {
        try
        {
            if (b == 0)
            { throw new Exception(); }
            else
            {
                double res = a / b;
                Console.WriteLine("{0} divided by {1} = {2}", a, b, res);
            }
        }
        catch (Exception e)
        { 
            Console.WriteLine($"Ошибка: {e.Message} - \"На ноль делить нельзя !\""); 
            throw; };
        return a / b;
    }
}
