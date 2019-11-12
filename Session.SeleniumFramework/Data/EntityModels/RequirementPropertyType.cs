namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementPropertyType")]
    public partial class RequirementPropertyType
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid PropertyTypeId { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
