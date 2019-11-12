namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityExternalLink")]
    public partial class ActivityExternalLink
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        [Required]
        public string LinkName { get; set; }

        [Required]
        public string Url { get; set; }

        public virtual Activity Activity { get; set; }
    }
}
