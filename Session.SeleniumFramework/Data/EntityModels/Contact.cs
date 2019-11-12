namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            Activities = new HashSet<Activity>();
            ActivityParties = new HashSet<ActivityParty>();
            AppointmentContacts = new HashSet<AppointmentContact>();
            AssetParties = new HashSet<AssetParty>();
            ChainTransactionParties = new HashSet<ChainTransactionParty>();
            CompanyContacts = new HashSet<CompanyContact>();
            CompanyContactNotes = new HashSet<CompanyContactNote>();
            ContactAccessRequests = new HashSet<ContactAccessRequest>();
            ContactAddresses = new HashSet<ContactAddress>();
            ContactBusinessHistories = new HashSet<ContactBusinessHistory>();
            ContactCompanyAddresses = new HashSet<ContactCompanyAddress>();
            ContactContactTypes = new HashSet<ContactContactType>();
            ContactEmails = new HashSet<ContactEmail>();
            ContactMarketingCampaigns = new HashSet<ContactMarketingCampaign>();
            ContactPhones = new HashSet<ContactPhone>();
            ContactPropertyInterests = new HashSet<ContactPropertyInterest>();
            ContactPropertyTypeInterests = new HashSet<ContactPropertyTypeInterest>();
            ContactPublicationEvents = new HashSet<ContactPublicationEvent>();
            ContactRelationships = new HashSet<ContactRelationship>();
            ContactSecurityAttributes = new HashSet<ContactSecurityAttribute>();
            ContactToBePhoneds = new HashSet<ContactToBePhoned>();
            ContactUsers = new HashSet<ContactUser>();
            DotmailerExportLogContacts = new HashSet<DotmailerExportLogContact>();
            ExternalMessageRecipients = new HashSet<ExternalMessageRecipient>();
            FeeSplits = new HashSet<FeeSplit>();
            InstructionParties = new HashSet<InstructionParty>();
            MarketingListContacts = new HashSet<MarketingListContact>();
            Notifications = new HashSet<Notification>();
            OfferParties = new HashSet<OfferParty>();
            PropertyManagementContacts = new HashSet<PropertyManagementContact>();
            Referrals = new HashSet<Referral>();
            RequirementParties = new HashSet<RequirementParty>();
            TenancyParties = new HashSet<TenancyParty>();
            UserExportLogContacts = new HashSet<UserExportLogContact>();
            Attachments = new HashSet<Attachment>();
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string FormalSalutation { get; set; }

        [StringLength(128)]
        public string SemiformalSalutation { get; set; }

        [StringLength(128)]
        public string InformalSalutation { get; set; }

        [StringLength(128)]
        public string PersonalSalutation { get; set; }

        [StringLength(128)]
        public string EnvelopeSalutation { get; set; }

        public Guid? DefaultSalutationId { get; set; }

        public Guid? NationalityId { get; set; }

        public bool? IsPodDoNotCall { get; set; }

        public bool? IsSuperRichAdvisor { get; set; }

        [StringLength(2500)]
        public string SuperRichProfile { get; set; }

        [StringLength(128)]
        public string Source { get; set; }

        public Guid? PersonalWealthId { get; set; }

        public Guid? ProfessionId { get; set; }

        [StringLength(128)]
        public string ProfessionText { get; set; }

        public Guid? AgeBandId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApproxBirthDate { get; set; }

        [StringLength(2500)]
        public string TwitterUrl { get; set; }

        [StringLength(2500)]
        public string LinkedInUrl { get; set; }

        [StringLength(2500)]
        public string WebsiteUrl { get; set; }

        public bool CddWarningFlag { get; set; }

        public Guid? SapUniqueNumberId { get; set; }

        [MaxLength(16)]
        public byte[] MaskedClaimsId { get; set; }

        [MaxLength(16)]
        public byte[] VisibleClaimsId { get; set; }

        public int Version { get; set; }

        public bool Deleted { get; set; }

        [StringLength(128)]
        public string AlternativeTitle { get; set; }

        [StringLength(128)]
        public string AlternativeFirstName { get; set; }

        [StringLength(128)]
        public string AlternativeLastName { get; set; }

        public bool DataHugOnly { get; set; }

        public short HighestDataHugRank { get; set; }

        public DateTimeOffset? LatestLastInteractionDate { get; set; }

        public Guid? LatestLastInteractionById { get; set; }

        public bool IsDeceased { get; set; }

        public bool IsRetired { get; set; }

        public Guid FairProcessingNoticeId { get; set; }

        public bool QubeSynchronized { get; set; }

        public bool? QubeErrorOccurred { get; set; }

        public Guid? DomicileCountryId { get; set; }

        public Guid? DomicileRegionId { get; set; }

        public Guid? SourceOfIncomeId { get; set; }

        [StringLength(250)]
        public string AgreementName { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityParty> ActivityParties { get; set; }

        public virtual AgeBand AgeBand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentContact> AppointmentContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetParty> AssetParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransactionParty> ChainTransactionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContact> CompanyContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContactNote> CompanyContactNotes { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual Nationality Nationality { get; set; }

        public virtual Profession Profession { get; set; }

        public virtual SapIndividualUniqueNumber SapIndividualUniqueNumber { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAccessRequest> ContactAccessRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddress> ContactAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBusinessHistory> ContactBusinessHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactCompanyAddress> ContactCompanyAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactContactType> ContactContactTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactEmail> ContactEmails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactMarketingCampaign> ContactMarketingCampaigns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPhone> ContactPhones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPropertyInterest> ContactPropertyInterests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPropertyTypeInterest> ContactPropertyTypeInterests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPublicationEvent> ContactPublicationEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactRelationship> ContactRelationships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactSecurityAttribute> ContactSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactToBePhoned> ContactToBePhoneds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactUser> ContactUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerExportLogContact> DotmailerExportLogContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessageRecipient> ExternalMessageRecipients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionParty> InstructionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingListContact> MarketingListContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferParty> OfferParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyManagementContact> PropertyManagementContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementParty> RequirementParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyParty> TenancyParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExportLogContact> UserExportLogContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
