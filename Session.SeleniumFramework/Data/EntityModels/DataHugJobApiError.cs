namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugJobApiError")]
    public partial class DataHugJobApiError
    {
        public Guid Id { get; set; }

        public Guid DataHugJobLogId { get; set; }

        [Required]
        [StringLength(50)]
        public string ResponseCode { get; set; }

        [Required]
        [StringLength(50)]
        public string DataHugJobStatus { get; set; }

        [Required]
        public string ErrorText { get; set; }

        public DateTimeOffset ErrorTime { get; set; }

        public virtual DataHugJobLog DataHugJobLog { get; set; }
    }
}
