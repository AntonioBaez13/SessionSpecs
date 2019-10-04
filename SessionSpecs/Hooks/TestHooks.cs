using Autofac;
using Autofac.Features.ResolveAnything;
using OpenQA.Selenium;
using Session.SeleniumFramework.Factories;
using SpecFlow.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Session.SeleniumFramework.Enums;
using TechTalk.SpecFlow;

namespace SessionSpecs.Hooks
{
    [Binding]
    public sealed class TestHooks
    {
        private static IWebDriver webDriver;



        [ScenarioDependencies]
        public static ContainerBuilder BeforeScenarioConfigureObjects()
        {
            var containerBuilder = new ContainerBuilder();
            webDriver = WebDriverFactory.Create(Browser.Chrome);
            containerBuilder.RegisterInstance(webDriver);


            containerBuilder.RegisterSource<AnyConcreteTypeNotAlreadyRegisteredSource>();

            return containerBuilder;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }
    }
}
