namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityAttribute")]
    public partial class SecurityAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityAttribute()
        {
            ActivitySecurityAttributes = new HashSet<ActivitySecurityAttribute>();
            AssetSecurityAttributes = new HashSet<AssetSecurityAttribute>();
            ContactSecurityAttributes = new HashSet<ContactSecurityAttribute>();
            InstructionSecurityAttributes = new HashSet<InstructionSecurityAttribute>();
            PitchSecurityAttributes = new HashSet<PitchSecurityAttribute>();
            RequirementSecurityAttributes = new HashSet<RequirementSecurityAttribute>();
            Roles = new HashSet<Role>();
            OrganisationUnits = new HashSet<OrganisationUnit>();
        }

        public Guid Id { get; set; }

        public int? Claim { get; set; }

        public Guid EntityTypeId { get; set; }

        public Guid AttributeTypeId { get; set; }

        public Guid AttributeGroupTypeId { get; set; }

        public Guid CalculationStrategyTypeId { get; set; }

        public bool RequiresOrganizationalRulesCalculation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitySecurityAttribute> ActivitySecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssetSecurityAttribute> AssetSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactSecurityAttribute> ContactSecurityAttributes { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        public virtual EnumTypeItem EnumTypeItem3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructionSecurityAttribute> InstructionSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PitchSecurityAttribute> PitchSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementSecurityAttribute> RequirementSecurityAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUnit> OrganisationUnits { get; set; }
    }
}
