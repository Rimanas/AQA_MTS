using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace SeleniumBasic.Core
{
    public class AdvancedDriver
    {
        private string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        public IWebDriver GetChromeDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--incognito");   // запукаем в приватном режиме
            chromeOptions.AddArguments("--disable-gpu");  // отключаем свой графический процессор
            chromeOptions.AddArguments("--disable-extensions");  //отключить всякие дополнения
            //chromeOptions.AddArguments("--headless");

            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);  // включаем логирование
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);   // включаем логирование

            return new ChromeDriver(path + @"/Resources/", chromeOptions);
        }
        public IWebDriver GetFirefoxDriver()
        {
            var mimeTypes =
                "image/png,image/gif,image/jpeg,image/pjpeg,application/pdf,text/csv,application/vnd.ms-excel," +
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" +
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

            var ffOptions = new FirefoxOptions();
            var profile = new FirefoxProfile();

            profile.SetPreference("browser.download.folderList", 2);
            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", mimeTypes);
            profile.SetPreference("browser.helperApps.neverAsk.openFile", mimeTypes);
            ffOptions.Profile = profile;

            ffOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            return new FirefoxDriver(ffOptions);
        }
    }
}
