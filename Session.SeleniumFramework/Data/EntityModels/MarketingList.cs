namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingList")]
    public partial class MarketingList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarketingList()
        {
            DotmailerExportLogs = new HashSet<DotmailerExportLog>();
            MarketingListContacts = new HashSet<MarketingListContact>();
            MarketingListEditors = new HashSet<MarketingListEditor>();
            Notifications = new HashSet<Notification>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public Guid TypeId { get; set; }

        public Guid SendTypeId { get; set; }

        public Guid SalutationId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid OwnerId { get; set; }

        public int Version { get; set; }

        public bool Deleted { get; set; }

        public bool IsLocked { get; set; }

        public Guid? PublicationEventId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerExportLog> DotmailerExportLogs { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual PublicationEvent PublicationEvent { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingListContact> MarketingListContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingListEditor> MarketingListEditors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
