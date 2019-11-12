namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CharacteristicLocalised")]
    public partial class CharacteristicLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid CharacteristicId { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public virtual Characteristic Characteristic { get; set; }

        public virtual Locale Locale { get; set; }
    }
}
