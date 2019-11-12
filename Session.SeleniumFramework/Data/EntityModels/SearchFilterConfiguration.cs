namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchFilterConfiguration")]
    public partial class SearchFilterConfiguration
    {
        public Guid Id { get; set; }

        public Guid SearchConfigurationId { get; set; }

        public Guid FilterId { get; set; }

        [Required]
        public string Value { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual SearchConfiguration SearchConfiguration { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
