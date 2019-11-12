namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressFieldLabel")]
    public partial class AddressFieldLabel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AddressFieldLabel()
        {
            AddressFieldDefinitions = new HashSet<AddressFieldDefinition>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string LabelKey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddressFieldDefinition> AddressFieldDefinitions { get; set; }
    }
}
