namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PitchUser")]
    public partial class PitchUser
    {
        public Guid Id { get; set; }

        public Guid PitchId { get; set; }

        public Guid UserId { get; set; }

        public Guid UserTypeId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Pitch Pitch { get; set; }

        public virtual User User { get; set; }
    }
}
