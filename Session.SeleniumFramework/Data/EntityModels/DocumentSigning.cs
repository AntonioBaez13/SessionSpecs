namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentSigning")]
    public partial class DocumentSigning
    {
        public Guid Id { get; set; }

        public Guid EntityId { get; set; }

        public Guid EntityTypeId { get; set; }

        public Guid StatusId { get; set; }

        public DateTimeOffset? SignedDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string EnvelopeId { get; set; }

        public Guid AttachmentId { get; set; }

        public string XmlContent { get; set; }

        public bool Deleted { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
