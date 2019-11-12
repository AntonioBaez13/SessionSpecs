namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementSecurityAttribute")]
    public partial class RequirementSecurityAttribute
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid SecurityAttributeId { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual SecurityAttribute SecurityAttribute { get; set; }
    }
}
