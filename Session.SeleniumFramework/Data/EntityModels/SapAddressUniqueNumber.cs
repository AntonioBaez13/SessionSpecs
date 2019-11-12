namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SapAddressUniqueNumber")]
    public partial class SapAddressUniqueNumber
    {
        [Key]
        public Guid AddressId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniqueNumber { get; set; }

        public virtual Address Address { get; set; }
    }
}
