using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session.SeleniumFramework.Factories
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            return webDriver;
        }
    }
}
