namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyIdentification")]
    public partial class TenancyIdentification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TenancyIdentification()
        {
            Attachments = new HashSet<Attachment>();
        }

        public Guid Id { get; set; }

        public Guid TenancyPartyId { get; set; }

        public bool IsPermanent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CertifiedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReviewDate { get; set; }

        [Required]
        [StringLength(256)]
        public string TenantIdNumber { get; set; }

        public Guid IdTypeId { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual TenancyParty TenancyParty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
