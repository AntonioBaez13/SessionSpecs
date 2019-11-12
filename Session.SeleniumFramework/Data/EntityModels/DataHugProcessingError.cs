namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugProcessingError")]
    public partial class DataHugProcessingError
    {
        public Guid Id { get; set; }

        public Guid DataHugJobResultFileId { get; set; }

        [Required]
        public string ErrorObject { get; set; }

        [Required]
        public string ErrorText { get; set; }

        public DateTimeOffset ErrorTime { get; set; }

        public virtual DataHugJobResultFile DataHugJobResultFile { get; set; }
    }
}
