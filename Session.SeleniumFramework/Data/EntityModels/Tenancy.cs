namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tenancy")]
    public partial class Tenancy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tenancy()
        {
            Activities = new HashSet<Activity>();
            FeeSplits = new HashSet<FeeSplit>();
            Notifications = new HashSet<Notification>();
            Tenancy1 = new HashSet<Tenancy>();
            TenancyAreaHierarchies = new HashSet<TenancyAreaHierarchy>();
            TenancyBillsDescriptions = new HashSet<TenancyBillsDescription>();
            TenancyBreaks = new HashSet<TenancyBreak>();
            TenancyDepartments = new HashSet<TenancyDepartment>();
            TenancyNegotiators = new HashSet<TenancyNegotiator>();
            TenancyParties = new HashSet<TenancyParty>();
            TenancyPropertyAreas = new HashSet<TenancyPropertyArea>();
            TenancyReviews = new HashSet<TenancyReview>();
            ExternalMessages = new HashSet<ExternalMessage>();
            Activities1 = new HashSet<Activity>();
            Appointments = new HashSet<Appointment>();
            Attachments = new HashSet<Attachment>();
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }

        public Guid? RequirementId { get; set; }

        public Guid? ActivityId { get; set; }

        public Guid AssetId { get; set; }

        public Guid? HeadLeaseId { get; set; }

        public Guid TenancyTypeId { get; set; }

        public Guid? RepairingObligationId { get; set; }

        public Guid? AlienationProvisionId { get; set; }

        public Guid? InsideActId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LeaseCommencementDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LeaseExpiryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SurrenderDate { get; set; }

        public Guid? LeaseTermPeriodTypeId { get; set; }

        public decimal? AgreedRentPa { get; set; }

        public Guid? AgreedRentPerUnitMinId { get; set; }

        public Guid? AgreedRentPerUnitMaxId { get; set; }

        public decimal? LeaseAdvisoryAgreedRentPa { get; set; }

        public Guid? LeaseAdvisoryAgreedRentPerUnitMinId { get; set; }

        public Guid? LeaseAdvisoryAgreedRentPerUnitMaxId { get; set; }

        public decimal? AgreedWeeklyRent { get; set; }

        public decimal? AgreedMonthlyRent { get; set; }

        public int? RentFreePeriod { get; set; }

        public Guid? DurationTypeId { get; set; }

        public string Comments { get; set; }

        public string ReviewsComment { get; set; }

        public Guid? FeeTypeId { get; set; }

        public Guid? ManagementFeeTypeId { get; set; }

        public decimal? FeeValue { get; set; }

        public decimal? FeePercentage { get; set; }

        public decimal? ManagementFeePercentage { get; set; }

        public decimal? ManagementFeeValue { get; set; }

        public string FeeComment { get; set; }

        public Guid? ManagementTypeId { get; set; }

        public Guid? TenancyAgreementTypeId { get; set; }

        public Guid? FinancialNegotiatorId { get; set; }

        public Guid AgencyTypeId { get; set; }

        public decimal? InitialPremium { get; set; }

        public bool? IsZoneA { get; set; }

        public bool? IsActivated { get; set; }

        [Required]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        public int Version { get; set; }

        [MaxLength(16)]
        public byte[] MaskedClaimsId { get; set; }

        [MaxLength(16)]
        public byte[] VisibleClaimsId { get; set; }

        public bool Deleted { get; set; }

        public Guid? RentFrequencyId { get; set; }

        public Guid CurrencyId { get; set; }

        public decimal? FeeLandlordTa { get; set; }

        public decimal? FeeTenantTa { get; set; }

        public decimal? CreditReferenceCheck { get; set; }

        public decimal? AdministrationFeeTds { get; set; }

        public decimal? OccupierRightToRentCheck { get; set; }

        public decimal? InventoryCharge { get; set; }

        public decimal? AdHocCharge { get; set; }

        public string AdHocChargeDescription { get; set; }

        public decimal? BankChargesAmount { get; set; }

        public Guid? BankChargesId { get; set; }

        public decimal? DepositAmount { get; set; }

        public Guid? IncludesBillsId { get; set; }

        public string SpecialTerms { get; set; }

        public Guid? OptionsToRenewId { get; set; }

        public string RentComment { get; set; }

        public Guid? FeeSplitValueTypeId { get; set; }

        [StringLength(128)]
        public string QubeReferenceId { get; set; }

        public bool? QubeErrorOccurred { get; set; }

        public string QubeUrl { get; set; }

        public bool? IsFallenThrough { get; set; }

        public bool? PassedToQube { get; set; }

        public decimal? Collared { get; set; }

        public decimal? Capped { get; set; }

        public string FallThroughReason { get; set; }

        public string SpecialRentArrangements { get; set; }

        public bool? IsRepresented { get; set; }

        public string OtherBillsDescription { get; set; }

        public bool IsAreaBreakdownInAcres { get; set; }

        public bool HmoLicenceRequired { get; set; }

        public Guid? EstimatedRatesId { get; set; }

        public Guid? EstimatedServiceChargeId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual EnumTypeItem EnumTypeItem5 { get; set; }

        public virtual EnumTypeItem EnumTypeItem6 { get; set; }

        public virtual EnumTypeItem EnumTypeItem7 { get; set; }

        public virtual EnumTypeItem EnumTypeItem8 { get; set; }

        public virtual EnumTypeItem EnumTypeItem9 { get; set; }

        public virtual EnumTypeItem EnumTypeItem10 { get; set; }

        public virtual EnumTypeItem EnumTypeItem11 { get; set; }

        public virtual EnumTypeItem EnumTypeItem12 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue2 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue3 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue4 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        public virtual Requirement Requirement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancy1 { get; set; }

        public virtual Tenancy Tenancy2 { get; set; }

        public virtual TenancyType TenancyType { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyAreaHierarchy> TenancyAreaHierarchies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyBillsDescription> TenancyBillsDescriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyBreak> TenancyBreaks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyDepartment> TenancyDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyNegotiator> TenancyNegotiators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyParty> TenancyParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyPropertyArea> TenancyPropertyAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyReview> TenancyReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessage> ExternalMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
