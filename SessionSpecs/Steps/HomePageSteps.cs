using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Session.SeleniumFramework.Pages;
using TechTalk.SpecFlow;

namespace SessionSpecs.Steps
{
    [Binding]
    public sealed class HomePageSteps
    {
        private readonly HomePage homePage;

        public HomePageSteps(HomePage homePage)
        {
            this.homePage = homePage;
        }

        [When(@"I navigate to the Preferences view for my hub User")]
        public void WhenINavigateToThePreferencesViewForMyHubUser()
        {
            this.homePage.OpenUserPreference();
        }

    }
}
