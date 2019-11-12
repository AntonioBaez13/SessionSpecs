namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugJobLog")]
    public partial class DataHugJobLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataHugJobLog()
        {
            DataHugJobApiErrors = new HashSet<DataHugJobApiError>();
            DataHugJobResultFiles = new HashSet<DataHugJobResultFile>();
        }

        public Guid Id { get; set; }

        public Guid DataHugLogId { get; set; }

        [Required]
        [StringLength(50)]
        public string DataHugJobType { get; set; }

        [Required]
        [StringLength(50)]
        public string DataHugJobStep { get; set; }

        [StringLength(50)]
        public string DataHugJobStatus { get; set; }

        public DateTimeOffset ActualStartTime { get; set; }

        public DateTimeOffset? ActualEndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataHugJobApiError> DataHugJobApiErrors { get; set; }

        public virtual DataHugLog DataHugLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataHugJobResultFile> DataHugJobResultFiles { get; set; }
    }
}
