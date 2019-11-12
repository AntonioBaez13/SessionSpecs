namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportLocalised")]
    public partial class ReportLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid ReportId { get; set; }

        [Required]
        [StringLength(250)]
        public string Value { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual Report Report { get; set; }
    }
}
