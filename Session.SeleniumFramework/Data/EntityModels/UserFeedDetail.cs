namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserFeedDetail
    {
        public Guid Id { get; set; }

        public Guid UserFeedLogId { get; set; }

        public Guid EntityId { get; set; }

        public Guid EntityTypeId { get; set; }

        [StringLength(42)]
        public string Property { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public bool IsNew { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual UserFeedLog UserFeedLog { get; set; }
    }
}
