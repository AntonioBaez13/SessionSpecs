namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingImage")]
    public partial class MarketingImage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarketingImage()
        {
            Activities = new HashSet<Activity>();
            ActivityMarketingImages = new HashSet<ActivityMarketingImage>();
            Assets = new HashSet<Asset>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(270)]
        public string FileName { get; set; }

        public Guid DocumentTypeId { get; set; }

        public Guid ExternalDocumentId { get; set; }

        public Guid OriginalActivityId { get; set; }

        public long Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual Activity Activity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityMarketingImage> ActivityMarketingImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asset> Assets { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }
    }
}
