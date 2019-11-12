namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Referral")]
    public partial class Referral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Referral()
        {
            Activities = new HashSet<Activity>();
            Instructions = new HashSet<Instruction>();
            Requirements = new HashSet<Requirement>();
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid? RecipientId { get; set; }

        public Guid? ReferrerId { get; set; }

        public string Requirement { get; set; }

        public Guid CountryId { get; set; }

        public bool SpokenToTheRecipient { get; set; }

        public bool DoNotWantAward { get; set; }

        public Guid ReferralStatusId { get; set; }

        public Guid? ServiceLineId { get; set; }

        public Guid? RateId { get; set; }

        public Guid? RegistrationSystemId { get; set; }

        [StringLength(128)]
        public string RegistrationReferenceNumber { get; set; }

        public decimal? AwardAmount { get; set; }

        public Guid? AwardCurrencyId { get; set; }

        public decimal? KfFeeAmount { get; set; }

        public Guid? KfFeeCurrencyId { get; set; }

        public Guid? ManagerId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? OriginalDepartmentId { get; set; }

        public string UniqueReferenceCode { get; set; }

        public int Version { get; set; }

        public DateTimeOffset StatusModifiedDate { get; set; }

        public bool OffSystemRecipient { get; set; }

        [StringLength(100)]
        public string OffSystemRecipientName { get; set; }

        public bool OffSystemReferrer { get; set; }

        public string OffSystemReferrerName { get; set; }

        public Guid? OffSystemReferrerCountryId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Country Country { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        public virtual EnumTypeItem EnumTypeItem4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual OrganisationUnit OrganisationUnit1 { get; set; }

        public virtual ServiceLine ServiceLine { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual User User4 { get; set; }

        public virtual User User5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
