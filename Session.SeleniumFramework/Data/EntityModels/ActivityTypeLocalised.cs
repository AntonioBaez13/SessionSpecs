namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityTypeLocalised")]
    public partial class ActivityTypeLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid ActivityTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public virtual ActivityType ActivityType { get; set; }

        public virtual Locale Locale { get; set; }
    }
}
