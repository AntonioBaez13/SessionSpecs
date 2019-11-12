namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KfDbContext : DbContext
    {
        public KfDbContext()
            : base("name=KfDbContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<C__SprintVersion> C__SprintVersion { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityAreaHierarchy> ActivityAreaHierarchies { get; set; }
        public virtual DbSet<ActivityAttributeValue> ActivityAttributeValues { get; set; }
        public virtual DbSet<ActivityCharacteristic> ActivityCharacteristics { get; set; }
        public virtual DbSet<ActivityDepartment> ActivityDepartments { get; set; }
        public virtual DbSet<ActivityDocumentTypeUsage> ActivityDocumentTypeUsages { get; set; }
        public virtual DbSet<ActivityExternalLink> ActivityExternalLinks { get; set; }
        public virtual DbSet<ActivityLocalised> ActivityLocaliseds { get; set; }
        public virtual DbSet<ActivityMarketingImage> ActivityMarketingImages { get; set; }
        public virtual DbSet<ActivityNegotiator> ActivityNegotiators { get; set; }
        public virtual DbSet<ActivityParty> ActivityParties { get; set; }
        public virtual DbSet<ActivityPropertyArea> ActivityPropertyAreas { get; set; }
        public virtual DbSet<ActivitySecurityAttribute> ActivitySecurityAttributes { get; set; }
        public virtual DbSet<ActivityServiceLineDefinition> ActivityServiceLineDefinitions { get; set; }
        public virtual DbSet<ActivityStatusDefinition> ActivityStatusDefinitions { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<ActivityTypeDefinition> ActivityTypeDefinitions { get; set; }
        public virtual DbSet<ActivityTypeLocalised> ActivityTypeLocaliseds { get; set; }
        public virtual DbSet<ActivityTypesConfigurationCache> ActivityTypesConfigurationCaches { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressField> AddressFields { get; set; }
        public virtual DbSet<AddressFieldDefinition> AddressFieldDefinitions { get; set; }
        public virtual DbSet<AddressFieldLabel> AddressFieldLabels { get; set; }
        public virtual DbSet<AddressForm> AddressForms { get; set; }
        public virtual DbSet<AddressFormEntityType> AddressFormEntityTypes { get; set; }
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AgeBand> AgeBands { get; set; }
        public virtual DbSet<AgeBandLocalised> AgeBandLocaliseds { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentContact> AppointmentContacts { get; set; }
        public virtual DbSet<AppointmentOtherAttendee> AppointmentOtherAttendees { get; set; }
        public virtual DbSet<AppointmentUser> AppointmentUsers { get; set; }
        public virtual DbSet<AreaHierarchy> AreaHierarchies { get; set; }
        public virtual DbSet<AreaHierarchyCache> AreaHierarchyCaches { get; set; }
        public virtual DbSet<AreaHierarchyShape> AreaHierarchyShapes { get; set; }
        public virtual DbSet<AreaTemplate> AreaTemplates { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetAttributeValue> AssetAttributeValues { get; set; }
        public virtual DbSet<AssetCharacteristic> AssetCharacteristics { get; set; }
        public virtual DbSet<AssetDocumentTypeUsage> AssetDocumentTypeUsages { get; set; }
        public virtual DbSet<AssetParty> AssetParties { get; set; }
        public virtual DbSet<AssetSecurityAttribute> AssetSecurityAttributes { get; set; }
        public virtual DbSet<AssetUniqueNumber> AssetUniqueNumbers { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<AttachmentSigningParty> AttachmentSigningParties { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<BuildingFloor> BuildingFloors { get; set; }
        public virtual DbSet<BusinessEvent> BusinessEvents { get; set; }
        public virtual DbSet<BusinessLanguage> BusinessLanguages { get; set; }
        public virtual DbSet<CacheItem> CacheItems { get; set; }
        public virtual DbSet<ChainTransaction> ChainTransactions { get; set; }
        public virtual DbSet<ChainTransactionParty> ChainTransactionParties { get; set; }
        public virtual DbSet<Characteristic> Characteristics { get; set; }
        public virtual DbSet<CharacteristicGroup> CharacteristicGroups { get; set; }
        public virtual DbSet<CharacteristicGroupItem> CharacteristicGroupItems { get; set; }
        public virtual DbSet<CharacteristicGroupLocalised> CharacteristicGroupLocaliseds { get; set; }
        public virtual DbSet<CharacteristicGroupUsage> CharacteristicGroupUsages { get; set; }
        public virtual DbSet<CharacteristicLocalised> CharacteristicLocaliseds { get; set; }
        public virtual DbSet<ClaimEntityUniqueNumber> ClaimEntityUniqueNumbers { get; set; }
        public virtual DbSet<ClaimsRecalculationLog> ClaimsRecalculationLogs { get; set; }
        public virtual DbSet<ClaimsUnique> ClaimsUniques { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public virtual DbSet<CompanyContact> CompanyContacts { get; set; }
        public virtual DbSet<CompanyContactNote> CompanyContactNotes { get; set; }
        public virtual DbSet<CompanyDomain> CompanyDomains { get; set; }
        public virtual DbSet<CompanyDomainUser> CompanyDomainUsers { get; set; }
        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<ConsentScript> ConsentScripts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactAccessRequest> ContactAccessRequests { get; set; }
        public virtual DbSet<ContactAddress> ContactAddresses { get; set; }
        public virtual DbSet<ContactAddressDirectMarketingConsent> ContactAddressDirectMarketingConsents { get; set; }
        public virtual DbSet<ContactBusinessHistory> ContactBusinessHistories { get; set; }
        public virtual DbSet<ContactCompanyAddress> ContactCompanyAddresses { get; set; }
        public virtual DbSet<ContactCompanyAddressDirectMarketingConsent> ContactCompanyAddressDirectMarketingConsents { get; set; }
        public virtual DbSet<ContactContactType> ContactContactTypes { get; set; }
        public virtual DbSet<ContactEmail> ContactEmails { get; set; }
        public virtual DbSet<ContactEmailDirectMarketingConsent> ContactEmailDirectMarketingConsents { get; set; }
        public virtual DbSet<ContactEmailUser> ContactEmailUsers { get; set; }
        public virtual DbSet<ContactMarketingCampaign> ContactMarketingCampaigns { get; set; }
        public virtual DbSet<ContactPhone> ContactPhones { get; set; }
        public virtual DbSet<ContactPropertyInterest> ContactPropertyInterests { get; set; }
        public virtual DbSet<ContactPropertyTypeInterest> ContactPropertyTypeInterests { get; set; }
        public virtual DbSet<ContactPublicationEvent> ContactPublicationEvents { get; set; }
        public virtual DbSet<ContactRelationship> ContactRelationships { get; set; }
        public virtual DbSet<ContactSecurityAttribute> ContactSecurityAttributes { get; set; }
        public virtual DbSet<ContactTitle> ContactTitles { get; set; }
        public virtual DbSet<ContactToBePhoned> ContactToBePhoneds { get; set; }
        public virtual DbSet<ContactUser> ContactUsers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryLocalised> CountryLocaliseds { get; set; }
        public virtual DbSet<Dashboard> Dashboards { get; set; }
        public virtual DbSet<DatahugDowngradeCompanyDomain> DatahugDowngradeCompanyDomains { get; set; }
        public virtual DbSet<DatahugDowngradeCompanyDomainUser> DatahugDowngradeCompanyDomainUsers { get; set; }
        public virtual DbSet<DatahugDowngradeContactEmail> DatahugDowngradeContactEmails { get; set; }
        public virtual DbSet<DatahugDowngradeContactEmailUser> DatahugDowngradeContactEmailUsers { get; set; }
        public virtual DbSet<DataHugJobApiError> DataHugJobApiErrors { get; set; }
        public virtual DbSet<DataHugJobConfig> DataHugJobConfigs { get; set; }
        public virtual DbSet<DataHugJobLog> DataHugJobLogs { get; set; }
        public virtual DbSet<DataHugJobResultFile> DataHugJobResultFiles { get; set; }
        public virtual DbSet<DataHugLog> DataHugLogs { get; set; }
        public virtual DbSet<DataHugManagement> DataHugManagements { get; set; }
        public virtual DbSet<DataHugPrivateEmailDomain> DataHugPrivateEmailDomains { get; set; }
        public virtual DbSet<DataHugProcessingError> DataHugProcessingErrors { get; set; }
        public virtual DbSet<DataHugUpdatedEntity> DataHugUpdatedEntities { get; set; }
        public virtual DbSet<DepartmentGroup> DepartmentGroups { get; set; }
        public virtual DbSet<DevelopmentDepartment> DevelopmentDepartments { get; set; }
        public virtual DbSet<DeviceRegistration> DeviceRegistrations { get; set; }
        public virtual DbSet<DivisionServiceLineDefinition> DivisionServiceLineDefinitions { get; set; }
        public virtual DbSet<DocumentSigning> DocumentSignings { get; set; }
        public virtual DbSet<DocumentTemplate> DocumentTemplates { get; set; }
        public virtual DbSet<DocumentTemplateContent> DocumentTemplateContents { get; set; }
        public virtual DbSet<DocumentTemplateField> DocumentTemplateFields { get; set; }
        public virtual DbSet<DocumentTemplateRole> DocumentTemplateRoles { get; set; }
        public virtual DbSet<DotmailerAccount> DotmailerAccounts { get; set; }
        public virtual DbSet<DotmailerEmailsQueue> DotmailerEmailsQueues { get; set; }
        public virtual DbSet<DotmailerEmailTemplate> DotmailerEmailTemplates { get; set; }
        public virtual DbSet<DotmailerExportLog> DotmailerExportLogs { get; set; }
        public virtual DbSet<DotmailerExportLogContact> DotmailerExportLogContacts { get; set; }
        public virtual DbSet<DotmailerImportedCampaign> DotmailerImportedCampaigns { get; set; }
        public virtual DbSet<DotmailerLog> DotmailerLogs { get; set; }
        public virtual DbSet<DotmailerSuppressedEmail> DotmailerSuppressedEmails { get; set; }
        public virtual DbSet<EnumLocalised> EnumLocaliseds { get; set; }
        public virtual DbSet<EnumType> EnumTypes { get; set; }
        public virtual DbSet<EnumTypeItem> EnumTypeItems { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<ExternalAddressServiceMapping> ExternalAddressServiceMappings { get; set; }
        public virtual DbSet<ExternalMessage> ExternalMessages { get; set; }
        public virtual DbSet<ExternalMessageRecipient> ExternalMessageRecipients { get; set; }
        public virtual DbSet<FeeIncome> FeeIncomes { get; set; }
        public virtual DbSet<FeeIncomeLocalised> FeeIncomeLocaliseds { get; set; }
        public virtual DbSet<FeeSplit> FeeSplits { get; set; }
        public virtual DbSet<FlexibleReport> FlexibleReports { get; set; }
        public virtual DbSet<Grid> Grids { get; set; }
        public virtual DbSet<GridColumn> GridColumns { get; set; }
        public virtual DbSet<GridColumnDefinition> GridColumnDefinitions { get; set; }
        public virtual DbSet<GridColumnServiceLine> GridColumnServiceLines { get; set; }
        public virtual DbSet<GridDefinition> GridDefinitions { get; set; }
        public virtual DbSet<HoldingCompany> HoldingCompanies { get; set; }
        public virtual DbSet<Impersonation> Impersonations { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<InstructionActivity> InstructionActivities { get; set; }
        public virtual DbSet<InstructionAsset> InstructionAssets { get; set; }
        public virtual DbSet<InstructionParty> InstructionParties { get; set; }
        public virtual DbSet<InstructionRequirement> InstructionRequirements { get; set; }
        public virtual DbSet<InstructionSecurityAttribute> InstructionSecurityAttributes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Ited> Iteds { get; set; }
        public virtual DbSet<LatestView> LatestViews { get; set; }
        public virtual DbSet<Locale> Locales { get; set; }
        public virtual DbSet<LocaleLocalised> LocaleLocaliseds { get; set; }
        public virtual DbSet<MarketingImage> MarketingImages { get; set; }
        public virtual DbSet<MarketingList> MarketingLists { get; set; }
        public virtual DbSet<MarketingListContact> MarketingListContacts { get; set; }
        public virtual DbSet<MarketingListEditor> MarketingListEditors { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchDiscard> MatchDiscards { get; set; }
        public virtual DbSet<MeasurementUnitConfiguration> MeasurementUnitConfigurations { get; set; }
        public virtual DbSet<MeasurementUnitValue> MeasurementUnitValues { get; set; }
        public virtual DbSet<MyKfFeedDetail> MyKfFeedDetails { get; set; }
        public virtual DbSet<MyKfFeedLog> MyKfFeedLogs { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<NationalityLocalised> NationalityLocaliseds { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationBlacklist> NotificationBlacklists { get; set; }
        public virtual DbSet<NotificationRecipient> NotificationRecipients { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OfferParty> OfferParties { get; set; }
        public virtual DbSet<OfferPropertyArea> OfferPropertyAreas { get; set; }
        public virtual DbSet<OfferType> OfferTypes { get; set; }
        public virtual DbSet<OfferTypeLocalised> OfferTypeLocaliseds { get; set; }
        public virtual DbSet<OfficePatch> OfficePatches { get; set; }
        public virtual DbSet<OfficePatchThreshold> OfficePatchThresholds { get; set; }
        public virtual DbSet<OrganisationalSecurityRule> OrganisationalSecurityRules { get; set; }
        public virtual DbSet<OrganisationUnit> OrganisationUnits { get; set; }
        public virtual DbSet<OrganisationUnitCompany> OrganisationUnitCompanies { get; set; }
        public virtual DbSet<OrganisationUnitServiceLine> OrganisationUnitServiceLines { get; set; }
        public virtual DbSet<Ownership> Ownerships { get; set; }
        public virtual DbSet<Pitch> Pitches { get; set; }
        public virtual DbSet<PitchSecurityAttribute> PitchSecurityAttributes { get; set; }
        public virtual DbSet<PitchUser> PitchUsers { get; set; }
        public virtual DbSet<Portal> Portals { get; set; }
        public virtual DbSet<PortalDefinition> PortalDefinitions { get; set; }
        public virtual DbSet<PostCodeShape> PostCodeShapes { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<ProfessionLocalised> ProfessionLocaliseds { get; set; }
        public virtual DbSet<PropertyArea> PropertyAreas { get; set; }
        public virtual DbSet<PropertyAttributeForm> PropertyAttributeForms { get; set; }
        public virtual DbSet<PropertyFloor> PropertyFloors { get; set; }
        public virtual DbSet<PropertyManagementContact> PropertyManagementContacts { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<PropertyTypeDefinition> PropertyTypeDefinitions { get; set; }
        public virtual DbSet<PropertyTypeLocalised> PropertyTypeLocaliseds { get; set; }
        public virtual DbSet<PublicationEvent> PublicationEvents { get; set; }
        public virtual DbSet<Referral> Referrals { get; set; }
        public virtual DbSet<ReferralManagementRule> ReferralManagementRules { get; set; }
        public virtual DbSet<ReferralUniqueNumber> ReferralUniqueNumbers { get; set; }
        public virtual DbSet<RegistrationStatu> RegistrationStatus { get; set; }
        public virtual DbSet<RegistrationStatusLocalised> RegistrationStatusLocaliseds { get; set; }
        public virtual DbSet<RegistrationSystem> RegistrationSystems { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportGroup> ReportGroups { get; set; }
        public virtual DbSet<ReportGroupLocalised> ReportGroupLocaliseds { get; set; }
        public virtual DbSet<ReportLocalised> ReportLocaliseds { get; set; }
        public virtual DbSet<ReportVisibilityCountry> ReportVisibilityCountries { get; set; }
        public virtual DbSet<ReportVisibilityDepartment> ReportVisibilityDepartments { get; set; }
        public virtual DbSet<ReportVisibilityServiceLine> ReportVisibilityServiceLines { get; set; }
        public virtual DbSet<Requirement> Requirements { get; set; }
        public virtual DbSet<RequirementArea> RequirementAreas { get; set; }
        public virtual DbSet<RequirementAreaHierarchy> RequirementAreaHierarchies { get; set; }
        public virtual DbSet<RequirementAttributeValue> RequirementAttributeValues { get; set; }
        public virtual DbSet<RequirementCharacteristic> RequirementCharacteristics { get; set; }
        public virtual DbSet<RequirementCountry> RequirementCountries { get; set; }
        public virtual DbSet<RequirementDepartment> RequirementDepartments { get; set; }
        public virtual DbSet<RequirementDocumentTypeUsage> RequirementDocumentTypeUsages { get; set; }
        public virtual DbSet<RequirementNegotiator> RequirementNegotiators { get; set; }
        public virtual DbSet<RequirementOtherMotivation> RequirementOtherMotivations { get; set; }
        public virtual DbSet<RequirementParty> RequirementParties { get; set; }
        public virtual DbSet<RequirementPropertyType> RequirementPropertyTypes { get; set; }
        public virtual DbSet<RequirementSecurityAttribute> RequirementSecurityAttributes { get; set; }
        public virtual DbSet<RequirementType> RequirementTypes { get; set; }
        public virtual DbSet<RequirementTypeLocalised> RequirementTypeLocaliseds { get; set; }
        public virtual DbSet<RequirementUniqueNumber> RequirementUniqueNumbers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SapAddressUniqueNumber> SapAddressUniqueNumbers { get; set; }
        public virtual DbSet<SapCompanyUniqueNumber> SapCompanyUniqueNumbers { get; set; }
        public virtual DbSet<SapIndividualUniqueNumber> SapIndividualUniqueNumbers { get; set; }
        public virtual DbSet<SapInstructionUniqueNumber> SapInstructionUniqueNumbers { get; set; }
        public virtual DbSet<SapPostingQueue> SapPostingQueues { get; set; }
        public virtual DbSet<ScheduledNotification> ScheduledNotifications { get; set; }
        public virtual DbSet<SearchConfiguration> SearchConfigurations { get; set; }
        public virtual DbSet<SearchConfigurationAccess> SearchConfigurationAccesses { get; set; }
        public virtual DbSet<SearchFilterConfiguration> SearchFilterConfigurations { get; set; }
        public virtual DbSet<SecurityAttribute> SecurityAttributes { get; set; }
        public virtual DbSet<ServiceLine> ServiceLines { get; set; }
        public virtual DbSet<ServiceLineLocalised> ServiceLineLocaliseds { get; set; }
        public virtual DbSet<ShowoverAvailability> ShowoverAvailabilities { get; set; }
        public virtual DbSet<SignalRConnection> SignalRConnections { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TargetDepartment> TargetDepartments { get; set; }
        public virtual DbSet<TargetNegotiator> TargetNegotiators { get; set; }
        public virtual DbSet<Tenancy> Tenancies { get; set; }
        public virtual DbSet<TenancyAreaHierarchy> TenancyAreaHierarchies { get; set; }
        public virtual DbSet<TenancyBillsDescription> TenancyBillsDescriptions { get; set; }
        public virtual DbSet<TenancyBreak> TenancyBreaks { get; set; }
        public virtual DbSet<TenancyDepartment> TenancyDepartments { get; set; }
        public virtual DbSet<TenancyDocumentTypeUsage> TenancyDocumentTypeUsages { get; set; }
        public virtual DbSet<TenancyIdentification> TenancyIdentifications { get; set; }
        public virtual DbSet<TenancyNegotiator> TenancyNegotiators { get; set; }
        public virtual DbSet<TenancyParty> TenancyParties { get; set; }
        public virtual DbSet<TenancyPropertyArea> TenancyPropertyAreas { get; set; }
        public virtual DbSet<TenancyReview> TenancyReviews { get; set; }
        public virtual DbSet<TenancyType> TenancyTypes { get; set; }
        public virtual DbSet<TenancyTypeLocalised> TenancyTypeLocaliseds { get; set; }
        public virtual DbSet<TenancyUniqueNumber> TenancyUniqueNumbers { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<TranslationLocalised> TranslationLocaliseds { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDotmailerAccount> UserDotmailerAccounts { get; set; }
        public virtual DbSet<UserExportLog> UserExportLogs { get; set; }
        public virtual DbSet<UserExportLogContact> UserExportLogContacts { get; set; }
        public virtual DbSet<UserFeedDetail> UserFeedDetails { get; set; }
        public virtual DbSet<UserFeedLog> UserFeedLogs { get; set; }
        public virtual DbSet<UserPreferenceArea> UserPreferenceAreas { get; set; }
        public virtual DbSet<UserPropertyType> UserPropertyTypes { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRoleBusiness> UserRoleBusinesses { get; set; }
        public virtual DbSet<UserRoleDepartment> UserRoleDepartments { get; set; }
        public virtual DbSet<ViewingTour> ViewingTours { get; set; }
        public virtual DbSet<WindowsTimeZone> WindowsTimeZones { get; set; }
        public virtual DbSet<WindowsTimeZoneLocalised> WindowsTimeZoneLocaliseds { get; set; }
        public virtual DbSet<Messages_0> Messages_0 { get; set; }
        public virtual DbSet<Messages_0_Id> Messages_0_Id { get; set; }
        public virtual DbSet<Schema> Schemata { get; set; }
        public virtual DbSet<CompanyActivitiesView> CompanyActivitiesViews { get; set; }
        public virtual DbSet<CompanyActivitiesView2> CompanyActivitiesView2 { get; set; }
        public virtual DbSet<CompanyContactsView> CompanyContactsViews { get; set; }
        public virtual DbSet<CompanyInstructionsView> CompanyInstructionsViews { get; set; }
        public virtual DbSet<CompanyPitchesView> CompanyPitchesViews { get; set; }
        public virtual DbSet<CompanyRequirementsView> CompanyRequirementsViews { get; set; }
        public virtual DbSet<ContactActivitiesView> ContactActivitiesViews { get; set; }
        public virtual DbSet<ContactDrilldownView> ContactDrilldownViews { get; set; }
        public virtual DbSet<ContactInstructionView> ContactInstructionViews { get; set; }
        public virtual DbSet<ContactReferralView> ContactReferralViews { get; set; }
        public virtual DbSet<ContactRequirementsView> ContactRequirementsViews { get; set; }
        public virtual DbSet<ElasticSearchActivity> ElasticSearchActivities { get; set; }
        public virtual DbSet<ElasticSearchActivityAdminWidget> ElasticSearchActivityAdminWidgets { get; set; }
        public virtual DbSet<ElasticSearchAsset> ElasticSearchAssets { get; set; }
        public virtual DbSet<ElasticSearchAsset2> ElasticSearchAsset2 { get; set; }
        public virtual DbSet<ElasticSearchCompany> ElasticSearchCompanies { get; set; }
        public virtual DbSet<ElasticSearchContact> ElasticSearchContacts { get; set; }
        public virtual DbSet<ElasticSearchInstruction> ElasticSearchInstructions { get; set; }
        public virtual DbSet<ElasticSearchMarketingList> ElasticSearchMarketingLists { get; set; }
        public virtual DbSet<ElasticSearchNotesActivity> ElasticSearchNotesActivities { get; set; }
        public virtual DbSet<ElasticSearchNotesAsset> ElasticSearchNotesAssets { get; set; }
        public virtual DbSet<ElasticSearchNotesCompany> ElasticSearchNotesCompanies { get; set; }
        public virtual DbSet<ElasticSearchNotesContact> ElasticSearchNotesContacts { get; set; }
        public virtual DbSet<ElasticSearchNotesOffer> ElasticSearchNotesOffers { get; set; }
        public virtual DbSet<ElasticSearchNotesReferral> ElasticSearchNotesReferrals { get; set; }
        public virtual DbSet<ElasticSearchNotesRequirement> ElasticSearchNotesRequirements { get; set; }
        public virtual DbSet<ElasticSearchNotesTenancy> ElasticSearchNotesTenancies { get; set; }
        public virtual DbSet<ElasticSearchPitch> ElasticSearchPitches { get; set; }
        public virtual DbSet<ElasticSearchReferral> ElasticSearchReferrals { get; set; }
        public virtual DbSet<ElasticSearchRequirement> ElasticSearchRequirements { get; set; }
        public virtual DbSet<ElasticSearchShapePostCode> ElasticSearchShapePostCodes { get; set; }
        public virtual DbSet<ElasticSearchTenancy> ElasticSearchTenancies { get; set; }
        public virtual DbSet<InstructionDrilldownView> InstructionDrilldownViews { get; set; }
        public virtual DbSet<PitchDrilldownView> PitchDrilldownViews { get; set; }
        public virtual DbSet<PortfolioView> PortfolioViews { get; set; }
        public virtual DbSet<ReferralDrilldownView> ReferralDrilldownViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedInitialMarketingPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.KfValuationPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.VendorValuationPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ServiceChargeAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.GroundRentAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ShortKfValuationWeeklyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ShortKfValuationMonthlyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.LongKfValuationWeeklyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.LongKfValuationMonthlyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ShortAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ShortAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ParkingPriceWeek)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ParkingPriceMonth)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.LongAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.LongAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.RentPA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Discount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.NetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotingRentPAMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotingRentPAMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.FeePercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Activity>()
                .Property(e => e.FeeValue)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ManagementFeePercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ManagementFeeValue)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Yield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.SurrenderPremium)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ExpectedWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ExpectedMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.MaskedClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Activity>()
                .Property(e => e.VisibleClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Activity>()
                .Property(e => e.OtherChargesMonthlyManagementFeeAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.OtherChargesGovtRatesPerQuarterAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.OtherChargesMonthlyCarParkFeeAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.OtherChargesMonthlyAcFeeAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.OtherChargesGovtRentPerYearAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedPricePerRoom)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedPricePerRoomMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedPricePerRoomMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.PricePerDeskMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.PricePerDeskMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.VacancyLevel)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.PurchaseCosts)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.DiscountLevel)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedRentPAMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedRentPAMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedSalePrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedNetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedReversionaryYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedReversionaryYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedNetEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedNetEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedTaxEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedTaxEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedGrossInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedGrossInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.RateableValueMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.RateableValueMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.EstimatedRentalValuePA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.GearingPercentage)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.LonResCommission)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.LonResNegotiatorBonusFee)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedRentPA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.PriorAgreedRentPA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.QuotedPricePerBed)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .Property(e => e.AgreedPricePerBed)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityAttributeValues)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityCharacteristics)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityDepartments)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityExternalLinks)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityLocaliseds)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityNegotiators)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityParties)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivityPropertyAreas)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ActivitySecurityAttributes)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Advertisements)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.Activity)
                .HasForeignKey(e => e.ActivityId);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.InstructionActivities)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.MarketingImages)
                .WithRequired(e => e.Activity)
                .HasForeignKey(e => e.OriginalActivityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Activity)
                .HasForeignKey(e => e.ActivityId);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.PropertyFloors)
                .WithOptional(e => e.Activity)
                .HasForeignKey(e => e.DevPipelineId);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Tenancies)
                .WithOptional(e => e.Activity)
                .HasForeignKey(e => e.ActivityId);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Appointments1)
                .WithMany(e => e.Activities)
                .Map(m => m.ToTable("ActivityAppointment").MapLeftKey("ActivityId").MapRightKey("AppointmentId"));

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Attachments)
                .WithMany(e => e.Activities)
                .Map(m => m.ToTable("ActivityAttachment").MapLeftKey("ActivityId").MapRightKey("AttachmentId"));

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Notes)
                .WithMany(e => e.Activities)
                .Map(m => m.ToTable("ActivityNote").MapLeftKey("ActivityId").MapRightKey("NoteId"));

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Portals)
                .WithMany(e => e.Activities)
                .Map(m => m.ToTable("ActivityPortal").MapLeftKey("ActivityId").MapRightKey("PortalId"));

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.ExternalMessages)
                .WithMany(e => e.Activities)
                .Map(m => m.ToTable("ExternalMessageActivity").MapLeftKey("ActivityId").MapRightKey("ExternalMessageId"));

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Tenancies1)
                .WithMany(e => e.Activities1)
                .Map(m => m.ToTable("LeaseAdvisoryTenancies").MapLeftKey("ActivityId").MapRightKey("TenancyId"));

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.ActivityType)
                .HasForeignKey(e => e.ActivitySubTypeId);

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.Activities1)
                .WithRequired(e => e.ActivityType1)
                .HasForeignKey(e => e.ActivityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.ActivityServiceLineDefinitions)
                .WithRequired(e => e.ActivityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.ActivityStatusDefinitions)
                .WithRequired(e => e.ActivityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.ActivityTypeLocaliseds)
                .WithRequired(e => e.ActivityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityTypeDefinition>()
                .HasMany(e => e.RequirementTypes)
                .WithMany(e => e.ActivityTypeDefinitions)
                .Map(m => m.ToTable("RequirementTypeActivityTypeDefinition").MapLeftKey("ActivityTypeDefinitionId").MapRightKey("RequirementTypeId"));

            modelBuilder.Entity<Address>()
                .HasMany(e => e.CompanyAddresses)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.ContactAddresses)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.FeeSplits)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.PartyAddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Instructions)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.AddresseeAddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.OrganisationUnits)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.OfficeAddressId);

            modelBuilder.Entity<Address>()
                .HasOptional(e => e.SapAddressUniqueNumber)
                .WithRequired(e => e.Address);

            modelBuilder.Entity<AddressField>()
                .HasMany(e => e.AddressFieldDefinitions)
                .WithRequired(e => e.AddressField)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressField>()
                .HasMany(e => e.ExternalAddressServiceMappings)
                .WithRequired(e => e.AddressField)
                .HasForeignKey(e => e.TargetFieldId);

            modelBuilder.Entity<AddressFieldLabel>()
                .HasMany(e => e.AddressFieldDefinitions)
                .WithRequired(e => e.AddressFieldLabel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AddressForm>()
                .HasMany(e => e.AddressFieldDefinitions)
                .WithRequired(e => e.AddressForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Cost)
                .HasPrecision(17, 2);

            modelBuilder.Entity<AgeBand>()
                .HasMany(e => e.AgeBandLocaliseds)
                .WithRequired(e => e.AgeBand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.AppointmentContacts)
                .WithRequired(e => e.Appointment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.AppointmentOtherAttendees)
                .WithRequired(e => e.Appointment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.AppointmentUsers)
                .WithRequired(e => e.Appointment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.Attachments)
                .WithMany(e => e.Appointments)
                .Map(m => m.ToTable("AppointmentAttachment").MapLeftKey("AppointmentId").MapRightKey("AttachmentId"));

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.Assets)
                .WithMany(e => e.Appointments)
                .Map(m => m.ToTable("AssetAppointment").MapLeftKey("AppointmentId").MapRightKey("AssetId"));

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.Requirements)
                .WithMany(e => e.Appointments1)
                .Map(m => m.ToTable("RequirementAppointment").MapLeftKey("AppointmentId").MapRightKey("RequirementId"));

            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.Tenancies)
                .WithMany(e => e.Appointments)
                .Map(m => m.ToTable("TenancyAppointment").MapLeftKey("AppointmentId").MapRightKey("TenancyId"));

            modelBuilder.Entity<AreaHierarchy>()
                .HasMany(e => e.AreaHierarchy1)
                .WithOptional(e => e.AreaHierarchy2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<AreaHierarchy>()
                .HasMany(e => e.AreaHierarchyShapes)
                .WithRequired(e => e.AreaHierarchy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Activities)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Asset1)
                .WithOptional(e => e.Asset2)
                .HasForeignKey(e => e.DevelopmentId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Asset11)
                .WithOptional(e => e.Asset3)
                .HasForeignKey(e => e.EstateId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Asset12)
                .WithOptional(e => e.Asset4)
                .HasForeignKey(e => e.PhaseId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.AssetAttributeValues)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.AssetCharacteristics)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.AssetParties)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.AssetSecurityAttributes)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.BuildingFloors)
                .WithRequired(e => e.Asset)
                .HasForeignKey(e => e.BuildingId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.ChainTransactions)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.DevelopmentDepartments)
                .WithRequired(e => e.Asset)
                .HasForeignKey(e => e.DevelopmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.InstructionAssets)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Asset)
                .HasForeignKey(e => e.PropertyId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Ownerships)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.PropertyFloors)
                .WithRequired(e => e.Asset)
                .HasForeignKey(e => e.PropertyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Requirements)
                .WithOptional(e => e.Asset)
                .HasForeignKey(e => e.CurrentLocationId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Requirements1)
                .WithOptional(e => e.Asset1)
                .HasForeignKey(e => e.SellingPropertyId);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Tenancies)
                .WithRequired(e => e.Asset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Attachments)
                .WithMany(e => e.Assets1)
                .Map(m => m.ToTable("AssetAttachment").MapLeftKey("PropertyId").MapRightKey("AttachmentId"));

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Notes)
                .WithMany(e => e.Assets)
                .Map(m => m.ToTable("AssetNote").MapLeftKey("AssetId").MapRightKey("NoteId"));

            modelBuilder.Entity<Asset>()
                .HasOptional(e => e.BuildingFloor)
                .WithMany(e => e.Assets);

            modelBuilder.Entity<Asset>()
                .HasMany(e => e.Asset13)
                .WithMany(e => e.Assets)
                .Map(m => m.ToTable("PortfolioProperty").MapLeftKey("PortfolioId").MapRightKey("PropertyId"));

            modelBuilder.Entity<AssetParty>()
                .HasMany(e => e.Ownerships)
                .WithMany(e => e.AssetParties)
                .Map(m => m.ToTable("OwnershipOwner").MapLeftKey("OwnerId").MapRightKey("OwnershipId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.Attachment)
                .HasForeignKey(e => e.AttachmentMainImageId);

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Attachment1)
                .WithOptional(e => e.Attachment2)
                .HasForeignKey(e => e.VersionRootId);

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.AttachmentSigningParties)
                .WithRequired(e => e.Attachment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.DocumentSignings)
                .WithRequired(e => e.Attachment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.ExternalMessages)
                .WithOptional(e => e.Attachment)
                .HasForeignKey(e => e.ContentId);

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Companies)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("CompanyAttachment").MapLeftKey("AttachmentId").MapRightKey("CompanyId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Contacts)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("ContactAttachment").MapLeftKey("AttachmentId").MapRightKey("ContactId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.ExternalMessages1)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("ExternalMessageAttachment").MapLeftKey("AttachmentId").MapRightKey("ExternalMessageId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Instructions)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("InstructionAttachment").MapLeftKey("AttachmentId").MapRightKey("InstructionId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Requirements)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("RequirementAttachment").MapLeftKey("AttachmentId").MapRightKey("RequirementId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.Tenancies)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("TenancyAttachment").MapLeftKey("AttachmentId").MapRightKey("TenancyId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.TenancyIdentifications)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("TenancyIdentificationAttachment").MapLeftKey("AttachmentId").MapRightKey("TenancyIdentificationId"));

            modelBuilder.Entity<Attachment>()
                .HasMany(e => e.ViewingTours)
                .WithMany(e => e.Attachments)
                .Map(m => m.ToTable("ViewingTourAttachment").MapLeftKey("AttachmentId").MapRightKey("AppointmentId"));

            modelBuilder.Entity<Attribute>()
                .HasMany(e => e.ActivityAttributeValues)
                .WithRequired(e => e.Attribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attribute>()
                .HasMany(e => e.AssetAttributeValues)
                .WithRequired(e => e.Attribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attribute>()
                .HasMany(e => e.PropertyAttributeForms)
                .WithRequired(e => e.Attribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attribute>()
                .HasMany(e => e.RequirementAttributeValues)
                .WithRequired(e => e.Attribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChainTransaction>()
                .HasMany(e => e.ChainTransaction1)
                .WithOptional(e => e.ChainTransaction2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<ChainTransaction>()
                .HasMany(e => e.ChainTransactionParties)
                .WithRequired(e => e.ChainTransaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characteristic>()
                .HasMany(e => e.ActivityCharacteristics)
                .WithRequired(e => e.Characteristic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characteristic>()
                .HasMany(e => e.AssetCharacteristics)
                .WithRequired(e => e.Characteristic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characteristic>()
                .HasMany(e => e.CharacteristicGroupItems)
                .WithRequired(e => e.Characteristic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characteristic>()
                .HasMany(e => e.CharacteristicLocaliseds)
                .WithRequired(e => e.Characteristic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characteristic>()
                .HasMany(e => e.RequirementCharacteristics)
                .WithRequired(e => e.Characteristic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CharacteristicGroup>()
                .HasMany(e => e.CharacteristicGroupLocaliseds)
                .WithRequired(e => e.CharacteristicGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CharacteristicGroup>()
                .HasMany(e => e.CharacteristicGroupUsages)
                .WithRequired(e => e.CharacteristicGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CharacteristicGroupUsage>()
                .HasMany(e => e.CharacteristicGroupItems)
                .WithRequired(e => e.CharacteristicGroupUsage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClaimsUnique>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<ClaimsUnique>()
                .Property(e => e.Claim)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.ResponsibleForSaleOrLetCompanyId);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.PropertyManagementCompanyId);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Company1)
                .WithOptional(e => e.Company2)
                .HasForeignKey(e => e.OwningCompanyId);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyAddresses)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyContacts)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyContactNotes)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyUsers)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.FeeSplits)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.PartyCompanyId);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.HoldingCompanies)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.ChildCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.HoldingCompanies1)
                .WithRequired(e => e.Company1)
                .HasForeignKey(e => e.ParentCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.ResponsibleForSaleCompanyId);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.OrganisationUnitCompanies)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Requirements)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => e.ResponsibleForDealCompanyId);

            modelBuilder.Entity<Company>()
                .HasOptional(e => e.SapCompanyUniqueNumber)
                .WithRequired(e => e.Company);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Notes)
                .WithMany(e => e.Companies)
                .Map(m => m.ToTable("CompanyNote").MapLeftKey("CompanyId").MapRightKey("NoteId"));

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Pitches)
                .WithMany(e => e.Companies)
                .Map(m => m.ToTable("PitchCompany").MapLeftKey("CompanyId").MapRightKey("PitchId"));

            modelBuilder.Entity<CompanyDomain>()
                .HasOptional(e => e.DatahugDowngradeCompanyDomain)
                .WithRequired(e => e.CompanyDomain)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CompanyDomainUser>()
                .HasOptional(e => e.DatahugDowngradeCompanyDomainUser)
                .WithRequired(e => e.CompanyDomainUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Contact>()
                .Property(e => e.MaskedClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.VisibleClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.Contact)
                .HasForeignKey(e => e.ResponsibleForSaleOrLetContactId);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.CompanyContacts)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.CompanyContactNotes)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactAccessRequests)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactAddresses)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactRelationships)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactSecurityAttributes)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.ContactUsers)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.DotmailerExportLogContacts)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.FeeSplits)
                .WithOptional(e => e.Contact)
                .HasForeignKey(e => e.PartyContactId);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.MarketingListContacts)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Referrals)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.UserExportLogContacts)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Notes)
                .WithMany(e => e.Contacts)
                .Map(m => m.ToTable("ContactNote").MapLeftKey("ContactId").MapRightKey("NoteId"));

            modelBuilder.Entity<ContactEmail>()
                .HasMany(e => e.ContactPublicationEvents)
                .WithOptional(e => e.ContactEmail)
                .HasForeignKey(e => e.UseSpecifiedEmailId);

            modelBuilder.Entity<ContactEmail>()
                .HasOptional(e => e.DatahugDowngradeContactEmail)
                .WithRequired(e => e.ContactEmail)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ContactEmail>()
                .HasMany(e => e.MarketingListContacts)
                .WithOptional(e => e.ContactEmail)
                .HasForeignKey(e => e.EmailId);

            modelBuilder.Entity<ContactEmailUser>()
                .HasOptional(e => e.DatahugDowngradeContactEmailUser)
                .WithRequired(e => e.ContactEmailUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AddressForms)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AreaHierarchies)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Companies)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.HeadOfficeLocationId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Contacts)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.DomicileCountryId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.CountryLocaliseds)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.PostCodeShapes)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Referrals)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Referrals1)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.OffSystemReferrerCountryId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.ReferralManagementRules)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.RecipientCountryId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.ReferralManagementRules1)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.ReferrerCountryId);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.ReportVisibilityCountries)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Users1)
                .WithRequired(e => e.Country1)
                .HasForeignKey(e => e.DefaultCountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentTemplate>()
                .HasOptional(e => e.DocumentTemplateContent)
                .WithRequired(e => e.DocumentTemplate)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DocumentTemplate>()
                .HasMany(e => e.DocumentTemplateRoles)
                .WithRequired(e => e.DocumentTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentTemplate>()
                .HasMany(e => e.OrganisationUnits)
                .WithMany(e => e.DocumentTemplates)
                .Map(m => m.ToTable("DocumentTemplateBusiness").MapLeftKey("DocumentTemplateId").MapRightKey("BusinessId"));

            modelBuilder.Entity<DocumentTemplate>()
                .HasMany(e => e.OrganisationUnits1)
                .WithMany(e => e.DocumentTemplates1)
                .Map(m => m.ToTable("DocumentTemplateDepartment").MapLeftKey("DocumentTemplateId").MapRightKey("DepartmentId"));

            modelBuilder.Entity<DocumentTemplate>()
                .HasMany(e => e.EnumTypeItems)
                .WithMany(e => e.DocumentTemplates6)
                .Map(m => m.ToTable("DocumentTemplateDivision").MapLeftKey("DocumentTemplateId").MapRightKey("DivisionId"));

            modelBuilder.Entity<DocumentTemplate>()
                .HasMany(e => e.EnumTypeItems1)
                .WithMany(e => e.DocumentTemplates7)
                .Map(m => m.ToTable("DocumentTemplateEntityStatus").MapLeftKey("DocumentTemplateId").MapRightKey("EntityStatusId"));

            modelBuilder.Entity<DocumentTemplate>()
                .HasMany(e => e.EnumTypeItems2)
                .WithMany(e => e.DocumentTemplates8)
                .Map(m => m.ToTable("DocumentTemplateServiceLine").MapLeftKey("DocumentTemplateId").MapRightKey("UserServiceLineId"));

            modelBuilder.Entity<DotmailerAccount>()
                .HasMany(e => e.DotmailerExportLogs)
                .WithRequired(e => e.DotmailerAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DotmailerExportLog>()
                .HasMany(e => e.DotmailerExportLogContacts)
                .WithRequired(e => e.DotmailerExportLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ActivityAssetTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.ActivityInstructionCddStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.ActivityStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.AdvertisingPrPermittedTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities4)
                .WithRequired(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.AgencyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities5)
                .WithOptional(e => e.EnumTypeItem5)
                .HasForeignKey(e => e.AlienationProvisionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities6)
                .WithOptional(e => e.EnumTypeItem6)
                .HasForeignKey(e => e.BreakTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities7)
                .WithOptional(e => e.EnumTypeItem7)
                .HasForeignKey(e => e.ConditionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities8)
                .WithRequired(e => e.EnumTypeItem8)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities9)
                .WithOptional(e => e.EnumTypeItem9)
                .HasForeignKey(e => e.DevPipelineCompletionDateQuarterId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities10)
                .WithOptional(e => e.EnumTypeItem10)
                .HasForeignKey(e => e.DevPipelineConstructionStageId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities11)
                .WithOptional(e => e.EnumTypeItem11)
                .HasForeignKey(e => e.DevPipelineConstructionStartQuarterId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities12)
                .WithOptional(e => e.EnumTypeItem12)
                .HasForeignKey(e => e.DevPipelineDevelopmentProbabilityId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities13)
                .WithOptional(e => e.EnumTypeItem13)
                .HasForeignKey(e => e.DevPipelineDevelopmentTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities14)
                .WithOptional(e => e.EnumTypeItem14)
                .HasForeignKey(e => e.DevPipelineRecordInfoId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities15)
                .WithOptional(e => e.EnumTypeItem15)
                .HasForeignKey(e => e.DevPipelineSpeculativePreLetId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities16)
                .WithOptional(e => e.EnumTypeItem16)
                .HasForeignKey(e => e.DisposalTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities17)
                .WithOptional(e => e.EnumTypeItem17)
                .HasForeignKey(e => e.DurationTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities18)
                .WithOptional(e => e.EnumTypeItem18)
                .HasForeignKey(e => e.FeeTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities19)
                .WithOptional(e => e.EnumTypeItem19)
                .HasForeignKey(e => e.FurnishingId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities20)
                .WithOptional(e => e.EnumTypeItem20)
                .HasForeignKey(e => e.GradeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities21)
                .WithOptional(e => e.EnumTypeItem21)
                .HasForeignKey(e => e.InformationQualityId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities22)
                .WithOptional(e => e.EnumTypeItem22)
                .HasForeignKey(e => e.KeyHolderTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities23)
                .WithOptional(e => e.EnumTypeItem23)
                .HasForeignKey(e => e.LonResCommissionTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities24)
                .WithRequired(e => e.EnumTypeItem24)
                .HasForeignKey(e => e.LonResStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities25)
                .WithOptional(e => e.EnumTypeItem25)
                .HasForeignKey(e => e.LostFromId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities26)
                .WithOptional(e => e.EnumTypeItem26)
                .HasForeignKey(e => e.ManagementFeeTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities27)
                .WithOptional(e => e.EnumTypeItem27)
                .HasForeignKey(e => e.ManagementTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities28)
                .WithOptional(e => e.EnumTypeItem28)
                .HasForeignKey(e => e.OwnershipTenureId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities29)
                .WithOptional(e => e.EnumTypeItem29)
                .HasForeignKey(e => e.PremiumPaidById);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities30)
                .WithOptional(e => e.EnumTypeItem30)
                .HasForeignKey(e => e.PriceQualifierId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities31)
                .WithOptional(e => e.EnumTypeItem31)
                .HasForeignKey(e => e.PriceTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities32)
                .WithOptional(e => e.EnumTypeItem32)
                .HasForeignKey(e => e.PurposeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities33)
                .WithOptional(e => e.EnumTypeItem33)
                .HasForeignKey(e => e.QuotingRentTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities34)
                .WithOptional(e => e.EnumTypeItem34)
                .HasForeignKey(e => e.RentFrequencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities35)
                .WithOptional(e => e.EnumTypeItem35)
                .HasForeignKey(e => e.RepairingObligationId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities36)
                .WithOptional(e => e.EnumTypeItem36)
                .HasForeignKey(e => e.RepresentingId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities37)
                .WithOptional(e => e.EnumTypeItem37)
                .HasForeignKey(e => e.RetirementHousingId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities38)
                .WithOptional(e => e.EnumTypeItem38)
                .HasForeignKey(e => e.SalePotentialId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities39)
                .WithOptional(e => e.EnumTypeItem39)
                .HasForeignKey(e => e.SalesBoardStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities40)
                .WithOptional(e => e.EnumTypeItem40)
                .HasForeignKey(e => e.SalesBoardTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities41)
                .WithOptional(e => e.EnumTypeItem41)
                .HasForeignKey(e => e.SellingReasonId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities42)
                .WithRequired(e => e.EnumTypeItem42)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities43)
                .WithOptional(e => e.EnumTypeItem43)
                .HasForeignKey(e => e.SingleLetId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities44)
                .WithOptional(e => e.EnumTypeItem44)
                .HasForeignKey(e => e.SourceId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities45)
                .WithOptional(e => e.EnumTypeItem45)
                .HasForeignKey(e => e.StandardDisregardsId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities46)
                .WithOptional(e => e.EnumTypeItem46)
                .HasForeignKey(e => e.SurrenderFromId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities47)
                .WithOptional(e => e.EnumTypeItem47)
                .HasForeignKey(e => e.SurrenderToId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities48)
                .WithOptional(e => e.EnumTypeItem48)
                .HasForeignKey(e => e.TreatmentOfRentFreePeriodsId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Activities49)
                .WithOptional(e => e.EnumTypeItem49)
                .HasForeignKey(e => e.TypeOfLeaseId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityAttributeValues)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EnumValueId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityDepartments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DepartmentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityDocumentTypeUsages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityDocumentTypeUsages1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityNegotiators)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.UserTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityPropertyAreas)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.SubStateId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityServiceLineDefinitions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityStatusDefinitions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ActivityStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityStatusDefinitions1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.AgencyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ActivityStatusDefinitions2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AddressForms)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AddressFormTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Advertisements)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.TypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AppointmentContacts)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ChannelTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AppointmentContacts1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.PartyRoleTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AppointmentOtherAttendees)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ChannelTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AreaHierarchies)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AgencyTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Assets1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DivisionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AssetAttributeValues)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EnumValueId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AssetDocumentTypeUsages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AssetDocumentTypeUsages1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AssetParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Attachments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Attachments1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Attachments2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.AttachmentSigningParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Attributes)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ValueTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.BusinessEvents)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityElementId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.BusinessEvents1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.BusinessEvents2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.EventTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.BusinessLanguages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ChainTransactions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ContractAgreedId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ChainTransactions1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.EnquiriesId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ChainTransactions2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.MortgageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ChainTransactions3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.SearchesId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ChainTransactions4)
                .WithRequired(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.SurveyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ChainTransactionParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Companies)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ClientCareStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Companies1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.CompanyCategoryId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Companies2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.CompanyTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Companies3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.InvestorTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Companies4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.TenantTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Contacts)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DefaultSalutationId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Contacts1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DomicileRegionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Contacts2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.FairProcessingNoticeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Contacts3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.PersonalWealthId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Contacts4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.SourceOfIncomeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactAccessRequests)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactAddresses)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ResidentialAddressTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactAddressDirectMarketingConsents)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ConsentMethodId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactAddressDirectMarketingConsents1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DirectMarketingConsentId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactCompanyAddressDirectMarketingConsents)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ConsentMethodId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactCompanyAddressDirectMarketingConsents1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DirectMarketingConsentId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactEmails)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.MyKfAccountStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactEmailDirectMarketingConsents)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ConsentMethodId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactEmailDirectMarketingConsents1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DirectMarketingConsentId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactMarketingCampaigns)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactPhones)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.PhoneTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactPublicationEvents)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.PrimaryAddressTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactPublicationEvents1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.SendMethodId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactPublicationEvents2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.SendTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactRelationships)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RelationTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ContactUsers)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RelationshipTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Countries1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DefaultLivingAreaUnitId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DataHugUpdatedEntities)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DepartmentGroups)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DepartmentGroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DevelopmentDepartments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DepartmentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DeviceRegistrations)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DeviceOsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DivisionServiceLineDefinitions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DivisionServiceLineDefinitions1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentSignings)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentSignings1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplates)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AgencyTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplates1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DocumentTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplates2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.EntityTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplates3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.TargetEntityTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplates4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.TemplateSubtypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplates5)
                .WithRequired(e => e.EnumTypeItem5)
                .HasForeignKey(e => e.TemplateTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplateFields)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTemplateFieldTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DocumentTemplateRoles)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.TemplateRoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DotmailerEmailsQueues)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DotmailerEmailTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.DotmailerEmailTemplates)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DotmailerEmailTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ExchangeRates)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.SourceCurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ExchangeRates1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.TargetCurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ExternalMessages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ExternalMessages1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ExternalMessages2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ExternalMessageRecipients)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.FeeSplits)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.FeeGroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.FeeSplits1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.FeeTakenFromId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.FeeSplits2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.PartyRoleId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.FlexibleReports)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Grids)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.GridCodeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.GridColumns)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.GridColumnCodeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.GridColumns1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.GridColumnSizeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.GridColumnServiceLines)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.UserServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Instructions)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.CddCompleteId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Instructions1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.InstructionCategoryId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Instructions2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.InstructionStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Instructions3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.InstructionTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Instructions4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.SourceId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Instructions5)
                .WithRequired(e => e.EnumTypeItem5)
                .HasForeignKey(e => e.TeamResponsibleForCddId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.InstructionParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.InvoiceTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingImages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingLists)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.SalutationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingLists1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.SendTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingLists2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingListContacts)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ExportStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingListContacts1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.PrimaryAddressTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingListContacts2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.SendMethodOverrideId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MarketingListContacts3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.SendTypeOverrideId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MeasurementUnitConfigurations)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.CurrencyPerUnitId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MeasurementUnitConfigurations1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DistanceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MeasurementUnitConfigurations2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.LandAreaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MeasurementUnitConfigurations3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.LivingAreaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MeasurementUnitValues)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.CurrencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.MyKfFeedDetails)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Notes)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Notes1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.RelatedEnumTypeItemId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Notifications)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Notifications1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.NotificationBlacklists)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.NotificationTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.NotificationRecipients)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.MobileStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.NotificationRecipients1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AdditionalSurveyStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.AgentTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.DurationTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.EnquiriesId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers5)
                .WithOptional(e => e.EnumTypeItem5)
                .HasForeignKey(e => e.FinancialPositionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers6)
                .WithOptional(e => e.EnumTypeItem6)
                .HasForeignKey(e => e.LeaseTermPeriodTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers7)
                .WithOptional(e => e.EnumTypeItem7)
                .HasForeignKey(e => e.MortgageStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers8)
                .WithOptional(e => e.EnumTypeItem8)
                .HasForeignKey(e => e.MortgageSurveyStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers9)
                .WithOptional(e => e.EnumTypeItem9)
                .HasForeignKey(e => e.OfferAgreementTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers10)
                .WithOptional(e => e.EnumTypeItem10)
                .HasForeignKey(e => e.RentFrequencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers11)
                .WithOptional(e => e.EnumTypeItem11)
                .HasForeignKey(e => e.SearchStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Offers12)
                .WithRequired(e => e.EnumTypeItem12)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.OfferParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.OfficePatches)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.OfficePatchTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.OfficePatchThresholds)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.OfficePatchThresholdTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.OrganisationUnits)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DivisionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.OrganisationUnits1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.EmailServerTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Ownerships)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Ownerships1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.OwnershipTenureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Ownerships2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.OwnershipTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Pitches)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ResultId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.PitchUsers)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.UserTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.PortalDefinitions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ServiceLineId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Professions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ProfessionGroupId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.PropertyTypeDefinitions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.PublicationEvents)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AllowedSendMethodId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.PublicationEvents1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.AllowedSendTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.PublicationEvents2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Referrals)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AwardCurrencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Referrals1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.KfFeeCurrencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Referrals2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.RateId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Referrals3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.ReferralStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Referrals4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.RegistrationSystemId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RegistrationSystems)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ReferralRegistrationSystemId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RelationshipTypes)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.LeftRelationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RelationshipTypes1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.RightRelationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ReportVisibilityCountries)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ReportVisibilityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ReportVisibilityDepartments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ReportVisibilityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ReportVisibilityServiceLines)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ReportVisibilityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ReportVisibilityServiceLines1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.UserServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AgencyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.BuyingPositionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.BuyingReasonId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.FeeTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements5)
                .WithOptional(e => e.EnumTypeItem5)
                .HasForeignKey(e => e.FinancialServicesStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements6)
                .WithOptional(e => e.EnumTypeItem6)
                .HasForeignKey(e => e.FurnishingId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements7)
                .WithOptional(e => e.EnumTypeItem7)
                .HasForeignKey(e => e.GradeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements8)
                .WithOptional(e => e.EnumTypeItem8)
                .HasForeignKey(e => e.HotId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements9)
                .WithOptional(e => e.EnumTypeItem9)
                .HasForeignKey(e => e.LetLengthId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements10)
                .WithOptional(e => e.EnumTypeItem10)
                .HasForeignKey(e => e.MoveReasonId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements11)
                .WithOptional(e => e.EnumTypeItem11)
                .HasForeignKey(e => e.NewBuildId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements12)
                .WithOptional(e => e.EnumTypeItem12)
                .HasForeignKey(e => e.PrimaryMotivationId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements13)
                .WithRequired(e => e.EnumTypeItem13)
                .HasForeignKey(e => e.RequirementStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements14)
                .WithOptional(e => e.EnumTypeItem14)
                .HasForeignKey(e => e.SectorId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements15)
                .WithOptional(e => e.EnumTypeItem15)
                .HasForeignKey(e => e.SellingPositionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements16)
                .WithOptional(e => e.EnumTypeItem16)
                .HasForeignKey(e => e.SellingStatusId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements17)
                .WithOptional(e => e.EnumTypeItem17)
                .HasForeignKey(e => e.SourceId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements18)
                .WithOptional(e => e.EnumTypeItem18)
                .HasForeignKey(e => e.TenantTypesId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements19)
                .WithOptional(e => e.EnumTypeItem19)
                .HasForeignKey(e => e.TenureId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements20)
                .WithOptional(e => e.EnumTypeItem20)
                .HasForeignKey(e => e.TimingQuarterMaxId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements21)
                .WithOptional(e => e.EnumTypeItem21)
                .HasForeignKey(e => e.TimingQuarterMinId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Requirements22)
                .WithOptional(e => e.EnumTypeItem22)
                .HasForeignKey(e => e.TimingTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementAttributeValues)
                .WithOptional(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EnumValueId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementDepartments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DepartmentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementDocumentTypeUsages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementDocumentTypeUsages1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementNegotiators)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.UserTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementOtherMotivations)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.OtherMotivationId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.RequirementTypes)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ServiceLineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ScheduledNotifications)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.ScheduledNotifications1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SearchConfigurations)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.SearchPageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SearchConfigurationAccesses)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.SearchConfigurationAccessTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SearchFilterConfigurations)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.FilterId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SecurityAttributes)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AttributeGroupTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SecurityAttributes1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.AttributeTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SecurityAttributes2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.CalculationStrategyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.SecurityAttributes3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.AgencyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.AlienationProvisionId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.BankChargesId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies3)
                .WithRequired(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies4)
                .WithOptional(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.DurationTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies5)
                .WithOptional(e => e.EnumTypeItem5)
                .HasForeignKey(e => e.FeeTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies6)
                .WithOptional(e => e.EnumTypeItem6)
                .HasForeignKey(e => e.InsideActId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies7)
                .WithOptional(e => e.EnumTypeItem7)
                .HasForeignKey(e => e.LeaseTermPeriodTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies8)
                .WithOptional(e => e.EnumTypeItem8)
                .HasForeignKey(e => e.ManagementFeeTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies9)
                .WithOptional(e => e.EnumTypeItem9)
                .HasForeignKey(e => e.ManagementTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies10)
                .WithOptional(e => e.EnumTypeItem10)
                .HasForeignKey(e => e.RentFrequencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies11)
                .WithOptional(e => e.EnumTypeItem11)
                .HasForeignKey(e => e.RepairingObligationId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Tenancies12)
                .WithOptional(e => e.EnumTypeItem12)
                .HasForeignKey(e => e.TenancyAgreementTypeId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyBillsDescriptions)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.BillDescriptionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyBreaks)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.BreakTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyBreaks1)
                .WithOptional(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.NoticePeriodAfterFrequencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyBreaks2)
                .WithOptional(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.NoticePeriodFrequencyId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyDepartments)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DepartmentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyDocumentTypeUsages)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.DocumentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyIdentifications)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.IdTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyNegotiators)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.UserTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyParties)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.TenancyReviews)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.ReviewTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Users1)
                .WithRequired(e => e.EnumTypeItem1)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Users2)
                .WithRequired(e => e.EnumTypeItem2)
                .HasForeignKey(e => e.RentPeriodId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Users3)
                .WithOptional(e => e.EnumTypeItem3)
                .HasForeignKey(e => e.SalutationFormatId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.Users4)
                .WithRequired(e => e.EnumTypeItem4)
                .HasForeignKey(e => e.UserServiceLineId);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.UserFeedDetails)
                .WithRequired(e => e.EnumTypeItem)
                .HasForeignKey(e => e.EntityTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumTypeItem>()
                .HasMany(e => e.OrganisationUnits2)
                .WithMany(e => e.EnumTypeItems)
                .Map(m => m.ToTable("BusinessRegistrationSystem").MapLeftKey("RegistrationSystemsEnumId").MapRightKey("BusinessId"));

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Rate)
                .HasPrecision(16, 6);

            modelBuilder.Entity<ExternalMessage>()
                .HasMany(e => e.Requirements)
                .WithMany(e => e.ExternalMessages)
                .Map(m => m.ToTable("ExternalMessageRequirement").MapLeftKey("ExternalMessageId").MapRightKey("RequirementId"));

            modelBuilder.Entity<ExternalMessage>()
                .HasMany(e => e.Tenancies)
                .WithMany(e => e.ExternalMessages)
                .Map(m => m.ToTable("ExternalMessageTenancy").MapLeftKey("ExternalMessageId").MapRightKey("TenancyId"));

            modelBuilder.Entity<FeeIncome>()
                .HasMany(e => e.FeeIncomeLocaliseds)
                .WithRequired(e => e.FeeIncome)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FeeIncome>()
                .HasMany(e => e.Pitches)
                .WithOptional(e => e.FeeIncome)
                .HasForeignKey(e => e.PotentialFeeIncomeId);

            modelBuilder.Entity<FeeSplit>()
                .Property(e => e.FeeValue)
                .HasPrecision(17, 2);

            modelBuilder.Entity<FeeSplit>()
                .Property(e => e.ShareOfFee)
                .HasPrecision(17, 2);

            modelBuilder.Entity<FeeSplit>()
                .Property(e => e.FeePercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FlexibleReport>()
                .HasMany(e => e.Notifications)
                .WithOptional(e => e.FlexibleReport)
                .HasForeignKey(e => e.ReportId);

            modelBuilder.Entity<Grid>()
                .HasMany(e => e.GridDefinitions)
                .WithRequired(e => e.Grid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grid>()
                .HasMany(e => e.GridColumns)
                .WithMany(e => e.Grids)
                .Map(m => m.ToTable("GridColumnAvailability").MapLeftKey("GridId").MapRightKey("GridColumnId"));

            modelBuilder.Entity<GridColumn>()
                .HasMany(e => e.GridColumnDefinitions)
                .WithRequired(e => e.GridColumn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GridColumn>()
                .HasMany(e => e.GridColumnServiceLines)
                .WithRequired(e => e.GridColumn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GridDefinition>()
                .HasMany(e => e.GridColumnDefinitions)
                .WithRequired(e => e.GridDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.InstructionActivities)
                .WithRequired(e => e.Instruction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.InstructionAssets)
                .WithRequired(e => e.Instruction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.InstructionParties)
                .WithRequired(e => e.Instruction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.InstructionRequirements)
                .WithRequired(e => e.Instruction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.InstructionSecurityAttributes)
                .WithRequired(e => e.Instruction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasOptional(e => e.SapInstructionUniqueNumber)
                .WithRequired(e => e.Instruction);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.SapPostingQueues)
                .WithRequired(e => e.Instruction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instruction>()
                .HasMany(e => e.Pitches)
                .WithMany(e => e.Instructions)
                .Map(m => m.ToTable("PitchInstruction").MapLeftKey("InstructionId").MapRightKey("PitchId"));

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Amount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.ActivityLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.ActivityTypeLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.AgeBandLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.BusinessLanguages)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.CharacteristicGroupLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.CharacteristicLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.CountryLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.DeviceRegistrations)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.DocumentTemplates)
                .WithOptional(e => e.Locale)
                .HasForeignKey(e => e.LanguageId);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.EnumLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.FeeIncomeLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.FlexibleReports)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.LocaleLocaliseds)
                .WithRequired(e => e.Locale)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.LocaleLocaliseds1)
                .WithRequired(e => e.Locale1)
                .HasForeignKey(e => e.LocaleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.NationalityLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.OfferTypeLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.ProfessionLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.PropertyTypeLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.RegistrationStatusLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.ReportGroupLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.ReportLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.RequirementTypeLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.ServiceLineLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.TenancyTypeLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.TranslationLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locale>()
                .HasMany(e => e.WindowsTimeZoneLocaliseds)
                .WithRequired(e => e.Locale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingImage>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.MarketingImage)
                .HasForeignKey(e => e.ActivityMainImageId);

            modelBuilder.Entity<MarketingImage>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.MarketingImage)
                .HasForeignKey(e => e.ActivityMainImageId);

            modelBuilder.Entity<MarketingList>()
                .HasMany(e => e.DotmailerExportLogs)
                .WithRequired(e => e.MarketingList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingList>()
                .HasMany(e => e.MarketingListContacts)
                .WithRequired(e => e.MarketingList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingList>()
                .HasMany(e => e.MarketingListEditors)
                .WithRequired(e => e.MarketingList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnitConfiguration>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.MeasurementUnitConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.SquareFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.SquareMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.Acre)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.Hectare)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.Miles)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.Kilometers)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.CurrencyPerSquareFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .Property(e => e.CurrencyPerSquareMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.AgreedCapitalValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.AgreedRentMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.AgreedRentMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities3)
                .WithOptional(e => e.MeasurementUnitValue3)
                .HasForeignKey(e => e.EstimatedRatesId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities4)
                .WithOptional(e => e.MeasurementUnitValue4)
                .HasForeignKey(e => e.EstimatedRentalValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities5)
                .WithOptional(e => e.MeasurementUnitValue5)
                .HasForeignKey(e => e.EstimatedServiceChargeId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities6)
                .WithOptional(e => e.MeasurementUnitValue6)
                .HasForeignKey(e => e.PriorAgreedRentMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities7)
                .WithOptional(e => e.MeasurementUnitValue7)
                .HasForeignKey(e => e.PriorAgreedRentMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities8)
                .WithOptional(e => e.MeasurementUnitValue8)
                .HasForeignKey(e => e.QuotedCapitalValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities9)
                .WithOptional(e => e.MeasurementUnitValue9)
                .HasForeignKey(e => e.QuotingRentMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities10)
                .WithOptional(e => e.MeasurementUnitValue10)
                .HasForeignKey(e => e.QuotingRentMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities11)
                .WithOptional(e => e.MeasurementUnitValue11)
                .HasForeignKey(e => e.TotalRentId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Activities12)
                .WithOptional(e => e.MeasurementUnitValue12)
                .HasForeignKey(e => e.ZoneARentId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityAttributeValues)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.MaxNumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityAttributeValues1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.MinNumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityAttributeValues2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.NumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityPropertyAreas)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.AgreedRentId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityPropertyAreas1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.MinSizeId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityPropertyAreas2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.QuotingRentId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.ActivityPropertyAreas3)
                .WithRequired(e => e.MeasurementUnitValue3)
                .HasForeignKey(e => e.SizeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.AreaTemplates)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.RadiusId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.TotalAreaBreakdownId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.AssetAttributeValues)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.MaxNumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.AssetAttributeValues1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.MinNumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.AssetAttributeValues2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.NumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.AgreedCapitalValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Offers1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.AmountMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Offers2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.AmountMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.OfferPropertyAreas)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.OfferAmountId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.OfferPropertyAreas1)
                .WithRequired(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.SizeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.PropertyAreas)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.MinSizeId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.PropertyAreas1)
                .WithRequired(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.SizeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Requirements)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.BudgetRentMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Requirements1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.BudgetRentMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.RequirementAreas)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.RadiusId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.RequirementAttributeValues)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.MaxNumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.RequirementAttributeValues1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.MinNumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.RequirementAttributeValues2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.NumberWithUnitValueId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Tenancies)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.AgreedRentPerUnitMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Tenancies1)
                .WithOptional(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.AgreedRentPerUnitMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Tenancies2)
                .WithOptional(e => e.MeasurementUnitValue2)
                .HasForeignKey(e => e.EstimatedRatesId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Tenancies3)
                .WithOptional(e => e.MeasurementUnitValue3)
                .HasForeignKey(e => e.EstimatedServiceChargeId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Tenancies4)
                .WithOptional(e => e.MeasurementUnitValue4)
                .HasForeignKey(e => e.LeaseAdvisoryAgreedRentPerUnitMaxId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.Tenancies5)
                .WithOptional(e => e.MeasurementUnitValue5)
                .HasForeignKey(e => e.LeaseAdvisoryAgreedRentPerUnitMinId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.TenancyPropertyAreas)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.AgreedRentId);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.TenancyPropertyAreas1)
                .WithRequired(e => e.MeasurementUnitValue1)
                .HasForeignKey(e => e.SizeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasurementUnitValue>()
                .HasMany(e => e.UserPreferenceAreas)
                .WithOptional(e => e.MeasurementUnitValue)
                .HasForeignKey(e => e.RadiusId);

            modelBuilder.Entity<MyKfFeedLog>()
                .HasMany(e => e.MyKfFeedDetails)
                .WithRequired(e => e.MyKfFeedLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nationality>()
                .HasMany(e => e.NationalityLocaliseds)
                .WithRequired(e => e.Nationality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Note>()
                .HasMany(e => e.CompanyContactNotes)
                .WithRequired(e => e.Note)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Offers)
                .WithMany(e => e.Notes)
                .Map(m => m.ToTable("OfferNote").MapLeftKey("NoteId").MapRightKey("OfferId"));

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Referrals)
                .WithMany(e => e.Notes)
                .Map(m => m.ToTable("ReferralNote").MapLeftKey("NoteId").MapRightKey("ReferralId"));

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Requirements)
                .WithMany(e => e.Notes)
                .Map(m => m.ToTable("RequirementNote").MapLeftKey("NoteId").MapRightKey("RequirementId"));

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Tenancies)
                .WithMany(e => e.Notes)
                .Map(m => m.ToTable("TenancyNote").MapLeftKey("NoteId").MapRightKey("TenancyId"));

            modelBuilder.Entity<Notification>()
                .HasMany(e => e.NotificationRecipients)
                .WithRequired(e => e.Notification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offer>()
                .Property(e => e.Price)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Offer>()
                .Property(e => e.PricePerWeek)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Offer>()
                .Property(e => e.AgreedPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Offer>()
                .Property(e => e.ParkingPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Offer>()
                .Property(e => e.AmountPA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.Offer)
                .HasForeignKey(e => e.AcceptedOfferId);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.OfferParties)
                .WithRequired(e => e.Offer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfferType>()
                .HasMany(e => e.Offers)
                .WithRequired(e => e.OfferType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfferType>()
                .HasMany(e => e.OfferTypeLocaliseds)
                .WithRequired(e => e.OfferType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficePatch>()
                .HasMany(e => e.OfficePatchThresholds)
                .WithRequired(e => e.OfficePatch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficePatch>()
                .HasMany(e => e.OrganisationUnits)
                .WithMany(e => e.OfficePatches)
                .Map(m => m.ToTable("OfficePatchDepartment").MapLeftKey("OfficePatchId").MapRightKey("DepartmentId"));

            modelBuilder.Entity<OfficePatchThreshold>()
                .Property(e => e.Value)
                .HasPrecision(17, 2);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.KeyHolderDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Activities1)
                .WithOptional(e => e.OrganisationUnit1)
                .HasForeignKey(e => e.ResponsibleForSaleOrLetNegotiatorDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ActivityDepartments)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.ResponsibleNegotiatorDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.BusinessLanguages)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ContactAddressDirectMarketingConsents)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ContactCompanyAddressDirectMarketingConsents)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ContactEmailDirectMarketingConsents)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ContactToBePhoneds)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.DepartmentGroups)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.DevelopmentDepartments)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.DotmailerAccounts)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.DotmailerEmailsQueues)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.BusinessId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.DotmailerEmailTemplates)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.BusinessId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.DotmailerSuppressedEmails)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.FeeSplits)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Instructions)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.MarketingLists)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.NegotiatorDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.OrganisationalSecurityRules)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.SourceOrganisationUnitId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.OrganisationalSecurityRules1)
                .WithRequired(e => e.OrganisationUnit1)
                .HasForeignKey(e => e.TargetOrganisationUnitId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.OrganisationUnit1)
                .WithOptional(e => e.OrganisationUnit2)
                .HasForeignKey(e => e.BusinessParentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.OrganisationUnit11)
                .WithOptional(e => e.OrganisationUnit3)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.OrganisationUnitCompanies)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.OrganisationUnitServiceLines)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Referrals)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Referrals1)
                .WithOptional(e => e.OrganisationUnit1)
                .HasForeignKey(e => e.OriginalDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ReferralManagementRules)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.RecipientDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.ReportVisibilityDepartments)
                .WithRequired(e => e.OrganisationUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Requirements)
                .WithOptional(e => e.OrganisationUnit)
                .HasForeignKey(e => e.ResponsibleForDealNegotiatorDepartmentId);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.RequirementDepartments)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.TenancyDepartments)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Users1)
                .WithRequired(e => e.OrganisationUnit1)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.UserRoleBusinesses)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.UserRoleDepartments)
                .WithRequired(e => e.OrganisationUnit)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.SecurityAttributes)
                .WithMany(e => e.OrganisationUnits)
                .Map(m => m.ToTable("SecurityAttributesAvailableForUnits").MapLeftKey("OrganisationUnitId").MapRightKey("SecurityAttributeId"));

            modelBuilder.Entity<OrganisationUnit>()
                .HasMany(e => e.Users2)
                .WithMany(e => e.OrganisationUnits)
                .Map(m => m.ToTable("UserDepartment").MapLeftKey("DepartmentId").MapRightKey("UserId"));

            modelBuilder.Entity<Ownership>()
                .Property(e => e.BuyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Ownership>()
                .Property(e => e.SellPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Pitch>()
                .Property(e => e.MaskedClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Pitch>()
                .Property(e => e.VisibleClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Pitch>()
                .HasMany(e => e.PitchSecurityAttributes)
                .WithRequired(e => e.Pitch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pitch>()
                .HasMany(e => e.PitchUsers)
                .WithRequired(e => e.Pitch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pitch>()
                .HasMany(e => e.ServiceLines)
                .WithMany(e => e.Pitches)
                .Map(m => m.ToTable("PitchServiceLine").MapLeftKey("PitchId").MapRightKey("ServiceLineId"));

            modelBuilder.Entity<Profession>()
                .HasMany(e => e.ProfessionLocaliseds)
                .WithRequired(e => e.Profession)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyArea>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.PropertyArea)
                .HasForeignKey(e => e.PropertyArea_Id);

            modelBuilder.Entity<PropertyFloor>()
                .HasMany(e => e.ActivityPropertyAreas)
                .WithRequired(e => e.PropertyFloor)
                .HasForeignKey(e => e.FloorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyFloor>()
                .HasMany(e => e.OfferPropertyAreas)
                .WithRequired(e => e.PropertyFloor)
                .HasForeignKey(e => e.FloorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyFloor>()
                .HasMany(e => e.PropertyAreas)
                .WithRequired(e => e.PropertyFloor)
                .HasForeignKey(e => e.FloorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyFloor>()
                .HasMany(e => e.TenancyPropertyAreas)
                .WithRequired(e => e.PropertyFloor)
                .HasForeignKey(e => e.FloorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.Activities)
                .WithRequired(e => e.PropertyType)
                .HasForeignKey(e => e.OriginalPropertyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.Activities1)
                .WithRequired(e => e.PropertyType1)
                .HasForeignKey(e => e.PropertyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.ActivityTypeDefinitions)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.CharacteristicGroupUsages)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.PropertyAttributeForms)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.PropertyType1)
                .WithOptional(e => e.PropertyType2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.PropertyTypeDefinitions)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.PropertyTypeLocaliseds)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyType>()
                .HasMany(e => e.UserPropertyTypes)
                .WithRequired(e => e.PropertyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegistrationStatu>()
                .HasMany(e => e.Instructions)
                .WithOptional(e => e.RegistrationStatu)
                .HasForeignKey(e => e.RegistrationStatusId);

            modelBuilder.Entity<RegistrationStatu>()
                .HasMany(e => e.RegistrationStatusLocaliseds)
                .WithRequired(e => e.RegistrationStatu)
                .HasForeignKey(e => e.RegistrationStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegistrationStatu>()
                .HasMany(e => e.SapPostingQueues)
                .WithOptional(e => e.RegistrationStatu)
                .HasForeignKey(e => e.LastPostingErrorCodeId);

            modelBuilder.Entity<Relationship>()
                .HasMany(e => e.ContactRelationships)
                .WithRequired(e => e.Relationship)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelationshipType>()
                .HasMany(e => e.Relationships)
                .WithRequired(e => e.RelationshipType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .HasMany(e => e.ReportLocaliseds)
                .WithRequired(e => e.Report)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .HasMany(e => e.ReportVisibilityCountries)
                .WithRequired(e => e.Report)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .HasMany(e => e.ReportVisibilityDepartments)
                .WithRequired(e => e.Report)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .HasMany(e => e.ReportVisibilityServiceLines)
                .WithRequired(e => e.Report)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReportGroup>()
                .HasMany(e => e.Reports)
                .WithRequired(e => e.ReportGroup)
                .HasForeignKey(e => e.GroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReportGroup>()
                .HasMany(e => e.ReportGroup1)
                .WithOptional(e => e.ReportGroup2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<ReportGroup>()
                .HasMany(e => e.ReportGroupLocaliseds)
                .WithRequired(e => e.ReportGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.RentWeeklyMin)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.RentMonthlyMin)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.RentWeeklyMax)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.RentMonthlyMax)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.PriceMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.PriceMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.MinNetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.MaxNetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.BudgetRentPaMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.BudgetRentPaMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.BudgetPricePaMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.BudgetPricePaMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Requirement>()
                .Property(e => e.MaskedClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Requirement>()
                .Property(e => e.VisibleClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.Requirement)
                .HasForeignKey(e => e.RequirementId);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.InstructionRequirements)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementAreas)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementAttributeValues)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementCharacteristics)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementDepartments)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementNegotiators)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementParties)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirement>()
                .HasMany(e => e.RequirementSecurityAttributes)
                .WithRequired(e => e.Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequirementType>()
                .HasMany(e => e.RequirementTypeLocaliseds)
                .WithRequired(e => e.RequirementType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.ValuationUserRoleId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Instructions)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.ValuationUserRoleId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Ownerships)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.ValuationUserRoleId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Role1)
                .WithOptional(e => e.Role2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.SecurityAttributes)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("SecurityAttributesAvailableForRoles").MapLeftKey("RoleId").MapRightKey("SecurityAttributeId"));

            modelBuilder.Entity<SapIndividualUniqueNumber>()
                .HasMany(e => e.Contacts)
                .WithOptional(e => e.SapIndividualUniqueNumber)
                .HasForeignKey(e => e.SapUniqueNumberId);

            modelBuilder.Entity<SapIndividualUniqueNumber>()
                .HasMany(e => e.Instructions)
                .WithOptional(e => e.SapIndividualUniqueNumber)
                .HasForeignKey(e => e.AddresseeSapUniqueNumberId);

            modelBuilder.Entity<SearchConfiguration>()
                .HasMany(e => e.SearchConfigurationAccesses)
                .WithRequired(e => e.SearchConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SearchConfiguration>()
                .HasMany(e => e.SearchFilterConfigurations)
                .WithRequired(e => e.SearchConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityAttribute>()
                .HasMany(e => e.ActivitySecurityAttributes)
                .WithRequired(e => e.SecurityAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityAttribute>()
                .HasMany(e => e.AssetSecurityAttributes)
                .WithRequired(e => e.SecurityAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityAttribute>()
                .HasMany(e => e.ContactSecurityAttributes)
                .WithRequired(e => e.SecurityAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityAttribute>()
                .HasMany(e => e.InstructionSecurityAttributes)
                .WithRequired(e => e.SecurityAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityAttribute>()
                .HasMany(e => e.PitchSecurityAttributes)
                .WithRequired(e => e.SecurityAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityAttribute>()
                .HasMany(e => e.RequirementSecurityAttributes)
                .WithRequired(e => e.SecurityAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceLine>()
                .HasMany(e => e.Instructions)
                .WithRequired(e => e.ServiceLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceLine>()
                .HasMany(e => e.OrganisationUnitServiceLines)
                .WithRequired(e => e.ServiceLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceLine>()
                .HasMany(e => e.ServiceLine1)
                .WithOptional(e => e.ServiceLine2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<ServiceLine>()
                .HasMany(e => e.ServiceLineLocaliseds)
                .WithRequired(e => e.ServiceLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TargetDepartment>()
                .Property(e => e.KFCommissionPct_All)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetDepartment>()
                .Property(e => e.MAToInstrucionsPct_All)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetDepartment>()
                .Property(e => e.KFCommissionPct_Core)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetDepartment>()
                .Property(e => e.MAToInstrucionsPct_Core)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetDepartment>()
                .Property(e => e.KFCommissionPct_Prime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetDepartment>()
                .Property(e => e.MAToInstrucionsPct_Prime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetNegotiator>()
                .Property(e => e.KFCommissionPct_All)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetNegotiator>()
                .Property(e => e.MAToInstrucionsPct_All)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetNegotiator>()
                .Property(e => e.KFCommissionPct_Core)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetNegotiator>()
                .Property(e => e.MAToInstrucionsPct_Core)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetNegotiator>()
                .Property(e => e.KFCommissionPct_Prime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TargetNegotiator>()
                .Property(e => e.MAToInstrucionsPct_Prime)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.AgreedRentPa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.LeaseAdvisoryAgreedRentPa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.AgreedWeeklyRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.AgreedMonthlyRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.FeeValue)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.FeePercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.ManagementFeePercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.ManagementFeeValue)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.InitialPremium)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.MaskedClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.VisibleClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.FeeLandlordTa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.FeeTenantTa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.CreditReferenceCheck)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.AdministrationFeeTds)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.OccupierRightToRentCheck)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.InventoryCharge)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.AdHocCharge)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.BankChargesAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .Property(e => e.DepositAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.Tenancy)
                .HasForeignKey(e => e.HeadLeaseId);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.Tenancy1)
                .WithOptional(e => e.Tenancy2)
                .HasForeignKey(e => e.HeadLeaseId);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.TenancyBillsDescriptions)
                .WithRequired(e => e.Tenancy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.TenancyBreaks)
                .WithRequired(e => e.Tenancy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.TenancyDepartments)
                .WithRequired(e => e.Tenancy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.TenancyNegotiators)
                .WithRequired(e => e.Tenancy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.TenancyParties)
                .WithRequired(e => e.Tenancy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tenancy>()
                .HasMany(e => e.TenancyReviews)
                .WithRequired(e => e.Tenancy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TenancyPropertyArea>()
                .HasMany(e => e.TenancyPropertyArea1)
                .WithOptional(e => e.TenancyPropertyArea2)
                .HasForeignKey(e => e.TenancyPropertyAreaId);

            modelBuilder.Entity<TenancyType>()
                .HasMany(e => e.Tenancies)
                .WithRequired(e => e.TenancyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TenancyType>()
                .HasMany(e => e.TenancyDocumentTypeUsages)
                .WithRequired(e => e.TenancyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TenancyType>()
                .HasMany(e => e.TenancyTypeLocaliseds)
                .WithRequired(e => e.TenancyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Translation>()
                .HasMany(e => e.TranslationLocaliseds)
                .WithRequired(e => e.Translation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Activities1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Activities2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.ResponsibleForSaleOrLetNegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Activities3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ActivityMarketingImages)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ActivityMarketingImages1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ActivityMarketingImages2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ActivityNegotiators)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointments1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointments2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.ResponsibleNegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointments3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AppointmentUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Assets1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.DevelopmentManagerId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Assets2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Assets3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Attachments)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Attachments1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Attachments2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LockedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Attachments3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BusinessEvents)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ImpersonatingUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BusinessEvents1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ChainTransactions)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.AgentUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ChainTransactions1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ChainTransactions2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ChainTransactions3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Companies)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Companies1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Companies2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LatestLastInteractionById);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Companies3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.RelationshipManagerId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Companies4)
                .WithOptional(e => e.User4)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanyAddresses)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanyAddresses1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanyAddresses2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanyDomains)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.LastInteractionById);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanyUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contacts)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contacts1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contacts2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LatestLastInteractionById);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contacts3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAccessRequests)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ApproverId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAccessRequests1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAccessRequests2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAccessRequests3)
                .WithRequired(e => e.User3)
                .HasForeignKey(e => e.RequesterId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAddresses)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAddresses1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAddresses2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAddressDirectMarketingConsents)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAddressDirectMarketingConsents1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactAddressDirectMarketingConsents2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactCompanyAddresses)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactCompanyAddresses1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactCompanyAddresses2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactCompanyAddressDirectMarketingConsents)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactCompanyAddressDirectMarketingConsents1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactCompanyAddressDirectMarketingConsents2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastInteractionById);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmails2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmails3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmailDirectMarketingConsents)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmailDirectMarketingConsents1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactEmailDirectMarketingConsents2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactPhones)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactPhones1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactPhones2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactPublicationEvents)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.SignatoryId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactToBePhoneds)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactToBePhoneds1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactToBePhoneds2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Dashboards)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DeviceRegistrations)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DocumentSignings)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DocumentSignings1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DocumentSignings2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DotmailerExportLogs)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ExportedByUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExternalMessages)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExternalMessages1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExternalMessages2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.SenderId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExternalMessages3)
                .WithRequired(e => e.User3)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExternalMessageRecipients)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.NegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.FeeSplits)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.NegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.FlexibleReports)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Impersonations)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ImpersonatedUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Impersonations1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.ImpersonatingUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Instructions)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Instructions1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Instructions2)
                .WithRequired(e => e.User2)
                .HasForeignKey(e => e.NegotiatorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Instructions3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestViews)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MarketingLists)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MarketingLists1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MarketingLists2)
                .WithRequired(e => e.User2)
                .HasForeignKey(e => e.OwnerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MarketingLists3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MarketingListContacts)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.SignatoryId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MarketingListEditors)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.EditorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Matches)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Matches1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Matches2)
                .WithRequired(e => e.User2)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Notes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Notes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Notes2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.NotificationBlacklists)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.NotificationRecipients)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.RecipientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.AgentUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Offers1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Offers2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Offers3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.NegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Offers4)
                .WithOptional(e => e.User4)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Ownerships)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Ownerships1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Ownerships2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Ownerships3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.ValuationUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Pitches)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Pitches1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Pitches2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PitchUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Referrals)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Referrals1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Referrals2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.ManagerId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Referrals3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.RecipientId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Referrals4)
                .WithOptional(e => e.User4)
                .HasForeignKey(e => e.ReferrerId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Referrals5)
                .WithOptional(e => e.User5)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ReferralManagementRules)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Requirements)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Requirements1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Requirements2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.ResponsibleForDealNegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Requirements3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.SellingAgentUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Requirements4)
                .WithOptional(e => e.User4)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RequirementNegotiators)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchConfigurations)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchConfigurations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchConfigurationAccesses)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchConfigurationAccesses1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchConfigurationAccesses2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchFilterConfigurations)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SearchFilterConfigurations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SignalRConnections)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tenancies)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tenancies1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.FinancialNegotiatorId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tenancies2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tenancies3)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TenancyNegotiators)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserExportLogs)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ExportedByUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserExportLogs1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.ImpersonatingUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserPropertyTypes)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ViewingTours)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ViewingTours1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.LastModifiedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ViewingTours2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User1)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("AssociatedUsers").MapLeftKey("AssociatedUserId").MapRightKey("UserId"));

            modelBuilder.Entity<UserExportLog>()
                .HasMany(e => e.UserExportLogContacts)
                .WithRequired(e => e.UserExportLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserFeedLog>()
                .HasMany(e => e.UserFeedDetails)
                .WithRequired(e => e.UserFeedLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WindowsTimeZone>()
                .HasMany(e => e.Appointments)
                .WithOptional(e => e.WindowsTimeZone)
                .HasForeignKey(e => e.TimeZoneId);

            modelBuilder.Entity<WindowsTimeZone>()
                .HasMany(e => e.Assets)
                .WithOptional(e => e.WindowsTimeZone)
                .HasForeignKey(e => e.TimeZoneId);

            modelBuilder.Entity<WindowsTimeZone>()
                .HasMany(e => e.ViewingTours)
                .WithRequired(e => e.WindowsTimeZone)
                .HasForeignKey(e => e.TimeZoneId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WindowsTimeZone>()
                .HasMany(e => e.WindowsTimeZoneLocaliseds)
                .WithRequired(e => e.WindowsTimeZone)
                .HasForeignKey(e => e.TimeZoneId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.ActivityPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.QuotedPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.ShortAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.ShortAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.LongAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.LongAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.QuotingRentMinMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.QuotingRentMinFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.QuotingRentMaxMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<CompanyActivitiesView>()
                .Property(e => e.QuotingRentMaxFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<CompanyActivitiesView2>()
                .Property(e => e.VisibleClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<CompanyActivitiesView2>()
                .Property(e => e.MaskedClaimsId)
                .IsFixedLength();

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.ActivityPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.QuotedPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.ShortAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.ShortAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.LongAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.LongAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.QuotingRentMinMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.QuotingRentMinFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.QuotingRentMaxMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ContactActivitiesView>()
                .Property(e => e.QuotingRentMaxFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.StatusLastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedInitialMarketingPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.KfValuationPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.VendorValuationPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.ServiceChargeAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.GroundRentAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.ShortKfValuationWeeklyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LongKfValuationWeeklyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.ShortKfValuationMonthlyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LongKfValuationMonthlyPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.ShortAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.ShortAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LongAskingWeekRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LongAskingMonthRent)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.SalesBoardRemovalDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedPricePerRoom)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedSalePrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedPricePerRoomMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedPricePerRoomMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedPricePerRoomMinSort)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedPricePerRoomMaxSort)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedPricePerBed)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedPricePerBed)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedNetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedRentPA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedRentPAMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedRentPAMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotingRentPAMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotingRentPAMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedReversionaryYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedReversionaryYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedNetEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedNetEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedTaxEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedTaxEquivalentYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotedGrossInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AgreedGrossInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.IncomeDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.QuotingRentPAForMatching)
                .HasPrecision(38, 4);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.MarketedDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.InstructedDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.ExchangedDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.NetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.DevPipelineConstructionStartDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.DevPipelineCompletionDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.AvailableDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.UnderOfferDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LeaseExpiryDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LeaseCommencementDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.LeadNegotiatorCallDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.PortfolioAveragePrice)
                .HasPrecision(28, 13);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.PriceMinSquareFeet)
                .HasPrecision(38, 20);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.PriceMinSquareMeter)
                .HasPrecision(38, 20);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.EstimatedRentalValuePA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivity>()
                .Property(e => e.RentPA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.ActivityMainImageCreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.AttachmentMainImageCreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.MinSizeSquareFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.MinSizeSquareMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.MaxSizeSquareFeet)
                .HasPrecision(38, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.MaxSizeSquareMeter)
                .HasPrecision(38, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.MaxSizeHectare)
                .HasPrecision(38, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.MaxSizeAcre)
                .HasPrecision(38, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.QuotedPrice)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.NetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.PriceMinSquareFeet)
                .HasPrecision(38, 21);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.PriceMinSquareMeter)
                .HasPrecision(38, 21);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.Price)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.QuotingRentMinMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.QuotingRentMinFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.QuotingRentMaxMeter)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.QuotingRentMaxFeet)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.RentShortLetMonth)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.RentShortLetWeek)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.RentLongLetMonth)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchActivityAdminWidget>()
                .Property(e => e.RentLongLetWeek)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchCompany>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchCompany>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchContact>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchContact>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchInstruction>()
                .Property(e => e.RegistrationDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchInstruction>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchMarketingList>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesActivity>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesActivity>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesAsset>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesAsset>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesCompany>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesCompany>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesContact>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesContact>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesOffer>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesOffer>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesReferral>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesReferral>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesRequirement>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesRequirement>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesTenancy>()
                .Property(e => e.MainEntityType)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchNotesTenancy>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchPitch>()
                .Property(e => e.PitchDeadline)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchPitch>()
                .Property(e => e.PitchCreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchReferral>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchReferral>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchReferral>()
                .Property(e => e.StatusModifiedDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.CreationTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.StatusLastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.RentWeeklyMin)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.RentWeeklyMax)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.RentMonthlyMin)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.RentMonthlyMax)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.MoveInDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.PriceMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.PriceMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.CurrentLeaseEventDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.MinNetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.MaxNetInitialYield)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.BudgetRentPaMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.BudgetRentPaMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.BudgetPricePaMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.BudgetPricePaMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchRequirement>()
                .Property(e => e.LeadNegotiatorCallDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchShapePostCode>()
                .Property(e => e.GeoShape)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.LastWriteTime)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.LeaseExpiryDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.LeaseCommencementDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.SurrenderDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.FeeLandlordTa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.FeeTenantTa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.CreditReferenceCheck)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.AdministrationFeeTds)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.OccupierRightToRentCheck)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.InventoryCharge)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.AdHocCharge)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.BankChargesAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.AgreedRentPa)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.DepositAmount)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.InitialPremium)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.QuotingRentPaMin)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.QuotingRentPaMax)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.EarliestRightToRentReviewDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.LeadNegotiatorCallDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.NextBreakDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.ExitDate)
                .IsUnicode(false);

            modelBuilder.Entity<ElasticSearchTenancy>()
                .Property(e => e.NextReviewDate)
                .IsUnicode(false);
        }
    }
}
