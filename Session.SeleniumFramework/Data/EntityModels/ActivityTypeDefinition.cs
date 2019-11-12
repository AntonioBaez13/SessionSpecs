namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityTypeDefinition")]
    public partial class ActivityTypeDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityTypeDefinition()
        {
            RequirementTypes = new HashSet<RequirementType>();
        }

        public Guid Id { get; set; }

        public Guid PropertyTypeId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid ActivityTypeId { get; set; }

        public short Order { get; set; }

        public virtual ActivityType ActivityType { get; set; }

        public virtual Country Country { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementType> RequirementTypes { get; set; }
    }
}
