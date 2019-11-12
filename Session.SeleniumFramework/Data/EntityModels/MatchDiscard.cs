namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatchDiscard")]
    public partial class MatchDiscard
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid ActivityId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
