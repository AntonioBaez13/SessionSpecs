namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TranslationLocalised")]
    public partial class TranslationLocalised
    {
        [Key]
        [Column(Order = 0)]
        public Guid LocaleId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TranslationId { get; set; }

        [Required]
        public string Value { get; set; }

        public Guid Id { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual Translation Translation { get; set; }
    }
}
