namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewingTour")]
    public partial class ViewingTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViewingTour()
        {
            Appointments = new HashSet<Appointment>();
            ExternalMessages = new HashSet<ExternalMessage>();
            Attachments = new HashSet<Attachment>();
        }

        public Guid Id { get; set; }

        public DateTimeOffset StartDateTime { get; set; }

        public string AppointmentMessage { get; set; }

        public string AppointmentEmailMessage { get; set; }

        public string AppointmentTextMessage { get; set; }

        public bool Cancelled { get; set; }

        public Guid TimeZoneId { get; set; }

        public string Subject { get; set; }

        public string Location { get; set; }

        public string InvitationMessageId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalMessage> ExternalMessages { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual WindowsTimeZone WindowsTimeZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
