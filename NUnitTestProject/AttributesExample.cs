using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture, Category("Regress")]   
    public class AttributesExample
    {
        private int x;
        private int i;
        [Test(Description ="Test for MAth Operation")]  //Дескрипшен для внешнего отчета
        public void DemoTest() 
        {
            Console.WriteLine($"{this}: DemoTest ...{x++}");
        }
        [Test, Category("Smoke")]
        public void BigTest()
        {
            Console.WriteLine($"{this}: BigTest ...{x++}");
        }
        [Test, Ignore("Ignoring test")]
        public void AlphaTest()
        {
            Console.WriteLine($"{this}: AlphaTest ...{x++}");
        }
        [Test, Order(1)]
        public void ZTest()
        {
            Console.WriteLine($"{this}: ZTest... {x++}");
        }

        [Test, Order(2)]
        public void XTest()
        {
            Console.WriteLine($"{this}: XTest... {x++}");
        }
        [Test, Order(2)]
        [Author("Jane Doe", "jane.doe@example.com")]   // Инфо будет во внешнем отчете
        [Author("Another Developer", "email@example.com")]  // Инфо будет во внешнем отчете
        public void AuthorTest()
        {
            Console.WriteLine($"{this}: AuthorTest... {x++}");
        }
        [Test]
        [Repeat(5)]
        public void RepeatTest()
        {
            Console.WriteLine($"{this}: RepeatTest... ");
        }
        [Test]
        [Retry(3)]    //повторить тест , если он провалился
        public void RetryTest()
        {
            Console.WriteLine($"{this}: RetryTest... {++i}");
            if (i == 3) Assert.Pass();
            else Assert.Fail();
        }
        [Test, MaxTime(2000)]
        public void TimedTest()
        {
            Thread.Sleep(2000);
        }

        [Test]
        public void RandomAndValuesTest(
        [Values(1, 2, 3)] int numberInt,
        [Random(-1.0, 1.0, 2)] double numberDouble)
        {
            // public Random(<T> min, <T> max, int count);
            Console.WriteLine($"{this}: RandomAndValuesTest... {numberInt} {numberDouble}");
        }
    }
}
