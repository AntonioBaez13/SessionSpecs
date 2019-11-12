namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyNegotiator")]
    public partial class TenancyNegotiator
    {
        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        public Guid UserId { get; set; }

        public Guid UserTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CallDate { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Tenancy Tenancy { get; set; }

        public virtual User User { get; set; }
    }
}
