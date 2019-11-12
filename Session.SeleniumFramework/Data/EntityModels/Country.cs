namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            ActivityDocumentTypeUsages = new HashSet<ActivityDocumentTypeUsage>();
            ActivityTypeDefinitions = new HashSet<ActivityTypeDefinition>();
            Addresses = new HashSet<Address>();
            AddressForms = new HashSet<AddressForm>();
            AreaHierarchies = new HashSet<AreaHierarchy>();
            AssetDocumentTypeUsages = new HashSet<AssetDocumentTypeUsage>();
            CharacteristicGroupUsages = new HashSet<CharacteristicGroupUsage>();
            Companies = new HashSet<Company>();
            Contacts = new HashSet<Contact>();
            CountryLocaliseds = new HashSet<CountryLocalised>();
            ExternalAddressServiceMappings = new HashSet<ExternalAddressServiceMapping>();
            Instructions = new HashSet<Instruction>();
            OrganisationUnits = new HashSet<OrganisationUnit>();
            PortalDefinitions = new HashSet<PortalDefinition>();
            PostCodeShapes = new HashSet<PostCodeShape>();
            PropertyAttributeForms = new HashSet<PropertyAttributeForm>();
            PropertyTypeDefinitions = new HashSet<PropertyTypeDefinition>();
            Referrals = new HashSet<Referral>();
            Referrals1 = new HashSet<Referral>();
            ReferralManagementRules = new HashSet<ReferralManagementRule>();
            ReferralManagementRules1 = new HashSet<ReferralManagementRule>();
            ReportVisibilityCountries = new HashSet<ReportVisibilityCountry>();
            RequirementCountries = new HashSet<RequirementCountry>();
            RequirementDocumentTypeUsages = new HashSet<RequirementDocumentTypeUsage>();
            TenancyDocumentTypeUsages = new HashSet<TenancyDocumentTypeUsage>();
            Users = new HashSet<User>();
            Users1 = new HashSet<User>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(2)]
        public string IsoCode { get; set; }

        [StringLength(10)]
        public string DiallingCode { get; set; }

        public Guid CurrencyId { get; set; }

        public Guid DefaultLivingAreaUnitId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityDocumentTypeUsage> ActivityDocumentTypeUsages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityTypeDefinition> ActivityTypeDefinitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddressForm> AddressForms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaHierarchy> AreaHierarchies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetDocumentTypeUsage> AssetDocumentTypeUsages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicGroupUsage> CharacteristicGroupUsages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryLocalised> CountryLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalAddressServiceMapping> ExternalAddressServiceMappings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortalDefinition> PortalDefinitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostCodeShape> PostCodeShapes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyAttributeForm> PropertyAttributeForms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyTypeDefinition> PropertyTypeDefinitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReferralManagementRule> ReferralManagementRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReferralManagementRule> ReferralManagementRules1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportVisibilityCountry> ReportVisibilityCountries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementCountry> RequirementCountries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementDocumentTypeUsage> RequirementDocumentTypeUsages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyDocumentTypeUsage> TenancyDocumentTypeUsages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users1 { get; set; }
    }
}
