namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactAddressDirectMarketingConsent")]
    public partial class ContactAddressDirectMarketingConsent
    {
        public Guid Id { get; set; }

        public Guid ContactAddressId { get; set; }

        public Guid OrganisationUnitId { get; set; }

        public Guid? DirectMarketingConsentId { get; set; }

        public Guid? ConsentMethodId { get; set; }

        public Guid? ConsentScriptId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual ConsentScript ConsentScript { get; set; }

        public virtual ContactAddress ContactAddress { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
