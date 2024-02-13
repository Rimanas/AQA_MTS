namespace NUnitHomeWork
{
    [TestFixture, Category("Regress")]
    public class Tests
    {
        private int i;
        [Test, Order(1)]
        [Description("Checking the division of a number(int) by number(int)")]
        [Author("Alina Alina", "alina@example.com")]  
        [Category("Smoke")]
        [Severity(SeverityLevel.Critical)]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void DivideTestInt(int a, int b, int expectedRes)
        {
            Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}:Checking the division of a number(int) by number(int)");
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            Console.WriteLine($"{this}: DivideTestDouble... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            int actualRes = Calculator.Div(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }

        // DIV double
        [Test, Order(4)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a number(double) by number(double)")]
        [Category("Regression")]
        [Severity(SeverityLevel.Critical)]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesDouble))]
        public void DivideTestDouble(double a, double b, double expectedRes)
        {
            Console.WriteLine($"{this}: DivideTestDouble ...{i++}");
            Console.WriteLine($"{this}: DivideTestDouble... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            double actualRes = Calculator.Div(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }

        [Test, Order(2)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a number(int) by zero")]
        [Category("Smoke")]
        [Severity(SeverityLevel.Critical)]
        [TestCase(5, 0)]
        public void DivideByZeroInt(int a, int b)
        {
            Console.WriteLine($"{this}: DivideByZeroInt ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroInt... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.Throws<DivideByZeroException>(() => Calculator.Div(a,b));
        }

        [Test, Order(3)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a zero(int) by zero")]
        [Category("Smoke")]
        [Severity(SeverityLevel.Critical)]
        [TestCase(7.995, 0)]
        public void DivideByZeroDouble(double a, double b)
        {
            Console.WriteLine($"{this}: DivideByZeroDouble ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroDouble... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            if (b == 0 && Double.IsInfinity(Calculator.Div(a, b)))
                Assert.Pass("На ноль делить нельзя!");
            else
                Assert.Fail("Знаменатель не равен 0. Тест провален. Измените исходные данные!");
        }

        [Test, Order(5)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a number(double) by number(double)")]
        [Category("Regression")]
        [Severity(SeverityLevel.Major)]
        [TestCase(-10.6, -2, 5.3)]
        [TestCase(10.6, -2, -5.3)]
        public void DivideTestDouble1(double a, double b, double expectedRes)
        {
            Console.WriteLine($"{this}: DivideTestDouble1 ...{i++}");
            Console.WriteLine($"{this}: DivideTestDouble1... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.That(Calculator.Div(a,b), Is.EqualTo(expectedRes));
        }

        [Test, Order(3)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division")]
        [Category("Regression")]
        [Severity(SeverityLevel.Minor)]
        [TestCase(-10.6, -2.0, ExpectedResult = 5.3)]
        [TestCase(100.0, -2.5, ExpectedResult = -40)]
        public double DivideByZeroDouble0(double a, double b)
        {
            Console.WriteLine($"{this}: DivideByZeroDouble0 ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroDouble0... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            return Calculator.Div(a,b);
        }

        [Test, Order(6)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division : REPEAT")]
        [Category("Regression")]
        [Severity(SeverityLevel.Minor)]
        [TestCase(100, 1, 100)]
        [Repeat(5)]
        public void DivideTestIntRepeat(int a, int b, int res)
        {
            Console.WriteLine($"{this}: DivideTestIntRepeat ...{i++}");
            Console.WriteLine($"{this}: DivideTestIntRepeat... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.That(Calculator.Div(a, b), Is.EqualTo(res));
        }

        [Test, Order(7)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division : RETRY")]
        [Category("Regression")]
        [Severity(SeverityLevel.Minor)]
        [TestCase(100, 1, 100)]
        [Retry(3)]
        public void DivideTestIntRetry(int a, int b, int res)
        {
            Console.WriteLine($"{this}: DivideTestIntRetry ...{i++}");
            Console.WriteLine($"{this}: DivideTestIntRetry... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.That(Calculator.Div(a, b), Is.EqualTo(res));
        }

        [Test, Ignore("Ignore"), Order(8)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division")]
        [Category("Regression")]
        [Severity(SeverityLevel.Minor)]
        [TestCase(100, 1, 100)]
        [Retry(3)]
        public void DivideTestIgnore(int a, int b, int res)
        {
            Console.WriteLine($"{this}: DivideTestIntRetry ...{i++}");
            Console.WriteLine($"{this}: DivideTestIntRetry... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.That(Calculator.Div(a, b), Is.EqualTo(res));
        }

        [Test, Combinatorial, Order(8)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division")]
        [Category("Regression")]
        [Severity(SeverityLevel.Minor)]
        public void DivideTestCombinatorial(
            [Values(10, 10)] int a, 
            [Values(1, 1)] int b, 
            [Values(10, 10)] int res)
        {
            Console.WriteLine($"{this}: DivideTestCombinatorial ...{i++}");
            Console.WriteLine($"{this}: DivideTestCombinatorial... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.That(Calculator.Div(a, b), Is.EqualTo(res));
        }
    }
}