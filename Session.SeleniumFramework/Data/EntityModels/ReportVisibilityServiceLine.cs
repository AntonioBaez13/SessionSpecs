namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportVisibilityServiceLine")]
    public partial class ReportVisibilityServiceLine
    {
        public Guid Id { get; set; }

        public Guid ReportId { get; set; }

        public Guid ReportVisibilityTypeId { get; set; }

        public Guid UserServiceLineId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual Report Report { get; set; }
    }
}
