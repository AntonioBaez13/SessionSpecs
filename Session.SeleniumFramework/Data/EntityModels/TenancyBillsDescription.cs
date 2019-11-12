namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyBillsDescription")]
    public partial class TenancyBillsDescription
    {
        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        public Guid BillDescriptionId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Tenancy Tenancy { get; set; }
    }
}
