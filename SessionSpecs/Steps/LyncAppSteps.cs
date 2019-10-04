using Session.SeleniumFramework.Pages;
using TechTalk.SpecFlow;

namespace SessionSpecs.Steps
{
    [Binding]
    public sealed class LyncAppSteps
    {
        
        private readonly HomePage homePage;

        public LyncAppSteps(HomePage homePage)
        {
            this.homePage = homePage;
        }


        [Given(@"I am an active user in hub")]
        public void GivenIAmAnActiveUserInHub()
        {
            this.homePage.Launch();
        }

    }
}
