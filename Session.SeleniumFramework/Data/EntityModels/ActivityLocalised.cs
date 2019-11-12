namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityLocalised")]
    public partial class ActivityLocalised
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid LocaleId { get; set; }

        [StringLength(4000)]
        public string MarketingStrapline { get; set; }

        public string MarketingFullDescription { get; set; }

        public string MarketingLocationDescription { get; set; }

        [StringLength(200)]
        public string PropertyWebDisplayAddress { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Locale Locale { get; set; }
    }
}
