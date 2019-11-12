namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerLog")]
    public partial class DotmailerLog
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DotmailerJobType { get; set; }

        public DateTimeOffset? QueryFromTime { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        public bool Succeeded { get; set; }

        public string Message { get; set; }
    }
}
