namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementOtherMotivation")]
    public partial class RequirementOtherMotivation
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid OtherMotivationId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
