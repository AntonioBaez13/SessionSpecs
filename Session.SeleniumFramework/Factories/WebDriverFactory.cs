using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using Session.SeleniumFramework.Enums;

namespace Session.SeleniumFramework.Factories
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create(Browser browser)
        {
            IWebDriver webDriver = null;
            switch (browser)
            {
                case Browser.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case Browser.Ie:
                    webDriver = new InternetExplorerDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, $"Browser selected {browser}, not implemented in this Framework");
            }

            webDriver.Manage().Window.Maximize();

            return webDriver;
        }
    }
}
