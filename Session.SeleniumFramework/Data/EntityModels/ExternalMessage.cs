namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalMessage")]
    public partial class ExternalMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExternalMessage()
        {
            ExternalMessageRecipients = new HashSet<ExternalMessageRecipient>();
            Activities = new HashSet<Activity>();
            Attachments = new HashSet<Attachment>();
            Requirements = new HashSet<Requirement>();
            Tenancies = new HashSet<Tenancy>();
        }

        public Guid Id { get; set; }

        public Guid StatusId { get; set; }

        public string ContentPlainText { get; set; }

        public Guid? SenderId { get; set; }

        [StringLength(100)]
        public string SenderName { get; set; }

        [StringLength(400)]
        public string Subject { get; set; }

        [StringLength(254)]
        public string SenderEmailAddress { get; set; }

        public DateTimeOffset? SendDateTime { get; set; }

        public int? SendRetries { get; set; }

        public bool Deleted { get; set; }

        public Guid? AppointmentId { get; set; }

        public Guid? ViewingTourId { get; set; }

        public Guid TypeId { get; set; }

        public Guid EntityTypeId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid UserId { get; set; }

        public Guid? ContentId { get; set; }

        [Required]
        [StringLength(3)]
        public string Discriminator { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual ViewingTour ViewingTour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessageRecipient> ExternalMessageRecipients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancies { get; set; }
    }
}
