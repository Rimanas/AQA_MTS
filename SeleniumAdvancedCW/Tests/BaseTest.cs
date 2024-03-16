using NUnit.Framework;
using SeleniumAdvancedCW.Core;
using SeleniumAdvancedCW.Utilites.Configuration;
using OpenQA.Selenium;

namespace SeleniumAdvancedCW.Tests;

public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}