namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchActivity")]
    public partial class ElasticSearchActivity
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AssetId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ServiceLineId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ActivityStatusId { get; set; }

        public string ActivityStatusLocalised { get; set; }

        [StringLength(33)]
        public string StatusLastWriteTime { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid ActivityTypeId { get; set; }

        public string ActivityTypeLocalised { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid CurrencyId { get; set; }

        public decimal? AgreedInitialMarketingPrice { get; set; }

        public decimal? KfValuationPrice { get; set; }

        public decimal? VendorValuationPrice { get; set; }

        public Guid? SourceId { get; set; }

        public string SourceLocalised { get; set; }

        public string SourceDescription { get; set; }

        public Guid? SellingReasonId { get; set; }

        public string PitchingThreats { get; set; }

        [StringLength(128)]
        public string KeyNumber { get; set; }

        public string AccessArrangements { get; set; }

        public decimal? ServiceChargeAmount { get; set; }

        public string ServiceChargeNote { get; set; }

        public decimal? GroundRentAmount { get; set; }

        public string GroundRentNote { get; set; }

        public string OtherCondition { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsPeppercorn { get; set; }

        public Guid? DisposalTypeId { get; set; }

        public decimal? ShortKfValuationWeeklyPrice { get; set; }

        public decimal? LongKfValuationWeeklyPrice { get; set; }

        public decimal? ShortKfValuationMonthlyPrice { get; set; }

        public decimal? LongKfValuationMonthlyPrice { get; set; }

        public Guid? PriceTypeId { get; set; }

        public decimal? ShortAskingWeekRent { get; set; }

        public decimal? ShortAskingMonthRent { get; set; }

        public decimal? LongAskingWeekRent { get; set; }

        public decimal? LongAskingMonthRent { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid PropertyTypeId { get; set; }

        public string PropertyTypeLocalised { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool AdvertisingPublishToWeb { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool PublishedToWeb { get; set; }

        public string AdvertisingNote { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool SalesBoardUpToDate { get; set; }

        [StringLength(10)]
        public string SalesBoardRemovalDate { get; set; }

        public string SalesBoardSpecialInstructions { get; set; }

        public Guid? AdvertisingPrPermittedTypeId { get; set; }

        public string AdvertisingPrContent { get; set; }

        public Guid? SalesBoardTypeId { get; set; }

        public Guid? SalesBoardStatusId { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public decimal? QuotedPricePerRoom { get; set; }

        public decimal? AgreedSalePrice { get; set; }

        public decimal? AgreedPricePerRoomMin { get; set; }

        public decimal? AgreedPricePerRoomMax { get; set; }

        public decimal? AgreedPricePerRoomMinSort { get; set; }

        public decimal? AgreedPricePerRoomMaxSort { get; set; }

        public decimal? QuotedPricePerBed { get; set; }

        public decimal? AgreedPricePerBed { get; set; }

        public decimal? AgreedNetInitialYield { get; set; }

        public decimal? QuotedPrice { get; set; }

        public decimal? AgreedPrice { get; set; }

        public decimal? AgreedRentPA { get; set; }

        public decimal? AgreedRentPAMin { get; set; }

        public decimal? AgreedRentPAMax { get; set; }

        public decimal? QuotingRentPAMin { get; set; }

        public decimal? QuotingRentPAMax { get; set; }

        public decimal? RentFreePeriod { get; set; }

        public string QuotingTermsComments { get; set; }

        public decimal? QuotedReversionaryYield { get; set; }

        public decimal? AgreedReversionaryYield { get; set; }

        public decimal? QuotedNetEquivalentYield { get; set; }

        public decimal? AgreedNetEquivalentYield { get; set; }

        public decimal? QuotedTaxEquivalentYield { get; set; }

        public decimal? AgreedTaxEquivalentYield { get; set; }

        public decimal? QuotedGrossInitialYield { get; set; }

        public decimal? AgreedGrossInitialYield { get; set; }

        public Guid? PurposeId { get; set; }

        [StringLength(10)]
        public string IncomeDate { get; set; }

        public Guid? OwnershipTenureId { get; set; }

        public decimal? QuotingRentPAForMatching { get; set; }

        [Key]
        [Column(Order = 11)]
        public Guid AgencyTypeId { get; set; }

        public string AgencyTypeLocalised { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool Deleted { get; set; }

        [StringLength(10)]
        public string MarketedDate { get; set; }

        [StringLength(10)]
        public string InstructedDate { get; set; }

        [StringLength(10)]
        public string ExchangedDate { get; set; }

        public Guid? FurnishingId { get; set; }

        public string FurnishingLocalised { get; set; }

        [Key]
        [Column(Order = 13)]
        public Guid CddStatusId { get; set; }

        public string CddStatusLocalised { get; set; }

        public Guid? GradeId { get; set; }

        public string GradeLocalised { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IsUploaded { get; set; }

        public decimal? NetInitialYield { get; set; }

        public decimal? WAULT { get; set; }

        public Guid? SingleLetId { get; set; }

        public string SingleLetLocalised { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool IsServicedProperty { get; set; }

        public bool? IsNewBuild { get; set; }

        public Guid? SalePotentialId { get; set; }

        public Guid? InformationQualityId { get; set; }

        public string InformationQualityLocalised { get; set; }

        public Guid? DevPipelineDevelopmentTypeId { get; set; }

        public string DevPipelineDevelopmentTypeLocalised { get; set; }

        public Guid? DevPipelineDevelopmentProbabilityId { get; set; }

        public string DevPipelineDevelopmentProbabilityLocalised { get; set; }

        public Guid? DevPipelineSpeculativePreLetId { get; set; }

        public string DevPipelineSpeculativePreLetLocalised { get; set; }

        public string DevPipelineComments { get; set; }

        public Guid? DevPipelineConstructionStartQuarterId { get; set; }

        public decimal? DevPipelineConstructionStartYear { get; set; }

        [StringLength(10)]
        public string DevPipelineConstructionStartDate { get; set; }

        public Guid? DevPipelineCompletionDateQuarterId { get; set; }

        public decimal? DevPipelineCompletionDateYear { get; set; }

        [StringLength(10)]
        public string DevPipelineCompletionDate { get; set; }

        public int? SalePotentialPrimarySortOrder { get; set; }

        public bool? ReLet { get; set; }

        [StringLength(10)]
        public string AvailableDate { get; set; }

        [StringLength(10)]
        public string UnderOfferDate { get; set; }

        [StringLength(10)]
        public string LeaseExpiryDate { get; set; }

        [StringLength(10)]
        public string LeaseCommencementDate { get; set; }

        public int? LeaseLengthMonths { get; set; }

        public int? CompletionDateMonthDayAsNumber { get; set; }

        public int? CompletionDateYear { get; set; }

        public Guid? KeyHolderTypeId { get; set; }

        public string KeyHolderTypeLocalised { get; set; }

        public Guid? LostFromId { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsFromDevelopmentPipeline { get; set; }

        public string Comments { get; set; }

        public decimal? MinBedrooms { get; set; }

        public decimal? MaxBedrooms { get; set; }

        public string LostFromLocalised { get; set; }

        public bool? IsKnightFrankDeal { get; set; }

        public string ActivityCharacteristics { get; set; }

        public string Asset { get; set; }

        public string Parties { get; set; }

        public string Matches { get; set; }

        public string ActivityUsers { get; set; }

        [StringLength(40)]
        public string LeadNegotiatorLastName { get; set; }

        [StringLength(10)]
        public string LeadNegotiatorCallDate { get; set; }

        public string MinAreaBreakdown { get; set; }

        public string TotalAreaBreakdown { get; set; }

        public string AreaHierarchies { get; set; }

        public string AreaHierarchiesNames { get; set; }

        public string MinAvailableSize { get; set; }

        public string AvailableSize { get; set; }

        public string CompletedSize { get; set; }

        public string UnderOfferSize { get; set; }

        public string AreaBreakdowns { get; set; }

        public string ActivityDepartments { get; set; }

        [StringLength(255)]
        public string ManagingDepartment { get; set; }

        public string QuotedCapitalValue { get; set; }

        public string AgreedCapitalValue { get; set; }

        public string QuotingRentMin { get; set; }

        public string QuotingRentMax { get; set; }

        public string AgreedRentMin { get; set; }

        public string AgreedRentMax { get; set; }

        public string TotalRent { get; set; }

        public string ActivityMainImage { get; set; }

        public string ActivityNextImage { get; set; }

        public string Aspect { get; set; }

        public string StarRating { get; set; }

        public string ActivityAttributeValues { get; set; }

        public string UnitActivities { get; set; }

        public string Appointments { get; set; }

        public string Offers { get; set; }

        public decimal? PortfolioAveragePrice { get; set; }

        public string MinPortfolioArea { get; set; }

        public string PortfolioArea { get; set; }

        public string TotalPortfolioArea { get; set; }

        public string PortfolioPropertyTypes { get; set; }

        public int? PortfolioPropertiesCount { get; set; }

        public string PortfolioPropertyCountries { get; set; }

        public string LatestNote { get; set; }

        public string ActivityLocalisedValues { get; set; }

        public string MinSize { get; set; }

        public string MaxSize { get; set; }

        public string MinSizeCommitted { get; set; }

        public string MaxSizeCommitted { get; set; }

        public string MinSizeSpeculative { get; set; }

        public string MaxSizeSpeculative { get; set; }

        public decimal? ActivityPriceMin { get; set; }

        public decimal? ActivityPriceMax { get; set; }

        public decimal? PriceMinSquareFeet { get; set; }

        public decimal? PriceMinSquareMeter { get; set; }

        public decimal? ActivityPriceMinSort { get; set; }

        public decimal? ActivityPriceMaxSort { get; set; }

        public string EstimatedRates { get; set; }

        public string EstimatedServiceCharge { get; set; }

        public decimal? EstimatedRentalValuePA { get; set; }

        public string EstimatedRentalValue { get; set; }

        public string ZoneARent { get; set; }

        public decimal? ITZA { get; set; }

        public decimal? RentPA { get; set; }

        public bool? IsAreaBreakdownInAcres { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }
    }
}
