namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssetParty")]
    public partial class AssetParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssetParty()
        {
            Ownerships = new HashSet<Ownership>();
        }

        public Guid Id { get; set; }

        public Guid AssetId { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? AddressId { get; set; }

        public Guid RoleId { get; set; }

        [Required]
        [StringLength(3)]
        public string Discriminator { get; set; }

        public virtual Address Address { get; set; }

        public virtual Asset Asset { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ownership> Ownerships { get; set; }
    }
}
