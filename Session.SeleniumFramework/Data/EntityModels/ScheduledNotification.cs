namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScheduledNotification")]
    public partial class ScheduledNotification
    {
        public Guid Id { get; set; }

        public DateTimeOffset DateOccurred { get; set; }

        [Column(TypeName = "date")]
        public DateTime ScheduledDate { get; set; }

        public Guid TypeId { get; set; }

        public Guid EntityTypeId { get; set; }

        public Guid EntityId { get; set; }

        [StringLength(400)]
        public string ScheduledNotificationMessage { get; set; }

        public Guid GroupId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }
    }
}
