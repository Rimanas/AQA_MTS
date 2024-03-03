using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    internal class XPathSelectorsTests : BaseTest
    {
        [Test]
        public void XPathSelectors()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            // Поиск элемента у которого есть аттрибут class cо значением error-message-container
            Assert.That(Driver.FindElement(By.XPath("//*[@class= 'error-message-container']")).Displayed);
            // Поиск элемента у которого текстовое значение содержит равно  
            Assert.That(Driver.FindElement(By.XPath("//div[text()='error_user']")).Displayed);
            // Поиск элемента у которого значение аттрибута содержит подстроку
            Assert.That(Driver.FindElement(By.XPath("//div[contains(@id, 'login_credentials')]")).Displayed);
            // Поиск элемента у которого текстовое значение содержит подстроку
            Assert.That(Driver.FindElement(By.XPath("//h4[contains(text(),'Accepted')]")).Displayed);
            //Использование ancestor - все предки текущего узла
            Assert.That(Driver.FindElements(By.XPath("//*[@id='login_credentials']/ancestor::div")).Count, Is.EqualTo(5));
            // Использование child - все дочерние элементы с тэгa от div
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login-box']//descendant::div")).Displayed);
            //Использование following - Выбирает всё в документе после закрытия тэга текущего узла
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login-box']/following::h4")).Displayed);
            // Поиск родителя у элемента с тэгом h1
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login-box']//parent::div")).Displayed);
            //Использование preceding- Выбирает все узлы, которые появляются перед текущим узлом в документе
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login-box']/preceding::div")).Displayed);
            // Поиск элемента у которого есть аттрибут class cо значением и аттрибут name со значением
            Assert.That(Driver.FindElement(By.XPath("//*[@class='submit-button btn_action' and @id='login-button']")).Displayed);
            }
        }
    }