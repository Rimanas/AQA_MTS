using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture, Category("Regress")]  // TestFixture - ставится перед классами, более глобальная   
    public class AttributesExample
    {
        private int x;
        private int i;
        [Test(Description ="Test for MAth Operation")]  //Дескрипшен для внешнего отчета
        public void DemoTest() 
        {
            Console.WriteLine($"{this}: DemoTest ...{x++}");
        }
        [Test, Category("Smoke")]    // категория также не видна, но можно через консоль
        // запустить командой dotnet test -- NUnit.Where="cat == Smoke"
        public void BigTest()
        {
            Console.WriteLine($"{this}: BigTest ...{x++}");
        }
        [Test, Ignore("Ignoring test")]   // игнорим этот тест и в отчете не будет учитываться
        public void AlphaTest()
        {
            Console.WriteLine($"{this}: AlphaTest ...{x++}");
        }
        [Test, Order(1)]    // выполнится первым
        public void ZTest()
        {
            Console.WriteLine($"{this}: ZTest... {x++}");
        }

        [Test, Order(2)]  // выполнится вторым
        public void XTest()
        {
            Console.WriteLine($"{this}: XTest... {x++}");
        }
        [Test, Order(2)]   // должен быть вторым, а потом уже XTest, но почему то не сработало ???
        [Author("Jane Doe", "jane.doe@example.com")]   // Инфо будет во внешнем отчете
        [Author("Another Developer", "email@example.com")]  // Инфо будет во внешнем отчете
        public void AuthorTest()
        {
            Console.WriteLine($"{this}: AuthorTest... {x++}");
        }
        [Test]
        [Repeat(5)]     // когда надо выполнить тест несколко раз. Например заполнение БД
        public void RepeatTest()
        {
            Console.WriteLine($"{this}: RepeatTest... ");
        }
        [Test]
        [Retry(3)]    //повторить тест , если он провалился
        public void RetryTest()
        {
            Console.WriteLine($"{this}: RetryTest... {++i}");
            if (i == 3) Assert.Pass();   //если i==4 поставим 4, то тест упадет
            else Assert.Fail();
        }
        [Test, MaxTime(2000)]  // указываем за какое время тест долден выполниться
        public void TimedTest()
        {
            Thread.Sleep(2000);  //тест упадет...если поствим меньше , то будет pass
        }

        [Test]
        public void RandomAndValuesTest0([Random(1,10,2)] int randomNumber) 
            // выполнится 2 раза с рандомными числами от 1 до 10
        {
            // public Random(<T> min, <T> max, int count);
            Console.WriteLine($"{this}: RandomAndValuesTest0... {randomNumber}");
        }

        [Test]
        public void RandomAndValuesTest(
        [Values(1, 2, 3)] int numberInt,
        [Random(-1.0, 1.0, 2)] double numberDouble)
        {
            // public Random(<T> min, <T> max, int count);
            Console.WriteLine($"{this}: RandomAndValuesTest... {numberInt} {numberDouble}");
        }

        [Test]
        public void RangeValuesTest([Range(0.2, 0.6, 0.2)] double numberDouble) 
            //по умолчанию шаг (3 число) равен 1, если число int
        {
            // public RangeAttribute(<T> from, <T> to);
            // public RangeAttribute(<T> from, <T> to, <T> step);
            Console.WriteLine($"{this}: RangeValuesTest... {numberDouble}");
        }

        // если нужно множество - конкретное число, сколько чисел столько раз выполнится
        [Test]
        public void ValuesTest([Values(1, 5, 2)] int valuesNumer)
        //по умолчанию шаг (3 число) равен 1, если число int
        {
            // public RangeAttribute(<T> from, <T> to);
            // public RangeAttribute(<T> from, <T> to, <T> step);
            Console.WriteLine($"{this}: ValuesTest... {valuesNumer}");
        }

        //миксовванный вариант
        [Test]
        public void AllValuesTest(
       [Random(1, 10, 5)] int rundomNumber,
       [Range(1, 5, 2)] int rangeNumber,
       [Values(1, 2, 3)] int valuesNumber)
        {
            // public Random(<T> min, <T> max, int count);
            Console.WriteLine($"{this}: AllValuesTest... {rundomNumber} {x++}");
            Console.WriteLine($"{this}: AllValuesTest... {rangeNumber} {x++}");
            Console.WriteLine($"{this}: AllValuesTest... {valuesNumber} {x++}");
        }

        [Test, Combinatorial] // Генерирует все возможные пары сам, используется по умолчанию, можно не писать
        public void CombinatorialTest(
      [Values(1, 2, 3)] int number,
      [Values("A", "B")] string text)
        {
            Console.WriteLine($"{this}: XTest... {number} {text}");
        }

        [Test, Pairwise]
        public void PairwiseTest(
       [Values("a", "b", "c")] string a,
       [Values("+", "-")] string b,
       [Values("x", "y")] string c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        // Property
        [Test, Property("Severity", "Critical")]
        public void PropertyTest()
        {
            Console.WriteLine($"{this}: PropertyTest... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
        }
        // TestContext - переменная
        // из консоли dotnet test -- NUnit.Where="cat == Example or Severity == Critical"
        [Test, Severity(SeverityLevel.Major)]
        public void AdvancedPropertyTest()
        { 
            Console.WriteLine($"{this}: PropertyTest... {TestContext.CurrentContext.Test.Properties.Get("Severity")}"); 
        }
    }
}
