namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfferPropertyArea")]
    public partial class OfferPropertyArea
    {
        public Guid Id { get; set; }

        public Guid OfferId { get; set; }

        public Guid? OfferAmountId { get; set; }

        public Guid? ActivityPropertyAreaId { get; set; }

        public Guid? PropertyAreaId { get; set; }

        public Guid FloorId { get; set; }

        public Guid SizeId { get; set; }

        public virtual ActivityPropertyArea ActivityPropertyArea { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual Offer Offer { get; set; }

        public virtual PropertyArea PropertyArea { get; set; }

        public virtual PropertyFloor PropertyFloor { get; set; }
    }
}
