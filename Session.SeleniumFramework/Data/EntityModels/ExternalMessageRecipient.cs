namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalMessageRecipient")]
    public partial class ExternalMessageRecipient
    {
        public Guid Id { get; set; }

        public Guid ExternalMessageId { get; set; }

        [StringLength(254)]
        public string EmailAddress { get; set; }

        public Guid TypeId { get; set; }

        public bool MessageSent { get; set; }

        public Guid? NegotiatorId { get; set; }

        public Guid? ContactId { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual ExternalMessage ExternalMessage { get; set; }

        public virtual User User { get; set; }
    }
}
