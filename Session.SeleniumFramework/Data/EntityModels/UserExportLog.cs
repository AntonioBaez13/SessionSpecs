namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserExportLog")]
    public partial class UserExportLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserExportLog()
        {
            UserExportLogContacts = new HashSet<UserExportLogContact>();
        }

        public Guid Id { get; set; }

        public Guid ExportedByUserId { get; set; }

        public Guid? ImpersonatingUserId { get; set; }

        public DateTimeOffset ExportDate { get; set; }

        public int NumberExported { get; set; }

        public string ExportCriteria { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExportLogContact> UserExportLogContacts { get; set; }
    }
}
