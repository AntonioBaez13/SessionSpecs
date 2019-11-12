namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssetAttributeValue")]
    public partial class AssetAttributeValue
    {
        public Guid Id { get; set; }

        public Guid AssetId { get; set; }

        public Guid AttributeId { get; set; }

        public decimal? MinNumberValue { get; set; }

        public decimal? MaxNumberValue { get; set; }

        public decimal? NumberValue { get; set; }

        public bool? BooleanValue { get; set; }

        public string StringValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateValue { get; set; }

        public Guid? NumberWithUnitValueId { get; set; }

        public Guid? MinNumberWithUnitValueId { get; set; }

        public Guid? MaxNumberWithUnitValueId { get; set; }

        public Guid? EnumValueId { get; set; }

        public bool Deleted { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Attribute Attribute { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue1 { get; set; }

        public virtual MeasurementUnitValue MeasurementUnitValue2 { get; set; }
    }
}
