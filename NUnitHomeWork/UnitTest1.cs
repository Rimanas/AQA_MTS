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
            int actualRes = Calculator.DivInt(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }
        [Test, Order(2)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a number(int) by zero")]
        [Category("Smoke")]
        [Severity(SeverityLevel.Critical)]
        public void DivideByZeroInt()
        {
            Console.WriteLine($"{this}: DivideByZeroInt ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroInt... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.Throws<DivideByZeroException>(() => Calculator.DivInt(5,0));
        }
        [Test, Order(3)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a zero(int) by zero")]
        [Category("Smoke")]
        [Severity(SeverityLevel.Critical)]
        public void DivideByZeroInt0()
        {
            Console.WriteLine($"{this}: DivideByZeroInt0 ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroInt0... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.Throws<DivideByZeroException>(() => Calculator.DivInt(0, 0));
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
            double actualRes = Calculator.DivDouble(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }
        [Test, Order(5)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a number(double) by zero")]
        [Category("Regression")]
        [Severity(SeverityLevel.Major)]
        public void DivideByZeroDouble()
        {
            Console.WriteLine($"{this}: DivideByZeroDouble ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroDouble... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.Throws<Exception>(() => Calculator.DivDouble(5.0d, 0.0d));
        }
        [Test, Order(3)]
        [Author("Alina Alina", "alina@example.com")]
        [Description("Checking the division of a zero(double) by zero")]
        [Category("Regression")]
        [Severity(SeverityLevel.Minor)]
        public void DivideByZeroDouble0()
        {
            Console.WriteLine($"{this}: DivideByZeroDouble0 ...{i++}");
            Console.WriteLine($"{this}: DivideByZeroDouble0... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
            Assert.Throws<Exception>(() => Calculator.DivDouble(0.0d, 0.0d));
        }
    }
}