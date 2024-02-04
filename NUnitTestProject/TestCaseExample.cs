using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject;
public class TestCaseExample
{
    [TestCase(1, 2, 3)]
    [TestCase(-1, -2, -3)]
    [TestCase(0, 0, 0)]
    public void Test1(int x, int y, int result)
    {
        Assert.That(Calc.Sum(x, y), Is.EqualTo(result));
    }
    // ExpectedResult - параметр
    [TestCase(1, 2, ExpectedResult = 3)]
    [TestCase(-1, -2, ExpectedResult = -3)]
    public int Test2(int x, int y)
    {
        return Calc.Sum(x, y);
    }

    public static object[] DivideCases =
    {
        new object[] { 12, 3, 4 },
        new object[] { 12, 2, 6 },
        new object[] { 12, 4, 3 }
    };
    //  TestCaseSource - ждет на вход источник данных - коллекцию DivideCases
    [TestCaseSource(nameof(DivideCases))]
    public void DivideTest(int n, int d, int q)
    {
        Assert.AreEqual(q, n / d);
    }
    // если внешний класс , то обязатлеьно указывать typeof
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))]
    public void ExternalDataTest(int n, int d, int q)
    {
        Assert.That(n / d, Is.EqualTo(q));
    }
}
