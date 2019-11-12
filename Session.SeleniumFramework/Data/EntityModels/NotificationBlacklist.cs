namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationBlacklist")]
    public partial class NotificationBlacklist
    {
        public Guid Id { get; set; }

        public Guid NotificationTypeId { get; set; }

        public Guid UserId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual User User { get; set; }
    }
}
