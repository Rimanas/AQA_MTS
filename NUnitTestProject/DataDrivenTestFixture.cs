using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject;
[TestFixture(10)]  //  TestFixture - передает значение на весь тестовый класс
[TestFixture(42)]
public class DataDrivenTestFixture
{
    int _x;

    public DataDrivenTestFixture(int x)
    {
        _x = x;
    }

    [Test]
    public void TestArguments()
    {
        Assert.Pass($"X is {_x}");
    }
}