namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CacheItem")]
    public partial class CacheItem
    {
        [Key]
        [StringLength(256)]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Expiration { get; set; }

        [StringLength(256)]
        public string DependentKey { get; set; }
    }
}
