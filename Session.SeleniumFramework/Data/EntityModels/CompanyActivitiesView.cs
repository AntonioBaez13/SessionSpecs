namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyActivitiesView")]
    public partial class CompanyActivitiesView
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        public Guid? CompanyId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string CompanyName { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ActivityTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ActivityStatusId { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid ServiceLineId { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public Guid? AddressId { get; set; }

        public Guid? AddressCountryId { get; set; }

        [StringLength(128)]
        public string AddressPropertyName { get; set; }

        [StringLength(140)]
        public string AddressPropertyNumber { get; set; }

        [StringLength(128)]
        public string AddressLine1 { get; set; }

        [StringLength(128)]
        public string AddressLine2 { get; set; }

        [StringLength(128)]
        public string AddressLine3 { get; set; }

        [StringLength(32)]
        public string AddressPostcode { get; set; }

        [StringLength(128)]
        public string AddressCity { get; set; }

        [StringLength(128)]
        public string AddressCounty { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid PropertyTypeId { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid CurrencyId { get; set; }

        public decimal? ActivityPrice { get; set; }

        public decimal? QuotedPrice { get; set; }

        public decimal? AgreedPrice { get; set; }

        public decimal? ShortAskingWeekRent { get; set; }

        public decimal? ShortAskingMonthRent { get; set; }

        public decimal? LongAskingWeekRent { get; set; }

        public decimal? LongAskingMonthRent { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? MaxPrice { get; set; }

        public decimal? QuotingRentMinMeter { get; set; }

        public decimal? QuotingRentMinFeet { get; set; }

        public decimal? QuotingRentMaxMeter { get; set; }

        public decimal? QuotingRentMaxFeet { get; set; }

        [StringLength(81)]
        public string LeadNegotiator { get; set; }

        public bool? IsLeadNegotiatorActive { get; set; }

        public int? SortOrder { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string Discriminator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MarketedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExchangedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UnderOfferDate { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTimeOffset LastWriteTime { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTimeOffset CreationTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TenancyStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReservedDate { get; set; }

        public DateTimeOffset? AppraisalDate { get; set; }
    }
}
