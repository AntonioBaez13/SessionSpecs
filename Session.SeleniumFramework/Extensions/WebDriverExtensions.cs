using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Session.SeleniumFramework.Extensions
{
    public static class WebDriverExtensions
    {
        public static void GoToPage(this IWebDriver webDriver, string pageUrl)
        {
            webDriver.Navigate().GoToUrl(pageUrl);
        }

        public static IWebElement FindElementById(this IWebDriver webDriver, string elementId)
        {
            var webElement = webDriver.FindElement(By.Id(elementId));
            return webElement;
        }
        public static IWebElement FindElementByXpath(this IWebDriver webDriver, string elementXpath)
        {
            var webElement = webDriver.FindElement(By.XPath(elementXpath));
            return webElement;
        }

        public static IWebElement WaitForElementToBeClickableById(this IWebDriver webDriver, string elementId,
            double timeOut=60)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeOut));
            var webElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(elementId)));
            return webElement;
        }
    }
}
