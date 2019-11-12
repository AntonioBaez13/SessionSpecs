namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyAttributeForm")]
    public partial class PropertyAttributeForm
    {
        public Guid Id { get; set; }

        public Guid CountryId { get; set; }

        public Guid PropertyTypeId { get; set; }

        public Guid AttributeId { get; set; }

        public int Order { get; set; }

        public virtual Attribute Attribute { get; set; }

        public virtual Country Country { get; set; }

        public virtual PropertyType PropertyType { get; set; }
    }
}
