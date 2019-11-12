namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessLanguage")]
    public partial class BusinessLanguage
    {
        public Guid Id { get; set; }

        public Guid BusinessId { get; set; }

        public Guid ServiceLineId { get; set; }

        public Guid LocaleId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Locale Locale { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
