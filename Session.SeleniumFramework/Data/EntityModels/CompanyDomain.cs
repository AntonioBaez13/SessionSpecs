namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyDomain")]
    public partial class CompanyDomain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyDomain()
        {
            CompanyDomainUsers = new HashSet<CompanyDomainUser>();
        }

        public Guid Id { get; set; }

        public short DataHugRank { get; set; }

        [Required]
        [StringLength(50)]
        public string DataHugDomainId { get; set; }

        [Required]
        [StringLength(100)]
        public string DataHugDomain { get; set; }

        public DateTimeOffset? LastInteractionDate { get; set; }

        public Guid? LastInteractionById { get; set; }

        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyDomainUser> CompanyDomainUsers { get; set; }

        public virtual DatahugDowngradeCompanyDomain DatahugDowngradeCompanyDomain { get; set; }
    }
}
