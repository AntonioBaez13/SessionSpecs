namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactTitle")]
    public partial class ContactTitle
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public Guid LocaleId { get; set; }

        public int? Priority { get; set; }

        public virtual Locale Locale { get; set; }
    }
}
