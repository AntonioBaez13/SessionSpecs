namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityMarketingImage")]
    public partial class ActivityMarketingImage
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid MarketingImageId { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public bool Deleted { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual MarketingImage MarketingImage { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
