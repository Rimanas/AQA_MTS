using OpenQA.Selenium;
using SeleniumBasicCW.Core;

namespace NUnitTest.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();   // убивает процесс вебдрайвера , иначе при запуске следующих тестов , процессы залочатся
    }

    
}