namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublicationEvent")]
    public partial class PublicationEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PublicationEvent()
        {
            ContactPublicationEvents = new HashSet<ContactPublicationEvent>();
            MarketingLists = new HashSet<MarketingList>();
        }

        public Guid Id { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        public Guid TypeId { get; set; }

        public Guid AllowedSendMethodId { get; set; }

        public Guid AllowedSendTypeId { get; set; }

        public bool IsLocked { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactPublicationEvent> ContactPublicationEvents { get; set; }

        public virtual EnumTypeItem EnumTypeItem { get; set; }

        public virtual EnumTypeItem EnumTypeItem1 { get; set; }

        public virtual EnumTypeItem EnumTypeItem2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingList> MarketingLists { get; set; }
    }
}
