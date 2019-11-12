namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostCodeShape")]
    public partial class PostCodeShape
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(32)]
        public string PostCode { get; set; }

        public Guid CountryId { get; set; }

        public int AreaLevel { get; set; }

        [Required]
        public DbGeography Shape { get; set; }

        public virtual Country Country { get; set; }
    }
}
