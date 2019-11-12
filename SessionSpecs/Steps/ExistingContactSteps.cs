using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Session.SeleniumFramework.Data.EntityModels;
using Session.SeleniumFramework.Data.Services;
using TechTalk.SpecFlow;

namespace SessionSpecs.Steps
{
    [Binding]
    public sealed class ExistingContactSteps
    {
        private readonly ContactService contactService;

        public ExistingContactSteps(ContactService contactService)
        {
            this.contactService = contactService;
        }

        [Given(@"A user exists on the database")]
        public void GivenAUserExistsOnTheDatabase()
        {
            Contact contact = this.contactService.Generate();
        }

    }
}
