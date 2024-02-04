using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject;
[TestFixture(typeof(int))]
[TestFixture(typeof(string))]
public class GenericTestFixture<T>
{
    [Test]
    public void TestType()
    {
        Assert.Pass($"The generic test type is {typeof(T)}");
    }
}

