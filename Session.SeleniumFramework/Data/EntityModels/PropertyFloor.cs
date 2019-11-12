namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyFloor")]
    public partial class PropertyFloor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyFloor()
        {
            ActivityPropertyAreas = new HashSet<ActivityPropertyArea>();
            OfferPropertyAreas = new HashSet<OfferPropertyArea>();
            PropertyAreas = new HashSet<PropertyArea>();
            TenancyPropertyAreas = new HashSet<TenancyPropertyArea>();
        }

        public Guid Id { get; set; }

        public Guid PropertyId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public int Order { get; set; }

        public bool Deleted { get; set; }

        public Guid? DevPipelineId { get; set; }

        public virtual Activity Activity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPropertyArea> ActivityPropertyAreas { get; set; }

        public virtual Asset Asset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferPropertyArea> OfferPropertyAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyArea> PropertyAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyPropertyArea> TenancyPropertyAreas { get; set; }
    }
}
