namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PitchSecurityAttribute")]
    public partial class PitchSecurityAttribute
    {
        public Guid Id { get; set; }

        public Guid PitchId { get; set; }

        public Guid SecurityAttributeId { get; set; }

        public virtual Pitch Pitch { get; set; }

        public virtual SecurityAttribute SecurityAttribute { get; set; }
    }
}
