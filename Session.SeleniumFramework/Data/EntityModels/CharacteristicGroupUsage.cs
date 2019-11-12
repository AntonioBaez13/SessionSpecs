namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CharacteristicGroupUsage")]
    public partial class CharacteristicGroupUsage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CharacteristicGroupUsage()
        {
            CharacteristicGroupItems = new HashSet<CharacteristicGroupItem>();
        }

        public Guid Id { get; set; }

        public Guid CharacteristicGroupId { get; set; }

        public Guid PropertyTypeId { get; set; }

        public Guid? CountryId { get; set; }

        public short Order { get; set; }

        public bool IsDisplayLabel { get; set; }

        public bool IsServicedProperty { get; set; }

        public virtual CharacteristicGroup CharacteristicGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacteristicGroupItem> CharacteristicGroupItems { get; set; }

        public virtual Country Country { get; set; }

        public virtual PropertyType PropertyType { get; set; }
    }
}
