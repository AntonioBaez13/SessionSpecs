namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactEmailUser")]
    public partial class ContactEmailUser
    {
        public Guid Id { get; set; }

        public Guid ContactEmailId { get; set; }

        public Guid UserId { get; set; }

        public short DataHugRank { get; set; }

        public DateTimeOffset? LastInteractionDate { get; set; }

        public virtual ContactEmail ContactEmail { get; set; }

        public virtual User User { get; set; }

        public virtual DatahugDowngradeContactEmailUser DatahugDowngradeContactEmailUser { get; set; }
    }
}
