namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingListEditor")]
    public partial class MarketingListEditor
    {
        public Guid Id { get; set; }

        public Guid MarketingListId { get; set; }

        public Guid EditorId { get; set; }

        public virtual MarketingList MarketingList { get; set; }

        public virtual User User { get; set; }
    }
}
