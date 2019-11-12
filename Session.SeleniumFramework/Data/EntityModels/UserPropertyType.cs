namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPropertyType")]
    public partial class UserPropertyType
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid PropertyTypeId { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        public virtual User User { get; set; }
    }
}
