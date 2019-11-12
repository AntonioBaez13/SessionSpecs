namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DevelopmentDepartment")]
    public partial class DevelopmentDepartment
    {
        public Guid Id { get; set; }

        public Guid DevelopmentId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid DepartmentTypeId { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
