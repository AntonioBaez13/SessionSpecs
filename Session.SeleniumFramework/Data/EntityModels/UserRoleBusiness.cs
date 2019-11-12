namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRoleBusiness")]
    public partial class UserRoleBusiness
    {
        public Guid Id { get; set; }

        public Guid BusinessId { get; set; }

        public Guid UserRoleId { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
