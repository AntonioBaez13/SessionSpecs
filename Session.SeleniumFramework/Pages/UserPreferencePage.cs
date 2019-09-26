using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Session.SeleniumFramework.Pages
{
    public class UserPreferencePage
    {
        private readonly IWebDriver webDriver;

        public UserPreferencePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        internal void OpenPreferences()
        {
            var webElement = this.webDriver.FindElement(By.XPath("//li[@role='menuitem']//a[@ui-sref='app.preferences']"));
            webElement.Click();
        }
    }
}
