namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessEvent")]
    public partial class BusinessEvent
    {
        public Guid Id { get; set; }

        public Guid EventTypeId { get; set; }

        public Guid EntityElementId { get; set; }

        public string SubElement { get; set; }

        public string OldData { get; set; }

        public string NewData { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public Guid UserId { get; set; }

        public Guid? ImpersonatingUserId { get; set; }

        public Guid EntityTypeId { get; set; }

        public Guid EntityId { get; set; }

        [Required]
        public string DtoClass { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
