namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyBreak")]
    public partial class TenancyBreak
    {
        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int? NoticePeriod { get; set; }

        public Guid? NoticePeriodFrequencyId { get; set; }

        public int? NoticePeriodAfter { get; set; }

        public Guid? NoticePeriodAfterFrequencyId { get; set; }

        public Guid BreakTypeId { get; set; }

        public bool? IsRolling { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual Tenancy Tenancy { get; set; }
    }
}
