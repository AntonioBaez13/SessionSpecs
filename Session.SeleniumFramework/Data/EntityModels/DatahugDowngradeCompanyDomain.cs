namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatahugDowngradeCompanyDomain")]
    public partial class DatahugDowngradeCompanyDomain
    {
        [Key]
        public Guid CompanyDomainId { get; set; }

        public short LoweredHugRank { get; set; }

        public virtual CompanyDomain CompanyDomain { get; set; }
    }
}
