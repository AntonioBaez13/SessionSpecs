namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notification()
        {
            NotificationRecipients = new HashSet<NotificationRecipient>();
        }

        public Guid Id { get; set; }

        public DateTimeOffset DateOccurred { get; set; }

        [Required]
        public string Title { get; set; }

        public Guid TypeId { get; set; }

        public Guid EntityTypeId { get; set; }

        public Guid? TenancyId { get; set; }

        public Guid? ActivityId { get; set; }

        public Guid? RequirementId { get; set; }

        public Guid? OfferId { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? ReportId { get; set; }

        public Guid? MarketingListId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual FlexibleReport FlexibleReport { get; set; }

        public virtual MarketingList MarketingList { get; set; }

        public virtual Offer Offer { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual Tenancy Tenancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationRecipient> NotificationRecipients { get; set; }
    }
}
