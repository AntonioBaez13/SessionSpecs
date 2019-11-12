namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganisationUnit")]
    public partial class OrganisationUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganisationUnit()
        {
            Activities = new HashSet<Activity>();
            Activities1 = new HashSet<Activity>();
            ActivityDepartments = new HashSet<ActivityDepartment>();
            Appointments = new HashSet<Appointment>();
            BusinessLanguages = new HashSet<BusinessLanguage>();
            ContactAddressDirectMarketingConsents = new HashSet<ContactAddressDirectMarketingConsent>();
            ContactCompanyAddressDirectMarketingConsents = new HashSet<ContactCompanyAddressDirectMarketingConsent>();
            ContactEmailDirectMarketingConsents = new HashSet<ContactEmailDirectMarketingConsent>();
            ContactToBePhoneds = new HashSet<ContactToBePhoned>();
            DepartmentGroups = new HashSet<DepartmentGroup>();
            DevelopmentDepartments = new HashSet<DevelopmentDepartment>();
            DotmailerAccounts = new HashSet<DotmailerAccount>();
            DotmailerEmailsQueues = new HashSet<DotmailerEmailsQueue>();
            DotmailerEmailTemplates = new HashSet<DotmailerEmailTemplate>();
            DotmailerSuppressedEmails = new HashSet<DotmailerSuppressedEmail>();
            FeeSplits = new HashSet<FeeSplit>();
            Instructions = new HashSet<Instruction>();
            MarketingLists = new HashSet<MarketingList>();
            Offers = new HashSet<Offer>();
            OrganisationalSecurityRules = new HashSet<OrganisationalSecurityRule>();
            OrganisationalSecurityRules1 = new HashSet<OrganisationalSecurityRule>();
            OrganisationUnit1 = new HashSet<OrganisationUnit>();
            OrganisationUnit11 = new HashSet<OrganisationUnit>();
            OrganisationUnitCompanies = new HashSet<OrganisationUnitCompany>();
            OrganisationUnitServiceLines = new HashSet<OrganisationUnitServiceLine>();
            Referrals = new HashSet<Referral>();
            Referrals1 = new HashSet<Referral>();
            ReferralManagementRules = new HashSet<ReferralManagementRule>();
            ReportVisibilityDepartments = new HashSet<ReportVisibilityDepartment>();
            Requirements = new HashSet<Requirement>();
            RequirementDepartments = new HashSet<RequirementDepartment>();
            SearchConfigurationAccesses = new HashSet<SearchConfigurationAccess>();
            TenancyDepartments = new HashSet<TenancyDepartment>();
            Users = new HashSet<User>();
            Users1 = new HashSet<User>();
            UserRoleBusinesses = new HashSet<UserRoleBusiness>();
            UserRoleDepartments = new HashSet<UserRoleDepartment>();
            EnumTypeItems = new HashSet<EnumTypeItem>();
            DocumentTemplates = new HashSet<DocumentTemplate>();
            DocumentTemplates1 = new HashSet<DocumentTemplate>();
            OfficePatches = new HashSet<OfficePatch>();
            SecurityAttributes = new HashSet<SecurityAttribute>();
            Users2 = new HashSet<User>();
        }

        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public Guid? BusinessParentId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Guid? CountryId { get; set; }

        public Guid? DivisionId { get; set; }

        [StringLength(4)]
        public string CompanyCode { get; set; }

        [StringLength(3)]
        public string Code { get; set; }

        [StringLength(40)]
        public string LicenceNumber { get; set; }

        public bool IsFpnEmailEnabled { get; set; }

        public bool IsConsentEnabled { get; set; }

        public bool IsConsentScriptAndEmailsEnabled { get; set; }

        public bool IsImpliedPrivateConsentEnabled { get; set; }

        public bool IsImpliedBusinessConsentEnabled { get; set; }

        public int? Claim { get; set; }

        public bool PublishedToLonRes { get; set; }

        public int? ActivityIntraVisibilityLevel { get; set; }

        public int? ActivityInterVisibilityLevel { get; set; }

        public int? ContactIntraVisibilityLevel { get; set; }

        public int? ContactInterVisibilityLevel { get; set; }

        public int? PitchIntraVisibilityLevel { get; set; }

        public int? PitchInterVisibilityLevel { get; set; }

        public int? ReferralIntraVisibilityLevel { get; set; }

        public int? ReferralInterVisibilityLevel { get; set; }

        public int? RequirementIntraVisibilityLevel { get; set; }

        public int? RequirementInterVisibilityLevel { get; set; }

        public int? TenancyIntraVisibilityLevel { get; set; }

        public int? TenancyInterVisibilityLevel { get; set; }

        public int? GlobalOfficeId { get; set; }

        public bool UsePostCode { get; set; }

        [StringLength(255)]
        public string OfficeName { get; set; }

        [StringLength(255)]
        public string OfficeWebDisplayName { get; set; }

        public Guid? OfficeAddressId { get; set; }

        [StringLength(255)]
        public string OfficeTelNumber { get; set; }

        [StringLength(255)]
        public string OfficeFaxNumber { get; set; }

        [StringLength(255)]
        public string OfficeEmail { get; set; }

        public Guid? EmailServerTypeId { get; set; }

        [StringLength(255)]
        public string PowerBiReportUrl { get; set; }

        [Required]
        [StringLength(3)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityDepartment> ActivityDepartments { get; set; }

        public virtual Address Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessLanguage> BusinessLanguages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddressDirectMarketingConsent> ContactAddressDirectMarketingConsents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactCompanyAddressDirectMarketingConsent> ContactCompanyAddressDirectMarketingConsents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactEmailDirectMarketingConsent> ContactEmailDirectMarketingConsents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactToBePhoned> ContactToBePhoneds { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentGroup> DepartmentGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevelopmentDepartment> DevelopmentDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerAccount> DotmailerAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerEmailsQueue> DotmailerEmailsQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerEmailTemplate> DotmailerEmailTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerSuppressedEmail> DotmailerSuppressedEmails { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingList> MarketingLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationalSecurityRule> OrganisationalSecurityRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationalSecurityRule> OrganisationalSecurityRules1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnit1 { get; set; }

        public virtual OrganisationUnit OrganisationUnit2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnit11 { get; set; }

        public virtual OrganisationUnit OrganisationUnit3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnitCompany> OrganisationUnitCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnitServiceLine> OrganisationUnitServiceLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReferralManagementRule> ReferralManagementRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportVisibilityDepartment> ReportVisibilityDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementDepartment> RequirementDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchConfigurationAccess> SearchConfigurationAccesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyDepartment> TenancyDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleBusiness> UserRoleBusinesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleDepartment> UserRoleDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnumTypeItem> EnumTypeItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTemplate> DocumentTemplates1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfficePatch> OfficePatches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityAttribute> SecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users2 { get; set; }
    }
}
