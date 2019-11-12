namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactAccessRequest")]
    public partial class ContactAccessRequest
    {
        public Guid Id { get; set; }

        public Guid StatusId { get; set; }

        public Guid RequesterId { get; set; }

        public Guid ApproverId { get; set; }

        public Guid ContactId { get; set; }

        [StringLength(256)]
        public string RequestReason { get; set; }

        [StringLength(256)]
        public string ResponseComment { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual User User3 { get; set; }
    }
}
