namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerEmailTemplate")]
    public partial class DotmailerEmailTemplate
    {
        public Guid Id { get; set; }

        public Guid DotmailerEmailTypeId { get; set; }

        public Guid BusinessId { get; set; }

        public string TemplateId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
