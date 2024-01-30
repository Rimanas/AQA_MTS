namespace NUnitTestProject
{
    public class PrePostConditionExample
    {
        protected int i = 0;
        [OneTimeSetUp]   //то , что выполняется до тестов
        public void OneTimeSetUp()
        {
            Console.WriteLine($"{this}: OneTimeSetUp...{i++}");
        }

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine($"{this}: SetUp...{i++}");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine($"{this}: Test... {i++}");
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine($"{this}: Test... {i++}");
        }

        [TearDown] 
        public void TearDown()
        {
            Console.WriteLine($"{this}: TearDown...{i++}");
        }

        [OneTimeTearDown] //то, что выполняется после тестов
        public void FinishTests( ) 
        {
            Console.WriteLine($"{this}: OneTimeTearDown... {i++}");
        }
    }
}

