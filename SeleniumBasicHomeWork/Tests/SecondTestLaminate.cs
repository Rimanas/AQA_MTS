using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTest.Tests;

public class SecondTestLaminate : BaseTest
{
    [Test]
    public void ValidateLaminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/ ");
        Thread.Sleep(2000);
        IWebElement lnRoom = Driver.FindElement(By.Id("ln_room_id"));                          // Длина комнаты
        IWebElement wdRoom = Driver.FindElement(By.Id("wd_room_id"));                          // Ширина комнаты
        IWebElement lnLam = Driver.FindElement(By.Id("ln_lam_id"));                            // Длина плашки
        IWebElement wdLam = Driver.FindElement(By.Id("wd_lam_id"));                            // Ширина плашки
        IWebElement nPacking = Driver.FindElement(By.Id("n_packing"));                         // Число плашек в упаковке
        IWebElement area = Driver.FindElement(By.Id("area"));                                  // Площадь упаковки
        IWebElement directionLaminate = Driver.FindElement(By.Id("direction-laminate-id1"));   // Направление укладки
        IWebElement selectedWebElementLam = Driver.FindElement(By.Id("laying_method_laminate"));     // Способ укладки
        SelectElement layingMethodLam = new SelectElement(selectedWebElementLam);
        IWebElement minLengthSegmentId = Driver.FindElement(By.Id("min_length_segment_id"));  // Минимальная длина обрезка        IWebElement indentWalls = Driver.FindElement(By.Id("indent_walls_id"));                // Отступ от стен
        IWebElement indentWalls = Driver.FindElement(By.Id("indent_walls_id"));            // Отступ от стен
        IWebElement calculateButton = Driver.FindElement(By.Id("btn_calculate"));              // Кнопка Рассчитать
        // Заполняем значениями
        lnRoom.Clear();
        lnRoom.SendKeys("500");
        wdRoom.Clear();
        wdRoom.SendKeys("400");
        lnLam.Clear();
        lnLam.SendKeys("100");
        wdLam.Clear();
        wdLam.SendKeys("30");
        nPacking.Clear();
        nPacking.SendKeys("10");
        area.Clear();
        area.SendKeys("3");
        directionLaminate.Click();
        layingMethodLam.SelectByValue("2");
        minLengthSegmentId.SendKeys(Keys.Backspace);
        minLengthSegmentId.SendKeys(Keys.Backspace);
        minLengthSegmentId.SendKeys(Keys.Backspace);
        minLengthSegmentId.SendKeys("300");   
        indentWalls.SendKeys(Keys.Backspace);
        indentWalls.SendKeys("8");
        Thread.Sleep(2000);
        calculateButton.Click();
        Thread.Sleep(5000);
        IWebElement areaRoom = Driver.FindElement(By.Id("area_room"));
        IWebElement lengthRoom = Driver.FindElement(By.Id("length_room_dim"));
        IWebElement calcLamResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[1]//span"));
        IWebElement calcPackResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[2]//span"));
        IWebElement calcPriceResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[3]//span"));
        IWebElement calcWeightResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[4]//span"));
        Assert.Multiple(() =>
        {
            Assert.That(areaRoom.Text, Is.EqualTo("Площадь комнаты: 20 м2"));
            Assert.That(lengthRoom.Text, Is.EqualTo("Длина 498.4 см"));
            Assert.That(calcLamResult.Text, Is.EqualTo("61792"));
            Assert.That(calcPackResult.Text, Is.EqualTo("6180"));
            Assert.That(calcPriceResult.Text, Is.EqualTo("0 руб"));
            Assert.That(calcWeightResult.Text, Is.EqualTo("0 кг"));

        }); 
        //или
         string result = Driver.FindElement(By.ClassName("calc-result")).Text;
        Assert.That(result.Contains("Требуемое количество плашек ламината: 61792")
            && result.Contains("Количество упаковок ламината: 6180")
            && result.Contains("Стоимость ламината: 0 руб")
            && result.Contains("Вес ламината: 0 кг"));
    }
}