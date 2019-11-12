namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugJobResultFile")]
    public partial class DataHugJobResultFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataHugJobResultFile()
        {
            DataHugProcessingErrors = new HashSet<DataHugProcessingError>();
        }

        public Guid Id { get; set; }

        public Guid DataHugJobLogId { get; set; }

        [Required]
        [StringLength(1000)]
        public string ResultFile { get; set; }

        [StringLength(100)]
        public string JobId { get; set; }

        public bool Processed { get; set; }

        public virtual DataHugJobLog DataHugJobLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataHugProcessingError> DataHugProcessingErrors { get; set; }
    }
}
