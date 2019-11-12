namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyDepartment")]
    public partial class TenancyDepartment
    {
        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid DepartmentTypeId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual Tenancy Tenancy { get; set; }
    }
}
