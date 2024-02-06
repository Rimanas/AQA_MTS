namespace NUnitHomeWork
{
    public class Tests
    {

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void DivideTest(int a, int b, int expectedRes)
        {
            int actualRes = Calculator.DivInt(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }

        [Test]
        public void DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.DivInt(5,0));
        }
        [Test]
        public void DivideByZero0()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.DivInt(0, 0));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesDouble))]
        public void DivideTest1(double a, double b, double expectedRes)
        {
            double actualRes = Calculator.DivDouble(a, b);
            Assert.That(actualRes, Is.EqualTo(expectedRes));
        }

        [Test]
        public void DivideByZero1()
        {
            Assert.Throws<Exception>(() => Calculator.DivDouble(5.0d, 0.0d));
        }
        [Test]
        public void DivideByZero2()
        {
            Assert.Throws<Exception>(() => Calculator.DivDouble(0.0d, 0.0d));
        }

        //проверить деление на ноль

    }
}