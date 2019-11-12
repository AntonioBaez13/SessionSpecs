namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalAddressServiceMapping")]
    public partial class ExternalAddressServiceMapping
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string SourceFieldName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TargetFieldId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CountryId { get; set; }

        public int Order { get; set; }

        public Guid Id { get; set; }

        public virtual AddressField AddressField { get; set; }

        public virtual Country Country { get; set; }
    }
}
