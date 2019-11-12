namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttachmentSigningParty")]
    public partial class AttachmentSigningParty
    {
        public Guid Id { get; set; }

        public Guid RoleId { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public int RoutingOrder { get; set; }

        public int TemplateOrder { get; set; }

        public Guid AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
