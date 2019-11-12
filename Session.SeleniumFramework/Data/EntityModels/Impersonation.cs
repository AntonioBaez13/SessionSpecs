namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Impersonation")]
    public partial class Impersonation
    {
        public Guid Id { get; set; }

        public Guid ImpersonatedUserId { get; set; }

        public Guid ImpersonatingUserId { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
