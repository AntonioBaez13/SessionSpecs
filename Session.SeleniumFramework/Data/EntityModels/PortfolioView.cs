namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PortfolioView")]
    public partial class PortfolioView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        public int? PropertiesCount { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? CompanyId { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTimeOffset CreationTime { get; set; }
    }
}
