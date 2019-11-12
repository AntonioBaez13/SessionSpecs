namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityStatusDefinition")]
    public partial class ActivityStatusDefinition
    {
        public Guid Id { get; set; }

        public Guid ActivityTypeId { get; set; }

        public Guid ActivityStatusId { get; set; }

        public Guid DivisionId { get; set; }

        public Guid AgencyTypeId { get; set; }

        public virtual ActivityType ActivityType { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }
    }
}
