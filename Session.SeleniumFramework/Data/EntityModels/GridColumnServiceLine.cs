namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GridColumnServiceLine")]
    public partial class GridColumnServiceLine
    {
        public Guid Id { get; set; }

        public Guid GridColumnId { get; set; }

        public Guid UserServiceLineId { get; set; }

        public bool VisibleByDefault { get; set; }

        public int? OrderOverride { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual GridColumn GridColumn { get; set; }
    }
}
