namespace NUnitHomeWork
{
    [TestFixture, Category("Regress")]
    public class Tests
    {
        private int i;
        [Test, Order(4)]
        [Description("Checking the division of a number(int) by number(int)")]
        [Category("Regression")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void DivideTestInt(int a, int b, int expectedRes)
        {
            Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}:Checking the division of a number(int) by number(int)");
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            int actualRes = Calculator.DivInt(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }
        [Test, Order(5)]
        [Description("Checking the division of a number(int) by zero")]
        [Category("Regression")]
        public void DivideByZeroInt()
        {
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            Assert.Throws<DivideByZeroException>(() => Calculator.DivInt(5,0));
        }
        [Test, Order(6)]
        [Description("Checking the division of a zero(int) by zero")]
        [Category("Smoke")]
        public void DivideByZeroInt0()
        {
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            Assert.Throws<DivideByZeroException>(() => Calculator.DivInt(0, 0));
        }
        // DIV double
        [Test, Order(1)]
        [Description("Checking the division of a number(double) by number(double)")]
        [Category("Regression")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesDouble))]
        public void DivideTestDouble(double a, double b, double expectedRes)
        {
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            double actualRes = Calculator.DivDouble(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }

        [Test, Order(2)]
        [Description("Checking the division of a number(double) by zero")]
        [Category("Regression")]
        public void DivideByZeroDouble()
        {
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            Assert.Throws<Exception>(() => Calculator.DivDouble(5.0d, 0.0d));
        }
        [Test, Order(3)]
        [Description("Checking the division of a zero(double) by zero")]
        [Category("Regression")]
        public void DivideByZeroDouble0()
        {
            Console.WriteLine($"{this}: DivideTestInt ...{i++}");
            Assert.Throws<Exception>(() => Calculator.DivDouble(0.0d, 0.0d));
        }
    }
}