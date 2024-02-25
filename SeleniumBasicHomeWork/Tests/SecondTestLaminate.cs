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
        IWebElement lnRoom = Driver.FindElement(By.Id("ln_room_id"));                          // Длина комнаты
        IWebElement wdRoom = Driver.FindElement(By.Id("wd_room_id"));                          // Ширина комнаты
        IWebElement lnLam = Driver.FindElement(By.Id("ln_lam_id"));                            // Длина плашки
        IWebElement wdLam = Driver.FindElement(By.Id("wd_lam_id"));                            // Ширина плашки
        IWebElement nPacking = Driver.FindElement(By.Id("n_packing"));                         // Число плашек в упаковке
        IWebElement area = Driver.FindElement(By.Id("area"));                                  // Площадь упаковки
        IWebElement directionLaminate = Driver.FindElement(By.Id("direction-laminate-id1"));   // Направление укладки
        IWebElement layingMethodLam = Driver.FindElement(By.Id("laying_method_laminate"));     // Способ укладки
        IWebElement indentWalls = Driver.FindElement(By.Id("indent_walls_id"));                // Отступ от стен
        IWebElement calculateButton = Driver.FindElement(By.Id("btn_calculate"));              // Кнопка Рассчитать


        Assert.Multiple(() =>
        {

           
        });
    }
}