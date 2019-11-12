namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimsUnique")]
    public partial class ClaimsUnique
    {
        [MaxLength(16)]
        public byte[] Id { get; set; }

        [Required]
        public string Claim { get; set; }
    }
}
