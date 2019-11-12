namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportGroup")]
    public partial class ReportGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportGroup()
        {
            Reports = new HashSet<Report>();
            ReportGroup1 = new HashSet<ReportGroup>();
            ReportGroupLocaliseds = new HashSet<ReportGroupLocalised>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        public Guid? ParentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportGroup> ReportGroup1 { get; set; }

        public virtual ReportGroup ReportGroup2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportGroupLocalised> ReportGroupLocaliseds { get; set; }
    }
}
