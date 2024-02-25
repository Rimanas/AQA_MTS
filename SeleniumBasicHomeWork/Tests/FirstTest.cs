using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(2000);
        //Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src]")));
        IWebElement age = Driver.FindElement(By.Id("age"));                         //поле Возраст
        IWebElement selectWebElementSex = Driver.FindElement(By.Id("sex"));         //поле Пол
        SelectElement selectSex = new SelectElement(selectWebElementSex);              
        IWebElement creatin = Driver.FindElement(By.Id("cr"));                      //поле Креатин
        IWebElement selectWebElementCrSize = Driver.FindElement(By.Id("cr-size"));  //поле Размер Креатина
        SelectElement crSize = new SelectElement(selectWebElementCrSize);
        IWebElement selectWebElementRace = Driver.FindElement(By.Id("race"));         //поле Раса
        SelectElement selectRace = new SelectElement(selectWebElementRace);              
        IWebElement mass = Driver.FindElement(By.Id("mass"));
        IWebElement grow = Driver.FindElement(By.Id("grow"));                        //Рост
        IWebElement calcButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
        IWebElement mdrd = Driver.FindElement(By.Id("mdrd_res"));
        IWebElement ckdEpi = Driver.FindElement(By.Id("ckd_epi_res"));
        IWebElement cgeRes = Driver.FindElement(By.Id("cge_res"));
        IWebElement schwartzRes = Driver.FindElement(By.Id("schwartz_res"));

        age.SendKeys("20");
        selectSex.SelectByIndex(2);    //Женский 
        Thread.Sleep(2000);
        creatin.SendKeys("0,003");
        crSize.SelectByText("мг/дл");
        Thread.Sleep(2000);
        selectRace.SelectByIndex(1);  // раса - Другая
        Thread.Sleep(2000);
        mass.SendKeys("50");
        grow.SendKeys("165");
        calcButton.Click();

        Assert.Multiple(() =>
        {
            //MDRD
            Assert.That(mdrd.Text, Is.EqualTo("55087.44"));
            

            //CKD-EPI
            Assert.That(ckdEpi.Text, Is.EqualTo("724.04"));

            //Формула Кокрофта-Голта
            Assert.That(cgeRes.Text, Is.EqualTo("22627.31"));

            //Формула Шварца
            Assert.That(schwartzRes.Text, Is.EqualTo("30485.84"));
        });
    }
}