namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnumLocalised")]
    public partial class EnumLocalised
    {
        public Guid Id { get; set; }

        public Guid EnumTypeItemId { get; set; }

        public Guid LocaleId { get; set; }

        [StringLength(100)]
        public string Value { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Locale Locale { get; set; }
    }
}
