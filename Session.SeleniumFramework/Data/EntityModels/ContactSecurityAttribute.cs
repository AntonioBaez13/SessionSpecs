namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactSecurityAttribute")]
    public partial class ContactSecurityAttribute
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid SecurityAttributeId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual SecurityAttribute SecurityAttribute { get; set; }
    }
}
