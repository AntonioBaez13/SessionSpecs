namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Translation")]
    public partial class Translation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Translation()
        {
            TranslationLocaliseds = new HashSet<TranslationLocalised>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Key { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TranslationLocalised> TranslationLocaliseds { get; set; }
    }
}
