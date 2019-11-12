namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfferTypeLocalised")]
    public partial class OfferTypeLocalised
    {
        public Guid Id { get; set; }

        public Guid LocaleId { get; set; }

        public Guid OfferTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual OfferType OfferType { get; set; }
    }
}
