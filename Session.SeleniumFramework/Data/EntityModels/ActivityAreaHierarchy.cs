namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityAreaHierarchy")]
    public partial class ActivityAreaHierarchy
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid AreaHierarchyId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual AreaHierarchy AreaHierarchy { get; set; }
    }
}
