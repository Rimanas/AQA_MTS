using SauceDemo.Tests;
using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Tests;

public class CssSelectorTest : BaseTest
{
    [Test]
    public void CssSelectorsTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        // Поиск по id
        Assert.That(Driver.FindElement(By.CssSelector("#password")).Displayed);

        // Поиск по class name
        Assert.That(Driver.FindElement(By.CssSelector(".login_container")).Displayed);

        // Поиск по нескольким значениям в аттрибуте class
        Assert.That(Driver.FindElement(By.CssSelector(".login_wrapper .login-box")).Displayed);

        // Поиск по нескольким значениям в аттрибуте class
        Assert.That(Driver.FindElement(By.CssSelector(".input_error.form_input")).Displayed);

        // Поиск по tag name
        Assert.That(Driver.FindElement(By.CssSelector("input")).Displayed);

        // Поиск по tag и значению из аттрибута class
        Assert.That(Driver.FindElement(By.CssSelector("div.login_logo")).Displayed);

        // Поиск всех элементов с тэгом h1 ----не обязательно
        Assert.That(Driver.FindElements(By.CssSelector("h4")).Count, Is.EqualTo(2));

        // Поиск всех элементов с тэгом h4 у которых непосредственный родитель с тэгом div ----не обязательно
        Assert.That(Driver.FindElements(By.CssSelector("div > h4")).Count, Is.EqualTo(2));

        // Поиск всех элементов у которых присутствует аттрибут id со значением заканчивающимся на какое-то value
        Assert.That(Driver.FindElements(By.CssSelector("[id$='ials']")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут id со значением начинающимся на какое-то слово
        Assert.That(Driver.FindElements(By.CssSelector("[id|=login]")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут id со значением начинающимся на какое-то value
        Assert.That(Driver.FindElements(By.CssSelector("[id^=l]")).Count, Is.EqualTo(3));

        // Поиск всех элементов у которых присутствует аттрибут autocorrect со значением содержащим слово целиком
        Assert.That(Driver.FindElements(By.CssSelector("[autocorrect~='off']")).Count, Is.EqualTo(2));

        // Поиск всех элементов у которых присутствует аттрибут class со значением содержащим какой текст
        Assert.That(Driver.FindElements(By.CssSelector("[class*='wrapper']")).Count, Is.EqualTo(2));

        // Поиск всех элементов у которых присутствует аттрибут placeholder со значением
        Assert.That(Driver.FindElement(By.CssSelector("[placeholder='Username']")).Displayed);

        // Поиск элемента с тэгом h4 и которым является первым дочерним элементом ----не обязательно
        Assert.That(Driver.FindElements(By.CssSelector("h4:first-child")).Count, Is.EqualTo(2));

        // Поиск элемента с тэгом h4 и которым является последним дочерним элементом ----не обязательно
        Assert.That(Driver.FindElements(By.CssSelector("h4:last-child")).Count, Is.EqualTo(1));

        // Поиск элемента с тэгом h4 и которым является n-ым дочерним элементом ----не обязательно
        Assert.That(Driver.FindElements(By.CssSelector("h4:nth-child(1)")).Count, Is.EqualTo(2));
    }
}