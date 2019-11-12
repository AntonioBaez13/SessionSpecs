using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session.SeleniumFramework.Data.EntityModels;
using Session.SeleniumFramework.Data.Generators;

namespace Session.SeleniumFramework.Data.Services
{
    public class ContactService
    {
        private readonly ContactSeedGenerator contactSeedGenerator;

        public ContactService(ContactSeedGenerator contactSeedGenerator)
        {
            this.contactSeedGenerator = contactSeedGenerator;
        }

        public Contact Generate()
        {
            throw new NotImplementedException();
        }
    }
}
