namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequirementCountry")]
    public partial class RequirementCountry
    {
        public Guid Id { get; set; }

        public Guid RequirementId { get; set; }

        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
