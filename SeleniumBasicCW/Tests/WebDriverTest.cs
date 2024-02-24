using NUnitTest.Core;
using OpenQA.Selenium;
using SeleniumBasic.Core;
using SeleniumBasicCW.Core;

namespace NUnitTest.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;
        webDriver.Manage().Window.Maximize(); 
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();   // убивает процесс вебдрайвера , иначе при запуске следующих тестов , процессы залочатся
    }
    [Test]
    public void AdvancedDriverTest()
    {
        IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();
    }
    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver!;
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();
    }

}