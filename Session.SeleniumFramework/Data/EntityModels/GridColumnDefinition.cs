namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GridColumnDefinition")]
    public partial class GridColumnDefinition
    {
        public Guid Id { get; set; }

        public Guid GridDefinitionId { get; set; }

        public Guid GridColumnId { get; set; }

        public int Order { get; set; }

        public virtual GridColumn GridColumn { get; set; }

        public virtual GridDefinition GridDefinition { get; set; }
    }
}
