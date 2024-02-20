using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicCW.Core
{
    public class SimpleDriver
    {
        public IWebDriver Driver
        {
            get
            {
                var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                return new ChromeDriver(basePath + @"\Resources\");
               // return new ChromeDriver(
                //    @"C:\Users\Alina\Downloads\chromedriver-win64 (1)\chromedriver-win64"); // путь на директорию
            
            }
        }
    }
}
