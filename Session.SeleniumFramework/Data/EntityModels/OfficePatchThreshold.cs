namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficePatchThreshold")]
    public partial class OfficePatchThreshold
    {
        public Guid Id { get; set; }

        public Guid OfficePatchId { get; set; }

        public short FinancialYear { get; set; }

        public Guid OfficePatchThresholdTypeId { get; set; }

        public decimal Value { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OfficePatch OfficePatch { get; set; }
    }
}
