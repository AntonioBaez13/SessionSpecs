namespace Session.SeleniumFramework.Data.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DotmailerExportLog")]
    public partial class DotmailerExportLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DotmailerExportLog()
        {
            DotmailerExportLogContacts = new HashSet<DotmailerExportLogContact>();
        }

        public Guid Id { get; set; }

        public Guid ExportedByUserId { get; set; }

        public DateTimeOffset ExportTime { get; set; }

        public int NumberExported { get; set; }

        public string ExportCriteria { get; set; }

        public int DotmailerAddressBookId { get; set; }

        public Guid DotmailerAccountId { get; set; }

        public Guid MarketingListId { get; set; }

        public bool IsDeletedInDotmailer { get; set; }

        public virtual DotmailerAccount DotmailerAccount { get; set; }

        public virtual MarketingList MarketingList { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DotmailerExportLogContact> DotmailerExportLogContacts { get; set; }
    }
}
