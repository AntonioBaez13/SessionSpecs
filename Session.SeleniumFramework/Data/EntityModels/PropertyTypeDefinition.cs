namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyTypeDefinition")]
    public partial class PropertyTypeDefinition
    {
        public Guid Id { get; set; }

        public Guid PropertyTypeId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid DivisionId { get; set; }

        public short Order { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual PropertyType PropertyType { get; set; }
    }
}
