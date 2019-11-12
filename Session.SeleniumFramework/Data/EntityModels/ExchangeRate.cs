namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeRate")]
    public partial class ExchangeRate
    {
        public Guid Id { get; set; }

        public Guid SourceCurrencyId { get; set; }

        public Guid TargetCurrencyId { get; set; }

        public decimal Rate { get; set; }

        public DateTimeOffset? LastUpdatedTime { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }
    }
}
