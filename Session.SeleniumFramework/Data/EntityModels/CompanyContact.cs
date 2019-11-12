namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyContact")]
    public partial class CompanyContact
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid CompanyId { get; set; }

        [StringLength(128)]
        public string JobTitle { get; set; }

        public bool NotCurrent { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
