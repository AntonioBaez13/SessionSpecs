namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchMarketingList")]
    public partial class ElasticSearchMarketingList
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string ListName { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        public string Department { get; set; }

        public string Owner { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }
    }
}
