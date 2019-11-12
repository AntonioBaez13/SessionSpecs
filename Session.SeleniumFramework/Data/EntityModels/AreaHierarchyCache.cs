namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaHierarchyCache")]
    public partial class AreaHierarchyCache
    {
        [Key]
        [Column(Order = 0)]
        public Guid AreaId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CountryId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid DivisionId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string PostCode { get; set; }
    }
}
