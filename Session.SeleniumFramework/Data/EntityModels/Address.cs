namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            ActivityParties = new HashSet<ActivityParty>();
            Assets = new HashSet<Asset>();
            AssetParties = new HashSet<AssetParty>();
            ChainTransactionParties = new HashSet<ChainTransactionParty>();
            CompanyAddresses = new HashSet<CompanyAddress>();
            ContactAddresses = new HashSet<ContactAddress>();
            ContactBusinessHistories = new HashSet<ContactBusinessHistory>();
            FeeSplits = new HashSet<FeeSplit>();
            Instructions = new HashSet<Instruction>();
            InstructionParties = new HashSet<InstructionParty>();
            OfferParties = new HashSet<OfferParty>();
            OrganisationUnits = new HashSet<OrganisationUnit>();
            RequirementParties = new HashSet<RequirementParty>();
            TenancyParties = new HashSet<TenancyParty>();
        }

        public Guid Id { get; set; }

        public Guid CountryId { get; set; }

        public Guid AddressFormId { get; set; }

        [StringLength(128)]
        public string PropertyName { get; set; }

        [StringLength(140)]
        public string PropertyNumber { get; set; }

        [StringLength(128)]
        public string Line1 { get; set; }

        [StringLength(128)]
        public string Line2 { get; set; }

        [StringLength(128)]
        public string Line3 { get; set; }

        [StringLength(32)]
        public string Postcode { get; set; }

        [StringLength(128)]
        public string City { get; set; }

        [StringLength(128)]
        public string County { get; set; }

        public string ShortAddressFormated { get; set; }

        public DbGeography Marker { get; set; }

        [StringLength(128)]
        public string AlternativePropertyName { get; set; }

        [StringLength(140)]
        public string AlternativePropertyNumber { get; set; }

        [StringLength(128)]
        public string AlternativeLine1 { get; set; }

        [StringLength(128)]
        public string AlternativeLine2 { get; set; }

        [StringLength(128)]
        public string AlternativeLine3 { get; set; }

        [StringLength(32)]
        public string AlternativePostcode { get; set; }

        [StringLength(128)]
        public string AlternativeCity { get; set; }

        [StringLength(128)]
        public string AlternativeCounty { get; set; }

        [StringLength(100)]
        public string UdprnKey { get; set; }

        [StringLength(100)]
        public string UmrrnKey { get; set; }

        [StringLength(100)]
        public string UprnKey { get; set; }

        public bool QubeSynchronized { get; set; }

        public bool? QubeErrorOccurred { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityParty> ActivityParties { get; set; }

        public virtual AddressForm AddressForm { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetParty> AssetParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransactionParty> ChainTransactionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddress> ContactAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactBusinessHistory> ContactBusinessHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeSplit> FeeSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionParty> InstructionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferParty> OfferParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementParty> RequirementParties { get; set; }

        public virtual SapAddressUniqueNumber SapAddressUniqueNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyParty> TenancyParties { get; set; }
    }
}
