namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserDotmailerAccount")]
    public partial class UserDotmailerAccount
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid DotmailerAccountId { get; set; }

        public virtual DotmailerAccount DotmailerAccount { get; set; }

        public virtual User User { get; set; }
    }
}
