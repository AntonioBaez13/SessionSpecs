namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportVisibilityDepartment")]
    public partial class ReportVisibilityDepartment
    {
        public Guid Id { get; set; }

        public Guid ReportId { get; set; }

        public Guid ReportVisibilityTypeId { get; set; }

        public Guid OrganisationUnitId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual Report Report { get; set; }
    }
}
