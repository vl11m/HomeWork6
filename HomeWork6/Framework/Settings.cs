using System;
using System.Configuration;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork6.Framework
{
    class Settings
    {
        public static IWebDriver GetDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        public static string GetBrowserType()
        {
            return ConfigurationManager.AppSettings["browserType"];
        }
    }
}
