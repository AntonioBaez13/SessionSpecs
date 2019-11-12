namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attribute")]
    public partial class Attribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attribute()
        {
            ActivityAttributeValues = new HashSet<ActivityAttributeValue>();
            AssetAttributeValues = new HashSet<AssetAttributeValue>();
            PropertyAttributeForms = new HashSet<PropertyAttributeForm>();
            RequirementAttributeValues = new HashSet<RequirementAttributeValue>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NameKey { get; set; }

        public string LabelKey { get; set; }

        public Guid ValueTypeId { get; set; }

        public int? Precision { get; set; }

        public Guid? EnumTypeId { get; set; }

        public bool Searchable { get; set; }

        public bool RequirementVisible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityAttributeValue> ActivityAttributeValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetAttributeValue> AssetAttributeValues { get; set; }

        public virtual EnumType EnumType { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyAttributeForm> PropertyAttributeForms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementAttributeValue> RequirementAttributeValues { get; set; }
    }
}
