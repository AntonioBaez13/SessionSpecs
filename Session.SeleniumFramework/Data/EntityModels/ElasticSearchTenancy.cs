namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchTenancy")]
    public partial class ElasticSearchTenancy
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [StringLength(33)]
        public string LastWriteTime { get; set; }

        [StringLength(10)]
        public string LeaseExpiryDate { get; set; }

        [StringLength(10)]
        public string LeaseCommencementDate { get; set; }

        [StringLength(10)]
        public string SurrenderDate { get; set; }

        public Guid? LeaseTermPeriodTypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TenancyTypeId { get; set; }

        public decimal? FeeLandlordTa { get; set; }

        public decimal? FeeTenantTa { get; set; }

        public decimal? CreditReferenceCheck { get; set; }

        public decimal? AdministrationFeeTds { get; set; }

        public decimal? OccupierRightToRentCheck { get; set; }

        public decimal? InventoryCharge { get; set; }

        public decimal? AdHocCharge { get; set; }

        public bool? IsFallenThrough { get; set; }

        public string FallThroughReason { get; set; }

        public decimal? BankChargesAmount { get; set; }

        public string Negotiators { get; set; }

        public string Parties { get; set; }

        public Guid? RequirementId { get; set; }

        public string Breaks { get; set; }

        public string Reviews { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Deleted { get; set; }

        public decimal? AgreedMonthlyRent { get; set; }

        public decimal? AgreedWeeklyRent { get; set; }

        public decimal? AgreedRentPa { get; set; }

        public int? RentFreePeriod { get; set; }

        public string Comments { get; set; }

        public string RentComment { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid CurrencyId { get; set; }

        public decimal? DepositAmount { get; set; }

        public decimal? InitialPremium { get; set; }

        public bool? IsActivated { get; set; }

        public Guid? ActivityId { get; set; }

        public string ReviewsComment { get; set; }

        public decimal? QuotingRentPaMin { get; set; }

        public decimal? QuotingRentPaMax { get; set; }

        public string QuotingRentMin { get; set; }

        public string QuotingRentMax { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid AssetId { get; set; }

        [StringLength(3)]
        public string AssetType { get; set; }

        public Guid? PropertyTypeId { get; set; }

        public string PropertyTypeLocalised { get; set; }

        public Guid? ManagementTypeId { get; set; }

        public string ManagementTypeLocalised { get; set; }

        public Guid? RentFrequencyId { get; set; }

        public string RentFrequencyLocalised { get; set; }

        public Guid? DurationTypeId { get; set; }

        public string DurationTypeLocalised { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid AgencyTypeId { get; set; }

        public bool? IsKnightFrankDeal { get; set; }

        public string AgencyTypeLocalised { get; set; }

        public Guid? FurnishingId { get; set; }

        public string FurnishingLocalised { get; set; }

        public Guid? RepairingObligationId { get; set; }

        public string RepairingObligationLocalised { get; set; }

        public Guid? AlienationProvisionId { get; set; }

        public string AlienationProvisionLocalised { get; set; }

        public Guid? InsideActId { get; set; }

        public string InsideActLocalised { get; set; }

        [StringLength(10)]
        public string EarliestRightToRentReviewDate { get; set; }

        public Guid? DirectSubletTypeId { get; set; }

        public string DirectSubletTypeLocalised { get; set; }

        public bool? HasGasCertificate { get; set; }

        public bool? HasR2RPartiesWithNoR2RDocument { get; set; }

        public string AgreedRentPerUnitMin { get; set; }

        public string AgreedRentPerUnitMax { get; set; }

        public string TotalAreaBreakdown { get; set; }

        public string AreaHierarchies { get; set; }

        public string AreaHierarchiesNames { get; set; }

        public string TenancyDepartments { get; set; }

        public string AssetAttributeValues { get; set; }

        public string Address { get; set; }

        public string AlternateAddress { get; set; }

        public string Floors { get; set; }

        [StringLength(255)]
        public string ManagingDepartmentName { get; set; }

        [StringLength(40)]
        public string LeadNegotiatorLastName { get; set; }

        [StringLength(10)]
        public string LeadNegotiatorCallDate { get; set; }

        public string AssetCharacteristics { get; set; }

        public string RightToRent { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }

        [StringLength(10)]
        public string NextBreakDate { get; set; }

        public Guid? NextBreakTypeId { get; set; }

        public string NextBreakTypeLocalised { get; set; }

        [StringLength(10)]
        public string ExitDate { get; set; }

        [StringLength(10)]
        public string NextReviewDate { get; set; }

        public bool? IsRepresented { get; set; }

        public bool? IsAreaBreakdownInAcres { get; set; }

        public string EstimatedServiceCharge { get; set; }

        public string EstimatedRates { get; set; }
    }
}
