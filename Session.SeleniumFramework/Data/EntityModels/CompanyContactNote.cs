namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyContactNote")]
    public partial class CompanyContactNote
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid ContactId { get; set; }

        public Guid NoteId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Note Note { get; set; }
    }
}
