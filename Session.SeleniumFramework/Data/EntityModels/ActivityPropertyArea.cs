namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityPropertyArea")]
    public partial class ActivityPropertyArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityPropertyArea()
        {
            OfferPropertyAreas = new HashSet<OfferPropertyArea>();
        }

        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public bool IsAncillary { get; set; }

        public Guid? SubStateId { get; set; }

        public Guid? QuotingRentId { get; set; }

        public string Name { get; set; }

        public Guid? MinSizeId { get; set; }

        public Guid? TenancyPropertyAreaId { get; set; }

        public decimal? QuotingRentPA { get; set; }

        public Guid? AgreedRentId { get; set; }

        public decimal? AgreedRentPA { get; set; }

        public bool Proposed { get; set; }

        public Guid? PropertyAreaId { get; set; }

        public Guid FloorId { get; set; }

        public Guid SizeId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue2 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue3 { get; set; }

        public virtual PropertyArea PropertyArea { get; set; }

        public virtual PropertyFloor PropertyFloor { get; set; }

        public virtual TenancyPropertyArea TenancyPropertyArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferPropertyArea> OfferPropertyAreas { get; set; }
    }
}
