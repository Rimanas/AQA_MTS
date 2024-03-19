using NUnit.Framework;
using SeleniumAdvancedHomeWork.Core;
using SeleniumAdvancedHomeWork.Helpers.Configuration;
using OpenQA.Selenium;
using SeleniumAdvancedHomeWork.Helpers;

namespace SeleniumAdvancedHomeWork.Tests;
//[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}