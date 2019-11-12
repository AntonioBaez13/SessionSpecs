namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoldingCompany")]
    public partial class HoldingCompany
    {
        public Guid Id { get; set; }

        public Guid ParentCompanyId { get; set; }

        public Guid ChildCompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }
    }
}
