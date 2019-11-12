namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaHierarchyShape")]
    public partial class AreaHierarchyShape
    {
        public Guid Id { get; set; }

        public Guid AreaHierarchyId { get; set; }

        [Required]
        public DbGeography Shape { get; set; }

        public virtual AreaHierarchy AreaHierarchy { get; set; }
    }
}
