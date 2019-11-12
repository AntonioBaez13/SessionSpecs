namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceLine")]
    public partial class ServiceLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceLine()
        {
            Instructions = new HashSet<Instruction>();
            OrganisationUnitServiceLines = new HashSet<OrganisationUnitServiceLine>();
            Referrals = new HashSet<Referral>();
            ReferralManagementRules = new HashSet<ReferralManagementRule>();
            ServiceLine1 = new HashSet<ServiceLine>();
            ServiceLineLocaliseds = new HashSet<ServiceLineLocalised>();
            Pitches = new HashSet<Pitch>();
        }

        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public bool IsInternal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnitServiceLine> OrganisationUnitServiceLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReferralManagementRule> ReferralManagementRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceLine> ServiceLine1 { get; set; }

        public virtual ServiceLine ServiceLine2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceLineLocalised> ServiceLineLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pitch> Pitches { get; set; }
    }
}
