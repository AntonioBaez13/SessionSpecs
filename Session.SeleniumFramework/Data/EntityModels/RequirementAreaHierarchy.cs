namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementAreaHierarchy")]
    public partial class RequirementAreaHierarchy
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid AreaHierarchyId { get; set; }

        public virtual AreaHierarchy AreaHierarchy { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
