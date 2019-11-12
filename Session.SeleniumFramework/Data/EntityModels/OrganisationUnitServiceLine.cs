namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganisationUnitServiceLine")]
    public partial class OrganisationUnitServiceLine
    {
        public Guid Id { get; set; }

        public Guid OrganisationUnitId { get; set; }

        public Guid ServiceLineId { get; set; }

        [StringLength(10)]
        public string ProfitCentreCode { get; set; }

        public bool IsCddRequired { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual ServiceLine ServiceLine { get; set; }
    }
}
