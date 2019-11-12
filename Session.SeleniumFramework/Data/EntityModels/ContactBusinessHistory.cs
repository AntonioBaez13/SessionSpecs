namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactBusinessHistory")]
    public partial class ContactBusinessHistory
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid CompanyId { get; set; }

        public Guid? AddressId { get; set; }

        [StringLength(128)]
        public string JobTitle { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        public bool Deleted { get; set; }

        public virtual Address Address { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
