using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Session.SeleniumFramework.Extensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElementById(this IWebDriver webDriver, string elementId)
        {
            var webElement = webDriver.FindElement(By.Id(elementId));
            return webElement;
        }

    }
}
