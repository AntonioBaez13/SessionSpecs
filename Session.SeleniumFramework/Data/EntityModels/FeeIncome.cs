namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeeIncome")]
    public partial class FeeIncome
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeeIncome()
        {
            FeeIncomeLocaliseds = new HashSet<FeeIncomeLocalised>();
            Pitches = new HashSet<Pitch>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        public int Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeIncomeLocalised> FeeIncomeLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pitch> Pitches { get; set; }
    }
}
