namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementTypeLocalised")]
    public partial class RequirementTypeLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid RequirementTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual RequirementType RequirementType { get; set; }
    }
}
