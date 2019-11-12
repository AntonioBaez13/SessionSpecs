namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyAreaHierarchy")]
    public partial class TenancyAreaHierarchy
    {
        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        public Guid AreaHierarchyId { get; set; }

        public virtual AreaHierarchy AreaHierarchy { get; set; }

        public virtual Tenancy Tenancy { get; set; }
    }
}
