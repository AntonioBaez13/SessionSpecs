using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Session.SeleniumFramework.Extensions;
using Session.SeleniumFramework.Support;

namespace Session.SeleniumFramework.Pages
{
    public class HomePage
    {
        private readonly IWebDriver webDriver;
        private readonly UserPreferencesPage userPreferencePage;

        public HomePage(IWebDriver webDriver, UserPreferencesPage userPreferencePage)
        {
            this.webDriver = webDriver;
            this.userPreferencePage = userPreferencePage;
        }

        public void Launch()
        {
            this.webDriver.GoToPage("https://uat-smoke.hub.knightfrank.com/#/app/dashboard");
        }

        public void OpenUserPreference()
        {
            ClickUserPreferences();
            this.userPreferencePage.OpenPreferences();
        }

        private void ClickUserPreferences()
        {
            var webElement = this.webDriver.WaitForElementToBeClickableById("topbar-menu-button",WaitTime.Five);

            webElement.Click();
        }
    }
}
