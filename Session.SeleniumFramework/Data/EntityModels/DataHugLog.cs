namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHugLog")]
    public partial class DataHugLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataHugLog()
        {
            DataHugJobLogs = new HashSet<DataHugJobLog>();
            DataHugUpdatedEntities = new HashSet<DataHugUpdatedEntity>();
        }

        public Guid Id { get; set; }

        public DateTimeOffset? ConfiguredStartTime { get; set; }

        public DateTimeOffset ConfiguredEndTime { get; set; }

        public DateTimeOffset ActualStartTime { get; set; }

        public DateTimeOffset? ActualEndTime { get; set; }

        public bool Completed { get; set; }

        [Required]
        [StringLength(128)]
        public string JobType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataHugJobLog> DataHugJobLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataHugUpdatedEntity> DataHugUpdatedEntities { get; set; }
    }
}
