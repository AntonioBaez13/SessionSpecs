namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchShapePostCode")]
    public partial class ElasticSearchShapePostCode
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(35)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string Postcode { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CountryId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AreaLevel { get; set; }

        public string GeoShape { get; set; }
    }
}
