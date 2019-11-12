namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityServiceLineDefinition")]
    public partial class ActivityServiceLineDefinition
    {
        public Guid Id { get; set; }

        public Guid ServiceLineId { get; set; }

        public Guid ActivityTypeId { get; set; }

        public virtual ActivityType ActivityType { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
