namespace NUnitTestProject
{
    public class SimpleTest1: PrePostConditionExample
    {
        [SetUp]
        public void SetUp1()
        {
            Console.WriteLine($"{this}: SetUp...{i++}");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine($"[{this}: Test1...");
            Assert.Pass();
        }
    }
}