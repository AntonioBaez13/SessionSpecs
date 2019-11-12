namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElasticSearchPitch")]
    public partial class ElasticSearchPitch
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ProjectTitle { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        [StringLength(10)]
        public string PitchDeadline { get; set; }

        [StringLength(10)]
        public string PitchCreationTime { get; set; }

        public string PitchNegotiators { get; set; }

        public string PitchCompanies { get; set; }

        [StringLength(128)]
        public string FirstCompanyName { get; set; }

        [StringLength(81)]
        public string LeadNegotiatorName { get; set; }

        public string PitchResult { get; set; }

        public string PitchResultLocalised { get; set; }

        public string PitchCompaniesContactLeadNegotiators { get; set; }

        public string MaskedClaims { get; set; }

        public string VisibleClaims { get; set; }
    }
}
