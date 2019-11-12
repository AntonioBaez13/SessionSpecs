namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyReview")]
    public partial class TenancyReview
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TenancyReview()
        {
            Activities = new HashSet<Activity>();
        }

        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal? AgreedWeeklyRent { get; set; }

        public decimal? AgreedMonthlyRent { get; set; }

        public Guid ReviewTypeId { get; set; }

        public bool? IsZoneA { get; set; }

        public int? TermMonths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Tenancy Tenancy { get; set; }
    }
}
