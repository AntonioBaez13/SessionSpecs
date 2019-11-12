namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activity()
        {
            ActivityAreaHierarchies = new HashSet<ActivityAreaHierarchy>();
            ActivityAttributeValues = new HashSet<ActivityAttributeValue>();
            ActivityCharacteristics = new HashSet<ActivityCharacteristic>();
            ActivityDepartments = new HashSet<ActivityDepartment>();
            ActivityExternalLinks = new HashSet<ActivityExternalLink>();
            ActivityLocaliseds = new HashSet<ActivityLocalised>();
            ActivityMarketingImages = new HashSet<ActivityMarketingImage>();
            ActivityNegotiators = new HashSet<ActivityNegotiator>();
            ActivityParties = new HashSet<ActivityParty>();
            ActivityPropertyAreas = new HashSet<ActivityPropertyArea>();
            ActivitySecurityAttributes = new HashSet<ActivitySecurityAttribute>();
            Advertisements = new HashSet<Advertisement>();
            Appointments = new HashSet<Appointment>();
            ChainTransactions = new HashSet<ChainTransaction>();
            FeeSplits = new HashSet<FeeSplit>();
            InstructionActivities = new HashSet<InstructionActivity>();
            Invoices = new HashSet<Invoice>();
            MarketingImages = new HashSet<MarketingImage>();
            Matches = new HashSet<Match>();
            MatchDiscards = new HashSet<MatchDiscard>();
            Notifications = new HashSet<Notification>();
            Offers = new HashSet<Offer>();
            PropertyFloors = new HashSet<PropertyFloor>();
            Tenancies = new HashSet<Tenancy>();
            Appointments1 = new HashSet<Appointment>();
            Attachments = new HashSet<Attachment>();
            Notes = new HashSet<Note>();
            Portals = new HashSet<Portal>();
            ExternalMessages = new HashSet<ExternalMessage>();
            Tenancies1 = new HashSet<Tenancy>();
        }

        public Guid Id { get; set; }

        public Guid AssetId { get; set; }

        public Guid PropertyTypeId { get; set; }

        public Guid OriginalPropertyTypeId { get; set; }

        public Guid ActivityStatusId { get; set; }

        public DateTimeOffset StatusLastWriteTime { get; set; }

        public Guid ActivityTypeId { get; set; }

        public Guid? ActivitySubTypeId { get; set; }

        public Guid? PurposeId { get; set; }

        public decimal? AgreedInitialMarketingPrice { get; set; }

        public decimal? KfValuationPrice { get; set; }

        public Guid? AgreedCapitalValueId { get; set; }

        public decimal? VendorValuationPrice { get; set; }

        public Guid? AcceptedOfferId { get; set; }

        public Guid? SourceId { get; set; }

        public string SourceDescription { get; set; }

        public Guid? SellingReasonId { get; set; }

        public string PitchingThreats { get; set; }

        [StringLength(128)]
        public string KeyNumber { get; set; }

        public string AccessArrangements { get; set; }

        public Guid? KeyHolderTypeId { get; set; }

        public Guid? KeyHolderDepartmentId { get; set; }

        public bool IsVacantProperty { get; set; }

        public bool Moneypenny { get; set; }

        [StringLength(128)]
        public string AlarmCodeIn { get; set; }

        [StringLength(128)]
        public string AlarmCodeOut { get; set; }

        public decimal? ServiceChargeAmount { get; set; }

        public string ServiceChargeNote { get; set; }

        public decimal? GroundRentAmount { get; set; }

        public string GroundRentNote { get; set; }

        public string OtherCondition { get; set; }

        public Guid? DisposalTypeId { get; set; }

        public decimal? ShortKfValuationWeeklyPrice { get; set; }

        public decimal? ShortKfValuationMonthlyPrice { get; set; }

        public decimal? LongKfValuationWeeklyPrice { get; set; }

        public decimal? LongKfValuationMonthlyPrice { get; set; }

        public bool ChainsExist { get; set; }

        public Guid? PriceTypeId { get; set; }

        public decimal? ActivityPrice { get; set; }

        public decimal? ShortAskingWeekRent { get; set; }

        public decimal? ShortAskingMonthRent { get; set; }

        public decimal? ParkingPriceWeek { get; set; }

        public decimal? ParkingPriceMonth { get; set; }

        public decimal? LongAskingWeekRent { get; set; }

        public decimal? LongAskingMonthRent { get; set; }

        public bool AdvertisingPublishToWeb { get; set; }

        public string AdvertisingNote { get; set; }

        public bool SalesBoardUpToDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SalesBoardRemovalDate { get; set; }

        public string SalesBoardSpecialInstructions { get; set; }

        public Guid? AdvertisingPrPermittedTypeId { get; set; }

        public string AdvertisingPrContent { get; set; }

        public Guid? SalesBoardTypeId { get; set; }

        public Guid? SalesBoardStatusId { get; set; }

        public Guid AgencyTypeId { get; set; }

        public bool? IsNewBuild { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastRefurbDate { get; set; }

        public Guid? GradeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MarketedDate { get; set; }

        public string Comments { get; set; }

        public Guid? EstimatedRatesId { get; set; }

        public Guid? EstimatedServiceChargeId { get; set; }

        public decimal? QuotedPrice { get; set; }

        public decimal? AgreedPrice { get; set; }

        public Guid? QuotedCapitalValueId { get; set; }

        public string QuotingTermsComments { get; set; }

        public decimal? WAULT { get; set; }

        public decimal? RentPA { get; set; }

        public decimal? Discount { get; set; }

        public decimal? NetInitialYield { get; set; }

        public Guid? QuotingRentTypeId { get; set; }

        public Guid? QuotingRentMinId { get; set; }

        public Guid? QuotingRentMaxId { get; set; }

        public decimal? QuotingRentPAMin { get; set; }

        public decimal? QuotingRentPAMax { get; set; }

        public string FeeComment { get; set; }

        public Guid? FeeTypeId { get; set; }

        public Guid? ManagementFeeTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AgencyExpiryDate { get; set; }

        public string AgencyExpiryDateComment { get; set; }

        public decimal? FeePercentage { get; set; }

        public decimal? FeeValue { get; set; }

        public decimal? ManagementFeePercentage { get; set; }

        public decimal? ManagementFeeValue { get; set; }

        public Guid? DurationTypeId { get; set; }

        public Guid? ManagementTypeId { get; set; }

        public Guid? InformationQualityId { get; set; }

        public Guid? HeadLeaseId { get; set; }

        public Guid? TypeOfLeaseId { get; set; }

        public bool Deleted { get; set; }

        public decimal? Yield { get; set; }

        public Guid? FurnishingId { get; set; }

        public bool? IsShariaCompliant { get; set; }

        public Guid? ConditionId { get; set; }

        public Guid? ActivityMainImageId { get; set; }

        public Guid? RepresentingId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HeadsOfTermsDate { get; set; }

        [StringLength(128)]
        public string FileReference { get; set; }

        public string TransactionExplanation { get; set; }

        public decimal? SurrenderPremium { get; set; }

        public Guid? PremiumPaidById { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SurrenderDate { get; set; }

        public Guid? SurrenderFromId { get; set; }

        public Guid? SurrenderToId { get; set; }

        public Guid? TenancyReviewId { get; set; }

        public Guid ServiceLineId { get; set; }

        public bool IsUploaded { get; set; }

        [Required]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        public decimal? ExpectedWeekRent { get; set; }

        public decimal? ExpectedMonthRent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AnticipatedCompletionDate { get; set; }

        public bool PublishedToWeb { get; set; }

        public Guid? SingleLetId { get; set; }

        public Guid? ReferralId { get; set; }

        [StringLength(128)]
        public string QubeReferenceId { get; set; }

        public bool? QubeErrorOccurred { get; set; }

        public string QubeUrl { get; set; }

        public int Version { get; set; }

        public Guid CurrencyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        public bool? HasSharedBathrooms { get; set; }

        public bool? HasSharedKitchens { get; set; }

        [StringLength(128)]
        public string WebsiteUrl { get; set; }

        [MaxLength(16)]
        public byte[] MaskedClaimsId { get; set; }

        [MaxLength(16)]
        public byte[] VisibleClaimsId { get; set; }

        public bool? PetAllowed { get; set; }

        public bool? AcceptsSharers { get; set; }

        public bool? AcceptsStudents { get; set; }

        public string PetSharersStudentsInfo { get; set; }

        public string ImportantInformation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AvailableDate { get; set; }

        public bool? InternalCCTV { get; set; }

        public bool? ReLet { get; set; }

        public Guid? FeeSplitValueTypeId { get; set; }

        public bool IsServicedProperty { get; set; }

        public Guid ActivityInstructionCddStatusId { get; set; }

        public decimal? OtherChargesMonthlyManagementFeeAmount { get; set; }

        public bool? OtherChargesMonthlyManagementFeeInclusive { get; set; }

        public bool? OtherChargesMonthlyManagementFeeToBeAdvised { get; set; }

        public decimal? OtherChargesGovtRatesPerQuarterAmount { get; set; }

        public bool? OtherChargesGovtRatesPerQuarterInclusive { get; set; }

        public bool? OtherChargesGovtRatesPerQuarterToBeAdvised { get; set; }

        public decimal? OtherChargesMonthlyCarParkFeeAmount { get; set; }

        public bool? OtherChargesMonthlyCarParkFeeInclusive { get; set; }

        public bool? OtherChargesMonthlyCarParkFeeToBeAdvised { get; set; }

        public decimal? OtherChargesMonthlyAcFeeAmount { get; set; }

        public bool? OtherChargesMonthlyAcFeeInclusive { get; set; }

        public bool? OtherChargesMonthlyAcFeeToBeAdvised { get; set; }

        public decimal? OtherChargesGovtRentPerYearAmount { get; set; }

        public bool? OtherChargesGovtRentPerYearInclusive { get; set; }

        public bool? OtherChargesGovtRentPerYearToBeAdvised { get; set; }

        public DateTimeOffset? LatestPublishToWebDate { get; set; }

        public decimal? QuotedPricePerRoom { get; set; }

        public decimal? AgreedPricePerRoomMin { get; set; }

        public decimal? AgreedPricePerRoomMax { get; set; }

        public decimal? EbitdaLastYear { get; set; }

        public decimal? EbitdaCurrentYear { get; set; }

        public decimal? EbitdaNextYearForecast { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExchangedDate { get; set; }

        [StringLength(128)]
        public string LicenceNumber { get; set; }

        public bool? HmoLicenceRequired { get; set; }

        [StringLength(128)]
        public string NonContactKeyHolderDetails { get; set; }

        public bool? HelpToBuy { get; set; }

        public Guid? RetirementHousingId { get; set; }

        public DateTimeOffset? ActivityMarketingMainImageCreationTime { get; set; }

        public decimal? PricePerDeskMin { get; set; }

        public decimal? PricePerDeskMax { get; set; }

        public Guid? ResponsibleForSaleOrLetNegotiatorId { get; set; }

        public Guid? ResponsibleForSaleOrLetNegotiatorDepartmentId { get; set; }

        public Guid? ResponsibleForSaleOrLetCompanyId { get; set; }

        public Guid? ResponsibleForSaleOrLetContactId { get; set; }

        public Guid? RentFrequencyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UnderOfferDate { get; set; }

        public Guid? OwnershipTenureId { get; set; }

        public decimal? VacancyLevel { get; set; }

        public Guid? ActivityAssetTypeId { get; set; }

        [StringLength(255)]
        public string PropertyVideoUrl { get; set; }

        [StringLength(255)]
        public string ElectronicBrochureUrl { get; set; }

        [StringLength(255)]
        public string VirtualTourUrl { get; set; }

        public decimal? PurchaseCosts { get; set; }

        public decimal? DiscountLevel { get; set; }

        public string CommercialSpace { get; set; }

        [StringLength(128)]
        public string UnitMix { get; set; }

        public decimal? AgreedRentPAMin { get; set; }

        public decimal? AgreedRentPAMax { get; set; }

        public Guid? AgreedRentMinId { get; set; }

        public Guid? AgreedRentMaxId { get; set; }

        public decimal? AgreedSalePrice { get; set; }

        public Guid? TotalRentId { get; set; }

        public decimal? AgreedNetInitialYield { get; set; }

        public decimal? QuotedReversionaryYield { get; set; }

        public decimal? AgreedReversionaryYield { get; set; }

        public decimal? QuotedNetEquivalentYield { get; set; }

        public decimal? AgreedNetEquivalentYield { get; set; }

        public decimal? QuotedTaxEquivalentYield { get; set; }

        public decimal? AgreedTaxEquivalentYield { get; set; }

        public decimal? QuotedGrossInitialYield { get; set; }

        public decimal? AgreedGrossInitialYield { get; set; }

        public decimal? RateableValueMin { get; set; }

        public decimal? RateableValueMax { get; set; }

        public Guid? PriceQualifierId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IncomeDate { get; set; }

        [StringLength(128)]
        public string PropertyExtranet { get; set; }

        public Guid? EstimatedRentalValueId { get; set; }

        public decimal? EstimatedRentalValuePA { get; set; }

        public bool IsPeppercorn { get; set; }

        public decimal? GearingPercentage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InstructedDate { get; set; }

        public Guid? SalePotentialId { get; set; }

        public Guid? LostFromId { get; set; }

        public bool IsFromDevelopmentPipeline { get; set; }

        public Guid? DevPipelineDevelopmentTypeId { get; set; }

        public Guid? DevPipelineConstructionStageId { get; set; }

        public Guid? DevPipelineConstructionStartQuarterId { get; set; }

        public decimal? DevPipelineConstructionStartYear { get; set; }

        public Guid? DevPipelineCompletionDateQuarterId { get; set; }

        public decimal? DevPipelineCompletionDateYear { get; set; }

        public Guid? DevPipelineDevelopmentProbabilityId { get; set; }

        public Guid? DevPipelineSpeculativePreLetId { get; set; }

        public Guid? DevPipelineRecordInfoId { get; set; }

        public string DevPipelineComments { get; set; }

        public decimal? RentFreePeriod { get; set; }

        public string OtherIncentives { get; set; }

        public Guid? ZoneARentId { get; set; }

        public decimal? ITZA { get; set; }

        public Guid LonResStatusId { get; set; }

        public Guid? LonResCommissionTypeId { get; set; }

        public decimal? LonResCommission { get; set; }

        public decimal? LonResNegotiatorBonusFee { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LeaseCommencementDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LeaseExpiryDate { get; set; }

        public int? LeaseLengthMonths { get; set; }

        public bool IsSentToLonRes { get; set; }

        public string TenancyConditions { get; set; }

        public Guid? AlienationProvisionId { get; set; }

        public Guid? RepairingObligationId { get; set; }

        public Guid? BreakTypeId { get; set; }

        public Guid? StandardDisregardsId { get; set; }

        public Guid? TreatmentOfRentFreePeriodsId { get; set; }

        public decimal? AgreedRentPA { get; set; }

        public decimal? PriorAgreedRentPA { get; set; }

        public Guid? PriorAgreedRentMinId { get; set; }

        public Guid? PriorAgreedRentMaxId { get; set; }

        public decimal? TermYears { get; set; }

        public string DefinitionOfRent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AssumedBreakDate { get; set; }

        public int? HypotheticalTermMonths { get; set; }

        public int? HypotheticalTermDays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegearDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AdviceGivenDate { get; set; }

        public bool IsSurrenderPremiumWaived { get; set; }

        public string Assumptions { get; set; }

        public string Disregards { get; set; }

        public bool IsAreaBreakdownInAcres { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HeadLeaseCommencementDate { get; set; }

        public int? HeadLeaseTermMonths { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HeadLeaseExpiryDate { get; set; }

        public decimal? HeadLeaseUnexpiredTerm { get; set; }

        public decimal? QuotedPricePerBed { get; set; }

        public decimal? AgreedPricePerBed { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual ActivityType ActivityType { get; set; }

        public virtual ActivityType ActivityType1 { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

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

        public virtual EnumTypeItem EnumTypeItem23 { get; set; }

        public virtual EnumTypeItem EnumTypeItem24 { get; set; }

        public virtual EnumTypeItem EnumTypeItem25 { get; set; }

        public virtual EnumTypeItem EnumTypeItem26 { get; set; }

        public virtual EnumTypeItem EnumTypeItem27 { get; set; }

        public virtual EnumTypeItem EnumTypeItem28 { get; set; }

        public virtual EnumTypeItem EnumTypeItem29 { get; set; }

        public virtual EnumTypeItem EnumTypeItem30 { get; set; }

        public virtual EnumTypeItem EnumTypeItem31 { get; set; }

        public virtual EnumTypeItem EnumTypeItem32 { get; set; }

        public virtual EnumTypeItem EnumTypeItem33 { get; set; }

        public virtual EnumTypeItem EnumTypeItem34 { get; set; }

        public virtual EnumTypeItem EnumTypeItem35 { get; set; }

        public virtual EnumTypeItem EnumTypeItem36 { get; set; }

        public virtual EnumTypeItem EnumTypeItem37 { get; set; }

        public virtual EnumTypeItem EnumTypeItem38 { get; set; }

        public virtual EnumTypeItem EnumTypeItem39 { get; set; }

        public virtual EnumTypeItem EnumTypeItem40 { get; set; }

        public virtual EnumTypeItem EnumTypeItem41 { get; set; }

        public virtual EnumTypeItem EnumTypeItem42 { get; set; }

        public virtual EnumTypeItem EnumTypeItem43 { get; set; }

        public virtual EnumTypeItem EnumTypeItem44 { get; set; }

        public virtual EnumTypeItem EnumTypeItem45 { get; set; }

        public virtual EnumTypeItem EnumTypeItem46 { get; set; }

        public virtual EnumTypeItem EnumTypeItem47 { get; set; }

        public virtual EnumTypeItem EnumTypeItem48 { get; set; }

        public virtual EnumTypeItem EnumTypeItem49 { get; set; }

        public virtual MarketingImage MarketingImage { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue2 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue3 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue4 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue5 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue6 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue7 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue8 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue9 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue10 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue11 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue12 { get; set; }

        public virtual Offer Offer { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual OrganisationUnit OrganisationUnit1 { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        public virtual PropertyType PropertyType1 { get; set; }

        public virtual Referral Referral { get; set; }

        public virtual Tenancy Tenancy { get; set; }

        public virtual TenancyReview TenancyReview { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityAreaHierarchy> ActivityAreaHierarchies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityAttributeValue> ActivityAttributeValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCharacteristic> ActivityCharacteristics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityDepartment> ActivityDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityExternalLink> ActivityExternalLinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLocalised> ActivityLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityMarketingImage> ActivityMarketingImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityNegotiator> ActivityNegotiators { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityParty> ActivityParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPropertyArea> ActivityPropertyAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySecurityAttribute> ActivitySecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisement> Advertisements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransaction> ChainTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionActivity> InstructionActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingImage> MarketingImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Matches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchDiscard> MatchDiscards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyFloor> PropertyFloors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Portal> Portals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessage> ExternalMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancies1 { get; set; }
    }
}
