namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClaimsRecalculationLog")]
    public partial class ClaimsRecalculationLog
    {
        public Guid Id { get; set; }

        public DateTimeOffset LastRunStartTime { get; set; }

        public DateTimeOffset? LastRunEndTime { get; set; }
    }
}
