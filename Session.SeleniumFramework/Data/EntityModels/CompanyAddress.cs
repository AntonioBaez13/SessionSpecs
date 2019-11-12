namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyAddress")]
    public partial class CompanyAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyAddress()
        {
            ContactCompanyAddresses = new HashSet<ContactCompanyAddress>();
        }

        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid AddressId { get; set; }

        public bool IsPrimary { get; set; }

        [StringLength(128)]
        public string Switchboard { get; set; }

        public bool NotCurrent { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Company Company { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactCompanyAddress> ContactCompanyAddresses { get; set; }
    }
}
