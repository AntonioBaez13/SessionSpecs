namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerSuppressedEmail")]
    public partial class DotmailerSuppressedEmail
    {
        public Guid Id { get; set; }

        public Guid OrganisationUnitId { get; set; }

        [Required]
        [StringLength(400)]
        public string Email { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
