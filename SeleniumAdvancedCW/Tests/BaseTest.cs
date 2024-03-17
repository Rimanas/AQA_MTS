using NUnit.Framework;
using SeleniumAdvancedCW.Core;
using SeleniumAdvancedCW.Helpers.Configuration;
using OpenQA.Selenium;
using SeleniumAdvancedCW.Helpers;

namespace SeleniumAdvancedCW.Tests;
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
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}