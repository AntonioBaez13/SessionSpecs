namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactEmail")]
    public partial class ContactEmail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactEmail()
        {
            ContactEmailDirectMarketingConsents = new HashSet<ContactEmailDirectMarketingConsent>();
            ContactEmailUsers = new HashSet<ContactEmailUser>();
            ContactPublicationEvents = new HashSet<ContactPublicationEvent>();
            DotmailerEmailsQueues = new HashSet<DotmailerEmailsQueue>();
            MarketingListContacts = new HashSet<MarketingListContact>();
        }

        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(128)]
        public string Description { get; set; }

        public bool IsPrimary { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MyKfInviteDate { get; set; }

        public Guid? MyKfAccountStatusId { get; set; }

        public short DataHugRank { get; set; }

        [StringLength(50)]
        public string DataHugContactId { get; set; }

        [StringLength(50)]
        public string DataHugDomainId { get; set; }

        public DateTimeOffset? LastInteractionDate { get; set; }

        public Guid? LastInteractionById { get; set; }

        public bool HasReceivedFpnEmail { get; set; }

        [StringLength(50)]
        public string EmailHash { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactEmailDirectMarketingConsent> ContactEmailDirectMarketingConsents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactEmailUser> ContactEmailUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPublicationEvent> ContactPublicationEvents { get; set; }

        public virtual DatahugDowngradeContactEmail DatahugDowngradeContactEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerEmailsQueue> DotmailerEmailsQueues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingListContact> MarketingListContacts { get; set; }
    }
}
