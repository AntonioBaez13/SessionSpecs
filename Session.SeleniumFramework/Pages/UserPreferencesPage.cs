using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Session.SeleniumFramework.Extensions;
using Session.SeleniumFramework.Support;

namespace Session.SeleniumFramework.Pages
{
    public class UserPreferencesPage
    {
        private readonly IWebDriver webDriver;
        private readonly string lyncAppLocator = "lyncAppId";
        public UserPreferencesPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        internal void OpenPreferences()
        {
            var webElement = this.webDriver.FindElementByXpath("//li[@role='menuitem']//a[@ui-sref='app.preferences']");
            webElement.Click();
        }

        public bool IsHubSkypeSwitchPresent()
        {
            try
            {
                var webElement = this.webDriver.WaitForElementToBeClickableById(lyncAppLocator, WaitTime.Five);
                return webElement.Displayed;
            }
            catch (NoSuchElementException nse)
            {
                return false;
            }
            catch (Exception e)
            {
                throw ErrorMessage(e);
            }

        }

        public bool IsHubSkypeSwitchOffByDefault()
        {
            try
            {
                var webElement = this.webDriver.FindElementById(lyncAppLocator);

                return webElement.Selected;
            }
            catch (NoSuchElementException nse)
            {
                return false;
            }
            catch (Exception e)
            {
                throw ErrorMessage(e);
            }
        }

        private static Exception ErrorMessage(Exception e)
        {
            return new Exception($"Error Message: {e.InnerException} ");
        }


    }
}
