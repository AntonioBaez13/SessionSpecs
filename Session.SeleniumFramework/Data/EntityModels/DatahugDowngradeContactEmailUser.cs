namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatahugDowngradeContactEmailUser")]
    public partial class DatahugDowngradeContactEmailUser
    {
        [Key]
        public Guid ContactEmailUserId { get; set; }

        public short LoweredHugRank { get; set; }

        public virtual ContactEmailUser ContactEmailUser { get; set; }
    }
}
