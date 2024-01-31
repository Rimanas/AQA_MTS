namespace NUnitTestProject
{
    public class SimpleTest: PrePostConditionExample
    {
        [SetUp]
        public void SetUp1()
        {
            Console.WriteLine($"{this}: SetUp from SimpleTest...{i++}");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine($"[{this}: Test1...");
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}