namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchActivityAdminWidget")]
    public partial class ElasticSearchActivityAdminWidget
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        public DateTimeOffset? LatestPublishToWebDate { get; set; }

        [StringLength(33)]
        public string ActivityMainImageCreationTime { get; set; }

        [StringLength(33)]
        public string AttachmentMainImageCreationTime { get; set; }

        public Guid? CurrentLocationCountryId { get; set; }

        public Guid? CurrentLocationAddressFormId { get; set; }

        [StringLength(128)]
        public string CurrentLocationPropertyName { get; set; }

        [StringLength(140)]
        public string CurrentLocationPropertyNumber { get; set; }

        [StringLength(128)]
        public string CurrentLocationLine1 { get; set; }

        [StringLength(128)]
        public string CurrentLocationLine2 { get; set; }

        [StringLength(128)]
        public string CurrentLocationLine3 { get; set; }

        [StringLength(32)]
        public string CurrentLocationPostcode { get; set; }

        [StringLength(128)]
        public string CurrentLocationCity { get; set; }

        [StringLength(128)]
        public string CurrentLocationCounty { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AgencyTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ActivityTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ServiceLineId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid StatusId { get; set; }

        public string StatusLocalised { get; set; }

        public decimal? MinSizeSquareFeet { get; set; }

        public decimal? MinSizeSquareMeter { get; set; }

        public decimal? MaxSizeSquareFeet { get; set; }

        public decimal? MaxSizeSquareMeter { get; set; }

        public decimal? MaxSizeHectare { get; set; }

        public decimal? MaxSizeAcre { get; set; }

        public bool? IsKnightFrankDeal { get; set; }

        public string LandlordOrVendor { get; set; }

        public int? MinBeds { get; set; }

        public int? MaxBeds { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextCall { get; set; }

        public string Negotiators { get; set; }

        public decimal? QuotedPrice { get; set; }

        public decimal? NetInitialYield { get; set; }

        public bool? HasMarketingStrapline { get; set; }

        public bool? HasFullDescription { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid CddId { get; set; }

        public string CddLocalised { get; set; }

        public Guid? PriceMinCurrencyId { get; set; }

        public decimal? PriceMinSquareFeet { get; set; }

        public decimal? PriceMinSquareMeter { get; set; }

        public decimal? Price { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid CurrencyId { get; set; }

        public decimal? QuotingRentMinMeter { get; set; }

        public decimal? QuotingRentMinFeet { get; set; }

        public decimal? QuotingRentMaxMeter { get; set; }

        public decimal? QuotingRentMaxFeet { get; set; }

        public Guid? QuotingRentCurrencyId { get; set; }

        public string Agents { get; set; }

        public string CurrentTenancy { get; set; }

        public decimal? RentShortLetMonth { get; set; }

        public decimal? RentShortLetWeek { get; set; }

        public decimal? RentLongLetMonth { get; set; }

        public decimal? RentLongLetWeek { get; set; }

        public Guid? FurnishingId { get; set; }

        public string FurnishingLocalised { get; set; }

        public decimal? PriceMin { get; set; }

        public decimal? PriceMax { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EpcExpiryDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EpcExemption { get; set; }

        public string Attachments { get; set; }

        public bool? HasAdvertisement { get; set; }

        public bool? HasViewingForTBSRequirement { get; set; }

        public bool? HasAcceptedOfferForTBSRequirement { get; set; }

        public string Offers { get; set; }

        public bool? IsAreaBreakdownInAcres { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }
    }
}
