namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPreferenceArea")]
    public partial class UserPreferenceArea
    {
        public Guid Id { get; set; }

        [Required]
        public DbGeography GeoData { get; set; }

        public Guid? RadiusId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public Guid UserId { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual User User { get; set; }
    }
}
