namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CharacteristicGroup")]
    public partial class CharacteristicGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CharacteristicGroup()
        {
            CharacteristicGroupLocaliseds = new HashSet<CharacteristicGroupLocalised>();
            CharacteristicGroupUsages = new HashSet<CharacteristicGroupUsage>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicGroupLocalised> CharacteristicGroupLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicGroupUsage> CharacteristicGroupUsages { get; set; }
    }
}
