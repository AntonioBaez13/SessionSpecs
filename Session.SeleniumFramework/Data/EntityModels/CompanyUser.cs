namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyUser")]
    public partial class CompanyUser
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid UserId { get; set; }

        public short HighestDataHugRank { get; set; }

        public DateTimeOffset? LatestLastInteractionDate { get; set; }

        public bool? IsKeyRelationship { get; set; }

        public virtual Company Company { get; set; }

        public virtual User User { get; set; }
    }
}
