namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Characteristic")]
    public partial class Characteristic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Characteristic()
        {
            ActivityCharacteristics = new HashSet<ActivityCharacteristic>();
            AssetCharacteristics = new HashSet<AssetCharacteristic>();
            CharacteristicGroupItems = new HashSet<CharacteristicGroupItem>();
            CharacteristicLocaliseds = new HashSet<CharacteristicLocalised>();
            RequirementCharacteristics = new HashSet<RequirementCharacteristic>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public bool IsDisplayText { get; set; }

        public bool IsEnabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCharacteristic> ActivityCharacteristics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetCharacteristic> AssetCharacteristics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicGroupItem> CharacteristicGroupItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicLocalised> CharacteristicLocaliseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementCharacteristic> RequirementCharacteristics { get; set; }
    }
}
