namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportGroupLocalised")]
    public partial class ReportGroupLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid ReportGroupId { get; set; }

        [Required]
        [StringLength(250)]
        public string Value { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual ReportGroup ReportGroup { get; set; }
    }
}
