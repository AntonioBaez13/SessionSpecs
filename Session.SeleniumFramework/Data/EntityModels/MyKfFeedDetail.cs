namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyKfFeedDetail
    {
        public Guid Id { get; set; }

        public Guid MyKfFeedLogId { get; set; }

        public Guid EntityId { get; set; }

        public Guid EntityTypeId { get; set; }

        [Required]
        [StringLength(42)]
        public string Property { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual MyKfFeedLog MyKfFeedLog { get; set; }
    }
}
