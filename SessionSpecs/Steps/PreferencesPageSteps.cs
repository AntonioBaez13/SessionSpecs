﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Session.SeleniumFramework.Pages;
using TechTalk.SpecFlow;

namespace SessionSpecs.Steps
{
    [Binding]
    public sealed class PreferencesPageSteps
    {

        private readonly ScenarioContext context;
        private readonly UserPreferencesPage userPreferencesPage;

        public PreferencesPageSteps(UserPreferencesPage userPreferencesPage)
        {
            this.userPreferencesPage = userPreferencesPage;
        }

        [Then(@"I can see the Lync App setting switch in my Basic Settings")]
        public void ThenICanSeeTheLyncAppSettingSwitchInMyBasicSettings()
        {
            var isHubSkypeSwitchPresent = this.userPreferencesPage.IsHubSkypeSwitchPresent();

            Assert.IsTrue(isHubSkypeSwitchPresent, "I can't see the Lync App setting switch in my Basic Settings");
        }
        [Then(@"Lync App setting switch is ON by default")]
        public void ThenLyncAppSettingSwitchIsOnByDefault()
        {
            var isHubSkypeSwitchOnByDefault = this.userPreferencesPage.IsHubSkypeSwitchOnByDefault();

            Assert.IsTrue(isHubSkypeSwitchOnByDefault, "Lync App setting switch is OFF by default");
        }
        

    }
}
