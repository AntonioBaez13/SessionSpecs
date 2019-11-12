namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PortalDefinition")]
    public partial class PortalDefinition
    {
        public Guid Id { get; set; }

        public Guid CountryId { get; set; }

        public Guid ServiceLineId { get; set; }

        public Guid PortalId { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
