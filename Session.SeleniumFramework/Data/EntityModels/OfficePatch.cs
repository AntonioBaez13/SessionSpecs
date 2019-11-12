namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficePatch")]
    public partial class OfficePatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OfficePatch()
        {
            OfficePatchThresholds = new HashSet<OfficePatchThreshold>();
            OrganisationUnits = new HashSet<OrganisationUnit>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid OfficePatchTypeId { get; set; }

        [Required]
        public DbGeography GeoData { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfficePatchThreshold> OfficePatchThresholds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnits { get; set; }
    }
}
