namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaHierarchy")]
    public partial class AreaHierarchy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AreaHierarchy()
        {
            ActivityAreaHierarchies = new HashSet<ActivityAreaHierarchy>();
            AreaHierarchy1 = new HashSet<AreaHierarchy>();
            AreaHierarchyShapes = new HashSet<AreaHierarchyShape>();
            RequirementAreaHierarchies = new HashSet<RequirementAreaHierarchy>();
            TenancyAreaHierarchies = new HashSet<TenancyAreaHierarchy>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public string PostCodes { get; set; }

        public string ExternalCode { get; set; }

        public Guid CountryId { get; set; }

        public Guid? ParentId { get; set; }

        public Guid DivisionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityAreaHierarchy> ActivityAreaHierarchies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaHierarchy> AreaHierarchy1 { get; set; }

        public virtual AreaHierarchy AreaHierarchy2 { get; set; }

        public virtual Country Country { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaHierarchyShape> AreaHierarchyShapes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementAreaHierarchy> RequirementAreaHierarchies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyAreaHierarchy> TenancyAreaHierarchies { get; set; }
    }
}
