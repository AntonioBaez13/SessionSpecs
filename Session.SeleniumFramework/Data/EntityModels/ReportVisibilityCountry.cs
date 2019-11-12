namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportVisibilityCountry")]
    public partial class ReportVisibilityCountry
    {
        public Guid Id { get; set; }

        public Guid ReportId { get; set; }

        public Guid ReportVisibilityTypeId { get; set; }

        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Report Report { get; set; }
    }
}
