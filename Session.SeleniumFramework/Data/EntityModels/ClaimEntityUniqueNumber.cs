namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimEntityUniqueNumber")]
    public partial class ClaimEntityUniqueNumber
    {
        [Key]
        public int UniqueNumber { get; set; }

        public Guid EntityId { get; set; }
    }
}
