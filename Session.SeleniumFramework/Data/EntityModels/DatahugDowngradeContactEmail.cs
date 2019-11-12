namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatahugDowngradeContactEmail")]
    public partial class DatahugDowngradeContactEmail
    {
        [Key]
        public Guid ContactEmailId { get; set; }

        public short LoweredHugRank { get; set; }

        public virtual ContactEmail ContactEmail { get; set; }
    }
}
