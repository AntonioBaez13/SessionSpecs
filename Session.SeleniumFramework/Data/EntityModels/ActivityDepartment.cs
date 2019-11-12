namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityDepartment")]
    public partial class ActivityDepartment
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid DepartmentTypeId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }
    }
}
