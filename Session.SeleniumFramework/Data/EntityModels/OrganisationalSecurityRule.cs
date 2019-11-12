namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganisationalSecurityRule")]
    public partial class OrganisationalSecurityRule
    {
        [Key]
        [Column(Order = 0)]
        public Guid SourceOrganisationUnitId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TargetOrganisationUnitId { get; set; }

        public int? ActivityVisibilityLevel { get; set; }

        public int? ContactVisibilityLevel { get; set; }

        public int? PitchVisibilityLevel { get; set; }

        public int? ReferralVisibilityLevel { get; set; }

        public int? RequirementVisibilityLevel { get; set; }

        public int? TenancyVisibilityLevel { get; set; }

        public Guid Id { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual OrganisationUnit OrganisationUnit1 { get; set; }
    }
}
