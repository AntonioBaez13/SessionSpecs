namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LatestView")]
    public partial class LatestView
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public Guid UserId { get; set; }

        public Guid EntityId { get; set; }

        public int LatestViewType { get; set; }

        public virtual User User { get; set; }
    }
}
