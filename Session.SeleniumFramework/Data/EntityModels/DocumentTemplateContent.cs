namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentTemplateContent")]
    public partial class DocumentTemplateContent
    {
        public Guid Id { get; set; }

        [Required]
        public byte[] Binary { get; set; }

        [Required]
        public string FileName { get; set; }

        public virtual DocumentTemplate DocumentTemplate { get; set; }
    }
}
