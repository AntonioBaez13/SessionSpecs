namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatahugDowngradeCompanyDomainUser")]
    public partial class DatahugDowngradeCompanyDomainUser
    {
        [Key]
        public Guid CompanyDomainUserId { get; set; }

        public short LoweredHugRank { get; set; }

        public virtual CompanyDomainUser CompanyDomainUser { get; set; }
    }
}
