namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CharacteristicGroupLocalised")]
    public partial class CharacteristicGroupLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid CharacteristicGroupId { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public virtual CharacteristicGroup CharacteristicGroup { get; set; }

        public virtual Locale Locale { get; set; }
    }
}
