namespace NUnitTestProject
{
    public class PrePostConditionExample
    {
        protected int i = 0;
        [OneTimeSetUp]   //то , что выполняется до тестов (например создать пользователя). 1 раз перед всеми тестами
        public void OneTimeSetUp()
        {
            Console.WriteLine($"{this}: OneTimeSetUp...{i++}");
        }

        [SetUp]  // например, открыть браузер (перед каждым тестом)
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

        [TearDown]   // например , закрыть браузер. (после каждого теста)
        public void TearDown()
        {
            Console.WriteLine($"{this}: TearDown...{i++}");
        }

        [OneTimeTearDown] //то, что выполняется после тестов (1 раз). Например, удалить пользователя
        public void FinishTests( ) 
        {
            Console.WriteLine($"{this}: OneTimeTearDown... {i++}");
        }
    }
}

