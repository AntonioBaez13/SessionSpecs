namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementArea")]
    public partial class RequirementArea
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid? AreaTemplateId { get; set; }

        [Required]
        public DbGeography GeoData { get; set; }

        public Guid? RadiusId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public virtual AreaTemplate AreaTemplate { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
