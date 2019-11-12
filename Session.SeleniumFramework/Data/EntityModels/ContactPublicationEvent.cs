namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactPublicationEvent")]
    public partial class ContactPublicationEvent
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid PublicationEventId { get; set; }

        public Guid SendTypeId { get; set; }

        public Guid SendMethodId { get; set; }

        public Guid? SignatoryId { get; set; }

        public Guid? PrimaryAddressTypeId { get; set; }

        public Guid? UseSpecifiedEmailId { get; set; }

        public bool Unsubscribed { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual ContactEmail ContactEmail { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual PublicationEvent PublicationEvent { get; set; }

        public virtual User User { get; set; }
    }
}
