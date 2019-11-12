namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactAddress")]
    public partial class ContactAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactAddress()
        {
            ContactAddressDirectMarketingConsents = new HashSet<ContactAddressDirectMarketingConsent>();
        }

        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Guid AddressId { get; set; }

        public bool IsPrimary { get; set; }

        public bool IsCorrespondenceConfidential { get; set; }

        public Guid? ResidentialAddressTypeId { get; set; }

        public bool NotCurrent { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public DateTimeOffset CreationTime { get; set; }

        public DateTimeOffset LastWriteTime { get; set; }

        public Guid? UserId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddressDirectMarketingConsent> ContactAddressDirectMarketingConsents { get; set; }
    }
}
