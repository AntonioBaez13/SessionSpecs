namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid InvoiceTypeId { get; set; }

        [StringLength(128)]
        public string Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }

        public decimal Amount { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
