namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssetDocumentTypeUsage")]
    public partial class AssetDocumentTypeUsage
    {
        public Guid Id { get; set; }

        public Guid DocumentTypeId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid DivisionId { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }
    }
}
