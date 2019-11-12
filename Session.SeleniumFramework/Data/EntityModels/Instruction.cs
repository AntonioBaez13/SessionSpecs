namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Instruction")]
    public partial class Instruction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instruction()
        {
            InstructionActivities = new HashSet<InstructionActivity>();
            InstructionAssets = new HashSet<InstructionAsset>();
            InstructionParties = new HashSet<InstructionParty>();
            InstructionRequirements = new HashSet<InstructionRequirement>();
            InstructionSecurityAttributes = new HashSet<InstructionSecurityAttribute>();
            SapPostingQueues = new HashSet<SapPostingQueue>();
            Attachments = new HashSet<Attachment>();
            Pitches = new HashSet<Pitch>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }

        public Guid ServiceLineId { get; set; }

        public Guid InstructionTypeId { get; set; }

        public Guid InstructionStatusId { get; set; }

        public Guid? CountryId { get; set; }

        public bool Confidential { get; set; }

        public Guid NegotiatorId { get; set; }

        public Guid DepartmentId { get; set; }

        public string RegistrationReference { get; set; }

        public Guid? RegistrationStatusId { get; set; }

        public Guid? RegistrationSystemId { get; set; }

        public DateTimeOffset? RegistrationDate { get; set; }

        public Guid InstructionCategoryId { get; set; }

        [StringLength(100)]
        public string CreditControlSomeoneElseName { get; set; }

        [StringLength(40)]
        public string CreditControlSomeoneElsePhone { get; set; }

        public Guid? ReferralId { get; set; }

        public Guid TeamResponsibleForCddId { get; set; }

        public Guid? CddCompleteId { get; set; }

        public bool RequireCdd { get; set; }

        public bool UserDefinedBillingAddress { get; set; }

        public Guid? AddresseeSapUniqueNumberId { get; set; }

        [StringLength(35)]
        public string AddresseeFirstName { get; set; }

        [StringLength(40)]
        public string AddresseeLastName { get; set; }

        [StringLength(100)]
        public string AddresseeCompany { get; set; }

        [StringLength(30)]
        public string AddresseeTitle { get; set; }

        [StringLength(128)]
        public string AddresseeHomePhone { get; set; }

        [StringLength(128)]
        public string AddresseeBusinessPhone { get; set; }

        [StringLength(128)]
        public string AddresseeMobilePhone { get; set; }

        [StringLength(128)]
        public string AddresseeEmail { get; set; }

        public Guid? AddresseeAddressId { get; set; }

        public Guid? SourceId { get; set; }

        public int Version { get; set; }

        public byte[] MaskedClaimsId { get; set; }

        public byte[] VisibleClaimsId { get; set; }

        public Guid? ValuationUserRoleId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        public virtual EnumTypeItem EnumTypeItem5 { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual Referral Referral { get; set; }

        public virtual RegistrationStatu RegistrationStatu { get; set; }

        public virtual RegistrationSystem RegistrationSystem { get; set; }

        public virtual Role Role { get; set; }

        public virtual SapIndividualUniqueNumber SapIndividualUniqueNumber { get; set; }

        public virtual ServiceLine ServiceLine { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionActivity> InstructionActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionAsset> InstructionAssets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionParty> InstructionParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionRequirement> InstructionRequirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionSecurityAttribute> InstructionSecurityAttributes { get; set; }

        public virtual SapInstructionUniqueNumber SapInstructionUniqueNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SapPostingQueue> SapPostingQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pitch> Pitches { get; set; }
    }
}
