namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GridDefinition")]
    public partial class GridDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GridDefinition()
        {
            GridColumnDefinitions = new HashSet<GridColumnDefinition>();
        }

        public Guid Id { get; set; }

        public Guid GridId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? SearchConfigurationId { get; set; }

        public virtual Grid Grid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GridColumnDefinition> GridColumnDefinitions { get; set; }

        public virtual SearchConfiguration SearchConfiguration { get; set; }

        public virtual User User { get; set; }
    }
}
