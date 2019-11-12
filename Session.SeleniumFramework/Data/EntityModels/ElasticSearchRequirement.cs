namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchRequirement")]
    public partial class ElasticSearchRequirement
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [StringLength(33)]
        public string CreationTime { get; set; }

        [StringLength(33)]
        public string StatusLastWriteTime { get; set; }

        public string RequirementStatusLocalised { get; set; }

        public string RequirementTypeLocalised { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RequirementTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RequirementStatusId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid CurrencyId { get; set; }

        public string Description { get; set; }

        public decimal? RentWeeklyMin { get; set; }

        public decimal? RentWeeklyMax { get; set; }

        public decimal? RentMonthlyMin { get; set; }

        public decimal? RentMonthlyMax { get; set; }

        public Guid? SourceId { get; set; }

        public string SourceLocalised { get; set; }

        public string SourceDescription { get; set; }

        public Guid? BuyingReasonId { get; set; }

        public Guid? SellingPositionId { get; set; }

        public Guid? SellingStatusId { get; set; }

        public Guid? FinancialServicesStatusId { get; set; }

        public string PostCodes { get; set; }

        public string Cities { get; set; }

        public string Countries { get; set; }

        public Guid? HotId { get; set; }

        public int? HotPrimarySortOrder { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsPotentialClient { get; set; }

        public Guid? SellingPropertyId { get; set; }

        public string CurrentSituation { get; set; }

        public Guid? MoveReasonId { get; set; }

        public string MoveReasonDescription { get; set; }

        public string BestPropertySeen { get; set; }

        [StringLength(10)]
        public string MoveInDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool AlsoLookingToBuy { get; set; }

        public Guid? LetLengthId { get; set; }

        public string LetLengthLocalised { get; set; }

        public decimal? PriceMin { get; set; }

        public decimal? PriceMax { get; set; }

        public Guid? TenureId { get; set; }

        public string TenureLocalised { get; set; }

        public decimal? MinLeaseRemaining { get; set; }

        public Guid? FurnishingId { get; set; }

        public string FurnishingLocalised { get; set; }

        [StringLength(403)]
        public string Project { get; set; }

        public Guid? SectorId { get; set; }

        public string SectorLocalised { get; set; }

        public Guid? NationalityId { get; set; }

        public string NationalityLocalised { get; set; }

        public Guid? NewBuildId { get; set; }

        public string CurrentPosition { get; set; }

        public Guid? CurrentLocationId { get; set; }

        [StringLength(10)]
        public string CurrentLeaseEventDate { get; set; }

        public bool? IsConfidential { get; set; }

        public Guid? GradeId { get; set; }

        public decimal? MinNetInitialYield { get; set; }

        public decimal? MaxNetInitialYield { get; set; }

        public decimal? MinWAULT { get; set; }

        public decimal? MaxWAULT { get; set; }

        public Guid? TimingTypeId { get; set; }

        public Guid? TimingQuarterMinId { get; set; }

        public int? TimingYearMin { get; set; }

        public Guid? TimingQuarterMaxId { get; set; }

        public int? TimingYearMax { get; set; }

        public Guid? TenantTypesId { get; set; }

        public bool? IsSingleLet { get; set; }

        public bool? IsShariaCompliant { get; set; }

        public decimal? BudgetRentPaMin { get; set; }

        public decimal? BudgetRentPaMax { get; set; }

        public decimal? BudgetPricePaMin { get; set; }

        public decimal? BudgetPricePaMax { get; set; }

        public Guid? PrimaryMotivationId { get; set; }

        public string PrimaryMotivationLocalised { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid AgencyTypeId { get; set; }

        public string AgencyTypeLocalised { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool DoNotMatch { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Deleted { get; set; }

        public bool? Represented { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        public bool? IsKnightFrankDeal { get; set; }

        public bool? TBS { get; set; }

        [StringLength(255)]
        public string ManagingDepartmentName { get; set; }

        [StringLength(40)]
        public string LeadNegotiatorLastName { get; set; }

        [StringLength(10)]
        public string LeadNegotiatorCallDate { get; set; }

        public string RequirementAttributeValues { get; set; }

        public string Departments { get; set; }

        public string Negotiators { get; set; }

        public string Appointments { get; set; }

        public string Matches { get; set; }

        public string PropertyTypes { get; set; }

        public string OtherMotivations { get; set; }

        public string Characteristics { get; set; }

        public string BudgetRentMin { get; set; }

        public string BudgetRentMax { get; set; }

        public string Areas { get; set; }

        public string AreaHierarchies { get; set; }

        public bool? IsUserDefinedArea { get; set; }

        public string AreaHierarchiesNames { get; set; }

        public string UserAreaNames { get; set; }

        public string Offers { get; set; }

        public string LatestNote { get; set; }

        public string Parties { get; set; }

        public string PartiesNames { get; set; }

        public string CreatedByUser { get; set; }

        public string LastModifiedByUser { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }

        public string AreaHierarchyPostcodes { get; set; }

        public string PostcodesAreaHierarchies { get; set; }
    }
}
