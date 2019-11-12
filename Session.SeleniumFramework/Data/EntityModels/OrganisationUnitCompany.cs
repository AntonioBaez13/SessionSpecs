namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganisationUnitCompany")]
    public partial class OrganisationUnitCompany
    {
        public Guid Id { get; set; }

        public Guid OrganisationUnitId { get; set; }

        public Guid CompanyId { get; set; }

        public bool NotCurrent { get; set; }

        public virtual Company Company { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
