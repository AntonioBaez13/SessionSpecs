namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataHugUpdatedEntity
    {
        public Guid Id { get; set; }

        public Guid EntityId { get; set; }

        public Guid DataHugLogId { get; set; }

        public Guid EntityTypeId { get; set; }

        public virtual DataHugLog DataHugLog { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
