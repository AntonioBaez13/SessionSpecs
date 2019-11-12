namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactContactType")]
    public partial class ContactContactType
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid EnumTypeItemId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
