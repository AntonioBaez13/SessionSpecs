namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CompanyActivitiesView2
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string CompanyName { get; set; }

        [MaxLength(16)]
        public byte[] VisibleClaimsId { get; set; }

        [MaxLength(16)]
        public byte[] MaskedClaimsId { get; set; }
    }
}
