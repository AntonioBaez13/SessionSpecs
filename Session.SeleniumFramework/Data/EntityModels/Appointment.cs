namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            AppointmentContacts = new HashSet<AppointmentContact>();
            AppointmentOtherAttendees = new HashSet<AppointmentOtherAttendee>();
            AppointmentUsers = new HashSet<AppointmentUser>();
            ExternalMessages = new HashSet<ExternalMessage>();
            Activities = new HashSet<Activity>();
            Attachments = new HashSet<Attachment>();
            Assets = new HashSet<Asset>();
            Requirements = new HashSet<Requirement>();
            Tenancies = new HashSet<Tenancy>();
        }

        public Guid Id { get; set; }

        [StringLength(400)]
        public string Subject { get; set; }

        public string Location { get; set; }

        public string AppointmentMessage { get; set; }

        public string AppointmentTextMessage { get; set; }

        public string AppointmentEmailMessage { get; set; }

        public DateTimeOffset StartDateTime { get; set; }

        public DateTimeOffset EndDateTime { get; set; }

        public bool Cancelled { get; set; }

        public string InvitationMessageId { get; set; }

        public Guid? TimeZoneId { get; set; }

        public Guid EntityTypeId { get; set; }

        public bool Deleted { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public string PostViewingComment { get; set; }

        public Guid? ResponsibleNegotiatorId { get; set; }

        public Guid? ResponsibleNegotiatorDepartmentId { get; set; }

        public Guid? ActivityId { get; set; }

        public Guid? ViewingTourId { get; set; }

        public Guid? RequirementId { get; set; }

        public string VendorFeedback { get; set; }

        [Required]
        [StringLength(3)]
        public string Discriminator { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }

        public virtual ViewingTour ViewingTour { get; set; }

        public virtual WindowsTimeZone WindowsTimeZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentContact> AppointmentContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentOtherAttendee> AppointmentOtherAttendees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentUser> AppointmentUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessage> ExternalMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenancy> Tenancies { get; set; }
    }
}
