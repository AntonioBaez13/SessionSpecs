namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaTemplate")]
    public partial class AreaTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AreaTemplate()
        {
            RequirementAreas = new HashSet<RequirementArea>();
        }

        public Guid Id { get; set; }

        public Guid? UserId { get; set; }

        [Required]
        public DbGeography GeoData { get; set; }

        public Guid? RadiusId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementArea> RequirementAreas { get; set; }
    }
}
