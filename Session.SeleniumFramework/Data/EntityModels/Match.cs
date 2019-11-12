namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Match")]
    public partial class Match
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid RequirementId { get; set; }

        public Guid? AdvertisementId { get; set; }

        public string Comment { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid UserId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Advertisement Advertisement { get; set; }

        public virtual Requirement Requirement { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
