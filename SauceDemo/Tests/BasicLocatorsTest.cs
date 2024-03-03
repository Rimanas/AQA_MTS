using SauceDemo.Helpers.Configuration;
using SauceDemo.Tests;
using OpenQA.Selenium;
namespace SauceDemo.Tests;
public class BasicLocatorsTest : BaseTest
{
    [Test]
    public void basicLocatorsTest_1()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        // Find webElement by ID
        Assert.That(Driver.FindElement(By.Id("user-name")).Displayed);
        // Find webElement by Name
        Assert.That(Driver.FindElement(By.Name("user-name")).Displayed);
        // Find webElement by TagName
        Assert.That(Driver.FindElements(By.TagName("input")).Count, Is.EqualTo(3));
    }

    [Test]
    public void basicLocatorsTest_2()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        // Find webElement by linkText        
        Assert.That(Driver.FindElements(By.LinkText("https://fonts.gstatic.com/s/i/productlogos/translate/v14/24px.svg")).Count, Is.EqualTo(0));
        // Find webElement by className
        Assert.That(Driver.FindElement(By.ClassName("login_container")).Displayed);
        // Find webElement by PartialLinkText
        Assert.That(Driver.FindElements(By.PartialLinkText("/productlogos/translate/")).Count, Is.EqualTo(0));
    }
}