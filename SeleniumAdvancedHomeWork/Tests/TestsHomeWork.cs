using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvancedHomeWork.Tests
{
    public class TestsHomeWork : BaseTest
    {
        [Test, Order(1)]
        [Description("Test for page Context Menu")]
        public void ContextMenuTest()
        {
            Actions actions = new Actions(Driver);
            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Context Menu")).Click();
            // Правая кнопка мыши по элементу
            actions.ContextClick(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot"))).Perform();
            /*
            //или другой способ
            actions
                .MoveToElement(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot")), 20, 20)
                .ContextClick()
                .Build()
                .Perform();
            */
            //Обработать Алерт
            IAlert alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
            alert.Accept();
        }
        [Test, Order(2)]
        [Description("Test for page Dynamic Control")]
        public void DynamicControlTest()
        {
            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Dynamic Controls")).Click();
            var inputField = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='text']"));
            // Нажать на кнопку remove
            WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@type='button' and text()='Remove']")).Click();
            // Дождаться надписи “It’s gone” , проверить ее 
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
            // Проверить, что чекбокса нет
            Assert.That(WaitsHelper.WaitForElementInvisible(By.CssSelector("[label~='blah']")));
            //Найти инпут / Проверить, что он disabled
            Assert.That(!inputField.Enabled);
            // Нажать на кнопку Enable
            WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@type='button' and text()='Enable']")).Click();
            // Дождаться надписи “It's enabled!”
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
            // Проверить, что инпут enabled
            Assert.That(inputField.Enabled);
        }
        [Test, Order(3)]
        [Description("Test for page File Upload")]
        public void FileUploadTest()
        {
            var myFile = "myFile.jpg";
            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("File Upload")).Click();
            var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));
            // Получаем путь к исполняемому файлу (exe)
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // Конструируем путь к файлу внутри проекта
            string filePath = Path.Combine(assemblyPath, "Resources", myFile);
            fileUploadPath.SendKeys(filePath);
            // Нажать кнопку Upload        
            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
            // Проверить, что имя файла на странице совпадает с именем загруженного файла
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("uploaded-files")).Text, Is.EqualTo(myFile));
        }
        [Test, Order(4)]
        [Description("Test for page Frames")]
        public void FramesTest()
        {
            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("Frames")).Click();
            //Открыть страницу iFrame
            WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("iFrame")).Click();
            //Найти нужный фрейм, содержащий текст
            Driver.SwitchTo().Frame(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("mce_0_ifr")));
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@class='mce-content-body ']")).Text, Is.EqualTo("Your content goes here."));
        }
    }
}