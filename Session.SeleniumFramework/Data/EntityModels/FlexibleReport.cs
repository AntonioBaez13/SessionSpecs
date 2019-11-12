namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlexibleReport")]
    public partial class FlexibleReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlexibleReport()
        {
            Notifications = new HashSet<Notification>();
        }

        public Guid Id { get; set; }

        public Guid DocumentTypeId { get; set; }

        [Required]
        [StringLength(270)]
        public string FileName { get; set; }

        public Guid LocaleId { get; set; }

        public Guid UserId { get; set; }

        public long Size { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
