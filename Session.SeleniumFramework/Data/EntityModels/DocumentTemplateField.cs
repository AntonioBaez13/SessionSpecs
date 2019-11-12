namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentTemplateField")]
    public partial class DocumentTemplateField
    {
        public Guid Id { get; set; }

        public Guid DocumentTemplateRoleId { get; set; }

        public Guid DocumentTemplateFieldTypeId { get; set; }

        [Required]
        public string AnchorPrefix { get; set; }

        public bool IsShared { get; set; }

        public string Values { get; set; }

        public virtual DocumentTemplateRole DocumentTemplateRole { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
