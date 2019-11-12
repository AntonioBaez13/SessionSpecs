namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ElasticSearchAsset2
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string AssetType { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid PropertyTypeId { get; set; }

        public Guid? DivisionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        public Guid? TimeZoneId { get; set; }

        public decimal? WAULT { get; set; }

        public Guid? EstateId { get; set; }

        [StringLength(128)]
        public string AssetName { get; set; }

        public bool? IsUnit { get; set; }

        public bool? HasBuilding { get; set; }

        public string Address { get; set; }

        public string AlternateAddress { get; set; }

        public string Ownerships { get; set; }

        public bool? IsCommercial { get; set; }

        public bool? IsResidential { get; set; }

        public int? KfConnection { get; set; }

        public string TotalAreaBreakdown { get; set; }

        public string ActivityMainImage { get; set; }

        public string AttachmentMainImage { get; set; }

        public string PortfolioProperties { get; set; }

        public string Parties { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }
    }
}
