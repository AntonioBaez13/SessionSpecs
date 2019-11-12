namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyDomainUser")]
    public partial class CompanyDomainUser
    {
        public Guid Id { get; set; }

        public short DataHugRank { get; set; }

        public DateTimeOffset? LastInteractionDate { get; set; }

        public Guid CompanyDomainId { get; set; }

        public Guid UserId { get; set; }

        public virtual CompanyDomain CompanyDomain { get; set; }

        public virtual User User { get; set; }

        public virtual DatahugDowngradeCompanyDomainUser DatahugDowngradeCompanyDomainUser { get; set; }
    }
}
