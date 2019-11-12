namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyPropertyArea")]
    public partial class TenancyPropertyArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TenancyPropertyArea()
        {
            ActivityPropertyAreas = new HashSet<ActivityPropertyArea>();
            TenancyPropertyArea1 = new HashSet<TenancyPropertyArea>();
        }

        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        public Guid? AgreedRentId { get; set; }

        public Guid? TenancyPropertyAreaId { get; set; }

        public Guid? PropertyAreaId { get; set; }

        public Guid FloorId { get; set; }

        public Guid SizeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPropertyArea> ActivityPropertyAreas { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual PropertyArea PropertyArea { get; set; }

        public virtual PropertyFloor PropertyFloor { get; set; }

        public virtual Tenancy Tenancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyPropertyArea> TenancyPropertyArea1 { get; set; }

        public virtual TenancyPropertyArea TenancyPropertyArea2 { get; set; }
    }
}
