namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConsentScript")]
    public partial class ConsentScript
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConsentScript()
        {
            ContactAddressDirectMarketingConsents = new HashSet<ContactAddressDirectMarketingConsent>();
            ContactCompanyAddressDirectMarketingConsents = new HashSet<ContactCompanyAddressDirectMarketingConsent>();
            ContactEmailDirectMarketingConsents = new HashSet<ContactEmailDirectMarketingConsent>();
        }

        public Guid Id { get; set; }

        public string Content { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAddressDirectMarketingConsent> ContactAddressDirectMarketingConsents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactCompanyAddressDirectMarketingConsent> ContactCompanyAddressDirectMarketingConsents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactEmailDirectMarketingConsent> ContactEmailDirectMarketingConsents { get; set; }
    }
}
