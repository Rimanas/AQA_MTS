using SauceDemo.Helpers.Configuration;
using NUnit.Framework;
using SauceDemo.Core;
using OpenQA.Selenium;

namespace SauceDemo.Tests;

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