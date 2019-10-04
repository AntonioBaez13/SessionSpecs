using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.webDriver.Navigate().GoToUrl("https://uat.hub.knightfrank.com/#/app/dashboard");
        }

        public void OpenUserPreference()
        {
            ClickUserPreferences();

            this.userPreferencePage.OpenPreferences();
        }

        private void ClickUserPreferences()
        {
            var webElement = this.webDriver.FindElement(By.Id("topbar-menu-button"));
            webElement.Click();
        }
    }
}
