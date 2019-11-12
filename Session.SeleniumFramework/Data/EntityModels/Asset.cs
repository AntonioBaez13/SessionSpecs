namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asset")]
    public partial class Asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asset()
        {
            Activities = new HashSet<Activity>();
            Asset1 = new HashSet<Asset>();
            Asset11 = new HashSet<Asset>();
            Asset12 = new HashSet<Asset>();
            AssetAttributeValues = new HashSet<AssetAttributeValue>();
            AssetCharacteristics = new HashSet<AssetCharacteristic>();
            AssetParties = new HashSet<AssetParty>();
            AssetSecurityAttributes = new HashSet<AssetSecurityAttribute>();
            BuildingFloors = new HashSet<BuildingFloor>();
            ChainTransactions = new HashSet<ChainTransaction>();
            DevelopmentDepartments = new HashSet<DevelopmentDepartment>();
            InstructionAssets = new HashSet<InstructionAsset>();
            Offers = new HashSet<Offer>();
            Ownerships = new HashSet<Ownership>();
            PropertyFloors = new HashSet<PropertyFloor>();
            PropertyManagementContacts = new HashSet<PropertyManagementContact>();
            Requirements = new HashSet<Requirement>();
            Requirements1 = new HashSet<Requirement>();
            Tenancies = new HashSet<Tenancy>();
            Appointments = new HashSet<Appointment>();
            Attachments = new HashSet<Attachment>();
            Notes = new HashSet<Note>();
            Asset13 = new HashSet<Asset>();
            Assets = new HashSet<Asset>();
        }

        public Guid Id { get; set; }

        public Guid PropertyTypeId { get; set; }

        public bool Deleted { get; set; }

        [Required]
        [StringLength(20)]
        public string UniqueReferenceCode { get; set; }

        public Guid? ActivityMainImageId { get; set; }

        public DateTimeOffset? ActivityMainImageCreationTime { get; set; }

        public Guid? AttachmentMainImageId { get; set; }

        public DateTimeOffset? AttachmentMainImageCreationTime { get; set; }

        public int Version { get; set; }

        public Guid? TimeZoneId { get; set; }

        public Guid? PropertyManagementCompanyId { get; set; }

        [StringLength(4000)]
        public string CaretakerContactDetails { get; set; }

        [StringLength(4000)]
        public string SecondaryContactDetails { get; set; }

        public byte[] MaskedClaimsId { get; set; }

        public byte[] VisibleClaimsId { get; set; }

        public Guid? ValuationUserRoleId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public Guid? DevelopmentId { get; set; }

        public Guid? AddressId { get; set; }

        public Guid? DivisionId { get; set; }

        public Guid? TotalAreaBreakdownId { get; set; }

        public Guid? PhaseId { get; set; }

        public decimal? WAULT { get; set; }

        public Guid? EstateId { get; set; }

        public bool? IsAreaBreakdownInAcres { get; set; }

        public Guid? AgencyTypeId { get; set; }

        public Guid? DevelopmentManagerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EstimatedCompletionDate { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LaunchDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        public string Comment { get; set; }

        [Required]
        [StringLength(3)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual Address Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Asset1 { get; set; }

        public virtual Asset Asset2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Asset11 { get; set; }

        public virtual Asset Asset3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Asset12 { get; set; }

        public virtual Asset Asset4 { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual Company Company { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual MarketingImage MarketingImage { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual WindowsTimeZone WindowsTimeZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetAttributeValue> AssetAttributeValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetCharacteristic> AssetCharacteristics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetParty> AssetParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetSecurityAttribute> AssetSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingFloor> BuildingFloors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChainTransaction> ChainTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevelopmentDepartment> DevelopmentDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionAsset> InstructionAssets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ownership> Ownerships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyFloor> PropertyFloors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyManagementContact> PropertyManagementContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }

        public virtual BuildingFloor BuildingFloor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Asset13 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
