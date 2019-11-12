namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            Activities = new HashSet<Activity>();
            ActivityParties = new HashSet<ActivityParty>();
            AppointmentContacts = new HashSet<AppointmentContact>();
            Assets = new HashSet<Asset>();
            AssetParties = new HashSet<AssetParty>();
            ChainTransactionParties = new HashSet<ChainTransactionParty>();
            Company1 = new HashSet<Company>();
            CompanyAddresses = new HashSet<CompanyAddress>();
            CompanyContacts = new HashSet<CompanyContact>();
            CompanyContactNotes = new HashSet<CompanyContactNote>();
            CompanyDomains = new HashSet<CompanyDomain>();
            CompanyUsers = new HashSet<CompanyUser>();
            ContactBusinessHistories = new HashSet<ContactBusinessHistory>();
            DocumentTemplates = new HashSet<DocumentTemplate>();
            FeeSplits = new HashSet<FeeSplit>();
            HoldingCompanies = new HashSet<HoldingCompany>();
            HoldingCompanies1 = new HashSet<HoldingCompany>();
            InstructionParties = new HashSet<InstructionParty>();
            Offers = new HashSet<Offer>();
            OfferParties = new HashSet<OfferParty>();
            OrganisationUnitCompanies = new HashSet<OrganisationUnitCompany>();
            Requirements = new HashSet<Requirement>();
            RequirementParties = new HashSet<RequirementParty>();
            TenancyParties = new HashSet<TenancyParty>();
            Attachments = new HashSet<Attachment>();
            Notes = new HashSet<Note>();
            Pitches = new HashSet<Pitch>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(128)]
        public string AlternativeName { get; set; }

        [StringLength(2500)]
        public string WebsiteUrl { get; set; }

        [StringLength(2500)]
        public string ClientCarePageUrl { get; set; }

        public string Description { get; set; }

        public bool Valid { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        public Guid? CompanyCategoryId { get; set; }

        public Guid? CompanyTypeId { get; set; }

        public Guid? ClientCareStatusId { get; set; }

        public Guid? RelationshipManagerId { get; set; }

        public bool StandaloneCompany { get; set; }

        public bool CddWarningFlag { get; set; }

        public bool Deleted { get; set; }

        public Guid? OwningCompanyId { get; set; }

        public int Version { get; set; }

        public bool DataHugOnly { get; set; }

        public short HighestDataHugRank { get; set; }

        public DateTimeOffset? LatestLastInteractionDate { get; set; }

        public Guid? LatestLastInteractionById { get; set; }

        [StringLength(128)]
        public string RegistrationNumber { get; set; }

        public bool QubeSynchronized { get; set; }

        public bool? QubeErrorOccurred { get; set; }

        public Guid? InvestorTypeId { get; set; }

        public Guid? TenantTypeId { get; set; }

        public Guid? HeadOfficeLocationId { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentContact> AppointmentContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetParty> AssetParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransactionParty> ChainTransactionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Company1 { get; set; }

        public virtual Company Company2 { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual User User4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContact> CompanyContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContactNote> CompanyContactNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyDomain> CompanyDomains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBusinessHistory> ContactBusinessHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoldingCompany> HoldingCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoldingCompany> HoldingCompanies1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionParty> InstructionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferParty> OfferParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnitCompany> OrganisationUnitCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementParty> RequirementParties { get; set; }

        public virtual SapCompanyUniqueNumber SapCompanyUniqueNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyParty> TenancyParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pitch> Pitches { get; set; }
    }
}
