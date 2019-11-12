namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationRecipient")]
    public partial class NotificationRecipient
    {
        public Guid Id { get; set; }

        public Guid RecipientId { get; set; }

        public Guid NotificationId { get; set; }

        public Guid StatusId { get; set; }

        public Guid MobileStatusId { get; set; }

        public DateTimeOffset? DateSent { get; set; }

        public DateTimeOffset? DateDelivered { get; set; }

        public DateTimeOffset? DateRead { get; set; }

        public DateTimeOffset? DateDismissed { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual Notification Notification { get; set; }

        public virtual User User { get; set; }
    }
}
