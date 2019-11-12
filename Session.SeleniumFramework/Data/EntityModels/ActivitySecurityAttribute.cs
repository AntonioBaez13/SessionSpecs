namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivitySecurityAttribute")]
    public partial class ActivitySecurityAttribute
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid SecurityAttributeId { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual SecurityAttribute SecurityAttribute { get; set; }
    }
}
