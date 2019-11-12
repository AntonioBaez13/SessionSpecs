namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Requirement")]
    public partial class Requirement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requirement()
        {
            Appointments = new HashSet<Appointment>();
            ChainTransactions = new HashSet<ChainTransaction>();
            FeeSplits = new HashSet<FeeSplit>();
            InstructionRequirements = new HashSet<InstructionRequirement>();
            Matches = new HashSet<Match>();
            MatchDiscards = new HashSet<MatchDiscard>();
            Notifications = new HashSet<Notification>();
            Offers = new HashSet<Offer>();
            RequirementAreas = new HashSet<RequirementArea>();
            RequirementAreaHierarchies = new HashSet<RequirementAreaHierarchy>();
            RequirementAttributeValues = new HashSet<RequirementAttributeValue>();
            RequirementCharacteristics = new HashSet<RequirementCharacteristic>();
            RequirementCountries = new HashSet<RequirementCountry>();
            RequirementDepartments = new HashSet<RequirementDepartment>();
            RequirementNegotiators = new HashSet<RequirementNegotiator>();
            RequirementOtherMotivations = new HashSet<RequirementOtherMotivation>();
            RequirementParties = new HashSet<RequirementParty>();
            RequirementPropertyTypes = new HashSet<RequirementPropertyType>();
            RequirementSecurityAttributes = new HashSet<RequirementSecurityAttribute>();
            Tenancies = new HashSet<Tenancy>();
            ExternalMessages = new HashSet<ExternalMessage>();
            Appointments1 = new HashSet<Appointment>();
            Attachments = new HashSet<Attachment>();
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }

        public Guid RequirementTypeId { get; set; }

        public Guid AgencyTypeId { get; set; }

        public Guid RequirementStatusId { get; set; }

        public DateTimeOffset StatusLastWriteTime { get; set; }

        public string Description { get; set; }

        public decimal? RentWeeklyMin { get; set; }

        public decimal? RentMonthlyMin { get; set; }

        public decimal? RentWeeklyMax { get; set; }

        public decimal? RentMonthlyMax { get; set; }

        public bool ChainsExist { get; set; }

        public Guid? SourceId { get; set; }

        public string SourceDescription { get; set; }

        public Guid? BuyingReasonId { get; set; }

        public Guid? SellingPositionId { get; set; }

        public Guid? SellingStatusId { get; set; }

        public Guid? FinancialServicesStatusId { get; set; }

        public Guid? HotId { get; set; }

        public bool IsPotentialClient { get; set; }

        public bool Moneypenny { get; set; }

        public Guid? SellingAgentUserId { get; set; }

        public Guid? SellingPropertyId { get; set; }

        public string CurrentSituation { get; set; }

        public Guid? MoveReasonId { get; set; }

        public string MoveReasonDescription { get; set; }

        public string BestPropertySeen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MoveInDate { get; set; }

        public bool AlsoLookingToBuy { get; set; }

        public Guid? LetLengthId { get; set; }

        public decimal? PriceMin { get; set; }

        public decimal? PriceMax { get; set; }

        public Guid? TenureId { get; set; }

        public decimal? MinLeaseRemaining { get; set; }

        public Guid? FurnishingId { get; set; }

        [StringLength(400)]
        public string Project { get; set; }

        public Guid? SectorId { get; set; }

        public Guid? NationalityId { get; set; }

        public string CurrentPosition { get; set; }

        public Guid? CurrentLocationId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CurrentLeaseEventDate { get; set; }

        public bool? IsConfidential { get; set; }

        public Guid? GradeId { get; set; }

        public decimal? MinNetInitialYield { get; set; }

        public decimal? MaxNetInitialYield { get; set; }

        public Guid? TimingTypeId { get; set; }

        public Guid? TimingQuarterMinId { get; set; }

        public int? TimingYearMin { get; set; }

        public Guid? TimingQuarterMaxId { get; set; }

        public int? TimingYearMax { get; set; }

        public Guid? TenantTypesId { get; set; }

        public bool? IsSingleLet { get; set; }

        public bool? IsShariaCompliant { get; set; }

        public bool? IsMortgageRequired { get; set; }

        public Guid? BudgetRentMinId { get; set; }

        public Guid? BudgetRentMaxId { get; set; }

        public decimal? BudgetRentPaMin { get; set; }

        public decimal? BudgetRentPaMax { get; set; }

        public decimal? BudgetPricePaMin { get; set; }

        public decimal? BudgetPricePaMax { get; set; }

        public Guid? PrimaryMotivationId { get; set; }

        public bool Deleted { get; set; }

        [Required]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        public bool DoNotMatch { get; set; }

        public bool? Represented { get; set; }

        public bool? RelocationAgentInvolved { get; set; }

        public string PostCodes { get; set; }

        public string Cities { get; set; }

        public Guid? ReferralId { get; set; }

        public int Version { get; set; }

        public Guid CurrencyId { get; set; }

        public Guid? NewBuildId { get; set; }

        [MaxLength(16)]
        public byte[] MaskedClaimsId { get; set; }

        [MaxLength(16)]
        public byte[] VisibleClaimsId { get; set; }

        public string FeeComment { get; set; }

        public Guid? FeeTypeId { get; set; }

        public decimal? MinWAULT { get; set; }

        public decimal? MaxWAULT { get; set; }

        public decimal? FeePercentage { get; set; }

        public decimal? FeeValue { get; set; }

        public Guid? FeeSplitValueTypeId { get; set; }

        public Guid? ResponsibleForDealNegotiatorId { get; set; }

        public Guid? ResponsibleForDealNegotiatorDepartmentId { get; set; }

        public Guid? ResponsibleForDealCompanyId { get; set; }

        public Guid? BuyingPositionId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Asset Asset1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransaction> ChainTransactions { get; set; }

        public virtual Company Company { get; set; }

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

        public virtual EnumTypeItem EnumTypeItem13 { get; set; }

        public virtual EnumTypeItem EnumTypeItem14 { get; set; }

        public virtual EnumTypeItem EnumTypeItem15 { get; set; }

        public virtual EnumTypeItem EnumTypeItem16 { get; set; }

        public virtual EnumTypeItem EnumTypeItem17 { get; set; }

        public virtual EnumTypeItem EnumTypeItem18 { get; set; }

        public virtual EnumTypeItem EnumTypeItem19 { get; set; }

        public virtual EnumTypeItem EnumTypeItem20 { get; set; }

        public virtual EnumTypeItem EnumTypeItem21 { get; set; }

        public virtual EnumTypeItem EnumTypeItem22 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionRequirement> InstructionRequirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Matches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchDiscard> MatchDiscards { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual Nationality Nationality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual Referral Referral { get; set; }

        public virtual RequirementType RequirementType { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual User User4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementArea> RequirementAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementAreaHierarchy> RequirementAreaHierarchies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementAttributeValue> RequirementAttributeValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementCharacteristic> RequirementCharacteristics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementCountry> RequirementCountries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementDepartment> RequirementDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementNegotiator> RequirementNegotiators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementOtherMotivation> RequirementOtherMotivations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementParty> RequirementParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementPropertyType> RequirementPropertyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementSecurityAttribute> RequirementSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessage> ExternalMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
