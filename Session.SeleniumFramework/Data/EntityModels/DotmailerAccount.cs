namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerAccount")]
    public partial class DotmailerAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DotmailerAccount()
        {
            DotmailerExportLogs = new HashSet<DotmailerExportLog>();
            UserDotmailerAccounts = new HashSet<UserDotmailerAccount>();
        }

        public Guid Id { get; set; }

        public string AccountName { get; set; }

        public string AccountEmail { get; set; }

        public string ApiUserName { get; set; }

        public string ApiPassword { get; set; }

        public Guid BusinessId { get; set; }

        public virtual OrganisationUnit OrganisationUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerExportLog> DotmailerExportLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDotmailerAccount> UserDotmailerAccounts { get; set; }
    }
}
