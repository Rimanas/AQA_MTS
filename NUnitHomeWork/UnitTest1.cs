namespace NUnitHomeWork
{
    public class Tests
    {
        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void ExternalDataTest(int a, int b, int result)
        {
            Assert.That(a / b, Is.EqualTo(result));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public int ExternalDataTest1(int a, int b)
        {
            return Calculator.Div(a,b);
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
        public void ExternalDataTest2(int a, int b, int res)
        {
            Assert.That(a / b, Is.EqualTo(res));
        }

        //проверить деление на ноль

    }
}