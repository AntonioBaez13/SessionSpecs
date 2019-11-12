namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WindowsTimeZoneLocalised")]
    public partial class WindowsTimeZoneLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid TimeZoneId { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual WindowsTimeZone WindowsTimeZone { get; set; }
    }
}
