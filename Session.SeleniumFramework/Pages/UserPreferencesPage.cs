using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Session.SeleniumFramework.Extensions;

namespace Session.SeleniumFramework.Pages
{
    public class UserPreferencesPage
    {
        private readonly IWebDriver webDriver;

        public UserPreferencesPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        internal void OpenPreferences()
        {
            var webElement = this.webDriver.FindElement(By.XPath("//li[@role='menuitem']//a[@ui-sref='app.preferences']"));
            webElement.Click();
        }

        public bool IsHubSkypeSwitchPresent()
        {
            try
            {
                var webElement = this.webDriver.FindElementById("lyncAppId");

                return webElement.Displayed;
            }
            catch (NoSuchElementException nse)
            {
                return false;
            }
            catch (Exception e)
            {
                throw new Exception($"Error Message: {e.InnerException} ");
            }

        }

        public bool IsHubSkypeSwitchOnByDefault()
        {
            try
            {
                var webElement = this.webDriver.FindElementById("lyncAppId");

                return webElement.Selected;
            }
            catch (NoSuchElementException nse)
            {
                return false;
            }
            catch (Exception e)
            {
                throw new Exception($"Error Message: {e.InnerException} ");
            }
        }


    }
}
