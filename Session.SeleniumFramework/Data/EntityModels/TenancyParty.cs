namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenancyParty")]
    public partial class TenancyParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TenancyParty()
        {
            TenancyIdentifications = new HashSet<TenancyIdentification>();
        }

        public Guid Id { get; set; }

        public Guid TenancyId { get; set; }

        [StringLength(255)]
        public string GenericDescription { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? AddressId { get; set; }

        public Guid RoleId { get; set; }

        [StringLength(128)]
        public string OtherName { get; set; }

        public decimal? RentSplit { get; set; }

        [StringLength(3)]
        public string Discriminator { get; set; }

        public virtual Address Address { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual Tenancy Tenancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenancyIdentification> TenancyIdentifications { get; set; }
    }
}
