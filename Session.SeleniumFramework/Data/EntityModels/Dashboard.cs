namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dashboard")]
    public partial class Dashboard
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [Required]
        public string Configuration { get; set; }

        public virtual User User { get; set; }
    }
}
