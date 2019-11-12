namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyArea")]
    public partial class PropertyArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyArea()
        {
            ActivityPropertyAreas = new HashSet<ActivityPropertyArea>();
            Offers = new HashSet<Offer>();
            OfferPropertyAreas = new HashSet<OfferPropertyArea>();
            TenancyPropertyAreas = new HashSet<TenancyPropertyArea>();
        }

        public Guid Id { get; set; }

        public Guid FloorId { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        public Guid SizeId { get; set; }

        public Guid? MinSizeId { get; set; }

        public bool Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPropertyArea> ActivityPropertyAreas { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferPropertyArea> OfferPropertyAreas { get; set; }

        public virtual PropertyFloor PropertyFloor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyPropertyArea> TenancyPropertyAreas { get; set; }
    }
}
