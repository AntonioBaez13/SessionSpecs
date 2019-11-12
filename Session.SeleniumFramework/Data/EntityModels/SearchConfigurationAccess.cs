namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchConfigurationAccess")]
    public partial class SearchConfigurationAccess
    {
        public Guid Id { get; set; }

        public Guid SearchConfigurationAccessTypeId { get; set; }

        public Guid? OrganisationUnitId { get; set; }

        public Guid SearchConfigurationId { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual SearchConfiguration SearchConfiguration { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
