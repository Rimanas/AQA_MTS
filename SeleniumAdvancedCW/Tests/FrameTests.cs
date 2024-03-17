﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvancedCW.Tests
{
    public class FrameTests : BaseTest
    {
        [Test]
        public void FrameTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");

            //Driver.SwitchTo().Frame(Driver.FindElement(By.id("mce_0_ifr")));
            //Driver.SwitchTo().Frame(0);
            Driver.SwitchTo().Frame("mce_0_ifr");
            Assert.That(Driver.FindElement(By.Id("tinymce")).Displayed);

            Driver.SwitchTo().ParentFrame();
            Assert.That(Driver.FindElement(By.ClassName("tox-editor-container")).Displayed);
        }
    }
}
